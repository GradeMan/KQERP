using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_Product_CustPackRepository : IRepository<ERP_M001_Product_CustPack>
	{
	}
	public class ERP_M001_Product_CustPackRepository : AnyRepositoryBase<ERP_M001_Product_CustPack>, IERP_M001_Product_CustPackRepository
	{
		public ERP_M001_Product_CustPackRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Product_CustPack, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}