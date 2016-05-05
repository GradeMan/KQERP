using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M105_MatReturnRepository : IRepository<WMS_M105_MatReturn>
	{
	}
	public class WMS_M105_MatReturnRepository : AnyRepositoryBase<WMS_M105_MatReturn>, IWMS_M105_MatReturnRepository
	{
		public WMS_M105_MatReturnRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}