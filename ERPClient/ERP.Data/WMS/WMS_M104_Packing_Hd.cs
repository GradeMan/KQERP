using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M104_Packing_HdRepository : IRepository<WMS_M104_Packing_Hd>
	{
	}
	public class WMS_M104_Packing_HdRepository : AnyRepositoryBase<WMS_M104_Packing_Hd>, IWMS_M104_Packing_HdRepository
	{
		public WMS_M104_Packing_HdRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}