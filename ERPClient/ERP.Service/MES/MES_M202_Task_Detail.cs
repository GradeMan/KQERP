using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using System.Text;
using System.Data.SqlClient;
namespace ERP.Service
{
	public interface IMES_M202_Task_DetailService
	{
		MES_M202_Task_Detail GetById(Guid Id);
        List<MES_M202_Task_Detail> GetList();
        IQueryable<MES_M202_Task_Detail> GetQuery();
		List<MES_M202_Task_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M202_Task_Detail MES_M202_Task_Detail);
        void Update(MES_M202_Task_Detail MES_M202_Task_Detail);
        void Delete(Guid Id);
        void Save(MES_M202_Task_Detail taskDetail, List<MES_M202_Task_JobLot> taskJobLotList);
	}
	public class MES_M202_Task_DetailService :IMES_M202_Task_DetailService
	{
		private IMES_M202_Task_DetailRepository MES_M202_Task_DetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IMES_M202_Task_JobLotRepository taskJobLotRepository;
		public MES_M202_Task_DetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M202_Task_DetailRepository = new MES_M202_Task_DetailRepository(dbfactory);
            this.taskJobLotRepository = new MES_M202_Task_JobLotRepository(dbfactory);
		}
        public void Save(MES_M202_Task_Detail taskDetail, List<MES_M202_Task_JobLot> taskJobLotList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existstemp = this.GetById(taskDetail.Id);
            if (existstemp == null)
            {
                taskDetail.CompCode = tempUser.CompCode;
                taskDetail.CreateDt = DateTime.Now;
                taskDetail.CreateUser = tempUser.UserName;
                taskDetail.Validate();
                this.MES_M202_Task_DetailRepository.Add(taskDetail);
            }
            else
            {
                taskDetail.ModifyDt = DateTime.Now;
                taskDetail.ModifyUser = tempUser.UserName;
                taskDetail.Validate();
                this.MES_M202_Task_DetailRepository.SetValues(taskDetail, existstemp);
            }
            if (taskJobLotList != null)
            {
                string sql = string.Format("Delete MES_M202_Task_JobLot where JobNo = '{0}'", taskDetail.TaskNo);
                taskJobLotRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var taskJobLot in taskJobLotList)
                {
                    taskJobLot.JobNo = taskDetail.TaskNo;
                    taskJobLot.CompCode = tempUser.CompCode;
                    taskJobLot.Validate();
                    this.taskJobLotRepository.Add(taskJobLot);
                }
            }
            this.runtimeService.Commit();
        }
		public List<MES_M202_Task_Detail> GetList()
        {
            var q = this.MES_M202_Task_DetailRepository.GetMany(i => true);
            return q.ToList();
        }
        public IQueryable<MES_M202_Task_Detail> GetQuery()
        {
            var q = this.MES_M202_Task_DetailRepository.GetMany(i => true);
            return q;
        }
        public MES_M202_Task_Detail GetById(Guid Id)
        {
            return this.MES_M202_Task_DetailRepository.GetByID(Id);
        }

        public void Create(MES_M202_Task_Detail MES_M202_Task_Detail)
        {
        	MES_M202_Task_Detail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M202_Task_Detail.CreateUser = tempUser.UserName;
            MES_M202_Task_Detail.Validate();
			this.MES_M202_Task_DetailRepository.Add(MES_M202_Task_Detail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            //var existstb_Sys_Menu = this.GetById(Id);
            //this.MES_M202_Task_DetailRepository.Delete(existstb_Sys_Menu);
            //this.runtimeService.Commit();
            var existstb_Sys_Menu = this.GetById(Id);
            if (existstb_Sys_Menu != null)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(@"    Delete MES_M202_Task_Detail where TaskNo=@TaskNo
                                    Delete MES_M202_Task_JobLot where JobNo = @TaskNo  ");
                var partNoParam = new SqlParameter
                {
                    ParameterName = "TaskNo",
                    Value = existstb_Sys_Menu.TaskNo
                };
                this.MES_M202_Task_DetailRepository.GetDbContext().Database.ExecuteSqlCommand(strSql.ToString(), partNoParam);
            }
        }

        public void Update(MES_M202_Task_Detail MES_M202_Task_Detail)
        {
        	MES_M202_Task_Detail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M202_Task_Detail.ModifyUser = tempUser.UserName;
            MES_M202_Task_Detail.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M202_Task_Detail.Id);
            this.MES_M202_Task_DetailRepository.SetValues(MES_M202_Task_Detail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M202_Task_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M202_Task_DetailRepository.GetMany(i => true);
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