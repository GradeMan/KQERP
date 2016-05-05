using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M802_Packing_DtlRepository : IRepository<MES_M802_Packing_Dtl>
	{
	}
	public class MES_M802_Packing_DtlRepository : AnyRepositoryBase<MES_M802_Packing_Dtl>, IMES_M802_Packing_DtlRepository
	{
		public MES_M802_Packing_DtlRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M802_Packing_Dtl, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}