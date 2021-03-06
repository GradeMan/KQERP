﻿using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_M001_Product_MaterialService
	{
		ERP_M001_Product_Material GetById(Guid Id);
        List<ERP_M001_Product_Material> GetList();
		List<ERP_M001_Product_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Product_Material ERP_M001_Product_Material);
        void Update(ERP_M001_Product_Material ERP_M001_Product_Material);
        void Delete(Guid Id);
	}
	public class ERP_M001_Product_MaterialService :IERP_M001_Product_MaterialService
	{
		private IERP_M001_Product_MaterialRepository ERP_M001_Product_MaterialRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M001_Product_MaterialService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Product_MaterialRepository = new ERP_M001_Product_MaterialRepository(dbfactory);
		}

		public List<ERP_M001_Product_Material> GetList()
        {
            var q = this.ERP_M001_Product_MaterialRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product_Material GetById(Guid Id)
        {
            return this.ERP_M001_Product_MaterialRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Product_Material ERP_M001_Product_Material)
        {
        	ERP_M001_Product_Material.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_Material.CreateUser = tempUser.UserName;
            ERP_M001_Product_Material.Validate();
			this.ERP_M001_Product_MaterialRepository.Add(ERP_M001_Product_Material);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Product_MaterialRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Product_Material ERP_M001_Product_Material)
        {
        	ERP_M001_Product_Material.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_Material.ModifyUser = tempUser.UserName;
            ERP_M001_Product_Material.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product_Material.Id);
            this.ERP_M001_Product_MaterialRepository.SetValues(ERP_M001_Product_Material, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Product_MaterialRepository.GetMany(i => true);
			if (beginDate.HasValue)
            {
                beginDate = beginDate.Value.Date;
           	    q = q.Where(p => p.CreateDt >= beginDate);
            }
            if (endDate.HasValue)
            {
                endDate = endDate.Value.Date.AddDays(1);
                q = q.Where(p => p.CreateDt < endDate);
            }
            
            q = q.OrderByDescending(i => i.CreateDt);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}