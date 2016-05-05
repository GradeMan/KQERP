using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using Util;
namespace ERP.Service
{
	public interface IMES_M202_TaskService
	{
		MES_M202_Task GetById(Guid Id);
        List<MES_M202_Task> GetList();
		List<MES_M202_Task> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M202_Task MES_M202_Task);
        void Update(MES_M202_Task MES_M202_Task);
        void Delete(Guid Id);
        void Save(MES_M202_Task Task, List<MES_M202_Task_Detail> TaskDetailList);

        IQueryable<MES_M202_Task> GetQuery();
        IQueryable<MES_M202_Task_Detail> GetProductQuery();
	}
	public class MES_M202_TaskService :IMES_M202_TaskService
	{
        private IMES_M202_Task_DetailRepository MES_M202_TaskDetailRepository;
		private IMES_M202_TaskRepository MES_M202_TaskRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IMES_M201_Plan_DetailRepository planDetailRepository;
		public MES_M202_TaskService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M202_TaskRepository = new MES_M202_TaskRepository(dbfactory);
            this.MES_M202_TaskDetailRepository = new MES_M202_Task_DetailRepository(dbfactory);
            this.planDetailRepository = new MES_M201_Plan_DetailRepository(dbfactory);
		}

		public List<MES_M202_Task> GetList()
        {
            var q = this.MES_M202_TaskRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M202_Task GetById(Guid Id)
        {
            return this.MES_M202_TaskRepository.GetByID(Id);
        }

        public void Create(MES_M202_Task MES_M202_Task)
        {
            MES_M202_Task.TaskDt = DateTime.Now;
        	MES_M202_Task.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M202_Task.CreateUser = tempUser.UserName;
            MES_M202_Task.Validate();
			this.MES_M202_TaskRepository.Add(MES_M202_Task);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M202_TaskRepository.Delete(existstb_Sys_Menu);
            var taskDetailList = this.MES_M202_TaskDetailRepository.GetMany(i => i.TaskNo == existstb_Sys_Menu.TaskNo).ToList();
            foreach (var taksDetail in taskDetailList)
                MES_M202_TaskDetailRepository.Delete(taksDetail);
            this.runtimeService.Commit();
        }

        public void Update(MES_M202_Task MES_M202_Task)
        {
        	MES_M202_Task.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M202_Task.ModifyUser = tempUser.UserName;
            MES_M202_Task.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M202_Task.Id);
            this.MES_M202_TaskRepository.SetValues(MES_M202_Task, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M202_Task> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M202_TaskRepository.GetMany(i => true);
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
        public void Save(MES_M202_Task task, List<MES_M202_Task_Detail> taskdtllist)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existtask = this.GetById(task.Id);
            if (existtask == null)
            {
                task.CompCode = tempUser.CompCode;
                task.CreateDt = DateTime.Now;
                task.CreateUser = tempUser.UserName;
                task.Validate();
                this.MES_M202_TaskRepository.Add(task);
            }
            else
            {
                task.ModifyDt = DateTime.Now;
                task.ModifyUser = tempUser.UserName;
                task.Validate();
                this.MES_M202_TaskRepository.SetValues(task, existtask);
            }
            foreach (var taskdtl in taskdtllist)
            {
                var existtaskdtl = MES_M202_TaskDetailRepository.GetByID(taskdtl.Id);
                var planDetail = planDetailRepository.GetByID(taskdtl.PlanDetailId.ToGuidOrNull());
                if (existtaskdtl == null)
                {
                    taskdtl.CompCode = tempUser.CompCode;
                    taskdtl.CreateDt = DateTime.Now;
                    taskdtl.CreateUser = tempUser.UserName;
                    taskdtl.TaskNo = task.TaskNo;
                    taskdtl.Validate();
                    this.MES_M202_TaskDetailRepository.Add(taskdtl);
                    planDetail.FQty += taskdtl.JobQty ?? 0;
                }
                else
                {
                    taskdtl.ModifyDt = DateTime.Now;
                    taskdtl.ModifyUser = tempUser.UserName;
                    taskdtl.Validate();
                    planDetail.FQty += taskdtl.JobQty ?? 0 - existtaskdtl.JobQty ?? 0;
                    this.MES_M202_TaskDetailRepository.SetValues(taskdtl, existtaskdtl);
                }
            }
            
            this.runtimeService.Commit();
        }
        public IQueryable<MES_M202_Task> GetQuery()
        {
            var q = this.MES_M202_TaskRepository.GetMany(i => true);
            return q;
        }
        public IQueryable<MES_M202_Task_Detail> GetProductQuery()
        {
            return this.MES_M202_TaskDetailRepository.GetMany(i => true);
        }
	}
}