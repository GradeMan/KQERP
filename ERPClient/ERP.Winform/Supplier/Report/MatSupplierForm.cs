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
    public partial class MatSupplierForm : ListForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        public MatSupplierForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.purPlanReportViewModelBindingSource.DataSource = purPlanService.GetPPReortList();
            this.gridView1.BestFitColumns();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.SortByMat)
            {
                colMatCode.VisibleIndex = 0;
                colMatName.VisibleIndex = 1;
                colMatName.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            else if (e.Item.Caption == BtnCommandEnum.SortBySupp)
            {
                colSuppCode.VisibleIndex = 0;
                colAlias.VisibleIndex = 1;
                colLevel.VisibleIndex = 2;

                colAlias.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
        }
        
    }
}
