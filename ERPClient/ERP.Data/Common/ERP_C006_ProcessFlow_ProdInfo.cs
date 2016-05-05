using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C006_ProcessFlow_ProdInfoRepository : IRepository<ERP_C006_ProcessFlow_ProdInfo>
	{
	}
	public class ERP_C006_ProcessFlow_ProdInfoRepository : AnyRepositoryBase<ERP_C006_ProcessFlow_ProdInfo>, IERP_C006_ProcessFlow_ProdInfoRepository
	{
		public ERP_C006_ProcessFlow_ProdInfoRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C006_ProcessFlow_ProdInfo, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}