using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C003_Supplier_FileRepository : IRepository<ERP_C003_Supplier_File>
	{
	}
	public class ERP_C003_Supplier_FileRepository : AnyRepositoryBase<ERP_C003_Supplier_File>, IERP_C003_Supplier_FileRepository
	{
		public ERP_C003_Supplier_FileRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C003_Supplier_File, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}