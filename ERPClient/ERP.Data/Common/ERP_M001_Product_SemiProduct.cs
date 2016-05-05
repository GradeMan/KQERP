using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_Product_SemiProductRepository : IRepository<ERP_M001_Product_SemiProduct>
	{
	}
	public class ERP_M001_Product_SemiProductRepository : AnyRepositoryBase<ERP_M001_Product_SemiProduct>, IERP_M001_Product_SemiProductRepository
	{
		public ERP_M001_Product_SemiProductRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Product_SemiProduct, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}