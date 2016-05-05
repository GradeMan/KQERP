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
using ERP.Service;
using COM.Service;
using COM.Domain;
using ERP.Domain;

namespace ERP.Winform.WMS
{
    public partial class WMS105MatGetForm : ListForm
    {
        private IWMS_M105_MatGetService matGetService = Unity.Instance.GetService<IWMS_M105_MatGetService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        public WMS105MatGetForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            //SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            this.wMSM105MatGetBindingSource.CurrentChanged += wMSM105MatGetBindingSource_CurrentChanged;
            this.wMSM105MatGetBindingSource.DataSource = matGetService.GetList();

        }

        void wMSM105MatGetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            WMS_M105_MatGet temp = this.wMSM105MatGetBindingSource.Current as WMS_M105_MatGet;
            if (temp != null)
                this.wMSM105MatGetDetailBindingSource.DataSource = matGetService.GetMatDetailQuery().Where(a => a.RequestNo == temp.RequestNo).ToList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.wMSM105MatGetBindingSource.AddNew();
                WMS_M105_MatGet temp = this.wMSM105MatGetBindingSource.Current as WMS_M105_MatGet;
                OpenForm("新增领料单", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("修改领料单", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    WMS_M105_MatGet tempData = this.wMSM105MatGetBindingSource.Current as WMS_M105_MatGet;
                    matGetService.Delete(tempData.Id);
                    this.wMSM105MatGetBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            WMS_M105_MatGet temp = this.wMSM105MatGetBindingSource.Current as WMS_M105_MatGet;
            WMS105MatGetEditForm edit = new WMS105MatGetEditForm(temp, matGetService);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.wMSM105MatGetBindingSource.CancelEdit();
            }
            else
            {
                wMSM105MatGetBindingSource_CurrentChanged(null, null);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("查看领料单", BtnCommandEnum.Watch);
        }
    }
}