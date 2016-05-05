using COM.Service;
using COM.Winform;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP.Winform.View
{
    public partial class JobListForm : ListForm
    {
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public JobListForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.gridControl1.DataSource = viewService.GetJobView(new QueryJobView() { PartName = "DIP-14L-A3" });
            this.gridView1.BestFitColumns();
        }
    }
}
