using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ERP.Winform.SysModule.DashboardModules
{
    public partial class DashboardMain : DevExpress.XtraEditors.XtraForm
    {
        public DashboardMain()
        {
            InitializeComponent();
            DashboardBaseControl con = new DashboardBaseControl();
            con.Dock = DockStyle.Fill;
            this.Controls.Add(con);
        }
    }
}