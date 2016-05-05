using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M202_TaskRepository : IRepository<MES_M202_Task>
	{
	}
	public class MES_M202_TaskRepository : AnyRepositoryBase<MES_M202_Task>, IMES_M202_TaskRepository
	{
		public MES_M202_TaskRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M202_Task, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}