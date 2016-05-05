using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
    public interface IERP_C005_EmployeeRepository : IRepository<ERP_C005_Employee>
	{
	}
    public class ERP_C005_EmployeeRepository : AnyRepositoryBase<ERP_C005_Employee>, IERP_C005_EmployeeRepository
	{
        public ERP_C005_EmployeeRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}

        protected override System.Linq.Expressions.Expression<Func<ERP_C005_Employee, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}