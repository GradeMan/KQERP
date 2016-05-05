using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M105_MatSotreRepository : IRepository<WMS_M105_MatSotre>
	{
	}
	public class WMS_M105_MatSotreRepository : AnyRepositoryBase<WMS_M105_MatSotre>, IWMS_M105_MatSotreRepository
	{
		public WMS_M105_MatSotreRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}