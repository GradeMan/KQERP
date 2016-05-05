using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C006_ProcessProdInfoRepository : IRepository<ERP_C006_ProcessProdInfo>
	{
	}
	public class ERP_C006_ProcessProdInfoRepository : AnyRepositoryBase<ERP_C006_ProcessProdInfo>, IERP_C006_ProcessProdInfoRepository
	{
		public ERP_C006_ProcessProdInfoRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C006_ProcessProdInfo, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}