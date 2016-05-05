﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using ERP.Service;
using COM.Service;
using DevExpress.XtraSplashScreen;
using COM.Winform;

namespace ERP.Winform.MES.Report
{
    public partial class R105_PlanTrace :ListForm
    {
        Task task1;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public R105_PlanTrace()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载初始化
        /// </summary>
        public override void OnAttachEvent()
        {
            TxtTxDt_S.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            TxtTxDt_E.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            txtProduct.Properties.Items.AddRange(viewService.GetComboxDataByType("Product"));
            txtCustomer.Properties.Items.AddRange(viewService.GetComboxDataByType("Customer"));
        }

        public override void InitData()
        {
            if (task1 != null && !task1.IsCompleted)
                return;
            task1 = new Task(() =>
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(LoadWaitForm));
                    var models = viewService.GetPlanTraceList(new QueryR103JobTxDetailView { ProdDt = TxtTxDt_S.Text, ProdDt2 = TxtTxDt_E.Text, PartNo = txtProduct.Text, CustName = txtCustomer.Text });
                    this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
                    {
                        this.r105PlanTraceBindingSource.DataSource = models;
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}