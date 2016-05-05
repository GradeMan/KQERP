using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ERP.Winform.Report
{
    public partial class JobLot_CulaInner2 : DevExpress.XtraReports.UI.XtraReport
    {
        public JobLot_CulaInner2(int rowCount)
        {
            InitializeComponent();
            for (int i = 1; i < rowCount; i++)
            {
                xrTable4.InsertRowBelow(xrTableRow1);
            }
        }

    }
}
