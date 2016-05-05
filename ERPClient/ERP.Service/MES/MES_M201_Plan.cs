using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M201_PlanService
	{
		MES_M201_Plan GetById(Guid Id);
        List<MES_M201_Plan> GetList();
        IQueryable<MES_M201_Plan> GetQuery();
        IQueryable<MES_M201_Plan_Detail> GetProductQuery();
        IQueryable<MES_M201_Plan_Material> GetMaterialQuery();
		List<MES_M201_Plan> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M201_Plan MES_M201_Plan);
        void Update(MES_M201_Plan MES_M201_Plan);
        void Delete(Guid Id);
        void Save(MES_M201_Plan material, List<MES_M201_Plan_Detail> productList);
        void MarkDelProduct(MES_M201_Plan_Detail temp);
        void ShenHe(MES_M201_Plan MES_M201_Plan);

	}
	public class MES_M201_PlanService :IMES_M201_PlanService
	{
		private IMES_M201_PlanRepository MES_M201_PlanRepository;
        private IMES_M201_Plan_DetailRepository planDetailRepository;
        private IMES_M201_Plan_MaterialRepository planMaterialRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M201_PlanService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M201_PlanRepository = new MES_M201_PlanRepository(dbfactory);
            this.planDetailRepository = new MES_M201_Plan_DetailRepository(dbfactory);
            this.planMaterialRepository = new MES_M201_Plan_MaterialRepository(dbfactory);
		}

        public void MarkDelProduct(MES_M201_Plan_Detail temp)
        {
            var existsDetail = this.planDetailRepository.GetByID(temp.Id);
            if (existsDetail != null)
            {
                this.planDetailRepository.Delete(existsDetail);
                var materialList = planMaterialRepository.GetMany(i => i.PlanDetailId == existsDetail.Id).ToList();
                foreach(var material in materialList)
                    this.planMaterialRepository.Delete(material);
            }

        }

        public void Save(MES_M201_Plan plan, List<MES_M201_Plan_Detail> productList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsplan = this.GetById(plan.Id);
            if (existsplan == null)
            {
                plan.CompCode = tempUser.CompCode;
                plan.CreateDt = DateTime.Now;
                plan.CreateUser = tempUser.UserName;
                plan.Validate();
                this.MES_M201_PlanRepository.Add(plan);
            }
            else
            {
                plan.ModifyDt = DateTime.Now;
                plan.ModifyUser = tempUser.UserName;
                plan.Validate();
                this.MES_M201_PlanRepository.SetValues(plan, existsplan);
            }
            foreach (var product in productList)
            {
                var existsmatSupp = planDetailRepository.GetByID(product.Id);
                if (existsmatSupp == null)
                {
                    product.CompCode = tempUser.CompCode;
                    product.CreateDt = DateTime.Now;
                    product.CreateUser = tempUser.UserName;
                    product.PLNo = plan.PLNo;
                    product.PlanId = plan.Id;
                    product.Validate();
                    this.planDetailRepository.Add(product);
                }
                else
                {
                    product.ModifyDt = DateTime.Now;
                    product.ModifyUser = tempUser.UserName;
                    product.Validate();
                    this.planDetailRepository.SetValues(product, existsmatSupp);
                }
            }
           
            this.runtimeService.Commit();
        }
		public List<MES_M201_Plan> GetList()
        {
            var q = this.MES_M201_PlanRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<MES_M201_Plan> GetQuery()
        {
            var q = this.MES_M201_PlanRepository.GetMany(i => true);
            return q;
        }
        public IQueryable<MES_M201_Plan_Detail> GetProductQuery()
        {
            return this.planDetailRepository.GetMany(i => true);
        }
        public IQueryable<MES_M201_Plan_Material> GetMaterialQuery()
        {
            return this.planMaterialRepository.GetMany(i => true);
        }
        public MES_M201_Plan GetById(Guid Id)
        {
            return this.MES_M201_PlanRepository.GetByID(Id);
        }

        public void Create(MES_M201_Plan MES_M201_Plan)
        {
        	MES_M201_Plan.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M201_Plan.CreateUser = tempUser.UserName;
            MES_M201_Plan.Validate();
			this.MES_M201_PlanRepository.Add(MES_M201_Plan);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            if (existstb_Sys_Menu != null)
            {
                var detailList = this.planDetailRepository.GetMany(i => i.PlanId == existstb_Sys_Menu.Id).ToList();
                foreach (var detail in detailList)
                    planDetailRepository.Delete(detail);
                var materialList = this.planMaterialRepository.GetMany(i => i.PLNo == existstb_Sys_Menu.PLNo).ToList();
                foreach (var material in materialList)
                    planMaterialRepository.Delete(material);
                this.MES_M201_PlanRepository.Delete(existstb_Sys_Menu);
                this.runtimeService.Commit();
            }      
        }

        public void Update(MES_M201_Plan MES_M201_Plan)
        {
        	MES_M201_Plan.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M201_Plan.ModifyUser = tempUser.UserName;
            MES_M201_Plan.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M201_Plan.Id);
            this.MES_M201_PlanRepository.SetValues(MES_M201_Plan, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }
        public void ShenHe(MES_M201_Plan MES_M201_Plan)
        {
            MES_M201_Plan.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M201_Plan.ModifyUser = tempUser.UserName;
            MES_M201_Plan.PLAuditing = tempUser.UserName;
            MES_M201_Plan.PLAuditingDt = DateTime.Now.Date;
            MES_M201_Plan.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M201_Plan.Id);
            this.MES_M201_PlanRepository.SetValues(MES_M201_Plan, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }
        public List<MES_M201_Plan> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M201_PlanRepository.GetMany(i => true);
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