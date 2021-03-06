﻿using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
namespace ERP.Service
{
	public interface Itb_Sys_RolesRightService
	{
		tb_Sys_RolesRight Gettb_Sys_RolesRightById(Guid Id);
        List<tb_Sys_RolesRight> Gettb_Sys_RolesRightList();
		List<tb_Sys_RolesRight> Gettb_Sys_RolesRightList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Createtb_Sys_RolesRight(tb_Sys_RolesRight tb_Sys_RolesRight);
        void Updatetb_Sys_RolesRight(tb_Sys_RolesRight tb_Sys_RolesRight);
        void Deletetb_Sys_RolesRight(Guid Id);
        void DeleteByMenuIdAndRolesId(Guid menuId,Guid roleId);
        void DeleteRolesId(Guid roleId);
        tb_Sys_RolesRight GetByMenuIdAndRolesId(Guid rolesId,Guid menuId);
	}
	public class tb_Sys_RolesRightService :Itb_Sys_RolesRightService
	{
        private IDatabaseFactory dbfactory;
		private Itb_Sys_RolesRightRepository tb_Sys_RolesRightRepository;
		private IUnitOfWork runtimeService;
		public tb_Sys_RolesRightService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
			this.runtimeService = new UnitOfWork(dbfactory);
            this.tb_Sys_RolesRightRepository = new tb_Sys_RolesRightRepository(dbfactory);
		}
        public void DeleteRolesId(Guid roleId)
        {
            string sql = string.Format("Delete tb_Sys_RolesRight where Roles_Id = '{0}'", roleId);
            tb_Sys_RolesRightRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
        }
		public List<tb_Sys_RolesRight> Gettb_Sys_RolesRightList()
        {
            var q = this.tb_Sys_RolesRightRepository.GetMany(i => true);
            return q.ToList();
        }

        public tb_Sys_RolesRight Gettb_Sys_RolesRightById(Guid Id)
        {
            return this.tb_Sys_RolesRightRepository.GetByID(Id);
        }

        public void Createtb_Sys_RolesRight(tb_Sys_RolesRight tb_Sys_RolesRight)
        {
			this.tb_Sys_RolesRightRepository.Add(tb_Sys_RolesRight);
            this.runtimeService.Commit();
        }

        public void Deletetb_Sys_RolesRight(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_RolesRightById(Id);
            this.tb_Sys_RolesRightRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Updatetb_Sys_RolesRight(tb_Sys_RolesRight tb_Sys_RolesRight)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_RolesRightById(tb_Sys_RolesRight.Id);
            this.tb_Sys_RolesRightRepository.SetValues(tb_Sys_RolesRight, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_RolesRight> Gettb_Sys_RolesRightList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_Sys_RolesRightRepository.GetMany(i => true);
			if (beginDate.HasValue)
            {
                beginDate = beginDate.Value.Date;
           	    q = q.Where(p => p.CreateTime >= beginDate);
            }
            if (endDate.HasValue)
            {
                endDate = endDate.Value.Date.AddDays(1);
                q = q.Where(p => p.CreateTime < endDate);
            }
            
            q = q.OrderByDescending(i => i.CreateTime);
            q = q.Paging(pagingModel);
            return q.ToList();
        }


        public List<tb_Sys_RolesRight> GetRoleRightByMenuId(Guid id)
        {
            var q = this.tb_Sys_RolesRightRepository.GetMany(i => i.Menu_Id == id);
            return q.ToList();
        }


        public void DeleteByMenuIdAndRolesId(Guid menuId, Guid roleId)
        {
            throw new NotImplementedException();
        }

        public tb_Sys_RolesRight GetByMenuIdAndRolesId(Guid rolesId, Guid menuId)
        {
            var q = this.tb_Sys_RolesRightRepository.GetMany(i => i.Roles_Id == rolesId && i.Menu_Id == menuId).FirstOrDefault();
            return q;
        }
    }
}