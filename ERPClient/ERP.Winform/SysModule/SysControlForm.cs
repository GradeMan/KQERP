using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using COM.Service;
using ERP.Service;
using ERP.Domain;

namespace ERP.Winform.SysModule
{
    public partial class SysControlForm : ListForm
    {
        private Itb_Sys_ControlsService controlService = Unity.Instance.GetService<Itb_Sys_ControlsService>();
        public SysControlForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.tbSysControlsBindingSource.DataSource = controlService.GetList();
            
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.tbSysControlsBindingSource.AddNew();
                OpenForm("公司资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("公司资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    tb_Sys_Controls user = this.tbSysControlsBindingSource.Current as tb_Sys_Controls;
                    controlService.Delete(user.Id);
                    this.tbSysControlsBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            tb_Sys_Controls temp = this.tbSysControlsBindingSource.Current as tb_Sys_Controls;
            SysControlEditForm edit = new SysControlEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.tbSysControlsBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("公司资料查看", BtnCommandEnum.Watch);
        }
    }
}
