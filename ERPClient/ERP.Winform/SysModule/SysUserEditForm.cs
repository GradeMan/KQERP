using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using COM.Service;
using COM.Domain;
using Util;
namespace ERP.Winform.SysModule
{
    public partial class SysUserEditForm : EditForm
    {
        private Itb_Sys_UserService userService = Unity.Instance.GetService<Itb_Sys_UserService>();
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        public SysUserEditForm(tb_Sys_User userData)
        {
            //this.userService = userService;
            InitializeComponent();
            tbSysUserBindingSource.DataSource = userData;
        }
        protected override void InitData()
        {
            var companyList = companyService.GetList().Select(i=>new InputItem { DisPlayName = i.CompName, Value = i.CompCode, InputCode1 = i.CompCode,InputCode2 = PinYin.GetCodstring(i.CompName)  }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(CompCodeTextEdit, companyList, 2);
            //CompCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(CompCodeTextEdit_EditValueChanging);
        }

        //void CompCodeTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        //{
        //    this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
        //    {
        //        ERPHelper.Instance.FilterLookup(sender);
        //    }));
        //}
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForUserCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForUserName, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForUserPassword, ItemBindingType.Required);
        }
        protected override void SetToolBarItem()
        {
            base.SetToolBarItem();
            OnAddToolBtn("测试", "mini1");
        }
        //按钮点击事件
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbSysUserBindingSource.EndEdit();
            var userData = tbSysUserBindingSource.DataSource as tb_Sys_User;
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    userService.Createtb_Sys_User(userData);
                else if(this.Tag.ToString() == BtnCommandEnum.Edit)
                    userService.Updatetb_Sys_User(userData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}