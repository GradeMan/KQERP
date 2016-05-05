using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using ERP.Service;
using ERP.Winform.Hepler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP.Domain;
using DevExpress.XtraEditors;
namespace ERP.Winform.WMS
{
    public partial class StockTXCPINForm : ListForm
    {
        private IWMS_M101_StockTx_DataService stockTxDataServer = Unity.Instance.GetService<IWMS_M101_StockTx_DataService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private bool m_checkStatus = false;
        private bool m_checkStatus2 = false;
        private List<WMS_M101_StockTx_Data> stockDataList;
        public StockTXCPINForm()
        {
            InitializeComponent();
            this.gridStockTx.Click += gridStockTx_Click;
            this.gridStockTx.CustomDrawColumnHeader += gridStockTx_CustomDrawColumnHeader;
            this.gridStockTx.DataSourceChanged += gridStockTx_DataSourceChanged;
            this.gridStockTX2.Click += gridStockTX2_Click;
            this.gridStockTX2.CustomDrawColumnHeader += gridStockTX2_CustomDrawColumnHeader;
            this.gridStockTX2.DataSourceChanged += gridStockTX2_DataSourceChanged;
            this.txtTxDt.DateTime = DateTime.Now.Date;
        }

        

       
        public override void OnAttachEvent()
        {
            var custData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(txtCustomer, custData, 3);
            var partData = productService.GetProductInputData();
            SetGridLookUpEdit(txtProduct, partData, 3);
        }
        public override void InitData()
        {
            var stockTxData = stockTxDataServer.GetStockTx_DataQuery().Where(a => a.IsProcessed == false && a.OPType == "PACK");
            if (!string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                string partNo = txtProduct.EditValue.ToString();
                stockTxData = stockTxData.Where(a => a.PartNo == partNo);
            }
            if (!string.IsNullOrWhiteSpace(this.txtCustomer.Text))
            {
                string custCode = txtCustomer.EditValue.ToString();
                stockTxData = stockTxData.Where(a => a.CustCode == custCode);
            }
            if (!string.IsNullOrWhiteSpace(this.txtLotno.Text))
            {
                string lotno = txtLotno.EditValue.ToString();
                stockTxData = stockTxData.Where(a => a.LotNo == lotno);
            }
            if (!string.IsNullOrWhiteSpace(this.txtTxDt.Text))
            {
                DateTime txdt = txtTxDt.DateTime.Date;
                stockTxData = stockTxData.Where(a => a.TxDt == txdt);
            }
            stockDataList = stockTxData.ToList();
            this.gcEmployee.DataSource = stockDataList;
            this.gridControlStock.DataSource = null;

        }
        void gridStockTX2_Click(object sender, EventArgs e)
        {
            if (BLLDevControlHelper.ClickGridCheckBox(this.gridStockTX2, "Check", m_checkStatus2))
            {
                m_checkStatus = !m_checkStatus;
            }
        }

        void gridStockTX2_DataSourceChanged(object sender, EventArgs e)
        {
            GridColumn column = this.gridStockTX2.Columns.ColumnByFieldName("Check");
            if (column != null)
            {
                column.Width = 80;
                column.OptionsColumn.ShowCaption = false;
                column.ColumnEdit = new RepositoryItemCheckEdit();
            }
        }
        void gridStockTx_DataSourceChanged(object sender, EventArgs e)
        {
            GridColumn column = this.gridStockTx.Columns.ColumnByFieldName("IsProcessed");
            if (column != null)
            {
                column.Width = 80;
                column.OptionsColumn.ShowCaption = false;
                column.ColumnEdit = new RepositoryItemCheckEdit();
            }
        }
        void gridStockTX2_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == "Check")
            {
                e.Column.ColumnEdit = new RepositoryItemCheckEdit();
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                BLLDevControlHelper.DrawCheckBox(e, m_checkStatus2);
                e.Handled = true;
            }
        }
        void gridStockTx_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == "IsProcessed")
            {
                e.Column.ColumnEdit = new RepositoryItemCheckEdit();
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                BLLDevControlHelper.DrawCheckBox(e, m_checkStatus);
                e.Handled = true;
            }
        }

        void gridStockTx_Click(object sender, EventArgs e)
        {
            if (BLLDevControlHelper.ClickGridCheckBox(this.gridStockTx, "IsProcessed", m_checkStatus))
            {
                m_checkStatus = !m_checkStatus;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            //var models = this.gridStockTx.DataSource as List<WMS_M101_StockTx_Data>;
            foreach (var stock in this.stockDataList.Where(a => a.IsProcessed == true))
            {
                stock.Check = false;
            }
            this.gcEmployee.DataSource = stockDataList.Where(a => a.IsProcessed == false).ToList();
            this.gridControlStock.DataSource = stockDataList.Where(a => a.IsProcessed == true).ToList();
            //BLLDevControlHelper.ClickGridCheckBox(this.gridStockTx, "IsProcessed", false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (var stock in this.stockDataList.Where(a => a.Check == true))
            {
                stock.IsProcessed = false;
            }
            this.gcEmployee.DataSource = stockDataList.Where(a => a.IsProcessed == false).ToList();
            this.gridControlStock.DataSource = stockDataList.Where(a => a.IsProcessed == true).ToList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                if (string.IsNullOrWhiteSpace(txtShipLotNo.Text))
                {
                    XtraMessageBox.Show("货位号不能为空");
                    return;
                }
                stockTxDataServer.Save(this.stockDataList.Where(a => a.IsProcessed == true).ToList(), txtShipLotNo.Text.Trim());
                //foreach(var stock in this.stockDataList.Where(a=>a.IsProcessed == true))
                //{
                //    WMS_M101_StockTx_Data model = new WMS_M101_StockTx_Data();
                //    model.ARCode = txtShipLotNo.Text.Trim();
                //    model.CustCode = stock.CustCode;
                //    model.StockID = stock.StockID;
                //    model.OPType = "CPIN";
                //    model.TxDt = DateTime.Now.Date;
                //    model.LotNo = stock.LotNo;
                //    model.PartNo = stock.PartNo;
                //    model.Weight = stock.Weight;
                //    model.Qty = stock.Qty;
                //    model.IsProcessed = true;
                //    stockTxDataServer.Create(model);
                //}
                XtraMessageBox.Show("保存成功");
                InitData();
            }
        }

        private void gridStockTx_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                else if (e.RowHandle < 0 && e.RowHandle > -1000)
                {
                    e.Info.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle.ToString();
                }
            }
        }
    }
}
