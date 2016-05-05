using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ERP.Domain.Order.ViewModel;
using ERP.Service;
using COM.Service;
namespace ERP.Winform.Order.Report
{
    public partial class JobReport : DevExpress.XtraReports.UI.XtraReport
    {
        private IProductProdInfoService productProdInfoService = Unity.Instance.GetService<IProductProdInfoService>();
        
        public JobReport(JobReportModel model)
        {
            InitializeComponent();
            BindData(model);
        }

        private void BindData(JobReportModel model)
        {
            this.bindingSource5.DataSource = model.JobReportHeaderList;
            this.bindingSource1.DataSource = model.JobReportDetailList;
        }

        private void xrTableCell6_TextChanged(object sender, EventArgs e)
        {
            this.DetailReport.FilterString = String.Format(" LotNo = '{0}'", txtLotNo.Text);
            //this.txtBarCode.Text = txtJobNo.Text + "-" + txtLotNo.Text;
            
        }

        //生产制程
        private void xrTableCell14_TextChanged(object sender, EventArgs e)
        {
            xrTableCell77.Lines = productProdInfoService.GetListByItemAndPocessCode(txtItemCode.Text.Trim(), txtProcessCode.Text.Trim());
        }

    }
}
