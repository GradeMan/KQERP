using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface Itb_Sys_ButtonService
	{
		tb_Sys_Button Gettb_Sys_ButtonById(Guid Id);
        List<tb_Sys_Button> Gettb_Sys_ButtonList();
		List<tb_Sys_Button> Gettb_Sys_ButtonList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Createtb_Sys_Button(tb_Sys_Button tb_Sys_Button);
        void Updatetb_Sys_Button(tb_Sys_Button tb_Sys_Button);
        void Deletetb_Sys_Button(Guid Id);
        List<tb_Sys_Button> GetButtonsByMenu(Guid mengId, Guid roleId);
	}
	public class tb_Sys_ButtonService :Itb_Sys_ButtonService
	{
		private Itb_Sys_ButtonRepository tb_Sys_ButtonRepository;
		private IUnitOfWork runtimeService;
        private Itb_Sys_RolesBtnRepository tb_Sys_RolesBtnRepository;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public tb_Sys_ButtonService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.tb_Sys_ButtonRepository = new tb_Sys_ButtonRepository(dbfactory);
            this.tb_Sys_RolesBtnRepository = new tb_Sys_RolesBtnRepository(dbfactory);
		}

		public List<tb_Sys_Button> Gettb_Sys_ButtonList()
        {
            var q = this.tb_Sys_ButtonRepository.GetMany(i => true);
            return q.ToList();
        }

        public tb_Sys_Button Gettb_Sys_ButtonById(Guid Id)
        {
            return this.tb_Sys_ButtonRepository.GetByID(Id);
        }

        public void Createtb_Sys_Button(tb_Sys_Button tb_Sys_Button)
        {
            tb_Sys_Button.Validate();
            tb_Sys_Button.CreateTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Button.CreateUser = tempUser.UserName;
            tb_Sys_Button.Validate();
			this.tb_Sys_ButtonRepository.Add(tb_Sys_Button);
            this.runtimeService.Commit();
        }

        public void Deletetb_Sys_Button(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_ButtonById(Id);
            this.tb_Sys_ButtonRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Updatetb_Sys_Button(tb_Sys_Button tb_Sys_Button)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_ButtonById(tb_Sys_Button.Id);
            tb_Sys_Button.ModifyTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Button.ModifyUser = tempUser.UserName;
            tb_Sys_Button.Validate();
            this.tb_Sys_ButtonRepository.SetValues(tb_Sys_Button, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_Button> Gettb_Sys_ButtonList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_Sys_ButtonRepository.GetMany(i => true);
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
        /// 获取页面有权限的按钮
        /// </summary>
        /// <param name="mengId"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<tb_Sys_Button> GetButtonsByMenu(Guid menuId, Guid roleId)
        {
            var buttonIdList = this.tb_Sys_RolesBtnRepository.GetMany(i => i.Menu_Id == menuId && i.Roles_Id == roleId).Select(i=>i.Btn_Id).ToList();
            var q = this.tb_Sys_ButtonRepository.GetMany(i => buttonIdList.Contains(i.Id)).OrderBy(i=>i.Btn_SeqNo);
            return q.ToList();
        }
    }
}