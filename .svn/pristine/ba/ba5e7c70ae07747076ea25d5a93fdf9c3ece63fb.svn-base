using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Service;
using COM.Service;
using ERP.Domain;
namespace ERP.Winform.SysModule
{
    public partial class SysRoleForm : ListForm
    {
        private Itb_Sys_RolesService roleService = Unity.Instance.GetService<Itb_Sys_RolesService>();
        public SysRoleForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            tbSysRolesBindingSource.DataSource = this.roleService.Gettb_Sys_RolesList();
        }

        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                tbSysRolesBindingSource.AddNew();
                OpenForm("角色新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("角色修改", BtnCommandEnum.Edit);
            }
        }

        private void OpenForm(string formText, string btnCommand)
        {
            tb_Sys_Roles temp = tbSysRolesBindingSource.Current as tb_Sys_Roles;
            SysRoleEditForm edit = new SysRoleEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                tbSysRolesBindingSource.CancelEdit();
            }
        }
    }
}
