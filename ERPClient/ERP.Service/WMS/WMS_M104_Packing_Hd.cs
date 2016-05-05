using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M104_Packing_HdService
	{
		WMS_M104_Packing_Hd GetById(Guid Id);
        List<WMS_M104_Packing_Hd> GetList();
		List<WMS_M104_Packing_Hd> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M104_Packing_Hd WMS_M104_Packing_Hd);
        void Update(WMS_M104_Packing_Hd WMS_M104_Packing_Hd);
        void Delete(Guid Id);
        List<WMS_M104_Packing_Detail> GetDetailList(Guid HdId);
        void MarkDelDetail(Guid PackingDetailId);
        void Save(WMS_M104_Packing_Hd instore, List<WMS_M104_Packing_Detail> instoreDetailList);
	}
	public class WMS_M104_Packing_HdService :IWMS_M104_Packing_HdService
	{
		private IWMS_M104_Packing_HdRepository WMS_M104_Packing_HdRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IWMS_M104_Packing_DetailRepository packingDetailRepository;
		public WMS_M104_Packing_HdService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M104_Packing_HdRepository = new WMS_M104_Packing_HdRepository(dbfactory);
            this.packingDetailRepository = new WMS_M104_Packing_DetailRepository(dbfactory);
		}
        public void MarkDelDetail(Guid PackingDetailId)
        {
            var existsTemp = this.packingDetailRepository.GetByID(PackingDetailId);
            if (existsTemp != null)
                this.packingDetailRepository.Delete(existsTemp);
            // this.runtimeService.Commit();
        }
        public List<WMS_M104_Packing_Detail> GetDetailList(Guid HdId)
        {
            var q = this.packingDetailRepository.GetMany(i => i.PackingHdId == HdId);
            return q.ToList();
        }
		public List<WMS_M104_Packing_Hd> GetList()
        {
            var q = this.WMS_M104_Packing_HdRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_M104_Packing_Hd GetById(Guid Id)
        {
            return this.WMS_M104_Packing_HdRepository.GetByID(Id);
        }

        public void Create(WMS_M104_Packing_Hd WMS_M104_Packing_Hd)
        {
            WMS_M104_Packing_Hd.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M104_Packing_Hd.CreateUser = tempUser.UserName;
            WMS_M104_Packing_Hd.Validate();
			this.WMS_M104_Packing_HdRepository.Add(WMS_M104_Packing_Hd);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M104_Packing_HdRepository.Delete(existstb_Sys_Menu);
            var details = this.packingDetailRepository.GetMany(i => i.PackingHdId == Id).ToList();
            foreach (var detail in details)
                this.packingDetailRepository.Delete(detail); 
            this.runtimeService.Commit();
        }

        public void Update(WMS_M104_Packing_Hd WMS_M104_Packing_Hd)
        {
        	WMS_M104_Packing_Hd.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M104_Packing_Hd.ModifyUser = tempUser.UserName;
            WMS_M104_Packing_Hd.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M104_Packing_Hd.Id);
            this.WMS_M104_Packing_HdRepository.SetValues(WMS_M104_Packing_Hd, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M104_Packing_Hd> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M104_Packing_HdRepository.GetMany(i => true);
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
        public void Save(WMS_M104_Packing_Hd instore, List<WMS_M104_Packing_Detail> instoreDetailList)
        {
            //if (instore.BeforeAmount < instore.ActualAmount)
            //    throw new AppException("实际入库数不能大于计划入库数");
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existslotTx = this.GetById(instore.Id);
            if (existslotTx == null)
            {
                instore.CreateDt = DateTime.Now;
                instore.CreateUser = tempUser.UserName;
                instore.Validate();
                this.WMS_M104_Packing_HdRepository.Add(instore);
            }
            else
            {
                instore.ModifyDt = DateTime.Now;
                instore.ModifyUser = tempUser.UserName;
                instore.Validate();
                this.WMS_M104_Packing_HdRepository.SetValues(instore, existslotTx);
            }
            if (instoreDetailList != null)
            {
                foreach (var detail in instoreDetailList)
                {
                    var existstLotTxNG = this.packingDetailRepository.GetByID(detail.Id);
                    if (existstLotTxNG == null)
                    {
                        detail.Validate();
                        this.packingDetailRepository.Add(detail);
                    }
                    else
                    {
                        this.packingDetailRepository.SetValues(detail, existstLotTxNG);
                    }
                }
            }
            this.runtimeService.Commit();
        }
	}
}