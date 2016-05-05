using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
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
    public partial class P106_ActMat_Daily : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public P106_ActMat_Daily()
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
            if (txtProdDt1.DateTime > txtProdDt2.DateTime)
            {
                throw new AppException("结束时间不能大于开始时间,请检查");
            }
            if (string.IsNullOrWhiteSpace(txtProdDt1.Text) || string.IsNullOrWhiteSpace(txtProdDt2.Text))
                throw new AppException("请先输入日期");
            task1 = new Task(() =>
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(LoadWaitForm));
                    var models = viewService.GetP106ActMatDaily(txtProdDt1.DateTime.Date, txtProdDt2.DateTime.Date);
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
    }
}
