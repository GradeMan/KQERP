using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using Util;
using ERP.Domain.Order.ViewModel;
namespace ERP.Service
{
	public interface IJobReportService
	{
        JobReportModel GetByJobNoList(string jobNo, List<string> lotList);
	}
    public class JobReportService : IJobReportService
	{
		private Ivw_JobReportRepository vw_JobReportRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IMES_M002_Job_Lot_ProcessRepository jobLotProcessRepository;
        private IERP_C001_CodeRepository codeRepository;
        public JobReportService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.vw_JobReportRepository = new vw_JobReportRepository(dbfactory);
            this.jobLotProcessRepository = new MES_M002_Job_Lot_ProcessRepository(dbfactory);
            this.codeRepository = new ERP_C001_CodeRepository(dbfactory);
		}

        public JobReportModel GetByJobNoList(string jobNo, List<string> lotList)
        {
            if(string.IsNullOrWhiteSpace(jobNo))
                throw new AppException("请先输入工单号");
            var q = this.vw_JobReportRepository.GetMany(i => i.JobNo == jobNo);
            if (lotList!=null)
                q = q.Where(i => lotList.Contains(i.LotNo));
            var HeaderList = q.OrderBy(i=>i.LotNo).ToList();
            var q2 = this.jobLotProcessRepository.GetMany(i => true);
            var DetailList = (from i in q2
                              join k in q on i.JobNo equals k.JobNo
                              where i.LotNo == k.LotNo
                              select i).OrderBy(i => i.SeqNo).ToList();
            foreach (var process in DetailList)
            {
                process.ProcessName = codeRepository.GetMany(c => c.CodeID == "PRC" && c.Code == process.ProcessCode).FirstOrDefault().Description;
            }

            return new JobReportModel() { JobReportHeaderList = HeaderList, JobReportDetailList = DetailList };
        }
    }
}