using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ERP.Domain;
using ERP.Service;
using ERP.Winform.CommonModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace ERP.Winform.MES
{
    public partial class MES201PlanMaterialViewForm : ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public MES201PlanMaterialViewForm()
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
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
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
                    var models = viewService.GetPlanProductMaterialView(query);
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
                PrintHelper.Print(this.pivotGridControl1, "计划物料", appCacheService.GetItem("CompName") as string);
            }
        }
    }
}
