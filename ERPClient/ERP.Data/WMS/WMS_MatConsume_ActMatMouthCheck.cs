using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_MatConsume_ActMatMouthCheckRepository : IRepository<WMS_MatConsume_ActMatMouthCheck>
	{
	}
	public class WMS_MatConsume_ActMatMouthCheckRepository : AnyRepositoryBase<WMS_MatConsume_ActMatMouthCheck>, IWMS_MatConsume_ActMatMouthCheckRepository
	{
		public WMS_MatConsume_ActMatMouthCheckRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}