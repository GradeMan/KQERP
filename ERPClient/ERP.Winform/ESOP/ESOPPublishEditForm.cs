using COM.Service;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Domain;

namespace ERP.Winform.ESOP
{
    public partial class ESOPPublishEditForm : EditForm
    {
        private IESOP_PublishService publishService = Unity.Instance.GetService<IESOP_PublishService>();
        private IESOP_DeviceService deviceService = Unity.Instance.GetService<IESOP_DeviceService>();
        private IESOP_DocIndexService docIndexServer = Unity.Instance.GetService<IESOP_DocIndexService>();
        private IESOP_DocService docServer = Unity.Instance.GetService<IESOP_DocService>();
        private ESOP_Publish tempData;
        public ESOPPublishEditForm(ESOP_Publish tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            //ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("IST"), 2);//状态
            //if (tempData.CreateUser != null)
                //tempData = publishService.GetById(tempData.Id);
            var deviceData = deviceService.GetDevice().Select(a => new InputItem { DisPlayName = a.DevName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(DevIdTextEdit, deviceData, 0);
            this.DevIdTextEdit.Properties.ValueMember = "Value2";
            var docIndexData = docIndexServer.GetDocIndex().Select(a => new InputItem { DisPlayName = a.DocIndexName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(DocIndexIdTextEdit, docIndexData, 0);
            this.DocIndexIdTextEdit.Properties.ValueMember = "Value2";

            this.eSOPPublishBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForDevId, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eSOPPublishBindingSource.EndEdit();
                publishService.Save(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void DocIndexIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            var docData = docServer.GetDoc().Select(a => new InputItem { DisPlayName = a.DocName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(DocIdTextEdit, docData, 0);
            DocIdTextEdit.Properties.ValueMember = "Value2";
        }
    }
}
