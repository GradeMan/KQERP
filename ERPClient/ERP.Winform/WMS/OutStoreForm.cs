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

namespace ERP.Winform.WMS
{
    public partial class OutStoreForm : ListForm
    {
        private IWMS_C104_OutStoreService outStoreService = Unity.Instance.GetService<IWMS_C104_OutStoreService>();
        public OutStoreForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.wMSC104OutStoreBindingSource.DataSource = outStoreService.GetList();

        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.wMSC104OutStoreBindingSource.AddNew();
                OpenForm("出仓资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("出仓资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    WMS_C104_OutStore tempData = this.wMSC104OutStoreBindingSource.Current as WMS_C104_OutStore;
                    outStoreService.Delete(tempData.Id);
                    this.wMSC104OutStoreBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            WMS_C104_OutStore temp = this.wMSC104OutStoreBindingSource.Current as WMS_C104_OutStore;
            OutStoreEditForm edit = new OutStoreEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.wMSC104OutStoreBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("进仓资料查看", BtnCommandEnum.Watch);
        }

        private void OutStoreForm_Load(object sender, EventArgs e)
        {
            this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
        }
    }
}
