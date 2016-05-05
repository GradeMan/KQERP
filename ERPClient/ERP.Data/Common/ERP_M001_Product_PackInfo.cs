using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_Product_PackInfoRepository : IRepository<ERP_M001_Product_PackInfo>
	{
	}
	public class ERP_M001_Product_PackInfoRepository : AnyRepositoryBase<ERP_M001_Product_PackInfo>, IERP_M001_Product_PackInfoRepository
	{
		public ERP_M001_Product_PackInfoRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Product_PackInfo, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}