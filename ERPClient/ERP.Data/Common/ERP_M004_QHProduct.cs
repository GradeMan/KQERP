using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M004_QHProductRepository : IRepository<ERP_M004_QHProduct>
	{
	}
	public class ERP_M004_QHProductRepository : AnyRepositoryBase<ERP_M004_QHProduct>, IERP_M004_QHProductRepository
	{
		public ERP_M004_QHProductRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M004_QHProduct, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}