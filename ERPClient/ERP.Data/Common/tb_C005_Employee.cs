using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
    public interface Itb_C005_EmployeeRepository : IRepository<ERP_C005_Employee>
	{
	}
    public class tb_C005_EmployeeRepository : AnyRepositoryBase<ERP_C005_Employee>, Itb_C005_EmployeeRepository
	{
		public tb_C005_EmployeeRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}

        protected override System.Linq.Expressions.Expression<Func<ERP_C005_Employee, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            var compCode = appCacheService.GetItem("Company") as string;
            return (i => i.CompCode == compCode);
        }
	}
}