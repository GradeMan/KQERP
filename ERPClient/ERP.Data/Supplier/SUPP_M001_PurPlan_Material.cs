using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface ISUPP_M001_PurPlan_MaterialRepository : IRepository<SUPP_M001_PurPlan_Material>
	{
	}
	public class SUPP_M001_PurPlan_MaterialRepository : AnyRepositoryBase<SUPP_M001_PurPlan_Material>, ISUPP_M001_PurPlan_MaterialRepository
	{
		public SUPP_M001_PurPlan_MaterialRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<SUPP_M001_PurPlan_Material, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            var compCode = appCacheService.GetItem("Company") as string;
            return (i => i.CompCode == compCode);
        }
	}
}