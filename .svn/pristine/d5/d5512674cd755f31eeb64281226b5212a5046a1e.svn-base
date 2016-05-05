using System;
using ERP.Domain;
namespace ERP.Data
{
    public interface IOrderRepository : IRepository<MES_M001_Order>
	{
	}
    public class OrderRepository : AnyRepositoryBase<MES_M001_Order>, IOrderRepository
	{
		public OrderRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}