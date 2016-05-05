using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M105_MatReturnDetailRepository : IRepository<WMS_M105_MatReturnDetail>
	{
	}
	public class WMS_M105_MatReturnDetailRepository : AnyRepositoryBase<WMS_M105_MatReturnDetail>, IWMS_M105_MatReturnDetailRepository
	{
		public WMS_M105_MatReturnDetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}