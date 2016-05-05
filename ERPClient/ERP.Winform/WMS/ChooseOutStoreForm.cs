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
using ERP.Service;
using COM.Service;

namespace ERP.Winform.WMS
{
    public partial class ChooseOutStoreForm : EditForm
    {
        private IWMS_C103_StockService stockService = Unity.Instance.GetService<IWMS_C103_StockService>();
        public ChooseOutStoreForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var stockData = stockService.GetQueryStock();
            if (string.IsNullOrWhiteSpace(txtMatCode.Text))
                stockData = stockData.Where(a => a.MatClass2 == txtMatCode.Text);

        }
    }
}