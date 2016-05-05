using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface Itb_Sys_RolesService
	{
		tb_Sys_Roles Gettb_Sys_RolesById(Guid Id);
        List<tb_Sys_Roles> Gettb_Sys_RolesList();
		List<tb_Sys_Roles> Gettb_Sys_RolesList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Createtb_Sys_Roles(tb_Sys_Roles tb_Sys_Roles);
        void Updatetb_Sys_Roles(tb_Sys_Roles tb_Sys_Roles);
        void Deletetb_Sys_Roles(Guid Id);
        List<tb_Sys_Roles> GetRolesByUserId(Guid userId);
	}
	public class tb_Sys_RolesService :Itb_Sys_RolesService
	{
		private Itb_Sys_RolesRepository tb_Sys_RolesRepository;
        private Itb_Sys_UserRoleRepository userRoleRepository;
		private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public tb_Sys_RolesService(IDatabaseFactory dbfactory)
		{
            this.runtimeService = new UnitOfWork(dbfactory);
            this.tb_Sys_RolesRepository = new tb_Sys_RolesRepository(dbfactory);
            this.userRoleRepository = new tb_Sys_UserRoleRepository(dbfactory);
		}

		public List<tb_Sys_Roles> Gettb_Sys_RolesList()
        {
            var q = this.tb_Sys_RolesRepository.GetMany(i => true);
            return q.ToList();
        }

        public tb_Sys_Roles Gettb_Sys_RolesById(Guid Id)
        {
            return this.tb_Sys_RolesRepository.GetByID(Id);
        }

        public void Createtb_Sys_Roles(tb_Sys_Roles tb_Sys_Roles)
        {
            tb_Sys_Roles.Validate();
            tb_Sys_Roles.CreateTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Roles.CreateUser = tempUser.UserName;
            tb_Sys_Roles.Validate();
			this.tb_Sys_RolesRepository.Add(tb_Sys_Roles);
            this.runtimeService.Commit();
        }

        public void Deletetb_Sys_Roles(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_RolesById(Id);
            this.tb_Sys_RolesRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Updatetb_Sys_Roles(tb_Sys_Roles tb_Sys_Roles)
        {
            tb_Sys_Roles.ModifyTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Roles.ModifyUser = tempUser.UserName;
            tb_Sys_Roles.Validate();
            var existstb_Sys_Menu = this.Gettb_Sys_RolesById(tb_Sys_Roles.Id);
            this.tb_Sys_RolesRepository.SetValues(tb_Sys_Roles, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_Roles> Gettb_Sys_RolesList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_Sys_RolesRepository.GetMany(i => true);
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

        //根据用户Id获取权限组
        public List<tb_Sys_Roles> GetRolesByUserId(Guid userId)
        {
            var userRole = this.userRoleRepository.GetMany(u => u.UserId == userId);
            var roles = this.tb_Sys_RolesRepository.GetMany(i=>true);
            roles = from r in roles
                    join i in userRole on r.Id equals i.RoleId
                    select r;
            return roles.ToList();
        }
    }
}