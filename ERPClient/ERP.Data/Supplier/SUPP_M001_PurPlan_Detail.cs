using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface ISUPP_M001_PurPlan_DetailRepository : IRepository<SUPP_M001_PurPlan_Detail>
	{
	}
	public class SUPP_M001_PurPlan_DetailRepository : AnyRepositoryBase<SUPP_M001_PurPlan_Detail>, ISUPP_M001_PurPlan_DetailRepository
	{
		public SUPP_M001_PurPlan_DetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<SUPP_M001_PurPlan_Detail, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            var compCode = appCacheService.GetItem("Company") as string;
            return (i => i.CompCode == compCode);
        }
	}
}