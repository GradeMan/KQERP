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
    public partial class SysButtonForm : ListForm
    {
        private Itb_Sys_ButtonService buttonService = Unity.Instance.GetService<Itb_Sys_ButtonService>();
        public SysButtonForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            tbSysButtonBindingSource.DataSource = buttonService.Gettb_Sys_ButtonList();

        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                tbSysButtonBindingSource.AddNew();
                OpenForm("按钮新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("按钮修改", BtnCommandEnum.Edit);
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            tb_Sys_Button temp = tbSysButtonBindingSource.Current as tb_Sys_Button;
            SysButtonEditForm edit = new SysButtonEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                tbSysButtonBindingSource.CancelEdit();
            }
        }
    }
}
