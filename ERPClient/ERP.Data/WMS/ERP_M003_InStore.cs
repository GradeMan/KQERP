using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IERP_M003_InStoreRepository : IRepository<ERP_M003_InStore>
	{
	}
	public class ERP_M003_InStoreRepository : AnyRepositoryBase<ERP_M003_InStore>, IERP_M003_InStoreRepository
	{
		public ERP_M003_InStoreRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}