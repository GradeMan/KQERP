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
    public partial class PurDetailReport : DevExpress.XtraReports.UI.XtraReport
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        public PurDetailReport(string purNo)
        {
            InitializeComponent();
            var purPl = purPlanService.GetPurPlan().Where(a => a.PurPlNo == purNo).FirstOrDefault();
            if (purPl != null)
            {
                this.txtPurPlNo.Text = purPl.PurPlNo;
                DateTime txDt = purPl.TxDt ?? DateTime.Now;
                this.txtPurDt.Text = txDt.ToString("yyyy/MM/dd");
                this.bindingSource2.DataSource = purPlanService.GetPurDetailGroupList(purPl.PurPlNo);
                PurDetailSubReport prod = new PurDetailSubReport(purPl.PurPlNo);
                this.xrSubreport1.ReportSource = prod;
            }
        }

    }
}
