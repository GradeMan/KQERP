using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_C103_ShelfRepository : IRepository<WMS_C103_Shelf>
	{
	}
	public class WMS_C103_ShelfRepository : AnyRepositoryBase<WMS_C103_Shelf>, IWMS_C103_ShelfRepository
	{
		public WMS_C103_ShelfRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}