using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M104_Packing_DetailService
	{
		WMS_M104_Packing_Detail GetById(Guid Id);
        List<WMS_M104_Packing_Detail> GetList();
		List<WMS_M104_Packing_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M104_Packing_Detail WMS_M104_Packing_Detail);
        void Update(WMS_M104_Packing_Detail WMS_M104_Packing_Detail);
        void Delete(Guid Id);
	}
	public class WMS_M104_Packing_DetailService :IWMS_M104_Packing_DetailService
	{
		private IWMS_M104_Packing_DetailRepository WMS_M104_Packing_DetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_M104_Packing_DetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M104_Packing_DetailRepository = new WMS_M104_Packing_DetailRepository(dbfactory);
		}

		public List<WMS_M104_Packing_Detail> GetList()
        {
            var q = this.WMS_M104_Packing_DetailRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_M104_Packing_Detail GetById(Guid Id)
        {
            return this.WMS_M104_Packing_DetailRepository.GetByID(Id);
        }

        public void Create(WMS_M104_Packing_Detail WMS_M104_Packing_Detail)
        {
            WMS_M104_Packing_Detail.Validate();
			this.WMS_M104_Packing_DetailRepository.Add(WMS_M104_Packing_Detail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M104_Packing_DetailRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M104_Packing_Detail WMS_M104_Packing_Detail)
        {
            WMS_M104_Packing_Detail.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M104_Packing_Detail.Id);
            this.WMS_M104_Packing_DetailRepository.SetValues(WMS_M104_Packing_Detail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M104_Packing_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M104_Packing_DetailRepository.GetMany(i => true);
			
            q = q.OrderByDescending(i => i.MFGDate);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}