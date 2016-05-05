using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M802_Packing_HdRepository : IRepository<MES_M802_Packing_Hd>
	{
	}
	public class MES_M802_Packing_HdRepository : AnyRepositoryBase<MES_M802_Packing_Hd>, IMES_M802_Packing_HdRepository
	{
		public MES_M802_Packing_HdRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M802_Packing_Hd, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}