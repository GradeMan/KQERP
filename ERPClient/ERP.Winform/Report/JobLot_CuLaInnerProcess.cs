using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ERP.Domain;
using ERP.Service;
using COM.Service;

namespace ERP.Winform.Report
{
    public partial class JobLot_CuLaInnerProcess : DevExpress.XtraReports.UI.XtraReport
    {
        //private IProductService productService = Unity.Instance.GetService<IProductService>();
        public JobLot_CuLaInnerProcess(List<ERP_M001_Product_ProdInfo> prodInfoList)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = prodInfoList;
        }

    }
}
