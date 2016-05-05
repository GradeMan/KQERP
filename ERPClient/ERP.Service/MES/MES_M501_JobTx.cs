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
	public interface IMES_M501_JobTxService
	{
		MES_M501_JobTx GetById(Guid Id);
        List<MES_M501_JobTx> GetList();
		List<MES_M501_JobTx> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M501_JobTx MES_M501_JobTx);
        void Update(MES_M501_JobTx MES_M501_JobTx);
        void Delete(Guid Id);
        IQueryable<MES_M501_JobTx> GetJobTxQuery();
        void Save(MES_M501_JobTx MES_M501_JobTx, MES_M202_Task_Detail task,List<MES_M501_JobTx_NG> jobLotNgList);
        void Save(MES_M501_JobTx jobtx, List<MES_M501_JobTxDetail> jobtxDetailList, List<MES_M501_JobTx_NG> jobLotNgList,List<MES_M501_JobTxProdInfo> jobtxProdInfoList);
        IQueryable<MES_M501_JobTxDetail> GetJobTxDetailQuery();
        IQueryable<MES_M501_JobTxProdInfo> GetJobTxProdInfoQuery();
	}
	public class MES_M501_JobTxService :IMES_M501_JobTxService
	{
		private IMES_M501_JobTxRepository MES_M501_JobTxRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IMES_M202_Task_DetailRepository taskRepository;
        private IMES_M501_JobTx_NGRepository jobtxNgRepository;
        private IMES_M501_JobTxDetailRepository jobtxDetailRepository;
        private IMES_M501_JobTxProdInfoRepository jobtxProdInfoRepository;
        private IMES_M202_Task_JobLotRepository taskJobLotRepository;
		public MES_M501_JobTxService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M501_JobTxRepository = new MES_M501_JobTxRepository(dbfactory);
            this.taskRepository = new MES_M202_Task_DetailRepository(dbfactory);
            jobtxNgRepository = new MES_M501_JobTx_NGRepository(dbfactory);
            jobtxDetailRepository = new MES_M501_JobTxDetailRepository(dbfactory);
            jobtxProdInfoRepository = new MES_M501_JobTxProdInfoRepository(dbfactory);
            taskJobLotRepository = new MES_M202_Task_JobLotRepository(dbfactory);
		}
        public IQueryable<MES_M501_JobTxProdInfo> GetJobTxProdInfoQuery()
        {
            return this.jobtxProdInfoRepository.GetMany(i => true);
        }
        public IQueryable<MES_M501_JobTxDetail> GetJobTxDetailQuery()
        {
            return this.jobtxDetailRepository.GetMany(i => true);
        }
        public IQueryable<MES_M501_JobTx> GetJobTxQuery()
        {
            return this.MES_M501_JobTxRepository.GetMany(i => true);
        }
		public List<MES_M501_JobTx> GetList()
        {
            var q = this.MES_M501_JobTxRepository.GetMany(i => true);
            return q.ToList();
        }
        public void Save(MES_M501_JobTx jobtx, List<MES_M501_JobTxDetail> jobtxDetailList, List<MES_M501_JobTx_NG> jobLotNgList, List<MES_M501_JobTxProdInfo> jobtxProdInfoList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsjobtx = this.GetById(jobtx.Id);
            if (existsjobtx == null)
            {
                jobtx.CompCode = tempUser.CompCode;
                jobtx.CreateDt = DateTime.Now;
                jobtx.CreateUser = tempUser.UserName;
                jobtx.Validate();
                this.MES_M501_JobTxRepository.Add(jobtx);
            }
            else
            {
                jobtx.ModifyDt = DateTime.Now;
                jobtx.ModifyUser = tempUser.UserName;
                jobtx.Validate();
                this.MES_M501_JobTxRepository.SetValues(jobtx, existsjobtx);
            }
            foreach (var jobtxDetail in jobtxDetailList)
            {
                var exitstDetail = jobtxDetailRepository.GetByID(jobtxDetail.Id);
                if (exitstDetail == null)
                {
                    jobtxDetail.CompCode = tempUser.CompCode;
                    jobtxDetail.JobNo = jobtx.JobNo;
                    jobtxDetail.ProcessCode = jobtx.ProcessCode;
                    jobtxDetail.Validate();
                    jobtxDetailRepository.Add(jobtxDetail);
                }
                else
                {
                    jobtxDetailRepository.SetValues(jobtxDetail, exitstDetail);
                }
            }
            if (jobtxProdInfoList != null)
            {
                foreach (var prodInfo in jobtxProdInfoList)
                {
                    var exitstProdInfo = jobtxProdInfoRepository.GetByID(prodInfo.Id);
                    if (exitstProdInfo == null)
                    {
                        prodInfo.CompCode = tempUser.CompCode;
                        prodInfo.JobNo = jobtx.JobNo;
                        prodInfo.PFCode = jobtx.PFCode;
                        prodInfo.ProcessCode = jobtx.ProcessCode;
                        prodInfo.Validate();
                        this.jobtxProdInfoRepository.Add(prodInfo);
                    }
                    else
                    {
                        jobtxProdInfoRepository.SetValues(prodInfo, exitstProdInfo);
                    }
                }
            }
            //foreach (var jobLotNg in jobLotNgList)
            //{
            //    jobLotNg.CompCode = tempUser.CompCode;
            //    jobLotNg.CreateDt = DateTime.Now;
            //    jobLotNg.CreateUser = tempUser.UserName;
            //    jobLotNg.Validate();
            //    jobtxNgRepository.Add(jobLotNg);
            //}

            var existsTask = this.taskRepository.GetMany(a=>a.TaskNo == jobtx.TaskNo).FirstOrDefault();
            if (existsTask != null)
            {
                existsTask.ModifyDt = DateTime.Now;
                existsTask.ModifyUser = tempUser.UserName;
                existsTask.Validate();
            }
            var existsTaskJobLot = this.taskJobLotRepository.GetMany(a => a.JobLotNo == jobtx.JobNo).FirstOrDefault();
            if (existsTaskJobLot != null)
            {
                existsTaskJobLot.CurrentProcess = jobtx.ProcessCode;
                existsTaskJobLot.ProcessQty = Convert.ToInt32(jobtx.Weight ?? 0);
            }
            this.runtimeService.Commit();
        }
        public void Save(MES_M501_JobTx MES_M501_JobTx, MES_M202_Task_Detail task, List<MES_M501_JobTx_NG> jobLotNgList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(MES_M501_JobTx.Id);
            if (existsdevice == null)
            {
                MES_M501_JobTx.CompCode = tempUser.CompCode;
                MES_M501_JobTx.CreateDt = DateTime.Now;
                MES_M501_JobTx.CreateUser = tempUser.UserName;
                MES_M501_JobTx.Validate();
                this.MES_M501_JobTxRepository.Add(MES_M501_JobTx);
            }
            else
            {
                MES_M501_JobTx.ModifyDt = DateTime.Now;
                MES_M501_JobTx.ModifyUser = tempUser.UserName;
                MES_M501_JobTx.Validate();
                this.MES_M501_JobTxRepository.SetValues(MES_M501_JobTx, existsdevice);
            }

            var existsmatSupp = this.taskRepository.GetByID(task.Id);
            if (existsmatSupp == null)
            {
                task.CompCode = tempUser.CompCode;
                task.CreateDt = DateTime.Now;
                task.CreateUser = tempUser.UserName;
                task.Validate();
                this.taskRepository.Add(task);
            }
            else
            {
                task.ModifyDt = DateTime.Now;
                task.ModifyUser = tempUser.UserName;
                task.Validate();
                this.taskRepository.SetValues(task, existsmatSupp);
            }
            foreach (var jobLotNg in jobLotNgList)
            {
                jobLotNg.CompCode = tempUser.CompCode;
                jobLotNg.CreateDt = DateTime.Now;
                jobLotNg.CreateUser = tempUser.UserName;
                jobLotNg.Validate();
                jobtxNgRepository.Add(jobLotNg);
            }
            
            this.runtimeService.Commit();
        }
        public MES_M501_JobTx GetById(Guid Id)
        {
            return this.MES_M501_JobTxRepository.GetByID(Id);
        }

        public void Create(MES_M501_JobTx MES_M501_JobTx)
        {
        	MES_M501_JobTx.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M501_JobTx.CreateUser = tempUser.UserName;
            MES_M501_JobTx.Validate();
			this.MES_M501_JobTxRepository.Add(MES_M501_JobTx);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            //var existstb_Sys_Menu = this.GetById(Id);
            //this.MES_M501_JobTxRepository.Delete(existstb_Sys_Menu);
            //this.runtimeService.Commit();
            var existstb_Sys_Menu = this.GetById(Id);
            if (existstb_Sys_Menu != null)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(@"    Delete MES_M501_JobTx where JobNo=@JobNo AND ProcessCode = @ProcessCode
                                    Delete MES_M501_JobTx_NG where JobNo = @JobNo AND ProcessCode = @ProcessCode
                                    Delete MES_M501_JobTxDetail where JobNo = @JobNo AND ProcessCode = @ProcessCode
                                    Delete MES_M501_JobTxProdInfo where JobNo = @JobNo AND ProcessCode = @ProcessCode
                                     ");
                var JobNoParam = new SqlParameter
                {
                    ParameterName = "JobNo",
                    Value = existstb_Sys_Menu.JobNo
                };
                var ProcessCodeParam = new SqlParameter
                {
                    ParameterName = "ProcessCode",
                    Value = existstb_Sys_Menu.ProcessCode
                };
                this.MES_M501_JobTxRepository.GetDbContext().Database.ExecuteSqlCommand(strSql.ToString(), JobNoParam, ProcessCodeParam);
            }
        }

        public void Update(MES_M501_JobTx MES_M501_JobTx)
        {
        	MES_M501_JobTx.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M501_JobTx.ModifyUser = tempUser.UserName;
            MES_M501_JobTx.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M501_JobTx.Id);
            this.MES_M501_JobTxRepository.SetValues(MES_M501_JobTx, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M501_JobTx> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M501_JobTxRepository.GetMany(i => true);
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