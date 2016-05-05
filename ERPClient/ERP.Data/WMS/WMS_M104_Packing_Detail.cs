using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IWMS_M104_Packing_DetailRepository : IRepository<WMS_M104_Packing_Detail>
	{
	}
	public class WMS_M104_Packing_DetailRepository : AnyRepositoryBase<WMS_M104_Packing_Detail>, IWMS_M104_Packing_DetailRepository
	{
		public WMS_M104_Packing_DetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}