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

namespace ERP.Winform.Supplier.Report
{
    public partial class PurPlanMatForm : ListForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        public PurPlanMatForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.purPlanMatViewModelBindingSource.DataSource = purPlanService.GetPurPlanMatList();
        }
    }
}
