using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M801_Label_LRepository : IRepository<MES_M801_Label_L>
	{
	}
	public class MES_M801_Label_LRepository : AnyRepositoryBase<MES_M801_Label_L>, IMES_M801_Label_LRepository
	{
		public MES_M801_Label_LRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M801_Label_L, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}