using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
namespace ERP.Service
{
	public interface Itb_Sys_UserRoleService
	{
		tb_Sys_UserRole Gettb_Sys_UserRoleById(Guid Id);
        List<tb_Sys_UserRole> Gettb_Sys_UserRoleList();
		List<tb_Sys_UserRole> Gettb_Sys_UserRoleList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Createtb_Sys_UserRole(tb_Sys_UserRole tb_Sys_UserRole);
        void Updatetb_Sys_UserRole(tb_Sys_UserRole tb_Sys_UserRole);
        void Deletetb_Sys_UserRole(Guid Id);
        List<tb_Sys_UserRole> GetByRoleId(Guid roleId);
	}
	public class tb_Sys_UserRoleService :Itb_Sys_UserRoleService
	{
        private IDatabaseFactory dbfactory;
		private Itb_Sys_UserRoleRepository tb_Sys_UserRoleRepository;
		private IUnitOfWork runtimeService;
        public tb_Sys_UserRoleService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
			this.runtimeService = new UnitOfWork(this.dbfactory);
			this.tb_Sys_UserRoleRepository = new tb_Sys_UserRoleRepository(this.dbfactory);
		}

		public List<tb_Sys_UserRole> Gettb_Sys_UserRoleList()
        {
            var q = this.tb_Sys_UserRoleRepository.GetMany(i => true);
            return q.ToList();
        }

        public tb_Sys_UserRole Gettb_Sys_UserRoleById(Guid Id)
        {
            return this.tb_Sys_UserRoleRepository.GetByID(Id);
        }

        public void Createtb_Sys_UserRole(tb_Sys_UserRole tb_Sys_UserRole)
        {
			this.tb_Sys_UserRoleRepository.Add(tb_Sys_UserRole);
            this.runtimeService.Commit();
        }

        public void Deletetb_Sys_UserRole(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_UserRoleById(Id);
            this.tb_Sys_UserRoleRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Updatetb_Sys_UserRole(tb_Sys_UserRole tb_Sys_UserRole)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_UserRoleById(tb_Sys_UserRole.Id);
            this.tb_Sys_UserRoleRepository.SetValues(tb_Sys_UserRole, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_UserRole> Gettb_Sys_UserRoleList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_Sys_UserRoleRepository.GetMany(i => true);
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


        public List<tb_Sys_UserRole> GetByRoleId(Guid roleId)
        {
            var q = this.tb_Sys_UserRoleRepository.GetMany(i => i.RoleId == roleId);
            return q.ToList();
        }
    }
}