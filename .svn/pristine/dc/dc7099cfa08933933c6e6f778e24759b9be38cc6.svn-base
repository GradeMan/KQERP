using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using COM.Service;
using ERP.Service;

namespace ERP.Winform.Supplier.Report
{
    public partial class PurPlanDetailSubReport : DevExpress.XtraReports.UI.XtraReport
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        public PurPlanDetailSubReport(string purPlNo)
        {
            InitializeComponent();
            this.DataSource = purPlanService.GetPurDetailList(purPlNo);
            
        }

    }
}
