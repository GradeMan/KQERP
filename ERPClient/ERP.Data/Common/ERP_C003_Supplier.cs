using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C003_SupplierRepository : IRepository<ERP_C003_Supplier>
	{
	}
	public class ERP_C003_SupplierRepository : AnyRepositoryBase<ERP_C003_Supplier>, IERP_C003_SupplierRepository
	{
		public ERP_C003_SupplierRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C003_Supplier, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}