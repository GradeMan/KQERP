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
    public partial class Q101_DailyQCSummaryForm : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public Q101_DailyQCSummaryForm()
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
            int iqc = 0;

            if (chkiqc.Checked)
            {
                iqc = 1;
            }
           lbStart = txtProdDt1.DateTime.Date;
           lbEnd = txtProdDt2.DateTime.Date;
           if (lbStart > lbEnd)
           {
               throw new Exception("结束时间不能大于开始时间,请检查");
           }
           task1 = new Task(() =>
               {
                   try
                   {
                       SplashScreenManager.ShowForm(typeof(LoadWaitForm));
                       var models = viewService.GetDailyQCSummary(lbStart, lbEnd, iqc);
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
            decimal firstn = 0;
            decimal sumn = 0;
            decimal second = 0;
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            if (e.DataField == TDNGRate)
            {
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldTDInQty1]); ;
                    sumn += Convert.ToDecimal(row[fieldTDNgQty1]);
                    second += Convert.ToDecimal(row[fieldTDIQCNGQty1]);
                    if ((firstn + second) != 0)
                        e.CustomValue = (sumn + second) / (firstn + second);

                }
            }
            else if (e.DataField == NGRate)
            {
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldInQty1]); ;
                    sumn += Convert.ToDecimal(row[fieldNgQty1]);
                    second += Convert.ToDecimal(row[fieldIQCNGQty1]);
                    if ((firstn + second) != 0)
                        e.CustomValue = (sumn + second) / (firstn + second);

                }
            }
        }

        private void pivotGridControl1_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e)
        {
            if (e.DataField == NGRate && e.ColumnValueType == PivotGridValueType.Value && e.RowValueType == PivotGridValueType.Value)
            {
                if (e.Value != null && Convert.ToSingle(e.Value) > 0.9)
                {
                    if (Convert.ToSingle(e.Value) > 1)
                        e.Appearance.BackColor = Color.Red;
                    else if (Convert.ToSingle(e.Value) > 0.9 && Convert.ToSingle(e.Value) < 1)
                        e.Appearance.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
                }
            }
            if (e.DataField == TDNGRate && e.ColumnValueType == PivotGridValueType.Value && e.RowValueType == PivotGridValueType.Value)
            {
                if (e.Value != null && Convert.ToSingle(e.Value) > 0.9)
                {
                    if (Convert.ToSingle(e.Value) > 1)
                        e.Appearance.BackColor = Color.Red;
                    else if (Convert.ToSingle(e.Value) > 0.9 && Convert.ToSingle(e.Value) < 1)
                        e.Appearance.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
                }
            }
        }
    }
}
