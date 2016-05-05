using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M105_MatReturnService
	{
		WMS_M105_MatReturn GetById(Guid Id);
        List<WMS_M105_MatReturn> GetList();
        IQueryable<WMS_M105_MatReturn> GetQuery();
		List<WMS_M105_MatReturn> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M105_MatReturn WMS_M105_MatReturn);
        void Update(WMS_M105_MatReturn WMS_M105_MatReturn);
        void Delete(Guid Id);
        IQueryable<WMS_M105_MatReturnDetail> GetMatDetailQuery();
        void Save(WMS_M105_MatReturn matGet, List<WMS_M105_MatReturnDetail> matDetailList);
	}
	public class WMS_M105_MatReturnService :IWMS_M105_MatReturnService
	{
		private IWMS_M105_MatReturnRepository WMS_M105_MatReturnRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IWMS_M105_MatReturnDetailRepository WMS_M105_MatReturnDetailRepository;
        private IWMS_M105_MatSotreRepository WMS_M105_MatSotreRepository;
		public WMS_M105_MatReturnService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M105_MatReturnRepository = new WMS_M105_MatReturnRepository(dbfactory);
            this.WMS_M105_MatReturnDetailRepository = new WMS_M105_MatReturnDetailRepository(dbfactory);
            this.WMS_M105_MatSotreRepository = new WMS_M105_MatSotreRepository(dbfactory);
		}
        public void Save(WMS_M105_MatReturn matGet, List<WMS_M105_MatReturnDetail> matDetailList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existslotTx = this.GetById(matGet.Id);
            if (existslotTx == null)
            {
                matGet.CompCode = tempUser.CompCode;
                matGet.CreateDt = DateTime.Now;
                matGet.CreateUser = tempUser.UserName;
                matGet.Validate();
                this.WMS_M105_MatReturnRepository.Add(matGet);
            }
            else
            {
                matGet.ModifyDt = DateTime.Now;
                matGet.ModifyUser = tempUser.UserName;
                matGet.Validate();
                this.WMS_M105_MatReturnRepository.SetValues(matGet, existslotTx);
            }
            if (matDetailList != null)
            {
                foreach (var detail in matDetailList)
                {
                    var existstLotTxNG = this.WMS_M105_MatReturnDetailRepository.GetByID(detail.Id);
                    if (existstLotTxNG == null)
                    {
                        detail.CompCode = tempUser.CompCode;
                        detail.CreateDt = DateTime.Now;
                        detail.CreateUser = tempUser.UserName;
                        detail.ReturnNo = matGet.ReturnNo;
                        detail.Validate();
                        this.WMS_M105_MatReturnDetailRepository.Add(detail);
                        //更新库存
                        var matStore = this.WMS_M105_MatSotreRepository.GetMany(a => a.MatSpecCode == detail.MatSpecCode).SingleOrDefault();
                        if (matStore != null)
                        {
                            matStore.StoreAmount -= detail.RetQty;
                        }
                        else
                        {
                            matStore = new WMS_M105_MatSotre();
                            matStore.CompCode = detail.CompCode;
                            matStore.MatSpecCode = detail.MatSpecCode;
                            matStore.MatSpec = detail.MatSpec;
                            matStore.MatType = detail.MatType;
                            matStore.Suppode = detail.Suppode;
                            matStore.StoreAmount = detail.RetQty;
                            this.WMS_M105_MatSotreRepository.Add(matStore);
                        }
                    }
                    else
                    {
                        //更新库存
                        var matStore = this.WMS_M105_MatSotreRepository.GetMany(a => a.MatSpecCode == detail.MatSpecCode).SingleOrDefault();
                        if (matStore != null)
                        {
                            matStore.StoreAmount += (detail.RetQty - existstLotTxNG.RetQty);
                        }
                        else
                        {
                            matStore = new WMS_M105_MatSotre();
                            matStore.CompCode = detail.CompCode;
                            matStore.MatSpecCode = detail.MatSpecCode;
                            matStore.MatSpec = detail.MatSpec;
                            matStore.MatType = detail.MatType;
                            matStore.Suppode = detail.Suppode;
                            matStore.StoreAmount = detail.RetQty;
                            this.WMS_M105_MatSotreRepository.Add(matStore);
                        }
                        this.WMS_M105_MatReturnDetailRepository.SetValues(detail, existstLotTxNG);
                    }
                }
            }
            this.runtimeService.Commit();
        }
        public IQueryable<WMS_M105_MatReturnDetail> GetMatDetailQuery()
        {
            var q = this.WMS_M105_MatReturnDetailRepository.GetMany(i => true);
            return q;
        }
		public List<WMS_M105_MatReturn> GetList()
        {
            var q = this.WMS_M105_MatReturnRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_M105_MatReturn> GetQuery()
        {
            var q = this.WMS_M105_MatReturnRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_M105_MatReturn GetById(Guid Id)
        {
            return this.WMS_M105_MatReturnRepository.GetByID(Id);
        }

        public void Create(WMS_M105_MatReturn WMS_M105_MatReturn)
        {
        	WMS_M105_MatReturn.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatReturn.CreateUser = tempUser.UserName;
            WMS_M105_MatReturn.Validate();
			this.WMS_M105_MatReturnRepository.Add(WMS_M105_MatReturn);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M105_MatReturnRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M105_MatReturn WMS_M105_MatReturn)
        {
        	WMS_M105_MatReturn.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatReturn.ModifyUser = tempUser.UserName;
            WMS_M105_MatReturn.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M105_MatReturn.Id);
            this.WMS_M105_MatReturnRepository.SetValues(WMS_M105_MatReturn, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M105_MatReturn> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M105_MatReturnRepository.GetMany(i => true);
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