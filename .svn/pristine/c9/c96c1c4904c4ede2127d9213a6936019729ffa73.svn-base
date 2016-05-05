using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
namespace ERP.Service
{
    public interface Itb_Sys_RolesBtnService
    {
        tb_Sys_RolesBtn Gettb_Sys_RolesBtnById(Guid Id);
        List<tb_Sys_RolesBtn> Gettb_Sys_RolesBtnList();
        List<tb_Sys_RolesBtn> Gettb_Sys_RolesBtnList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Createtb_Sys_RolesBtn(tb_Sys_RolesBtn tb_Sys_RolesBtn);
        void Updatetb_Sys_RolesBtn(tb_Sys_RolesBtn tb_Sys_RolesBtn);
        void Deletetb_Sys_RolesBtn(Guid Id);
        tb_Sys_RolesBtn GetByMenuId(Guid roleId,Guid menuId,Guid btnId);
    }
    public class tb_Sys_RolesBtnService : Itb_Sys_RolesBtnService
    {
        private Itb_Sys_RolesBtnRepository tb_Sys_RolesBtnRepository;
        private IUnitOfWork runtimeService;
        public tb_Sys_RolesBtnService(IDatabaseFactory dbfactory)
        {
            this.runtimeService = new UnitOfWork(dbfactory);
            this.tb_Sys_RolesBtnRepository = new tb_Sys_RolesBtnRepository(dbfactory);
        }

        public List<tb_Sys_RolesBtn> Gettb_Sys_RolesBtnList()
        {
            var q = this.tb_Sys_RolesBtnRepository.GetMany(i => true);
            return q.ToList();
        }

        public tb_Sys_RolesBtn Gettb_Sys_RolesBtnById(Guid Id)
        {
            return this.tb_Sys_RolesBtnRepository.GetByID(Id);
        }

        public void Createtb_Sys_RolesBtn(tb_Sys_RolesBtn tb_Sys_RolesBtn)
        {
            this.tb_Sys_RolesBtnRepository.Add(tb_Sys_RolesBtn);
            this.runtimeService.Commit();
        }

        public void Deletetb_Sys_RolesBtn(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_RolesBtnById(Id);
            this.tb_Sys_RolesBtnRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Updatetb_Sys_RolesBtn(tb_Sys_RolesBtn tb_Sys_RolesBtn)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_RolesBtnById(tb_Sys_RolesBtn.Id);
            this.tb_Sys_RolesBtnRepository.SetValues(tb_Sys_RolesBtn, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_RolesBtn> Gettb_Sys_RolesBtnList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_Sys_RolesBtnRepository.GetMany(i => true);
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


        public tb_Sys_RolesBtn GetByMenuId(Guid roleId, Guid menuId, Guid btnId)
        {
            var q = this.tb_Sys_RolesBtnRepository.GetMany(i =>i.Roles_Id == roleId && i.Menu_Id == menuId && i.Btn_Id == btnId).FirstOrDefault();
            return q;
        }
    }
}