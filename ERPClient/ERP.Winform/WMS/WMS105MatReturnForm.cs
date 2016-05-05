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
    public partial class WMS105MatReturnForm : ListForm
    {
        private IWMS_M105_MatReturnService matGetService = Unity.Instance.GetService<IWMS_M105_MatReturnService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        public WMS105MatReturnForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            //SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            this.wMSM105MatReturnBindingSource.CurrentChanged += wMSM105MatReturnBindingSource_CurrentChanged;
            this.wMSM105MatReturnBindingSource.DataSource = matGetService.GetList();

        }

        void wMSM105MatReturnBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            WMS_M105_MatReturn temp = this.wMSM105MatReturnBindingSource.Current as WMS_M105_MatReturn;
            if (temp != null)
                this.wMSM105MatReturnDetailBindingSource.DataSource = matGetService.GetMatDetailQuery().Where(a => a.ReturnNo == temp.ReturnNo).ToList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.wMSM105MatReturnBindingSource.AddNew();
                WMS_M105_MatReturn temp = this.wMSM105MatReturnBindingSource.Current as WMS_M105_MatReturn;
                //temp.ReturnNo = "1001";
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
                    WMS_M105_MatReturn tempData = this.wMSM105MatReturnBindingSource.Current as WMS_M105_MatReturn;
                    matGetService.Delete(tempData.Id);
                    this.wMSM105MatReturnBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            WMS_M105_MatReturn temp = this.wMSM105MatReturnBindingSource.Current as WMS_M105_MatReturn;
            WMS105MatReturnEditForm edit = new WMS105MatReturnEditForm(temp, matGetService);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.wMSM105MatReturnBindingSource.CancelEdit();
            }
            else
            {
                wMSM105MatReturnBindingSource_CurrentChanged(null, null);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("查看领料单", BtnCommandEnum.Watch);
        }
    }
}