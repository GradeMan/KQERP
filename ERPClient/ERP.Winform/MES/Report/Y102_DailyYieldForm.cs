using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;
namespace ERP.Winform.MES.Report
{
    public partial class Y102_DailyYieldForm : ListForm
    {
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public Y102_DailyYieldForm()
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
            DateTime lbStart;
            DateTime lbEnd;
            try
            {
                lbStart = txtProdDt1.DateTime.Date;
                lbEnd = txtProdDt2.DateTime.Date;
                if (lbStart > lbEnd)
                {
                    XtraMessageBox.Show("结束时间不能大于开始时间,请检查");
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("输入的时间格式不正确，请查阅");
                return;
            }
           
            this.pivotGridControl1.DataSource = viewService.GetDailyYield(lbStart, lbEnd);
            this.pivotGridControl1.BestFit();
            //this.gridView1.BestFitColumns();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e)
        {
            Rectangle r;
            if (e.RowValueType == PivotGridValueType.GrandTotal)
            {
                e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.LightBlue,
                    Color.FromArgb(0x00, 0x66, 0xFF), LinearGradientMode.Vertical), e.Bounds);
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(0x00, 0x66, 0xFF),
                    Color.LightSkyBlue, LinearGradientMode.Vertical), r);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                    new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
                e.Handled = true;
                return;
            }
            if (e.RowValueType == PivotGridValueType.Total)
            {
                e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.LightBlue,
                    Color.FromArgb(0x33, 0x66, 0xFF), LinearGradientMode.Vertical), e.Bounds);
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(0x33, 0x66, 0xFF),
                    Color.LightSkyBlue, LinearGradientMode.Vertical), r);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                    new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
                e.Handled = true;
                return;
            }
        }

        private void pivotGridControl1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {
            decimal firstn = 0;
            decimal sumn = 0;
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            if (e.DataField == fieldRate)
            {
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldPlanQty1]); ;
                    sumn += Convert.ToDecimal(row[fieldOutQty1]);
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
        }
    }
}
