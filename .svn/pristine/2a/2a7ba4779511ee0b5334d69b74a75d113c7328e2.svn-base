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

namespace ERP.Winform.ESOP
{
    public partial class ESOPDeviceEditForm : EditForm
    {
        private IESOP_DeviceService devService = Unity.Instance.GetService<IESOP_DeviceService>();
        private ESOP_Device tempData;
        public ESOPDeviceEditForm(ESOP_Device tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            //ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("IST"), 2);//状态
            this.eSOPDeviceBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForDevName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eSOPDeviceBindingSource.EndEdit();
                devService.Save(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
