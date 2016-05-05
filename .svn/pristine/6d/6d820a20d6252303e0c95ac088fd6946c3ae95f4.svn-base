using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_C105_OutStoreDetailService
	{
		WMS_C105_OutStoreDetail GetById(Guid Id);
        List<WMS_C105_OutStoreDetail> GetList();
		List<WMS_C105_OutStoreDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C105_OutStoreDetail WMS_C105_OutStoreDetail);
        void Update(WMS_C105_OutStoreDetail WMS_C105_OutStoreDetail);
        void Delete(Guid Id);
	}
	public class WMS_C105_OutStoreDetailService :IWMS_C105_OutStoreDetailService
	{
		private IWMS_C105_OutStoreDetailRepository WMS_C105_OutStoreDetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_C105_OutStoreDetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C105_OutStoreDetailRepository = new WMS_C105_OutStoreDetailRepository(dbfactory);
		}

		public List<WMS_C105_OutStoreDetail> GetList()
        {
            var q = this.WMS_C105_OutStoreDetailRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C105_OutStoreDetail GetById(Guid Id)
        {
            return this.WMS_C105_OutStoreDetailRepository.GetByID(Id);
        }

        public void Create(WMS_C105_OutStoreDetail WMS_C105_OutStoreDetail)
        {
        	WMS_C105_OutStoreDetail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C105_OutStoreDetail.CreateUser = tempUser.UserName;
            WMS_C105_OutStoreDetail.CompCode = tempUser.CompCode;
            WMS_C105_OutStoreDetail.Validate();
			this.WMS_C105_OutStoreDetailRepository.Add(WMS_C105_OutStoreDetail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.WMS_C105_OutStoreDetailRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C105_OutStoreDetail WMS_C105_OutStoreDetail)
        {
        	WMS_C105_OutStoreDetail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C105_OutStoreDetail.ModifyUser = tempUser.UserName;
            WMS_C105_OutStoreDetail.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C105_OutStoreDetail.Id);
            this.WMS_C105_OutStoreDetailRepository.SetValues(WMS_C105_OutStoreDetail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C105_OutStoreDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C105_OutStoreDetailRepository.GetMany(i => true);
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