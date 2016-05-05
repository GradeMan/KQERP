using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IESOP_DocIndex_SecRepository : IRepository<ESOP_DocIndex_Sec>
	{
	}
	public class ESOP_DocIndex_SecRepository : AnyRepositoryBase<ESOP_DocIndex_Sec>, IESOP_DocIndex_SecRepository
	{
		public ESOP_DocIndex_SecRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}