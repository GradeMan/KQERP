using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IERP_M003_InStoreDetailRepository : IRepository<ERP_M003_InStoreDetail>
	{
	}
	public class ERP_M003_InStoreDetailRepository : AnyRepositoryBase<ERP_M003_InStoreDetail>, IERP_M003_InStoreDetailRepository
	{
		public ERP_M003_InStoreDetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}