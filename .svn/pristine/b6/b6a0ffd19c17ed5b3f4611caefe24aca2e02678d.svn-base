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
using ERP.Domain;
using COM.Service;
namespace ERP.Winform.SysModule
{
    public partial class SysRoleEditForm : EditForm
    {
        private Itb_Sys_RolesService roleService = Unity.Instance.GetService<Itb_Sys_RolesService>();
        public SysRoleEditForm( tb_Sys_Roles rolesData)
        {
            InitializeComponent();
            tbSysRolesBindingSource.DataSource = rolesData;
        }
        public SysRoleEditForm(Guid roleId, Itb_Sys_RolesService roleService)
        {
            InitializeComponent();
            this.roleService = roleService;
            tbSysRolesBindingSource.DataSource = roleService.Gettb_Sys_RolesById(roleId);
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForRoles_Name, ItemBindingType.Required);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbSysRolesBindingSource.EndEdit();
            var RolesData = tbSysRolesBindingSource.DataSource as tb_Sys_Roles;
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    roleService.Createtb_Sys_Roles(RolesData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    roleService.Updatetb_Sys_Roles(RolesData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
