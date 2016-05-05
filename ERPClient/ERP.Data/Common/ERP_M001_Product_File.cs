using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_Product_FileRepository : IRepository<ERP_M001_Product_File>
	{
	}
	public class ERP_M001_Product_FileRepository : AnyRepositoryBase<ERP_M001_Product_File>, IERP_M001_Product_FileRepository
	{
		public ERP_M001_Product_FileRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Product_File, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}