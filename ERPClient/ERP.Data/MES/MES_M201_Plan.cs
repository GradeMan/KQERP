using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M201_PlanRepository : IRepository<MES_M201_Plan>
	{
	}
	public class MES_M201_PlanRepository : AnyRepositoryBase<MES_M201_Plan>, IMES_M201_PlanRepository
	{
		public MES_M201_PlanRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M201_Plan, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}