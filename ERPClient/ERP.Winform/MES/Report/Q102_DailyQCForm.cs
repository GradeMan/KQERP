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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
namespace ERP.Winform.MES.Report
{
    public partial class Q102_DailyQCForm : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public Q102_DailyQCForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            txtProdDt1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtProdDt2.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            
            ShowData();
        }

        public void ShowData()
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
                    var models = viewService.GetDailyQC(lbStart, lbEnd);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e)
        {
            //Rectangle r;
            //if (e.RowValueType == PivotGridValueType.GrandTotal)
            //{
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.LightBlue,
            //        Color.FromArgb(0x00, 0x66, 0xFF), LinearGradientMode.Vertical), e.Bounds);
            //    r = Rectangle.Inflate(e.Bounds, -3, -3);
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(0x00, 0x66, 0xFF),
            //        Color.LightSkyBlue, LinearGradientMode.Vertical), r);
            //    e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
            //        new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
            //    e.Handled = true;
            //    return;
            //}
            //if (e.RowValueType == PivotGridValueType.Total)
            //{
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.LightBlue,
            //        Color.FromArgb(0x33, 0x66, 0xFF), LinearGradientMode.Vertical), e.Bounds);
            //    r = Rectangle.Inflate(e.Bounds, -3, -3);
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(0x33, 0x66, 0xFF),
            //        Color.LightSkyBlue, LinearGradientMode.Vertical), r);
            //    e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
            //        new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
            //    e.Handled = true;
            //    return;
            //}
        }

        private void pivotGridControl1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {
            decimal inqty = 0;
            decimal ngqty = 0;
            decimal iqcngqty = 0;
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            if (e.DataField == FieldNGRate)
            { //报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    inqty += Convert.ToDecimal(row[fieldInQty1]);//投入
                    ngqty += Convert.ToDecimal(row[fieldNgQty]);//报废
                    iqcngqty += Convert.ToDecimal(row[fieldIQCNGQty1]);//iqc报废
                    if (inqty != 0)
                        e.CustomValue = (ngqty + iqcngqty) / (inqty + iqcngqty);

                }
            }
        }

        private void pivotGridControl1_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e)
        {
            if (e.DataField == FieldNGRate && e.ColumnValueType == PivotGridValueType.Value && e.RowValueType == PivotGridValueType.Value)
            {
                if (e.Value != null && Convert.ToSingle(e.Value) > 0.1)
                {
                    e.Appearance.BackColor = Color.Red;

                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
                }
            }
        }
    }
}
