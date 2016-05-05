using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M501_JobTxRepository : IRepository<MES_M501_JobTx>
	{
	}
	public class MES_M501_JobTxRepository : AnyRepositoryBase<MES_M501_JobTx>, IMES_M501_JobTxRepository
	{
		public MES_M501_JobTxRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M501_JobTx, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}