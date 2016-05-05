using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using COM.Service;
using ERP.Service;

namespace ERP.Winform.Supplier.Report
{
    public partial class PurPlanDetailForm : ListForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        public PurPlanDetailForm()
        {
            InitializeComponent();
            this.purPlanHeaderModelBindingSource.DataSource = purPlanService.GetPurPlanDetailList();
        }
    }
}
