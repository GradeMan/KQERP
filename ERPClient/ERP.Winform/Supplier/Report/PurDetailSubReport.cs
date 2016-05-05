using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ERP.Service;
using COM.Service;

namespace ERP.Winform.Supplier.Report
{
    public partial class PurDetailSubReport : DevExpress.XtraReports.UI.XtraReport
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        public PurDetailSubReport(string purPlNo)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = purPlanService.GetPurDetailList(purPlNo);
        }

    }
}
