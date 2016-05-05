using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M202_Task_JobLotRepository : IRepository<MES_M202_Task_JobLot>
	{
	}
	public class MES_M202_Task_JobLotRepository : AnyRepositoryBase<MES_M202_Task_JobLot>, IMES_M202_Task_JobLotRepository
	{
		public MES_M202_Task_JobLotRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
            
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M202_Task_JobLot, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}