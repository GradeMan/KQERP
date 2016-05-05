using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface Itb_Sys_MenuService
	{
		tb_Sys_Menu Gettb_Sys_MenuById(Guid Id);
        List<tb_Sys_Menu> Gettb_Sys_MenuList();
		List<tb_Sys_Menu> Gettb_Sys_MenuList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Createtb_Sys_Menu(tb_Sys_Menu tb_Sys_Menu);
        void Updatetb_Sys_Menu(tb_Sys_Menu tb_Sys_Menu);
        void Deletetb_Sys_Menu(Guid Id);
        List<tb_Sys_Menu> GetMenusByUserId(Guid id);
        List<tb_Sys_Menu> GetMenusByParentMenuId(Guid id);
        List<tb_Sys_Menu> GetMenusByRoleId(Guid id);
	}

	public class tb_Sys_MenuService :Itb_Sys_MenuService
	{
		private Itb_Sys_MenuRepository tb_Sys_MenuRepository;
        private Itb_Sys_RolesRepository rolesRepository;
        private Itb_Sys_RolesRightRepository rolesRightRepository;
        private Itb_Sys_RolesService rolesService;
		private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public tb_Sys_MenuService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
            this.tb_Sys_MenuRepository = new tb_Sys_MenuRepository(dbfactory);
            this.rolesRepository = new tb_Sys_RolesRepository(dbfactory);
            this.rolesRightRepository = new tb_Sys_RolesRightRepository(dbfactory);
            this.rolesService = new tb_Sys_RolesService(dbfactory);

		}

		public List<tb_Sys_Menu> Gettb_Sys_MenuList()
        {
            var q = this.tb_Sys_MenuRepository.GetMany(i => true).OrderBy(i=>i.SeqNo);

            return q.ToList();
        }

        public tb_Sys_Menu Gettb_Sys_MenuById(Guid Id)
        {
            return this.tb_Sys_MenuRepository.GetByID(Id);
        }

        public void Createtb_Sys_Menu(tb_Sys_Menu tb_Sys_Menu)
        {
            tb_Sys_Menu.Validate();
            tb_Sys_Menu.CreateTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Menu.CreateUser = tempUser.UserName;
            tb_Sys_Menu.Validate();
			this.tb_Sys_MenuRepository.Add(tb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Deletetb_Sys_Menu(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_MenuById(Id);
            this.tb_Sys_MenuRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Updatetb_Sys_Menu(tb_Sys_Menu tb_Sys_Menu)
        {
            tb_Sys_Menu.ModifyTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Menu.ModifyUser = tempUser.UserName;
            tb_Sys_Menu.Validate();
            var existstb_Sys_Menu = this.Gettb_Sys_MenuById(tb_Sys_Menu.Id);
            this.tb_Sys_MenuRepository.SetValues(tb_Sys_Menu, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_Menu> Gettb_Sys_MenuList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_Sys_MenuRepository.GetMany(i => true);
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
        /// <summary>
        /// 根据用户ID获取餐单列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<tb_Sys_Menu> GetMenusByUserId(Guid id)
        {
            var rolesIdList = this.rolesService.GetRolesByUserId(id).Select(i=>i.Id).ToList();
            var rolesRights = this.rolesRightRepository.GetMany(i => rolesIdList.Contains(i.Roles_Id)).Select(i=>i.Menu_Id).ToList();
            var menus = this.tb_Sys_MenuRepository.GetMany(i => rolesRights.Contains(i.Id));
            return menus.ToList();

        }


        public List<tb_Sys_Menu> GetMenusByParentMenuId(Guid id)
        {
            var menus = this.tb_Sys_MenuRepository.GetMany(i => i.ParentMenuId == id).ToList();
            return menus;
        }


        public List<tb_Sys_Menu> GetMenusByRoleId(Guid id)
        {
            var rolesRights = this.rolesRightRepository.GetMany(i => i.Roles_Id == id).Select(i => i.Menu_Id).ToList();
            var menus = this.tb_Sys_MenuRepository.GetMany(i => rolesRights.Contains(i.Id));
            return menus.ToList();
        }
    }
}