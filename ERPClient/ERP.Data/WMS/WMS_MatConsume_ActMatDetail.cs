using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_MatConsume_ActMatDetailRepository : IRepository<WMS_MatConsume_ActMatDetail>
	{
	}
	public class WMS_MatConsume_ActMatDetailRepository : AnyRepositoryBase<WMS_MatConsume_ActMatDetail>, IWMS_MatConsume_ActMatDetailRepository
	{
		public WMS_MatConsume_ActMatDetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}