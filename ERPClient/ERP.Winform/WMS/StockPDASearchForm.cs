using COM.Service;
using COM.Winform;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP.Winform.WMS
{
    public partial class StockPDASearchForm : ListForm
    {
        private IWMS_M101_StockTx_DataService stockTxDataServer = Unity.Instance.GetService<IWMS_M101_StockTx_DataService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        public StockPDASearchForm()
        {
            InitializeComponent();
        }
        public override void OnAttachEvent()
        {
            var custData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(txtCustomer, custData, 3);
            var partData = productService.GetProductInputData();
            SetGridLookUpEdit(txtProduct, partData, 3);
            this.dateTxdt.DateTime = dateTxdt2.DateTime = DateTime.Now.Date;

        }
        public override void InitData()
        {
            var models = stockTxDataServer.GetStockTx_DataQuery();
            if (!string.IsNullOrWhiteSpace(txtArCode.Text))
            {
                models = models.Where(a => a.ARCode == txtArCode.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(this.txtLotNo.Text))
            {
                models = models.Where(a => a.LotNo == txtLotNo.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(this.txtProduct.Text))
            {
                string partno = txtProduct.EditValue.ToString();
                models = models.Where(a => a.PartNo == partno);
            }
            if (!string.IsNullOrWhiteSpace(this.txtOptype.Text))
            {
                string optype = txtOptype.EditValue.ToString();
                models = models.Where(a => a.OPType == optype);
            }
            if (!string.IsNullOrWhiteSpace(this.txtCustomer.Text))
            {
                string custCode = txtCustomer.EditValue.ToString();
                models = models.Where(a => a.CustCode == custCode);
            }
            if (!string.IsNullOrWhiteSpace(dateTxdt.Text) && !string.IsNullOrWhiteSpace(dateTxdt2.Text))
            {
                models = models.Where(a => a.TxDt >= dateTxdt.DateTime.Date && a.TxDt <= dateTxdt2.DateTime.Date);
            }
            wMSM101StockTxDataBindingSource.DataSource = models.ToList();
            this.gridView1.BestFitColumns();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
