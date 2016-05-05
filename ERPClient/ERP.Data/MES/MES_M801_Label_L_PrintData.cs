using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IMES_M801_Label_L_PrintDataRepository : IRepository<MES_M801_Label_L_PrintData>
	{
	}
	public class MES_M801_Label_L_PrintDataRepository : AnyRepositoryBase<MES_M801_Label_L_PrintData>, IMES_M801_Label_L_PrintDataRepository
	{
		public MES_M801_Label_L_PrintDataRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}