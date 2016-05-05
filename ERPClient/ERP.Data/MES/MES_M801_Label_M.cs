using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M801_Label_MRepository : IRepository<MES_M801_Label_M>
	{
	}
	public class MES_M801_Label_MRepository : AnyRepositoryBase<MES_M801_Label_M>, IMES_M801_Label_MRepository
	{
		public MES_M801_Label_MRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M801_Label_M, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}