using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_Material_SuppRepository : IRepository<ERP_M001_Material_Supp>
	{
	}
	public class ERP_M001_Material_SuppRepository : AnyRepositoryBase<ERP_M001_Material_Supp>, IERP_M001_Material_SuppRepository
	{
		public ERP_M001_Material_SuppRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Material_Supp, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}