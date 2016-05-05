using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ERP.Service;
using COM.Service;
using System.Linq;
namespace ERP.Winform.Supplier.Report
{
    public partial class PurReport : DevExpress.XtraReports.UI.XtraReport
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        private string purPlNo;
        public PurReport(string purNo )
        {
            InitializeComponent();
            this.purPlNo = purNo;
            var purPl = purPlanService.GetPurPlan().Where(a => a.PurPlNo == purNo).FirstOrDefault();
            if (purPl != null)
            {
                this.bindingSource1.DataSource = purPlanService.GetPurHeaderList(purPl.PurPlNo);
                PurSubReport prod = new PurSubReport(purPl.PurPlNo);
                this.xrSubreport1.ReportSource = prod;
                this.txtPurPlNo.Text = purPl.PurPlNo;
                DateTime txDt = purPl.TxDt ?? DateTime.Now;
                this.txtPurDt.Text = txDt.ToString("yyyy/MM/dd");
            }
        }

        private void cellMatCode_TextChanged(object sender, EventArgs e)
        {
            //string matCode = cellMatCode.Text.Trim();
            //this.bindingSource2.DataSource = purPlanService.GetPurDetailList(purPlNo, matCode);
        }

    }
}
