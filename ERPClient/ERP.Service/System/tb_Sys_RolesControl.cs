﻿using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface Itb_Sys_RolesControlService
	{
		tb_Sys_RolesControl GetById(Guid Id);
        List<tb_Sys_RolesControl> GetList();
		List<tb_Sys_RolesControl> GetList(PagingModel pagingModel);
        void Create(tb_Sys_RolesControl tb_Sys_RolesControl);
        void Update(tb_Sys_RolesControl tb_Sys_RolesControl);
        void Delete(Guid Id);
        tb_Sys_RolesControl GetByRolesIdAndControlId(Guid rolesId, Guid controlId);
	} 
	public class tb_Sys_RolesControlService :Itb_Sys_RolesControlService
	{
		private Itb_Sys_RolesControlRepository tb_Sys_RolesControlRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public tb_Sys_RolesControlService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.tb_Sys_RolesControlRepository = new tb_Sys_RolesControlRepository(dbfactory);
		}

		public List<tb_Sys_RolesControl> GetList()
        {
            var q = this.tb_Sys_RolesControlRepository.GetMany(i => true);
            return q.ToList();
        }

        public tb_Sys_RolesControl GetById(Guid Id)
        {
            return this.tb_Sys_RolesControlRepository.GetByID(Id);
        }

        public void Create(tb_Sys_RolesControl tb_Sys_RolesControl)
        {
        	tb_Sys_RolesControl.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_RolesControl.CreateUser = tempUser.UserName;
            tb_Sys_RolesControl.Validate();
			this.tb_Sys_RolesControlRepository.Add(tb_Sys_RolesControl);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.tb_Sys_RolesControlRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(tb_Sys_RolesControl tb_Sys_RolesControl)
        {
        	tb_Sys_RolesControl.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_RolesControl.ModifyUser = tempUser.UserName;
            tb_Sys_RolesControl.Validate();
            var existstb_Sys_Menu = this.GetById(tb_Sys_RolesControl.Id);
            this.tb_Sys_RolesControlRepository.SetValues(tb_Sys_RolesControl, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_RolesControl> GetList(PagingModel pagingModel)
        {
            var q = this.tb_Sys_RolesControlRepository.GetMany(i => true);
            q = q.OrderByDescending(i => i.CreateDt);
            q = q.Paging(pagingModel);
            return q.ToList();
        }


        public tb_Sys_RolesControl GetByRolesIdAndControlId(Guid rolesId, Guid controlId)
        {
            var q = this.tb_Sys_RolesControlRepository.GetMany(i => i.Roles_Id == rolesId && i.ControlId == controlId).FirstOrDefault();
            return q;
        }
    }
}