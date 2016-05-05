using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M501_JobTxDetailRepository : IRepository<MES_M501_JobTxDetail>
	{
	}
	public class MES_M501_JobTxDetailRepository : AnyRepositoryBase<MES_M501_JobTxDetail>, IMES_M501_JobTxDetailRepository
	{
		public MES_M501_JobTxDetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M501_JobTxDetail, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}