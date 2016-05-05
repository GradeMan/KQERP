using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ERP.Service;
using COM.Service;

namespace ERP.Winform.Supplier.Report
{
    public partial class PurSubReport : DevExpress.XtraReports.UI.XtraReport
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        public PurSubReport(string purPlNo)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = purPlanService.GetPurMaterialList(purPlNo);
        }

    }
}
