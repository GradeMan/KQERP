using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_C101_WareHouseRepository : IRepository<WMS_C101_WareHouse>
	{
	}
	public class WMS_C101_WareHouseRepository : AnyRepositoryBase<WMS_C101_WareHouse>, IWMS_C101_WareHouseRepository
	{
		public WMS_C101_WareHouseRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}