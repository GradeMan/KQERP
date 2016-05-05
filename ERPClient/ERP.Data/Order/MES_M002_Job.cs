using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IJobRepository : IRepository<MES_M002_Job>
	{
	}
    public class JobRepository : AnyRepositoryBase<MES_M002_Job>, IJobRepository
	{
        public JobRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}