﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Service;
using COM.Service;
using ERP.Domain;
using COM.Domain;
namespace ERP.Winform.SysModule
{
    public partial class SysUserForm : ListForm
    {
        private Itb_Sys_UserService userService = Unity.Instance.GetService<Itb_Sys_UserService>();
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        public SysUserForm()
        {
            InitializeComponent();
            this.gridView2.CustomDrawRowIndicator +=new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
            this.gridView2.DoubleClick += new EventHandler(gridView2_DoubleClick);
        }

        void gridView2_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("用户资料查看", BtnCommandEnum.Watch);
        }
        public override void OnAttachEvent()
        {
            SetGridLookUpEdit(repositoryItemCompCode, companyService.GetList().Select(a => new InputItem { DisPlayName = a.CompName, Value = a.CompCode }).ToList(), 0);
        }
        //数据插入
        public override void InitData()
        {
            tbSysUserBindingSource.DataSource = this.userService.Gettb_Sys_UserList();
            
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                tbSysUserBindingSource.AddNew();
                OpenForm("用户资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("用户资料修改", BtnCommandEnum.Edit);
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            tb_Sys_User temp = tbSysUserBindingSource.Current as tb_Sys_User;
            SysUserEditForm edit = new SysUserEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                tbSysUserBindingSource.CancelEdit();
            }
        }
    }
}