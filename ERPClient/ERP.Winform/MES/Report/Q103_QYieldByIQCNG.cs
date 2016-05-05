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
using System.Threading.Tasks;
using ERP.Service;
using COM.Service;
using DevExpress.XtraSplashScreen;
using System.Threading;
using Util;
using DevExpress.XtraPivotGrid;

namespace ERP.Winform.MES.Report
{
    public partial class Q103_QYieldByIQCNG : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public Q103_QYieldByIQCNG()
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
                    var models = viewService.GetQYieldIQCNG(lbStart, lbEnd);
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
            if (e.DataField == colNgQtyPercent)
            { //报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldInQty1]);//冲压投入
                    sumn += Convert.ToDecimal(row[fieldNgQty1]);//冲压报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == colPNGQtyPercent)
            { //冲压报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldPinqtyink1]) + Convert.ToDecimal(row[fieldPIQCNGQtyInk1]);//冲压投入
                    sumn += Convert.ToDecimal(row[fieldPNGQtyInK1]) + Convert.ToDecimal(row[fieldPIQCNGQtyInk1]);//冲压报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == colENGQtyPercent)
            { //电镀报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldEinqtyink1]) + Convert.ToDecimal(row[fieldEIQCNGQtyInk1]);//投入
                    sumn += Convert.ToDecimal(row[fieldENGQtyInK1]) + Convert.ToDecimal(row[fieldEIQCNGQtyInk1]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == colCNGQtyPercent)
            { //切断报废率pivotGridField19
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldCinqtyink1]) + Convert.ToDecimal(row[fieldCIQCNGQtyInk1]);//投入
                    sumn += Convert.ToDecimal(row[fieldCNGQtyInK1]) + Convert.ToDecimal(row[fieldCIQCNGQtyInk1]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == colFNGQtyPercent)
            {//其他报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[fieldFinqtyink1]) + Convert.ToDecimal(row[fieldFIQCNGQtyInk1]);//投入
                    sumn += Convert.ToDecimal(row[fieldFNGQtyInK1]) + Convert.ToDecimal(row[fieldFIQCNGQtyInk1]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
        }
    }
}