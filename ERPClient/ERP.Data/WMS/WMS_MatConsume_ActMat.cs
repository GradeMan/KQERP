using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_MatConsume_ActMatRepository : IRepository<WMS_MatConsume_ActMat>
	{
	}
	public class WMS_MatConsume_ActMatRepository : AnyRepositoryBase<WMS_MatConsume_ActMat>, IWMS_MatConsume_ActMatRepository
	{
		public WMS_MatConsume_ActMatRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}