using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_C102_InStoreDetailService
	{
		WMS_C102_InStoreDetail GetById(Guid Id);
        List<WMS_C102_InStoreDetail> GetList();
		List<WMS_C102_InStoreDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C102_InStoreDetail WMS_C102_InStoreDetail);
        void Update(WMS_C102_InStoreDetail WMS_C102_InStoreDetail);
        void Delete(Guid Id);
	}
	public class WMS_C102_InStoreDetailService :IWMS_C102_InStoreDetailService
	{
		private IWMS_C102_InStoreDetailRepository WMS_C102_InStoreDetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_C102_InStoreDetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C102_InStoreDetailRepository = new WMS_C102_InStoreDetailRepository(dbfactory);
		}

		public List<WMS_C102_InStoreDetail> GetList()
        {
            var q = this.WMS_C102_InStoreDetailRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C102_InStoreDetail GetById(Guid Id)
        {
            return this.WMS_C102_InStoreDetailRepository.GetByID(Id);
        }

        public void Create(WMS_C102_InStoreDetail WMS_C102_InStoreDetail)
        {
        	WMS_C102_InStoreDetail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C102_InStoreDetail.CreateUser = tempUser.UserName;
            WMS_C102_InStoreDetail.Validate();
			this.WMS_C102_InStoreDetailRepository.Add(WMS_C102_InStoreDetail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.WMS_C102_InStoreDetailRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C102_InStoreDetail WMS_C102_InStoreDetail)
        {
        	WMS_C102_InStoreDetail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C102_InStoreDetail.ModifyUser = tempUser.UserName;
            WMS_C102_InStoreDetail.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C102_InStoreDetail.Id);
            this.WMS_C102_InStoreDetailRepository.SetValues(WMS_C102_InStoreDetail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C102_InStoreDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C102_InStoreDetailRepository.GetMany(i => true);
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