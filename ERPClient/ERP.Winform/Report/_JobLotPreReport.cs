﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ERP.Domain;

namespace ERP.Winform.Report
{
    public partial class _JobLotPreReport : DevExpress.XtraReports.UI.XtraReport
    {
        
        public _JobLotPreReport(List<MES_M202_Task_Detail> taskDetailList)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = taskDetailList;
        }

    }
}
