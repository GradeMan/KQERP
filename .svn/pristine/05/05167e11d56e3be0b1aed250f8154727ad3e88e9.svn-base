using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using Util;
using ERP.Domain.Order.ViewModel;
using COM.Domain;
namespace ERP.Service
{
	public interface IJobService
	{
		MES_M002_Job GetById(Guid Id);
        List<MES_M002_Job> GetList();
        List<MES_M002_Job> GetListByJobNo(string jobNo);
		List<MES_M002_Job> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M002_Job MES_M002_Job);
        void Update(MES_M002_Job MES_M002_Job);
        void Delete(Guid Id);
        void MarkDelLot(Guid id);//biaoji shanchu 
        List<MES_M002_Job_Lot> GetJobLotListByJobNo(string JobNo);
        List<MES_M002_Job_Lot_Process> GetProcessByJobNo(string jobNo);
        void Save(MES_M002_Job job, List<MES_M002_Job_Lot> lotList, List<MES_M002_Job_Lot_Process> jobLotProcessList);
        List<MES_M002_Job_Lot> CreateJobLots(decimal jobQty, decimal panelQty, decimal stripPerPanel, string JobNo);
        List<InputItem> GetInputDataList();
        void DeleteLotByJobNo(string jobNo);
	}
    public class JobService : IJobService
	{
		private IJobRepository MES_M002_JobRepository;
        private IJobLotRepository jobLotRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IMES_M002_Job_Lot_ProcessRepository joblotProcessRepository;
        private IProductService productService;
        private IERP_C006_ProcessFlow_ProcessRepository processFlowDetailRepository; 
        public JobService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
            this.MES_M002_JobRepository = new JobRepository(dbfactory);
            this.jobLotRepository = new JobLotRepository(dbfactory);
            this.joblotProcessRepository = new MES_M002_Job_Lot_ProcessRepository(dbfactory);
		}

		public List<MES_M002_Job> GetList()
        {
            var q = this.MES_M002_JobRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M002_Job GetById(Guid Id)
        {
            return this.MES_M002_JobRepository.GetByID(Id);
        }

        public void Create(MES_M002_Job MES_M002_Job)
        {
        	MES_M002_Job.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M002_Job.CreateUser = tempUser.UserName;
            MES_M002_Job.CompCode = tempUser.CompCode;
            MES_M002_Job.Validate();
			this.MES_M002_JobRepository.Add(MES_M002_Job);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.MES_M002_JobRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(MES_M002_Job MES_M002_Job)
        {
        	MES_M002_Job.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M002_Job.ModifyUser = tempUser.UserName;
            MES_M002_Job.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M002_Job.Id);
            this.MES_M002_JobRepository.SetValues(MES_M002_Job, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M002_Job> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M002_JobRepository.GetMany(i => true);
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


        public List<MES_M002_Job_Lot> GetJobLotListByJobNo(string JobNo)
        {
            var q = this.jobLotRepository.GetMany(i => i.JobNo == JobNo).OrderBy(i=>i.LotNo);
            return q.ToList();
        }


        public void MarkDelLot(Guid id)
        {
            var existsTemp = this.jobLotRepository.GetByID(id);
            if (existsTemp != null)
                this.jobLotRepository.Delete(existsTemp);
            //this.runtimeService.Commit(); 
        }

        /// <summary>
        /// baocun
        /// </summary>
        /// <param name="job"></param>
        /// <param name="lotList"></param>
        public void Save(MES_M002_Job job, List<MES_M002_Job_Lot> lotList, List<MES_M002_Job_Lot_Process> jobLotProcessList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existsJob= this.GetById(job.Id);
            if (existsJob == null)
            {
                job.CompCode = tempUser.CompCode;
                job.CreateDt = DateTime.Now;
                job.CreateUser = tempUser.UserName;
                job.Validate();
                this.MES_M002_JobRepository.Add(job);
            }
            else
            {
                job.ModifyDt = DateTime.Now;
                job.ModifyUser = tempUser.UserName;
                job.Validate();
                this.MES_M002_JobRepository.SetValues(job, existsJob);
            }
            if (lotList != null)
            {
                foreach (var lot in lotList)
                {
                    var existstlot = this.jobLotRepository.GetByID(lot.Id);
                    if (existstlot == null)
                    {
                        lot.CompCode = tempUser.CompCode;
                        lot.CreateDt = DateTime.Now;
                        lot.CreateUser = tempUser.UserName;
                        lot.Validate();
                        this.jobLotRepository.Add(lot);
                    }
                    else
                    {
                        //lot.ModifyDt = DateTime.Now;
                        lot.ModifyUser = tempUser.UserName;
                        lot.Validate();
                        this.jobLotRepository.SetValues(lot, existstlot);
                    }
                }
            }
            if (jobLotProcessList != null && jobLotProcessList.Count>0)
            {
                string Sqlcommand = string.Format("delete dbo.MES_M002_Job_Lot_Process where JobNo = '{0}'", job.JobNo);
                joblotProcessRepository.GetDbContext().Database.ExecuteSqlCommand(Sqlcommand);
                foreach (var lotProcess in jobLotProcessList)
                {
                    lotProcess.CompCode = tempUser.CompCode;
                    lotProcess.CreateDt = DateTime.Now;
                    lotProcess.CreateUser = tempUser.UserName;
                    lotProcess.Validate();
                    this.joblotProcessRepository.Add(lotProcess);
                }
            }
            this.runtimeService.Commit();
        }

        /// <summary>
        ///  生成Lot数 Lot个数 == 工单数量/(每板数量*板数量)  每个Lot数量 ==每板数量*板数量
        /// </summary>
        /// <param name="jobQty">工单数量</param>
        /// <param name="panelQty">板数量</param>
        /// <param name="stripPerPanel">每板数量</param>
        /// <returns></returns>
        public List<MES_M002_Job_Lot> CreateJobLots(decimal jobQty, decimal panelQty, decimal stripPerPanel,string jobNo)
        {
            if (string.IsNullOrWhiteSpace(jobNo))
                throw new AppException("工作单号不能为空");
            if (jobQty <= 0)
                throw new AppException("开单数量必须大于0");
            if (stripPerPanel <= 0)
                throw new AppException("条/板数量必须大于0");
            if (panelQty <= 0)
                throw new AppException("板数量必须大于0");
            else if ((stripPerPanel * panelQty) > jobQty)
                throw new AppException("条/板数量与板数量乘积不得大于开单数量");
            decimal modNumber = jobQty % (stripPerPanel * panelQty);//每Lot数量数是否相等，看下是否有余数
            int totalLotNo = Convert.ToInt32((Math.Ceiling(jobQty / (stripPerPanel * panelQty))));//总Lot数
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            List<MES_M002_Job_Lot> jobLotList = new List<MES_M002_Job_Lot>();
            for (int i = 1; i <= (modNumber > 0 && totalLotNo > 1 ? totalLotNo - 1 : totalLotNo); i++)
            {
                MES_M002_Job_Lot jobLot = new MES_M002_Job_Lot();
                jobLot.CompCode = tempUser.CompCode;
                jobLot.CreateDt = DateTime.Now;
                jobLot.CreateUser = tempUser.UserCode;
                jobLot.JobNo = jobNo;
                jobLot.LotNo = i < 10 ? 0 + i.ToString() : i.ToString();
                jobLot.LotQty = stripPerPanel * panelQty;
                jobLotList.Add(jobLot);
            }
            if (modNumber > 0) //最后一Lot的数量
            {
                MES_M002_Job_Lot jobLot = new MES_M002_Job_Lot();
                jobLot.CompCode = tempUser.CompCode;
                jobLot.CreateDt = DateTime.Now;
                jobLot.CreateUser = tempUser.UserCode;
                jobLot.JobNo = jobNo;
                jobLot.LotNo =  totalLotNo < 10 ? 0 + totalLotNo.ToString() : totalLotNo.ToString();
                jobLot.LotQty = modNumber;
                jobLotList.Add(jobLot);
            }
            return jobLotList;
        }


        public List<InputItem> GetInputDataList()
        {
            var q = this.MES_M002_JobRepository.GetMany(i => true).Select(i=>new {i.JobNo}).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.JobNo, Value = i.JobNo});
            return q2.ToList();
        }


        public List<MES_M002_Job_Lot_Process> GetProcessByJobNo(string jobNo)
        {
            var q = this.joblotProcessRepository.GetMany(i => i.JobNo == jobNo);
            return q.ToList();
        }

        public void DeleteLotByJobNo(string jobNo)
        {
            var q = this.jobLotRepository.GetMany(i => i.JobNo == jobNo);
            foreach (var lot in q)
                this.jobLotRepository.Delete(lot);
            this.runtimeService.Commit();
        }


        public List<MES_M002_Job> GetListByJobNo(string jobNo)
        {

            var q = this.MES_M002_JobRepository.GetMany(i => i.JobNo == jobNo);
            return q.ToList();
        
        }
    }
}