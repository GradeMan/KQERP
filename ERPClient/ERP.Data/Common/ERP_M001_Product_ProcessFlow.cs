using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_Product_ProcessFlowRepository : IRepository<ERP_M001_Product_ProcessFlow>
	{
	}
	public class ERP_M001_Product_ProcessFlowRepository : AnyRepositoryBase<ERP_M001_Product_ProcessFlow>, IERP_M001_Product_ProcessFlowRepository
	{
		public ERP_M001_Product_ProcessFlowRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Product_ProcessFlow, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}