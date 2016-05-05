using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M201_Plan_MaterialRepository : IRepository<MES_M201_Plan_Material>
	{
	}
	public class MES_M201_Plan_MaterialRepository : AnyRepositoryBase<MES_M201_Plan_Material>, IMES_M201_Plan_MaterialRepository
	{
		public MES_M201_Plan_MaterialRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M201_Plan_Material, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}