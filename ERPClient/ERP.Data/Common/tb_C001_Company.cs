using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
    public interface Itb_C001_CompanyRepository : IRepository<ERP_C002_Company>
	{
	}
    public class tb_C001_CompanyRepository : AnyRepositoryBase<ERP_C002_Company>, Itb_C001_CompanyRepository
	{
		public tb_C001_CompanyRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        //protected override System.Linq.Expressions.Expression<Func<ERP_C002_Company, bool>> ReadExpression()
        //{
        //    ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        //    var compCode = appCacheService.GetItem("Company") as string;
        //    return (i => i.CompCode == compCode);
        //}
	}
}