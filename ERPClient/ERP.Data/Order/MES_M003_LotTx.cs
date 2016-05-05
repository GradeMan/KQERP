using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface ILotTxRepository : IRepository<MES_M003_LotTx>
	{
	}
    public class LotTxRepository : AnyRepositoryBase<MES_M003_LotTx>, ILotTxRepository
	{
        public LotTxRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}