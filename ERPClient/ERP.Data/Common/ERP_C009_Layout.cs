using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C009_LayoutRepository : IRepository<ERP_C009_Layout>
	{
	}
	public class ERP_C009_LayoutRepository : AnyRepositoryBase<ERP_C009_Layout>, IERP_C009_LayoutRepository
	{
		public ERP_C009_LayoutRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        
	}
}