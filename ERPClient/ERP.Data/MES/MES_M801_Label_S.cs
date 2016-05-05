using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M801_Label_SRepository : IRepository<MES_M801_Label_S>
	{
	}
	public class MES_M801_Label_SRepository : AnyRepositoryBase<MES_M801_Label_S>, IMES_M801_Label_SRepository
	{
		public MES_M801_Label_SRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M801_Label_S, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}