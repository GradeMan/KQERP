﻿using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_M001_Product_ProdInfoRepository : IRepository<ERP_M001_Product_ProdInfo>
	{
	}
	public class ERP_M001_Product_ProdInfoRepository : AnyRepositoryBase<ERP_M001_Product_ProdInfo>, IERP_M001_Product_ProdInfoRepository
	{
		public ERP_M001_Product_ProdInfoRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_M001_Product_ProdInfo, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}