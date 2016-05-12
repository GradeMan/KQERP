using System;
using COM.Service;
using ERP.Domain;
namespace ERP.Data
{
	public interface IMES_M201_Plan_DailyRepository : IRepository<MES_M201_Plan_Daily>
	{
	}
	public class MES_M201_Plan_DailyRepository : AnyRepositoryBase<MES_M201_Plan_Daily>, IMES_M201_Plan_DailyRepository
	{
		public MES_M201_Plan_DailyRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
            
        }
        protected override System.Linq.Expressions.Expression<Func<MES_M201_Plan_Daily, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
    }
}