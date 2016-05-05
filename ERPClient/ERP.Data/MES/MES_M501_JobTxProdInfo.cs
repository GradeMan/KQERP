using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IMES_M501_JobTxProdInfoRepository : IRepository<MES_M501_JobTxProdInfo>
	{
	}
	public class MES_M501_JobTxProdInfoRepository : AnyRepositoryBase<MES_M501_JobTxProdInfo>, IMES_M501_JobTxProdInfoRepository
	{
		public MES_M501_JobTxProdInfoRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}