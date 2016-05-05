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
using COM.Domain;
using Util;

namespace ERP.Winform.Supplier.Report
{
    public partial class PurReportForm : ReportForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>(); 
        public PurReportForm()
        {
            InitializeComponent();
        }

        public override void InitData()
        {
            var purPlNoData = purPlanService.GetPurPlan().Select(a => new InputItem { DisPlayName = a.PurPlNo, Value = a.PurPlNo }).ToList();
            SetGridLookUpEdit(txtPurPlNo, purPlNoData, 0);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurPlNo.Text))
                throw new AppException("请选择采购单号");
            string purPlNo = txtPurPlNo.EditValue.ToString();
            PurReport jobreport = new PurReport(purPlNo);
            documentViewer1.DocumentSource = jobreport;
            jobreport.CreateDocument();
        }

        private void btnPurDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurPlNo.Text))
                throw new AppException("请选择采购单号");
            string purPlNo = txtPurPlNo.EditValue.ToString();
            PurDetailReport jobreport = new PurDetailReport(purPlNo);
            documentViewer1.DocumentSource = jobreport;
            jobreport.CreateDocument();
        }
    }
}
