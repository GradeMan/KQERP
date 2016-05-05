using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IMES_M801_Label_S_PrintDataRepository : IRepository<MES_M801_Label_S_PrintData>
	{
	}
	public class MES_M801_Label_S_PrintDataRepository : AnyRepositoryBase<MES_M801_Label_S_PrintData>, IMES_M801_Label_S_PrintDataRepository
	{
		public MES_M801_Label_S_PrintDataRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}