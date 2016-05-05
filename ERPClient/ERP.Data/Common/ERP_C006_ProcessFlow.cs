using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C006_ProcessFlowRepository : IRepository<ERP_C006_ProcessFlow>
	{
	}
	public class ERP_C006_ProcessFlowRepository : AnyRepositoryBase<ERP_C006_ProcessFlow>, IERP_C006_ProcessFlowRepository
	{
		public ERP_C006_ProcessFlowRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C006_ProcessFlow, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}