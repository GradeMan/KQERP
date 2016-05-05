using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M105_MatGetRepository : IRepository<WMS_M105_MatGet>
	{
	}
	public class WMS_M105_MatGetRepository : AnyRepositoryBase<WMS_M105_MatGet>, IWMS_M105_MatGetRepository
	{
		public WMS_M105_MatGetRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}