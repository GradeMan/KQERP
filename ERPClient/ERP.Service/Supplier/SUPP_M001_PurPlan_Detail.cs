using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface ISUPP_M001_PurPlan_DetailService
	{
		SUPP_M001_PurPlan_Detail GetById(Guid Id);
        List<SUPP_M001_PurPlan_Detail> GetList();
		List<SUPP_M001_PurPlan_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(SUPP_M001_PurPlan_Detail SUPP_M001_PurPlan_Detail);
        void Update(SUPP_M001_PurPlan_Detail SUPP_M001_PurPlan_Detail);
        void Delete(Guid Id);
        IQueryable<SUPP_M001_PurPlan_Detail> GetSuppDetail();
	}
	public class SUPP_M001_PurPlan_DetailService :ISUPP_M001_PurPlan_DetailService
	{
		private ISUPP_M001_PurPlan_DetailRepository SUPP_M001_PurPlan_DetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public SUPP_M001_PurPlan_DetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.SUPP_M001_PurPlan_DetailRepository = new SUPP_M001_PurPlan_DetailRepository(dbfactory);
		}
        public IQueryable<SUPP_M001_PurPlan_Detail> GetSuppDetail()
        {
            return this.SUPP_M001_PurPlan_DetailRepository.GetMany(i => true);
        }
		public List<SUPP_M001_PurPlan_Detail> GetList()
        {
            var q = this.SUPP_M001_PurPlan_DetailRepository.GetMany(i => true);
            return q.ToList();
        }

        public SUPP_M001_PurPlan_Detail GetById(Guid Id)
        {
            return this.SUPP_M001_PurPlan_DetailRepository.GetByID(Id);
        }

        public void Create(SUPP_M001_PurPlan_Detail SUPP_M001_PurPlan_Detail)
        {
        	SUPP_M001_PurPlan_Detail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            SUPP_M001_PurPlan_Detail.CreateUser = tempUser.UserName;
            SUPP_M001_PurPlan_Detail.Validate();
			this.SUPP_M001_PurPlan_DetailRepository.Add(SUPP_M001_PurPlan_Detail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.SUPP_M001_PurPlan_DetailRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(SUPP_M001_PurPlan_Detail SUPP_M001_PurPlan_Detail)
        {
        	SUPP_M001_PurPlan_Detail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            SUPP_M001_PurPlan_Detail.ModifyUser = tempUser.UserName;
            SUPP_M001_PurPlan_Detail.Validate();
            var existstb_Sys_Menu = this.GetById(SUPP_M001_PurPlan_Detail.Id);
            this.SUPP_M001_PurPlan_DetailRepository.SetValues(SUPP_M001_PurPlan_Detail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<SUPP_M001_PurPlan_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.SUPP_M001_PurPlan_DetailRepository.GetMany(i => true);
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