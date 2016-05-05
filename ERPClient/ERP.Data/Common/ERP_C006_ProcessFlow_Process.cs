using System;
using ERP.Domain;
using COM.Service;
using System.Collections.Generic;
using System.Linq;
namespace ERP.Data
{
	public interface IERP_C006_ProcessFlow_ProcessRepository : IRepository<ERP_C006_ProcessFlow_Process>
	{
	}
	public class ERP_C006_ProcessFlow_ProcessRepository : AnyRepositoryBase<ERP_C006_ProcessFlow_Process>, IERP_C006_ProcessFlow_ProcessRepository
	{
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C006_ProcessFlow_ProcessRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
            
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C006_ProcessFlow_Process, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
        //protected override System.Linq.Expressions.Expression<Func<ERP_C006_ProcessFlow_Process, bool>> ReadExpression()
        //{
        //    tb_Sys_Roles temprole = appCacheService.GetItem("roles") as tb_Sys_Roles;
        //    var rolesEntityValueList = rolesEntityRepositoy.GetMany(i => i.Roles_Id == temprole.Id && i.EntityName == EntityNameEnum.ERP_C006_ProcessFlow_Process.ToString() && i.IsState == true).Select(i=>i.EntityValue).ToList();
        //    if (rolesEntityValueList.Count > 0)
        //        return (i => rolesEntityValueList.Contains(i.Process));
        //    else
        //        return base.ReadExpression();
        //}
	}
}