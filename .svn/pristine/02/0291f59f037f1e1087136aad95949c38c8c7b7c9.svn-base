using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface ISUPP_M001_PurPlan_MaterialService
	{
		SUPP_M001_PurPlan_Material GetById(Guid Id);
        List<SUPP_M001_PurPlan_Material> GetList();
		List<SUPP_M001_PurPlan_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(SUPP_M001_PurPlan_Material SUPP_M001_PurPlan_Material);
        void Update(SUPP_M001_PurPlan_Material SUPP_M001_PurPlan_Material);
        void Delete(Guid Id);
	}
	public class SUPP_M001_PurPlan_MaterialService :ISUPP_M001_PurPlan_MaterialService
	{
		private ISUPP_M001_PurPlan_MaterialRepository SUPP_M001_PurPlan_MaterialRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public SUPP_M001_PurPlan_MaterialService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.SUPP_M001_PurPlan_MaterialRepository = new SUPP_M001_PurPlan_MaterialRepository(dbfactory);
		}

		public List<SUPP_M001_PurPlan_Material> GetList()
        {
            var q = this.SUPP_M001_PurPlan_MaterialRepository.GetMany(i => true);
            return q.ToList();
        }

        public SUPP_M001_PurPlan_Material GetById(Guid Id)
        {
            return this.SUPP_M001_PurPlan_MaterialRepository.GetByID(Id);
        }

        public void Create(SUPP_M001_PurPlan_Material SUPP_M001_PurPlan_Material)
        {
        	SUPP_M001_PurPlan_Material.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            SUPP_M001_PurPlan_Material.CreateUser = tempUser.UserName;
            SUPP_M001_PurPlan_Material.Validate();
			this.SUPP_M001_PurPlan_MaterialRepository.Add(SUPP_M001_PurPlan_Material);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.SUPP_M001_PurPlan_MaterialRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(SUPP_M001_PurPlan_Material SUPP_M001_PurPlan_Material)
        {
        	SUPP_M001_PurPlan_Material.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            SUPP_M001_PurPlan_Material.ModifyUser = tempUser.UserName;
            SUPP_M001_PurPlan_Material.Validate();
            var existstb_Sys_Menu = this.GetById(SUPP_M001_PurPlan_Material.Id);
            this.SUPP_M001_PurPlan_MaterialRepository.SetValues(SUPP_M001_PurPlan_Material, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<SUPP_M001_PurPlan_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.SUPP_M001_PurPlan_MaterialRepository.GetMany(i => true);
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