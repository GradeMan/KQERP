using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.Domain;
using ERP.Service;
using COM.Service;
using DevExpress.DashboardCommon;
namespace ERP.Winform.SysModule
{
    public partial class DashboardDesignerForm : DevExpress.XtraEditors.XtraForm
    {
        private IOrderService orderService = Unity.Instance.GetService<IOrderService>();
        public DashboardDesignerForm()
        {
            InitializeComponent();
            var orderList = this.orderService.GetOrderDashboardModelListGroupByMouth();
            Dashboard orderDashboard = new Dashboard();
            DataSource orderDataSource = new DataSource("Order",orderList);
            orderDashboard.DataSources.Add(orderDataSource);
            this.dashboardDesigner1.Dashboard = orderDashboard;
        }
    }
}