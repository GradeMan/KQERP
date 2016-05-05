using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_C102_InStoreDetailRepository : IRepository<WMS_C102_InStoreDetail>
	{
	}
	public class WMS_C102_InStoreDetailRepository : AnyRepositoryBase<WMS_C102_InStoreDetail>, IWMS_C102_InStoreDetailRepository
	{
		public WMS_C102_InStoreDetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}