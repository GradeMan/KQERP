using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraSplashScreen;
using ERP.Domain;
using ERP.Service;
using ERP.Winform.CommonModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
namespace ERP.Winform.MES.Report
{
    public partial class Y202_EYieldForm : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private IERP_C009_LayoutService layoutService = Unity.Instance.GetService<IERP_C009_LayoutService>();
        public Y202_EYieldForm()
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
            txtProduct.Properties.Items.AddRange(viewService.GetComboxDataByType("Product"));
            txtCustomer.Properties.Items.AddRange(viewService.GetComboxDataByType("Customer"));
        }

        public override void InitData()
        {
            if (task1 != null && !task1.IsCompleted)
                return;
            if (txtProdDt1.DateTime > txtProdDt2.DateTime)
            {
                throw new AppException("结束时间不能大于开始时间,请检查");
            }
            task1 = new Task(() =>
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(LoadWaitForm));
                    var models = viewService.GetEYield(new QueryEYieldView { proddt1 = txtProdDt1.Text, proddt2 = txtProdDt2.Text, IsInStore = checkInStore.EditValue.ToStr(), IsCheck = checkIsCheck.EditValue.ToStr(), PartNo = txtProduct.Text,CustName = txtCustomer.Text });
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

        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == "保存界面")
            {
                Stream stream = new System.IO.MemoryStream();
                this.pivotGridControl1.SaveLayoutToStream(stream);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                ERP_C009_Layout layout = new ERP_C009_Layout();
                layout.FrmType = this.Name;
                layout.LayFiles = FileStreamHelp.StreamToBytes(stream);
                C009_Layout frm = new C009_Layout(layout);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XtraMessageBox.Show("保存成功");
                }
            }
            else if (e.Item.Caption == "显示表头")
            {
                this.pivotGridControl1.OptionsView.ShowColumnHeaders = !this.pivotGridControl1.OptionsView.ShowColumnHeaders;
                this.pivotGridControl1.OptionsView.ShowDataHeaders = !this.pivotGridControl1.OptionsView.ShowDataHeaders;
                this.pivotGridControl1.OptionsView.ShowFilterHeaders = !this.pivotGridControl1.OptionsView.ShowFilterHeaders;
            }
            else if (e.Item.Caption == BtnCommandEnum.Print)
            {
                PrintHelper.Print(this.pivotGridControl1, "产量统计报表", "冲压框架事业部");
            }
        }

        /// <summary>
        /// 读取界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadLayout_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            var layout = layoutService.GetByType(this.Name, btn.Text);
            if (layout != null)
            {
                Stream stream = FileStreamHelp.BytesToStream(layout.LayFiles);
                this.pivotGridControl1.RestoreLayoutFromStream(stream);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
                this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
                this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            }
            else
            {
                throw new ApplicationException("该界面尚未有保存的模版");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }

    }
}
