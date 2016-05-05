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
using DevExpress.XtraEditors.Repository;
using ERP.Domain;
namespace ERP.Winform.SysModule
{
    public partial class SysMenuForm : ListForm
    {
        Itb_Sys_MenuService menuService = Unity.Instance.GetService<Itb_Sys_MenuService>();
        public SysMenuForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            tbSysMenuBindingSource.DataSource = this.menuService.Gettb_Sys_MenuList();
            repositoryMenuParentId.DataSource = this.menuService.Gettb_Sys_MenuList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                tbSysMenuBindingSource.AddNew();
                OpenForm("菜单新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("菜单修改", BtnCommandEnum.Edit);
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            tb_Sys_Menu temp = tbSysMenuBindingSource.Current as tb_Sys_Menu;
            SysMenuEditForm edit = new SysMenuEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                tbSysMenuBindingSource.CancelEdit();
            }
        }
        private void SysMenuForm_Load(object sender, EventArgs e)
        {
           
        }

    }
}
