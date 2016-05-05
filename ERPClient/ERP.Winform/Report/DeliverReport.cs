using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ERP.Domain;
using System.Linq;
namespace ERP.Winform.Report
{
    public partial class DeliverReport : DevExpress.XtraReports.UI.XtraReport
    {
        private List<vwSALE_R101_Delivery_Dtl> deliveryList;
        public DeliverReport(List<vwSALE_R101_Delivery_Dtl> deliveryList)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = deliveryList;
            this.deliveryList = deliveryList;
        }

        private void txtMlotNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtlotNo.Text))
            {
                var model = deliveryList.Single(a => a.LotNo == txtlotNo.Text);
                txtlotNoA.Text = txtlotNo.Text.Trim() + "A";
                txtlotNoB.Text = txtlotNo.Text.Trim() + "B";
                decimal qty = Convert.ToDecimal(txtQty.Text);
                txtQtyA.Text = (model.SumAmount??0 / 2).ToString("0");
                txtQtyB.Text = (model.SumAmount??0 / 2).ToString("0");
            }
        }

    }
}
