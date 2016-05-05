using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C004_SupplierRepository : IRepository<ERP_C004_Supplier>
	{
	}
	public class ERP_C004_SupplierRepository : AnyRepositoryBase<ERP_C004_Supplier>, IERP_C004_SupplierRepository
	{
		public ERP_C004_SupplierRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C004_Supplier, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}