using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_M003_InStoreDetailService
	{
		ERP_M003_InStoreDetail GetById(Guid Id);
        List<ERP_M003_InStoreDetail> GetList();
		List<ERP_M003_InStoreDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M003_InStoreDetail ERP_M003_InStoreDetail);
        void Update(ERP_M003_InStoreDetail ERP_M003_InStoreDetail);
        void Delete(Guid Id);
	}
	public class ERP_M003_InStoreDetailService :IERP_M003_InStoreDetailService
	{
		private IERP_M003_InStoreDetailRepository ERP_M003_InStoreDetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M003_InStoreDetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M003_InStoreDetailRepository = new ERP_M003_InStoreDetailRepository(dbfactory);
		}

		public List<ERP_M003_InStoreDetail> GetList()
        {
            var q = this.ERP_M003_InStoreDetailRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M003_InStoreDetail GetById(Guid Id)
        {
            return this.ERP_M003_InStoreDetailRepository.GetByID(Id);
        }

        public void Create(ERP_M003_InStoreDetail ERP_M003_InStoreDetail)
        {
        	ERP_M003_InStoreDetail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_InStoreDetail.CreateUser = tempUser.UserName;
            ERP_M003_InStoreDetail.Validate();
			this.ERP_M003_InStoreDetailRepository.Add(ERP_M003_InStoreDetail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M003_InStoreDetailRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M003_InStoreDetail ERP_M003_InStoreDetail)
        {
        	ERP_M003_InStoreDetail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_InStoreDetail.ModifyUser = tempUser.UserName;
            ERP_M003_InStoreDetail.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M003_InStoreDetail.Id);
            this.ERP_M003_InStoreDetailRepository.SetValues(ERP_M003_InStoreDetail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M003_InStoreDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M003_InStoreDetailRepository.GetMany(i => true);
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