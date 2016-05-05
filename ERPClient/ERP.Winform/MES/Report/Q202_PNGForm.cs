using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraSplashScreen;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace ERP.Winform.MES.Report
{
    public partial class Q202_PNGForm : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public Q202_PNGForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载初始化
        /// </summary>
        public override void OnAttachEvent()
        {
            txtProdDt1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtProdDt2.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public override void InitData()
        {
            if (task1 != null && !task1.IsCompleted)
                return;
            DateTime lbStart;
            DateTime lbEnd;
            lbStart = txtProdDt1.DateTime.Date;
            lbEnd = txtProdDt2.DateTime.Date;
            if (lbStart > lbEnd)
            {
                throw new AppException("结束时间不能大于开始时间,请检查");
            }
            task1 = new Task(() =>
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(LoadWaitForm));
                    var models = viewService.GetQ202PNG(lbStart, lbEnd);
                    this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
                    {
                        this.pivotGridControl1.DataSource = models;
                        this.pivotGridControl1.BestFit();
                    }));
                }
                catch (Exception ef)
                {
                    XtraMessageBox.Show(ef.Message);
                }
                finally
                {
                    SplashScreenManager.CloseForm();
                }
            });
            task1.Start();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void pivotGridControl1_CustomSummary(object sender, DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs e)
        {
            decimal firstn = 0;
            decimal sumn = 0;
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            if (e.DataField == filedQcPer)
            {
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldPNGQtyInK1]); ;
                    sumn += Convert.ToDecimal(row[fieldinqtyink1]);
                    if (sumn != 0)
                        e.CustomValue = firstn / sumn;
                }
            }
        }

        private void pivotGridControl1_CustomDrawCell(object sender, PivotCustomDrawCellEventArgs e)
        {
            Rectangle r;
            //Brush backBrush;
            r = e.Bounds;
            if (e.Value != null && Convert.ToSingle(e.Value) == 0)
            {
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                  new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
                e.Handled = true;
            }
        }
    }
}
