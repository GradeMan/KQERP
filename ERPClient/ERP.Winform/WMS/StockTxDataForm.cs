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
using ERP.Winform.Report;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraPrinting;
using COM.Domain;
namespace ERP.Winform.WMS
{
    public partial class StockTxDataForm : ListForm
    {
        private IWMS_M101_StockTx_DataService stockTxDataServer = Unity.Instance.GetService<IWMS_M101_StockTx_DataService>();
        public StockTxDataForm()
        {
            InitializeComponent();
            dateProdDt.DateTime = DateTime.Now.Date;
            dateProdDtTo.DateTime = DateTime.Now.Date;
        }
        public override void OnAttachEvent()
        {
            var custData = stockTxDataServer.GetDeliveryDtlQuery().Select(a => new { a.CustCode,a.CustName}).Distinct().ToList().Select(a => new InputItem { DisPlayName = a.CustName, Value = a.CustCode, InputCode1 = a.CustCode }).ToList();
            SetGridLookUpEdit(txtCustCode, custData, 1);
            var partData = stockTxDataServer.GetDeliveryDtlQuery().Select(a => new { a.PartNo, a.PartType }).Distinct().ToList().Select(a => new InputItem { DisPlayName = a.PartType, Value = a.PartNo, InputCode1 = a.PartNo }).ToList();
            SetGridLookUpEdit(txtPartNo, partData, 1);
        }
        public override void InitData()
        {
            var model = stockTxDataServer.GetDeliveryDtlQuery();
            model = model.Where(a => a.PartNo != null);
            if (!string.IsNullOrWhiteSpace(txtDocNo.Text))
                model = model.Where(a => a.DocNo == txtDocNo.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtCustCode.Text))
            {
                string custCode = txtCustCode.EditValue.ToString();
                model = model.Where(a => a.CustCode == custCode);
            }
            if (!string.IsNullOrWhiteSpace(txtPartNo.Text))
            {
                string partType = txtPartNo.EditValue.ToString();
                model = model.Where(a => a.PartType == partType);
            }
            if (!string.IsNullOrWhiteSpace(dateProdDt.Text) && !string.IsNullOrWhiteSpace(dateProdDtTo.Text))
            {
                DateTime prodDt = dateProdDt.DateTime.Date;
                DateTime prodDtTo = dateProdDtTo.DateTime.Date.AddDays(1);
                model = model.Where(a => a.TxDt >= prodDt && a.TxDt <= prodDtTo);
            }
            this.vwSALER101DeliveryDtlBindingSource.DataSource = model.ToList();
            this.gridView1.BestFitColumns();
        }

        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.TSDelivery)
            {
                List<vwSALE_R101_Delivery_Dtl> deliveryList = new List<vwSALE_R101_Delivery_Dtl>();
                var model = this.vwSALER101DeliveryDtlBindingSource.DataSource as List<vwSALE_R101_Delivery_Dtl>;
                var mlotNoData = model.Select(a => a.MLotNo).Distinct();
                foreach (var mlotNo in mlotNoData)
                {
                    var boxQty = model.Where(a => a.MLotNo == mlotNo).Sum(a => a.BoxQty);
                    var delivery = model.Where(a => a.MLotNo == mlotNo).First();
                    delivery.BoxQty = boxQty;
                    delivery.SumAmount = boxQty * delivery.PerQty;
                    deliveryList.Add(delivery);
                }
                StockTxDataReport reportFrm = new StockTxDataReport(deliveryList);
                ReportShowForm reportShowFrm = new ReportShowForm(reportFrm);
                reportShowFrm.ShowDialog();
                //PrintingSystem printingSystem1 = reportFrm.PrintingSystem as PrintingSystem;
                //PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
                ////printingSystem1.Links.Add(printableComponentLink1);
                //printableComponentLink1.Landscape = true;
                //printableComponentLink1.ClearDocument();
                //printableComponentLink1.ShowPreview();
            }
            else if (e.Item.Caption == BtnCommandEnum.Print)
            {
                PrintHelper.Print(ykGridControl1, "宁波康强电子", "送货单明细");
            }
            else if (e.Item.Caption == BtnCommandEnum.FHDelivery)
            {
                List<vwSALE_R101_Delivery_Dtl> deliveryList = new List<vwSALE_R101_Delivery_Dtl>();
                var model = this.vwSALER101DeliveryDtlBindingSource.DataSource as List<vwSALE_R101_Delivery_Dtl>;
                var lotNoData = model.Select(a => a.LotNo).Distinct();
                foreach (var lotNo in lotNoData)
                {
                    var boxQty = model.Where(a => a.LotNo == lotNo).Sum(a => a.BoxQty);
                    var delivery = model.Where(a => a.LotNo == lotNo).First();
                    delivery.BoxQty = boxQty;
                    delivery.SumAmount = boxQty * delivery.PerQty;
                    deliveryList.Add(delivery);
                }
                DeliverReport reportFrm = new DeliverReport(deliveryList);
                ReportShowForm reportShowFrm = new ReportShowForm(reportFrm);
                reportShowFrm.ShowDialog();
            }
        }

        private void ykGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
