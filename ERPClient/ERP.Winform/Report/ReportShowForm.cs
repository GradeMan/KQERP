using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace ERP.Winform.Report
{
    public partial class ReportShowForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportShowForm(XtraReport report)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = report;

            report.CreateDocument();
            report.PrintingSystem.ShowMarginsWarning = false; 
            
        }
    }
}