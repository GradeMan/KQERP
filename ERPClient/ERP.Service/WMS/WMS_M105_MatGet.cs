using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M105_MatGetService
	{
		WMS_M105_MatGet GetById(Guid Id);
        List<WMS_M105_MatGet> GetList();
        IQueryable<WMS_M105_MatGet> GetQuery();
		List<WMS_M105_MatGet> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M105_MatGet WMS_M105_MatGet);
        void Update(WMS_M105_MatGet WMS_M105_MatGet);
        void Delete(Guid Id);
        IQueryable<WMS_M105_MatGetDetail> GetMatDetailQuery();
        void Save(WMS_M105_MatGet matGet, List<WMS_M105_MatGetDetail> matDetailList);
	}
	public class WMS_M105_MatGetService :IWMS_M105_MatGetService
	{
		private IWMS_M105_MatGetRepository WMS_M105_MatGetRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IWMS_M105_MatGetDetailRepository WMS_M105_MatGetDetailRepository;
        private IWMS_M105_MatSotreRepository WMS_M105_MatSotreRepository;
		public WMS_M105_MatGetService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M105_MatGetRepository = new WMS_M105_MatGetRepository(dbfactory);
            this.WMS_M105_MatGetDetailRepository = new WMS_M105_MatGetDetailRepository(dbfactory);
            this.WMS_M105_MatSotreRepository = new WMS_M105_MatSotreRepository(dbfactory);
		
		}
        public void Save(WMS_M105_MatGet matGet, List<WMS_M105_MatGetDetail> matDetailList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existslotTx = this.GetById(matGet.Id);
            if (existslotTx == null)
            {
                matGet.CompCode = tempUser.CompCode;
                matGet.CreateDt = DateTime.Now;
                matGet.CreateUser = tempUser.UserName;
                matGet.Validate();
                this.WMS_M105_MatGetRepository.Add(matGet);
            }
            else
            {
                matGet.ModifyDt = DateTime.Now;
                matGet.ModifyUser = tempUser.UserName;
                matGet.Validate();
                this.WMS_M105_MatGetRepository.SetValues(matGet, existslotTx);
            }
            if (matDetailList != null)
            {
                foreach (var detail in matDetailList)
                {
                    var existstLotTxNG = this.WMS_M105_MatGetDetailRepository.GetByID(detail.Id);
                    if (existstLotTxNG == null)
                    {
                        detail.CompCode = tempUser.CompCode;
                        detail.CreateDt = DateTime.Now;
                        detail.CreateUser = tempUser.UserName;
                        detail.RequestNo = matGet.RequestNo;
                        detail.Validate();
                        this.WMS_M105_MatGetDetailRepository.Add(detail);
                        //更新库存
                        var matStore = this.WMS_M105_MatSotreRepository.GetMany(a => a.MatSpecCode == detail.MatSpecCode).SingleOrDefault();
                        if (matStore != null)
                        {
                            matStore.StoreAmount += detail.ReqQty;
                        }
                        else
                        {
                            matStore = new WMS_M105_MatSotre();
                            matStore.CompCode = detail.CompCode;
                            matStore.MatSpecCode = detail.MatSpecCode;
                            matStore.MatSpec = detail.MatSpec;
                            matStore.MatType = detail.MatType;
                            matStore.Suppode = detail.Suppode;
                            matStore.StoreAmount = detail.ReqQty;
                            this.WMS_M105_MatSotreRepository.Add(matStore);
                        }
                    }
                    else
                    {
                        //更新库存
                        var matStore = this.WMS_M105_MatSotreRepository.GetMany(a => a.MatSpecCode == detail.MatSpecCode).SingleOrDefault();
                        if (matStore != null)
                        {
                            matStore.StoreAmount += (detail.ReqQty-existstLotTxNG.ReqQty);
                        }
                        else
                        {
                            matStore = new WMS_M105_MatSotre();
                            matStore.CompCode = detail.CompCode;
                            matStore.MatSpecCode = detail.MatSpecCode;
                            matStore.MatSpec = detail.MatSpec;
                            matStore.MatType = detail.MatType;
                            matStore.Suppode = detail.Suppode;
                            matStore.StoreAmount = detail.ReqQty;
                            this.WMS_M105_MatSotreRepository.Add(matStore);
                        }
                        this.WMS_M105_MatGetDetailRepository.SetValues(detail, existstLotTxNG);
                    }
                }
            }
            this.runtimeService.Commit();
        }
		public List<WMS_M105_MatGet> GetList()
        {
            var q = this.WMS_M105_MatGetRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_M105_MatGet> GetQuery()
        {
            var q = this.WMS_M105_MatGetRepository.GetMany(i => true);
            return q;
        }
        public IQueryable<WMS_M105_MatGetDetail> GetMatDetailQuery()
        {
            var q = this.WMS_M105_MatGetDetailRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_M105_MatGet GetById(Guid Id)
        {
            return this.WMS_M105_MatGetRepository.GetByID(Id);
        }

        public void Create(WMS_M105_MatGet WMS_M105_MatGet)
        {
        	WMS_M105_MatGet.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatGet.CreateUser = tempUser.UserName;
            WMS_M105_MatGet.Validate();
			this.WMS_M105_MatGetRepository.Add(WMS_M105_MatGet);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M105_MatGetRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M105_MatGet WMS_M105_MatGet)
        {
        	WMS_M105_MatGet.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatGet.ModifyUser = tempUser.UserName;
            WMS_M105_MatGet.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M105_MatGet.Id);
            this.WMS_M105_MatGetRepository.SetValues(WMS_M105_MatGet, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M105_MatGet> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M105_MatGetRepository.GetMany(i => true);
			if (beginDate.HasValue)
            {
                beginDate = beginDate.Value.Date;
           	    q = q.Where(p => p.CreateDt >= beginDate);
            }
            if (endDate.HasValue)
            {
                endDate = endDate.Value.Date.AddDays(1);
                q = q.Where(p => p.CreateDt < endDate);
            }
            
            q = q.OrderByDescending(i => i.CreateDt);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}