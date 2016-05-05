using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M501_JobTx_NGRepository : IRepository<MES_M501_JobTx_NG>
	{
	}
	public class MES_M501_JobTx_NGRepository : AnyRepositoryBase<MES_M501_JobTx_NG>, IMES_M501_JobTx_NGRepository
	{
		public MES_M501_JobTx_NGRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M501_JobTx_NG, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}