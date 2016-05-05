using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M004_PlanJobService
	{
		MES_M004_PlanJob GetById(Guid Id);
        List<MES_M004_PlanJob> GetList();
		List<MES_M004_PlanJob> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M004_PlanJob MES_M004_PlanJob);
        void Update(MES_M004_PlanJob MES_M004_PlanJob);
        void Delete(Guid Id);
	}
	public class MES_M004_PlanJobService :IMES_M004_PlanJobService
	{
		private IMES_M004_PlanJobRepository MES_M004_PlanJobRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M004_PlanJobService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M004_PlanJobRepository = new MES_M004_PlanJobRepository(dbfactory);
		}

		public List<MES_M004_PlanJob> GetList()
        {
            var q = this.MES_M004_PlanJobRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M004_PlanJob GetById(Guid Id)
        {
            return this.MES_M004_PlanJobRepository.GetByID(Id);
        }

        public void Create(MES_M004_PlanJob MES_M004_PlanJob)
        {
        	MES_M004_PlanJob.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M004_PlanJob.CreateUser = tempUser.UserName;
            MES_M004_PlanJob.Validate();
			this.MES_M004_PlanJobRepository.Add(MES_M004_PlanJob);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M004_PlanJobRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M004_PlanJob MES_M004_PlanJob)
        {
        	MES_M004_PlanJob.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M004_PlanJob.ModifyUser = tempUser.UserName;
            MES_M004_PlanJob.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M004_PlanJob.Id);
            this.MES_M004_PlanJobRepository.SetValues(MES_M004_PlanJob, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M004_PlanJob> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M004_PlanJobRepository.GetMany(i => true);
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