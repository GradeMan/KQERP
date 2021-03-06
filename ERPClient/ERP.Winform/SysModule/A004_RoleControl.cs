﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList.Columns;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using COM.Service;
using ERP.Winform.ESOP;
using Util;
namespace ERP.Winform
{
    public partial class A004_RoleControl : XtraForm
    {
        private Itb_Sys_RolesService rolesService = Unity.Instance.GetService<Itb_Sys_RolesService>();
        private Itb_Sys_ButtonService buttonService = Unity.Instance.GetService<Itb_Sys_ButtonService>();
        private Itb_Sys_MenuService menuService = Unity.Instance.GetService<Itb_Sys_MenuService>();
        private Itb_Sys_UserService userService = Unity.Instance.GetService<Itb_Sys_UserService>();
        private Itb_Sys_RolesRightService rolesRightService = Unity.Instance.GetService<Itb_Sys_RolesRightService>();
        private Itb_Sys_RolesBtnService rolesBtnService = Unity.Instance.GetService<Itb_Sys_RolesBtnService>();
        private Itb_Sys_UserRoleService userRoleService = Unity.Instance.GetService<Itb_Sys_UserRoleService>();
        private Itb_Sys_ControlsService controlService = Unity.Instance.GetService<Itb_Sys_ControlsService>();
        private Itb_Sys_RolesControlService roleControlService = Unity.Instance.GetService<Itb_Sys_RolesControlService>();
        public A004_RoleControl()
        {
            InitializeComponent();
           
        }
        public  int BindGridColumns()
        {
            GvRoles.Columns.Add(ERPHelper.Instance.AddGridColumns("角色名称", "Roles_Name", true));
            GvRoles.Columns.Add(ERPHelper.Instance.AddGridColumns("角色ID", "Id", false));
            //菜单
            //gridviewMenu.Columns.Add(ERPHelper.Instance.AddGridColumns("菜单名称", "MenuName", true));
            //gridviewMenu.Columns.Add(ERPHelper.Instance.AddGridColumns("菜单ID", "Id", false));
            treeListColumn1.FieldName = "Id";
            treeListColumn2.FieldName = "MenuName";
            treeMenu.ParentFieldName = "ParentMenuId";
            treeMenu.KeyFieldName = "Id";

            //按钮
            gridviewAction.Columns.Add(ERPHelper.Instance.AddGridColumns("按钮名称", "Btn_Name", true));
            gridviewAction.Columns.Add(ERPHelper.Instance.AddGridColumns("按钮ID", "Id", false));

            //用户
            gridviewUser.Columns.Add(ERPHelper.Instance.AddGridColumns("用户名", "UserCode", true));
            gridviewUser.Columns.Add(ERPHelper.Instance.AddGridColumns("中文名", "UserName", true));
            gridviewUser.Columns.Add(ERPHelper.Instance.AddGridColumns("用户ID", "Id", false));
            
            //用户
            gridViewControl.Columns.Add(ERPHelper.Instance.AddGridColumns("窗体", "Windows", true));
            gridViewControl.Columns.Add(ERPHelper.Instance.AddGridColumns("对象", "Control", true));
            gridViewControl.Columns.Add(ERPHelper.Instance.AddGridColumns("对象值", "CValue", true));
            gridViewControl.Columns.Add(ERPHelper.Instance.AddGridColumns("对象ID", "Id", false));
            return 1;
        }
        //加载数据
        public  int OnRetrieve()
        {
            //1.0 加载角色信息
            List<tb_Sys_Roles> listRoles = rolesService.Gettb_Sys_RolesList();
            
            GcRoles.DataSource = listRoles;

            GvRoles.OptionsBehavior.Editable = false;
            treeMenu.OptionsBehavior.Editable = false;
            gridviewAction.OptionsBehavior.Editable = false;
            gridviewUser.OptionsBehavior.Editable = false;

            GvRoles_FocusedRowChanged(this.GvRoles, null);
            //gridviewMenu_FocusedRowChanged(this.gridviewMenu, null);

            return 1;
        }
        //注册事件
        public  int OnAttachEvent()
        {
            
            GvRoles.FocusedRowChanged +=GvRoles_FocusedRowChanged;
            //gridviewMenu.FocusedRowChanged += gridviewMenu_FocusedRowChanged;  
            return 1;
        }
        ////菜单表行改变事件
        //void gridviewMenu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
        //    tb_Sys_Menu menu = treeMenu.get as tb_Sys_Menu;
        //    if (role != null && menu != null)
        //    {
        //        //查出该权限所在菜单下的所有按钮
        //       // List<string> listactionID =  // ServiceHelper.Current.DbSession.Itb_Sys_RoleActionDAL.GetListBy(r => r.RoleID == role.RoleID && r.MoudelID == module.ModuleID).Select(r => r.ActionID).ToList();
        //        gridcontrolAction.DataSource = buttonService.GetButtonsByMenu(menu.Id, role.Id);
                
        //    }
        //}
        //2016-03-10更改
        //菜单表行改变事件
        private void treeMenu_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            Guid? menuId = e.Node.GetValue(treeListColumn1).ToString().ToGuidOrNull(); //获取PermissionID
            if (role != null && menuId != null)
            {
                //查出该权限所在菜单下的所有按钮
                // List<string> listactionID =  // ServiceHelper.Current.DbSession.Itb_Sys_RoleActionDAL.GetListBy(r => r.RoleID == role.RoleID && r.MoudelID == module.ModuleID).Select(r => r.ActionID).ToList();
                gridcontrolAction.DataSource = buttonService.GetButtonsByMenu(menuId?? new Guid(), role.Id);

            }
        }

        //角色表行改变事件
        void GvRoles_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            if (role != null)
            {
                //查出该权限下所有菜单
                //List<string> listmenuID = ServiceHelper.Current.DbSession.Itb_Sys_RoleModuleDAL.GetListBy(r => r.RoleID == role.RoleID).Select(r => r.ModuleID).ToList();
                treeMenu.DataSource = menuService.GetMenusByRoleId(role.Id); //ServiceHelper.Current.DbSession.Itb_Sys_ModuleDAL.GetListBy(m => listmenuID.Contains(m.ModuleID));

                //List<string> listUserID = ServiceHelper.Current.DbSession.Itb_Sys_UserRoleDAL.GetListBy(r => r.RoleID == role.RoleID).Select(r => r.UserID).ToList();
                gridcontrolUser.DataSource = userService.GetUserByRoleId(role.Id);//ServiceHelper.Current.DbSession.Itb_Sys_UserDAL.GetListBy(r => listUserID.Contains(r.UserID));

                gridControlControl.DataSource = controlService.GetlistByRolesId(role.Id);
            }
        }
        public  void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            BindGridColumns();
            OnRetrieve();
            OnAttachEvent();
        }
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            if (role == null)
            {
                XtraMessageBox.Show("请先选择角色");
                return;
            }
            A004_RoleControlEdit frmedit = new A004_RoleControlEdit("AddMenu", role.Id);
            if (frmedit.ShowDialog() == DialogResult.OK)
            {
                GvRoles_FocusedRowChanged(this.GvRoles, null);
            }
        }
        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;

            if (treeMenu.Focused)
            {
                //tb_Sys_Menu menu = gridviewMenu.GetFocusedRow() as tb_Sys_Menu;
                Guid? menuId = this.treeMenu.FocusedNode.GetValue(treeListColumn1).ToString().ToGuidOrNull(); //获取PermissionID
                if (menuId != null)
                {
                    //tb_Sys_RolesRight roleMenu = menuService// ServiceHelper.Current.DbSession.Itb_Sys_RoleModuleDAL.GetListBy(m => m.RoleID == role.RoleID && m.ModuleID == menu.ModuleID).FirstOrDefault();
                    tb_Sys_RolesRight roleMenu = rolesRightService.GetByMenuIdAndRolesId(role.Id, menuId?? new Guid());
                    //int count = ServiceHelper.Current.DbSession.Itb_Sys_RoleModuleDAL.Del(roleMenu);
                    if (roleMenu != null)
                    {
                        rolesRightService.Deletetb_Sys_RolesRight(roleMenu.Id);
                        this.treeMenu.DeleteNode(this.treeMenu.FocusedNode);
                        XtraMessageBox.Show("删除成功");
                    }

                }
            }
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            Guid? menuId = this.treeMenu.FocusedNode.GetValue(treeListColumn1).ToString().ToGuidOrNull();
            if (menuId == null)
            {
                XtraMessageBox.Show("请先选择菜单模块");
                return;
            }
            A004_RoleControlEdit frmedit = new A004_RoleControlEdit("AddAction", role.Id, menuId??new Guid());
            if (frmedit.ShowDialog() == DialogResult.OK)
            {
                gridcontrolAction.DataSource = buttonService.GetButtonsByMenu(menuId ?? new Guid(), role.Id);
            }
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            if (gridviewAction.SelectedRowsCount >= 0)
            {
                Guid? menuId = this.treeMenu.FocusedNode.GetValue(treeListColumn1).ToString().ToGuidOrNull();
                if (menuId != null)
                {
                    tb_Sys_Button action = gridviewAction.GetFocusedRow() as tb_Sys_Button;
                    if (action != null)
                    {
                        tb_Sys_RolesBtn roleBtn = rolesBtnService.GetByMenuId(role.Id, menuId?? new Guid(), action.Id);//ServiceHelper.Current.DbSession.Itb_Sys_RoleActionDAL.GetListBy(m => m.RoleID == role.RoleID && m.MoudelID == module.ModuleID && m.ActionID == action.ActionID).FirstOrDefault();
                        if(roleBtn!=null)
                        {
                            rolesBtnService.Deletetb_Sys_RolesBtn(roleBtn.Id);
                            this.gridviewAction.DeleteSelectedRows();
                            XtraMessageBox.Show("删除成功");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            A004_RoleControlEdit frmedit = new A004_RoleControlEdit("AddUser", role.Id);
            if (frmedit.ShowDialog() == DialogResult.OK)
            {
                List<Guid> listUserID = userRoleService.GetByRoleId(role.Id).Select(i => i.UserId).ToList();//ServiceHelper.Current.DbSession.Itb_Sys_UserRoleDAL.GetListBy(r => r.RoleID == role.RoleID).Select(r => r.UserID).ToList();
                gridcontrolUser.DataSource = userService.Gettb_Sys_UserList().Where(i => listUserID.Contains(i.Id)).ToList();//ServiceHelper.Current.DbSession.Itb_Sys_UserDAL.GetListBy(r => listUserID.Contains(r.UserID));
            }
        }

        /// <summary>
        /// 添加对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            A004_RoleControlEdit frmedit = new A004_RoleControlEdit("AddControl", role.Id);
            if (frmedit.ShowDialog() == DialogResult.OK)
            {
                gridControlControl.DataSource = controlService.GetlistByRolesId(role.Id);
            }
        }

        private void btnDelControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            if (gridViewControl.SelectedRowsCount >= 0) 
            {
                tb_Sys_Controls control = gridViewControl.GetFocusedRow() as tb_Sys_Controls;
                if (control != null)
                {

                    tb_Sys_RolesControl roleControl = roleControlService.GetByRolesIdAndControlId(role.Id, control.Id);//ServiceHelper.Current.DbSession.Itb_Sys_RoleActionDAL.GetListBy(m => m.RoleID == role.RoleID && m.Mo
                    if (roleControl != null)
                    {
                        roleControlService.Delete(roleControl.Id);
                        this.gridviewAction.DeleteSelectedRows();
                        XtraMessageBox.Show("删除成功");
                    }
                    
                }
            }
        }

        /// <summary>
        /// 机台设备权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeviceRole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tb_Sys_Roles role = GvRoles.GetFocusedRow() as tb_Sys_Roles;
            if (role == null)
            {
                XtraMessageBox.Show("请先选择角色");
                return;
            }
            ESOPRoleDevice frmedit = new ESOPRoleDevice(role.Id);
            frmedit.Tag = BtnCommandEnum.Edit;
            if (frmedit.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("保存成功");
            }
            
        }

        
      
 
    }
}
