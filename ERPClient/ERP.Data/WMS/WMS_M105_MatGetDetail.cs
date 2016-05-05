using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M105_MatGetDetailRepository : IRepository<WMS_M105_MatGetDetail>
	{
	}
	public class WMS_M105_MatGetDetailRepository : AnyRepositoryBase<WMS_M105_MatGetDetail>, IWMS_M105_MatGetDetailRepository
	{
		public WMS_M105_MatGetDetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}