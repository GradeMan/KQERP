using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;
using ERP.Service;
using COM.Service;
using System.IO;
using Util;

namespace ERP.Winform.SysModule.DashboardModules
{
    public partial class DashboardBaseControl : DevExpress.XtraEditors.XtraUserControl
    {
        private IOrderService orderService = Unity.Instance.GetService<IOrderService>();
        public DashboardBaseControl()
        {
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            this.dashboardViewer1.LoadDashboard(FileStreamHelp.FileToStream("OrderInfo.xml"));
           // this.dashboardViewer1.Dashboard.LoadFromXml()
            //this.dashboardViewer1.LoadDashboard
            var orderList = this.orderService.GetOrderDashboardModelListGroupByMouth();
            dashboardViewer1.Dashboard.DataSources[0].Data = orderList;
            dashboardViewer1.Dashboard.Title.Text = "订单查看";
            //DataSource orderDataSource = new DataSource("Order", orderList);
            
            //db.DataSources.Add(orderDataSource);
            //dashboardViewer1.Dashboard = db;
        }
        protected Dashboard Dashboard
        {
            get { return dashboardViewer1.Dashboard; }
            set
            {
                if (value != Dashboard)
                {
                    DisposeDashboard();
                    dashboardViewer1.Dashboard = value;
                }
            }
        }
        void DisposeDashboard()
        {
            Dashboard dashboard = Dashboard;
            if (dashboard != null)
                dashboard.Dispose();
        }
    }
}
