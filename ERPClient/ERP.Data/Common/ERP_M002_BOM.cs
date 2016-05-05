using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M002_BOMRepository : IRepository<ERP_M002_BOM>
	{
	}
	public class ERP_M002_BOMRepository : AnyRepositoryBase<ERP_M002_BOM>, IERP_M002_BOMRepository
	{
		public ERP_M002_BOMRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M002_BOM, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}