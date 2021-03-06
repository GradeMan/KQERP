﻿using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IMES_M201_Plan_DetailRepository : IRepository<MES_M201_Plan_Detail>
	{
	}
	public class MES_M201_Plan_DetailRepository : AnyRepositoryBase<MES_M201_Plan_Detail>, IMES_M201_Plan_DetailRepository
	{
		public MES_M201_Plan_DetailRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<MES_M201_Plan_Detail, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}