using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Service;
using COM.Service;
using DevExpress.XtraSplashScreen;
using System.Threading.Tasks;
using Util;
using DevExpress.XtraPivotGrid;
using System.Drawing.Drawing2D;

namespace ERP.Winform.MES.Report
{
    public partial class Q201_NGForm : ListForm
    {
        Task task1;
        PivotGridField percents;
        PivotGridField percents2;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public Q201_NGForm()
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
                    var models = viewService.GetNGDetail(lbStart, lbEnd);
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

        private void Q201_NGForm_Load(object sender, EventArgs e)
        {
            percents = pivotGridControl1.Fields.Add(fieldNGItemQty1.FieldName, PivotArea.DataArea);
            percents.Caption = "占比(行)";
            percents.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRow;
            percents2 = pivotGridControl1.Fields.Add(fieldNGItemQty1.FieldName, PivotArea.FilterArea);
            percents2.Caption = "占比(列)";
            percents2.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
        }

        private void pivotGridControl1_CustomDrawCell(object sender, PivotCustomDrawCellEventArgs e)
        {
            Rectangle r;
            if (e.RowValueType == PivotGridValueType.GrandTotal)
            {
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.Blue,
                    Color.LightSkyBlue, LinearGradientMode.Vertical), r);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                   new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
                e.Handled = true;
                return;
            }
            if (e.RowValueType == PivotGridValueType.Total)
            {
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(0x00, 0xCC, 0xFF),
                    Color.LightSkyBlue, LinearGradientMode.Vertical), r);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                   new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
                e.Handled = true;
                return;
            }
            if (e.Selected)
            {
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                  new SolidBrush(Color.FromArgb(0x33, 0x66, 0xFF)), r, e.Appearance.GetStringFormat());
                e.Handled = true;
            }
            else if (e.DataField == percents)
            {
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                  new SolidBrush(Color.FromArgb(0x00, 0xCC, 0xFF)), r, e.Appearance.GetStringFormat());
                e.Handled = true;
            }
            else if (e.DataField == percents2)
            {
                r = Rectangle.Inflate(e.Bounds, -3, -3);
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
                  new SolidBrush(Color.FromArgb(0x99, 0xCC, 0xFF)), r, e.Appearance.GetStringFormat());
                e.Handled = true;
            }
        }
    }
}