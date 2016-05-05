using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C003_CustomerRepository : IRepository<ERP_C003_Customer>
	{
	}
	public class ERP_C003_CustomerRepository : AnyRepositoryBase<ERP_C003_Customer>, IERP_C003_CustomerRepository
	{
		public ERP_C003_CustomerRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{

		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C003_Customer, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}