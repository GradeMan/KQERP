using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface Ivw_JobReportRepository : IRepository<vw_JobReport>
	{
	}
	public class vw_JobReportRepository : AnyRepositoryBase<vw_JobReport>, Ivw_JobReportRepository
	{
		public vw_JobReportRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}