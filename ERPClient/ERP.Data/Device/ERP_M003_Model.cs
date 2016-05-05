using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M003_ModelRepository : IRepository<ERP_M003_Model>
	{
	}
	public class ERP_M003_ModelRepository : AnyRepositoryBase<ERP_M003_Model>, IERP_M003_ModelRepository
	{
		public ERP_M003_ModelRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M003_Model, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            var compCode = appCacheService.GetItem("Company") as string;
            return (i => i.CompCode == compCode);
        }
	}
}