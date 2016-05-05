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
using ERP.Domain;
using ERP.Domain.Order.ViewModel;

namespace ERP.Winform.SysModule.DashboardModules
{
    public partial class OrderDashboardControl : Dashboard
    {
       // private IOrderService orderService = Unity.Instance.GetService<IOrderService>();
        public OrderDashboardControl()
        {
            InitializeComponent();
            var orderList = new List<OrderDashboardModel>();
            DataSource orderDataSource = new DataSource("Order", orderList);
            this.DataSources.Add(orderDataSource);
        }
    }
}
