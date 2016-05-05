using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_MaterialRepository : IRepository<ERP_M001_Material>
	{
	}
	public class ERP_M001_MaterialRepository : AnyRepositoryBase<ERP_M001_Material>, IERP_M001_MaterialRepository
	{
		public ERP_M001_MaterialRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Material, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}