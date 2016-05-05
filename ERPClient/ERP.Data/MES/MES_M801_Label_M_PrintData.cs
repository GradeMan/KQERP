using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IMES_M801_Label_M_PrintDataRepository : IRepository<MES_M801_Label_M_PrintData>
	{
	}
	public class MES_M801_Label_M_PrintDataRepository : AnyRepositoryBase<MES_M801_Label_M_PrintData>, IMES_M801_Label_M_PrintDataRepository
	{
		public MES_M801_Label_M_PrintDataRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}