using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using ERP.Domain;
using System.Collections.Generic;
using System.Linq;
namespace ERP.Winform.Report
{
    public partial class StockTxDataReport : DevExpress.XtraReports.UI.XtraReport
    {
        private List<vwSALE_R101_Delivery_Dtl> deliveryList;
        public StockTxDataReport(List<vwSALE_R101_Delivery_Dtl> deliveryList)
        {
            InitializeComponent();
            foreach (var delivery in deliveryList)
            {
                delivery.SumAmount = delivery.SumAmount / 1000;
                delivery.PerQty = delivery.PerQty / 1000;
            }
            this.bindingSource2.DataSource = deliveryList;
            this.deliveryList = deliveryList;
        }

        private void txtMlotNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMlotNo.Text))
            {
                var model = deliveryList.Single(a => a.MLotNo == txtMlotNo.Text.Trim());
                string code2d = model.CustPartName + Environment.NewLine + model.CustPartType + Environment.NewLine + model.CustPartSpec;
                code2d += Environment.NewLine + model.CustDrawingNo + Environment.NewLine + model.Supplier + Environment.NewLine + model.CustPONo;
                code2d += Environment.NewLine + model.CustPartNo + Environment.NewLine + (model.SumAmount??0).ToString("0.00") + Environment.NewLine + (model.BoxQty??0).ToString("0");
                code2d += Environment.NewLine + model.MLotNo + Environment.NewLine + model.ProdDt + Environment.NewLine + model.ExpDt;
                xrBarCode1.Text = code2d;

            }
        }

    }
}
