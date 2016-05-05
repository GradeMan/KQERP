using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M202_Task_DetailRepository : IRepository<MES_M202_Task_Detail>
	{
	}
	public class MES_M202_Task_DetailRepository : AnyRepositoryBase<MES_M202_Task_Detail>, IMES_M202_Task_DetailRepository
	{
		public MES_M202_Task_DetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M202_Task_Detail, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}