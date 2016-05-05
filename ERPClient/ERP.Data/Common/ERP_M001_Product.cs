using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_ProductRepository : IRepository<ERP_M001_Product>
	{
	}
	public class ERP_M001_ProductRepository : AnyRepositoryBase<ERP_M001_Product>, IERP_M001_ProductRepository
	{
		public ERP_M001_ProductRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{

		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Product, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}