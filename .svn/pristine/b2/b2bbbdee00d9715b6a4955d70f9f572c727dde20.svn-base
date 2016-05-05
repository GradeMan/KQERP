using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IOrderDetailRepository : IRepository<MES_M001_Order_Detail>
	{
	}
    public class OrderDetailRepository : AnyRepositoryBase<MES_M001_Order_Detail>, IOrderDetailRepository
	{
        public OrderDetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}