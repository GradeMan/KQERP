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

namespace ERP.Winform.MES
{
    public partial class MES201PlanProductViewForm : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        public MES201PlanProductViewForm()
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
            var productData = productService.GetProductInputData();
            SetGridLookUpEdit(txtProduct, productData, 1);
            var customerData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(txtCustomer, customerData, 1);
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
                    var query = new QueryMESPlanView() { TxDt = lbStart, TxDt2 = lbEnd, CustNo = txtCustomer.EditValue.ToStr(), PartNo = txtProduct.EditValue.ToStr(), PlanNo = txtPlanNo.Text, SONo = txtSONo.Text, Status = txtStatus.Text };
                    var models = viewService.GetPlanProductView(query);
                    this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
                    {
                        this.gridControl1.DataSource = models;
                        this.gridView1.BestFitColumns();
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
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Print)
            {
                PrintHelper.Print(this.gridControl1, "计划明细", "冲压框架事业部");
            }
        }
    }
}
