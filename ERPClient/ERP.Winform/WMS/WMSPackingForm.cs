using COM.Domain;
using COM.Service;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using ERP.Winform.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;

namespace ERP.Winform.WMS
{
    public partial class WMSPackingForm : ListForm
    {
        private IWMS_M104_Packing_HdService packingService = Unity.Instance.GetService<IWMS_M104_Packing_HdService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        public WMSPackingForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.wMSM104PackingHdBindingSource.CurrentChanged += wMSM104PackingHdBindingSource_CurrentChanged;
            this.wMSM104PackingHdBindingSource.DataSource = packingService.GetList();

        }

        void wMSM104PackingHdBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            WMS_M104_Packing_Hd tempData = this.wMSM104PackingHdBindingSource.Current as WMS_M104_Packing_Hd;
            if (tempData != null)
                this.wMSM104PackingDetailBindingSource.DataSource = packingService.GetDetailList(tempData.Id);
            else
                this.wMSM104PackingDetailBindingSource.DataSource = null;
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.wMSM104PackingHdBindingSource.AddNew();
                WMS_M104_Packing_Hd temp = this.wMSM104PackingHdBindingSource.Current as WMS_M104_Packing_Hd;
                temp.Code = "NINGBO KANGQIANG ELECTRONICS CO.,LTD";
                OpenForm("装箱单新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("装箱单修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    WMS_M104_Packing_Hd tempData = this.wMSM104PackingHdBindingSource.Current as WMS_M104_Packing_Hd;
                    packingService.Delete(tempData.Id);
                    this.wMSM104PackingHdBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Print)
            {
                WMS_M104_Packing_Hd temp = this.wMSM104PackingHdBindingSource.Current as WMS_M104_Packing_Hd;
                if (temp == null)
                    throw new AppException("请先选择数据");
                PackingListReport reportFrm = new PackingListReport(temp.Id);
                ReportShowForm reportShowFrm = new ReportShowForm(reportFrm);
                reportShowFrm.Text = "装箱单-" + temp.CustCode;
                reportShowFrm.ShowDialog();
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            WMS_M104_Packing_Hd temp = this.wMSM104PackingHdBindingSource.Current as WMS_M104_Packing_Hd;
            WMSPackingEditForm edit = new WMSPackingEditForm(temp, packingService);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.wMSM104PackingHdBindingSource.CancelEdit();
            }
            else
            {
                wMSM104PackingHdBindingSource_CurrentChanged(null, null);
            }
        }
    }
}
