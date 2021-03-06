﻿using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M002_MaterialRepository : IRepository<ERP_M002_Material>
	{
	}
	public class ERP_M002_MaterialRepository : AnyRepositoryBase<ERP_M002_Material>, IERP_M002_MaterialRepository
	{
		public ERP_M002_MaterialRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M002_Material, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}