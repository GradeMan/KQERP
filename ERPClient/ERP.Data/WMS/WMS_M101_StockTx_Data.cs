using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M101_StockTx_DataRepository : IRepository<WMS_M101_StockTx_Data>
	{
	}
	public class WMS_M101_StockTx_DataRepository : AnyRepositoryBase<WMS_M101_StockTx_Data>, IWMS_M101_StockTx_DataRepository
	{
		public WMS_M101_StockTx_DataRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}