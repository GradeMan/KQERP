using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Service;
using COM.Service;

namespace ERP.Winform.WMS
{
    public partial class StockTxListForm : ListForm
    {
        private IWMSStockTxService stockTxService = Unity.Instance.GetService<IWMSStockTxService>();
        public StockTxListForm()
        {
            InitializeComponent();

        }

    }
}
