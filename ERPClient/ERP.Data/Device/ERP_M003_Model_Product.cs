using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M003_Model_ProductRepository : IRepository<ERP_M003_Model_Product>
	{
	}
	public class ERP_M003_Model_ProductRepository : AnyRepositoryBase<ERP_M003_Model_Product>, IERP_M003_Model_ProductRepository
	{
		public ERP_M003_Model_ProductRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M003_Model_Product, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            var compCode = appCacheService.GetItem("Company") as string;
            return (i => i.CompCode == compCode);
        }
	}
}