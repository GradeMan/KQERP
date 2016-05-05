using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface ISUPP_M001_PurPlanRepository : IRepository<SUPP_M001_PurPlan>
	{
	}
	public class SUPP_M001_PurPlanRepository : AnyRepositoryBase<SUPP_M001_PurPlan>, ISUPP_M001_PurPlanRepository
	{
		public SUPP_M001_PurPlanRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<SUPP_M001_PurPlan, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            var compCode = appCacheService.GetItem("Company") as string;
            return (i => i.CompCode == compCode);
        }
	}
}