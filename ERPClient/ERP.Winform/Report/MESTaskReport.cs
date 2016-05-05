using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ERP.Domain;
using COM.Service;

namespace ERP.Winform.Report
{
    public partial class MESTaskReport : DevExpress.XtraReports.UI.XtraReport
    {
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public MESTaskReport()
        {
            InitializeComponent();
            xrLabel1.Text = appCacheService.GetItem("CompName") as string;
        }
        private List<MES_M202_Task_Detail> taskDetailList;
        public MESTaskReport(List<MES_M202_Task_Detail> taskDetailList)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = taskDetailList;
            this.taskDetailList = taskDetailList;
        }
    }
}
