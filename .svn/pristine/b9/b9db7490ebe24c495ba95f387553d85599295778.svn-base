using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IJobLotRepository : IRepository<MES_M002_Job_Lot>
	{
	}
    public class JobLotRepository : AnyRepositoryBase<MES_M002_Job_Lot>, IJobLotRepository
	{
        public JobLotRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}