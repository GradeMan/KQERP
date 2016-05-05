using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using ERP.Service;
using ERP.Domain;
using Util;
using COM.Service;
namespace ERP.Winform
{
    public partial class A004_RoleControlEdit : Form
    {
        private Itb_Sys_MenuService menuService = Unity.Instance.GetService<Itb_Sys_MenuService>();
        private Itb_Sys_RolesRightService  roleRightService = Unity.Instance.GetService<Itb_Sys_RolesRightService>();
        private Itb_Sys_ButtonService buttonService = Unity.Instance.GetService<Itb_Sys_ButtonService>();
        private Itb_Sys_UserService userService = Unity.Instance.GetService<Itb_Sys_UserService>();
        private Itb_Sys_RolesBtnService rolesBtnService = Unity.Instance.GetService<Itb_Sys_RolesBtnService>();
        private Itb_Sys_UserRoleService userRoleService = Unity.Instance.GetService<Itb_Sys_UserRoleService>();
        private Itb_Sys_ControlsService controlService = Unity.Instance.GetService<Itb_Sys_ControlsService>();
        private Itb_Sys_RolesControlService roleControlService = Unity.Instance.GetService<Itb_Sys_RolesControlService>();
        private string toolCommand;
        private Guid sys_roleid;
        private Guid sys_moduleId;
        private List<Guid> listmenuID;
        public A004_RoleControlEdit()
        {
            InitializeComponent();
        }
        //Menu
        public A004_RoleControlEdit(string toolCommand)
        {
            InitializeComponent();
            this.toolCommand = toolCommand;
            BindData();
        }
        //Menu
        public A004_RoleControlEdit(string toolCommand,Guid roleid)
        {
            InitializeComponent();
            this.toolCommand = toolCommand;
            this.sys_roleid = roleid;
            BindData();
        }
        //Action
        public A004_RoleControlEdit(string toolCommand, Guid roleid, Guid moduleId)
        {
            InitializeComponent();
            this.toolCommand = toolCommand;
            this.sys_roleid = roleid;
            this.sys_moduleId = moduleId;
            BindData();
        }
        //绑定数据
        private void BindData()
        {
            if(toolCommand=="AddMenu")
            {
                this.Text = "添加菜单";
                treeListColumn1.FieldName = "Id";
                treeListColumn2.FieldName = "MenuName";
                treeList1.ParentFieldName = "ParentMenuId";
                treeList1.KeyFieldName = "Id";
                listmenuID = roleRightService.Gettb_Sys_RolesRightList().Where(i=>i.Roles_Id==sys_roleid).Select(i=>i.Menu_Id).ToList();//ServiceHelper.Current.DbSession.Itb_Sys_RoleModuleDAL.GetListBy(r => r.RoleID == sys_roleid).Select(r => r.ModuleID).ToList();
                this.treeList1.DataSource = this.menuService.Gettb_Sys_MenuList();//ServiceHelper.Current.DbSession.Itb_Sys_ModuleDAL.GetListBy(m => m.State != false);
                this.treeList1.ExpandAll();
                foreach (TreeListNode node in treeList1.Nodes)
                {
                    Guid moduleId = node.GetValue(treeListColumn1).ToStr().ToGuid(); //获取PermissionID  
                    if (listmenuID.Contains(moduleId))
                    {
                        node.Checked = true;
                        SetTreeListChecks(node);
                    }
                    else
                    {
                        node.Checked = false;
                        SetTreeListChecks(node);
                    }
                }
            }
            else if (toolCommand == "AddAction")
            {
                this.Text = "添加按钮";
                treeListColumn1.FieldName = "Id";
                treeListColumn2.FieldName = "Btn_Name";
                listmenuID = buttonService.GetButtonsByMenu(sys_roleid, sys_moduleId).Select(i => i.Id).ToList();
                this.treeList1.DataSource = buttonService.Gettb_Sys_ButtonList() ;// ServiceHelper.Current.DbSession.Itb_Sys_ActionDAL.GetListBy(m => m.ActionID != null );
                foreach (TreeListNode node in treeList1.Nodes)
                {
                    Guid buttonId = node.GetValue(treeListColumn1).ToStr().ToGuid(); //获取PermissionID  
                    if (listmenuID.Contains(buttonId))
                    {
                        node.Checked = true;
                        SetTreeListChecks(node);
                    }
                    else
                    {
                        node.Checked = false;
                        SetTreeListChecks(node);
                    }
                }
            }
            else if (toolCommand == "AddUser")
            {
                this.Text = "添加按钮";
                treeListColumn1.FieldName = "Id";
                treeListColumn2.FieldName = "UserName";
                this.treeList1.DataSource = userService.Gettb_Sys_UserList();//ServiceHelper.Current.DbSession.Itb_Sys_UserDAL.GetListBy(m => m.State != false);
            }
            else if (toolCommand == "AddControl")
            {
                this.Text = "添加Control";
                treeListColumn1.FieldName = "Id";
                treeListColumn2.FieldName = "Windows";
                treeListColumn3.FieldName = "Control";
                treeListColumn4.FieldName = "CValue";
                treeListColumn3.Visible = true;
                treeListColumn4.Visible = true;
                this.treeList1.DataSource = controlService.GetList();//ServiceHelper.Current.DbSession.Itb_Sys_UserDAL.GetListBy(m => m.State != false);
            }
        }

        private void SetTreeListChecks(TreeListNode node)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                Guid moduleId = node.Nodes[i].GetValue(treeListColumn1).ToStr().ToGuid(); //获取PermissionID  
                if (listmenuID.Contains(moduleId))
                    node.Nodes[i].Checked = true;
                else
                    node.Nodes[i].Checked = false;
                SetTreeListChecks(node.Nodes[i]);
            }
        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            //保存菜单
            if (toolCommand == "AddMenu")
            {
                //roleRightService.DeleteRolesId(sys_roleid);
                foreach(TreeListNode node in treeList1.Nodes)
                {
                    Guid menuId = node.GetValue(treeListColumn1).ToString().ToGuid(); //获取PermissionID
                    if (node.CheckState == CheckState.Checked && !listmenuID.Contains(menuId))
                    {
                        tb_Sys_Menu module = menuService.Gettb_Sys_MenuById(menuId);//ServiceHelper.Current.DbSession.Itb_Sys_ModuleDAL.GetListBy(m => m.ModuleID == moduleId).FirstOrDefault();
                        tb_Sys_RolesRight rolesRight = new tb_Sys_RolesRight {  Roles_Id = sys_roleid,  Menu_Id = module.Id };
                        roleRightService.Createtb_Sys_RolesRight(rolesRight);
                    }
                    else if(node.CheckState != CheckState.Checked && listmenuID.Contains(menuId))
                    {
                        roleRightService.GetByMenuIdAndRolesId(sys_roleid,menuId);
                    }
                    SaveTreeList(node);
                }
               
            }
            else if (toolCommand == "AddAction")//保存按钮
            {
                foreach (TreeListNode node in treeList1.Nodes)
                {
                    if (node.CheckState == CheckState.Checked)
                    {
                       // tb_Sys_Roles role = role//ServiceHelper.Current.DbSession.Itb_Sys_RoleDAL.GetListBy(r => r.RoleID == sys_roleid).FirstOrDefault();
                        Guid btnId = node.GetValue(treeListColumn1).ToString().ToGuid(); //获取PermissionID
                        tb_Sys_RolesBtn roleAction = new tb_Sys_RolesBtn {  Roles_Id = sys_roleid,  Menu_Id = sys_moduleId,  Btn_Id = btnId };
                         rolesBtnService.Createtb_Sys_RolesBtn(roleAction);
                        
                    }
                }
            }
            else if (toolCommand == "AddUser")
            {
                foreach (TreeListNode node in treeList1.Nodes)
                {
                    if (node.CheckState == CheckState.Checked)
                    {
                        Guid userId = node.GetValue(treeListColumn1).ToString().ToGuid(); //获取PermissionID
                        tb_Sys_UserRole roleuser = new tb_Sys_UserRole {  RoleId = sys_roleid,  UserId = userId };
                        //int row = ServiceHelper.Current.DbSession.Itb_Sys_UserRoleDAL.Add(roleuser);
                        userRoleService.Createtb_Sys_UserRole(roleuser);
                    }
                }
            }
            else if (toolCommand == "AddControl")
            {
                foreach (TreeListNode node in treeList1.Nodes)
                {
                    if (node.CheckState == CheckState.Checked)
                    {
                        Guid controlID = node.GetValue(treeListColumn1).ToString().ToGuid(); //获取ControlID
                        tb_Sys_RolesControl rolecontrol = new tb_Sys_RolesControl { Roles_Id = sys_roleid, ControlId = controlID };
                        //int row = ServiceHelper.Current.DbSession.Itb_Sys_UserRoleDAL.Add(roleuser);
                        roleControlService.Create(rolecontrol);
                    }
                }
            }
            MessageBox.Show("保存成功");
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void SaveTreeList(TreeListNode listNode)
        {
            foreach (TreeListNode node in listNode.Nodes)
            {
                Guid menuId = node.GetValue(treeListColumn1).ToString().ToGuid(); //获取PermissionID
                if (node.CheckState == CheckState.Checked && !listmenuID.Contains(menuId))
                {
                    tb_Sys_Menu module = menuService.Gettb_Sys_MenuById(menuId);//ServiceHelper.Current.DbSession.Itb_Sys_ModuleDAL.GetListBy(m => m.ModuleID == moduleId).FirstOrDefault();
                    tb_Sys_RolesRight rolesRight = new tb_Sys_RolesRight { Roles_Id = sys_roleid, Menu_Id = module.Id };
                    roleRightService.Createtb_Sys_RolesRight(rolesRight);
                }
                else if (node.CheckState != CheckState.Checked && listmenuID.Contains(menuId))
                {
                    roleRightService.GetByMenuIdAndRolesId(sys_roleid, menuId);
                }
                SaveTreeList(node);
            }
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

       
    }
}
