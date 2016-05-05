using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C001_CodeRepository : IRepository<ERP_C001_Code>
	{
	}
	public class ERP_C001_CodeRepository : AnyRepositoryBase<ERP_C001_Code>, IERP_C001_CodeRepository
	{
		public ERP_C001_CodeRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C001_Code, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}