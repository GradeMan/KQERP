namespace ERP.Winform.WMS
{
    partial class K041PDARecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(K041PDARecords));
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.k041PDARecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdentityNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoxQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiredDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTxDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateTxdt2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateTxdt = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k041PDARecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.k041PDARecordsBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "第 {0} 总 {1}";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 85);
            this.ykGridControl1.MainView = this.gridProduct;
            this.ykGridControl1.MenuManager = this.barManager1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(1108, 459);
            this.ykGridControl1.TabIndex = 5;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridProduct});
            // 
            // k041PDARecordsBindingSource
            // 
            this.k041PDARecordsBindingSource.DataSource = typeof(ERP.Domain.K041PDARecords);
            // 
            // gridProduct
            // 
            this.gridProduct.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridProduct.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridProduct.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridProduct.Appearance.OddRow.Options.UseBackColor = true;
            this.gridProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentityNo,
            this.colStockID,
            this.colOPType,
            this.colCustCode,
            this.colLotNo,
            this.colPartNo,
            this.colBoxQty,
            this.colQty,
            this.colProdDt,
            this.colExpiredDt,
            this.colTxDt,
            this.colRemarks,
            this.colStatus});
            this.gridProduct.GridControl = this.ykGridControl1;
            this.gridProduct.IndicatorWidth = 40;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.OptionsBehavior.ReadOnly = true;
            this.gridProduct.OptionsFind.AlwaysVisible = true;
            this.gridProduct.OptionsView.ColumnAutoWidth = false;
            this.gridProduct.OptionsView.EnableAppearanceEvenRow = true;
            this.gridProduct.OptionsView.EnableAppearanceOddRow = true;
            this.gridProduct.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridProduct.OptionsView.ShowGroupPanel = false;
            // 
            // colIdentityNo
            // 
            this.colIdentityNo.FieldName = "IdentityNo";
            this.colIdentityNo.Name = "colIdentityNo";
            // 
            // colStockID
            // 
            this.colStockID.Caption = "货位号";
            this.colStockID.FieldName = "StockID";
            this.colStockID.Name = "colStockID";
            this.colStockID.Visible = true;
            this.colStockID.VisibleIndex = 0;
            // 
            // colOPType
            // 
            this.colOPType.Caption = "操作类别";
            this.colOPType.FieldName = "OPType";
            this.colOPType.Name = "colOPType";
            this.colOPType.Visible = true;
            this.colOPType.VisibleIndex = 1;
            // 
            // colCustCode
            // 
            this.colCustCode.Caption = "客户";
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 2;
            // 
            // colLotNo
            // 
            this.colLotNo.Caption = "批号";
            this.colLotNo.FieldName = "LotNo";
            this.colLotNo.Name = "colLotNo";
            this.colLotNo.Visible = true;
            this.colLotNo.VisibleIndex = 3;
            // 
            // colPartNo
            // 
            this.colPartNo.Caption = "品名";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 4;
            // 
            // colBoxQty
            // 
            this.colBoxQty.Caption = "箱数";
            this.colBoxQty.DisplayFormat.FormatString = "n2";
            this.colBoxQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBoxQty.FieldName = "BoxQty";
            this.colBoxQty.Name = "colBoxQty";
            this.colBoxQty.Visible = true;
            this.colBoxQty.VisibleIndex = 5;
            // 
            // colQty
            // 
            this.colQty.Caption = "K数";
            this.colQty.DisplayFormat.FormatString = "n2";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 6;
            // 
            // colProdDt
            // 
            this.colProdDt.Caption = "生产日期";
            this.colProdDt.FieldName = "ProdDt";
            this.colProdDt.Name = "colProdDt";
            this.colProdDt.Visible = true;
            this.colProdDt.VisibleIndex = 7;
            // 
            // colExpiredDt
            // 
            this.colExpiredDt.Caption = "有效日期";
            this.colExpiredDt.FieldName = "ExpiredDt";
            this.colExpiredDt.Name = "colExpiredDt";
            this.colExpiredDt.Visible = true;
            this.colExpiredDt.VisibleIndex = 8;
            // 
            // colTxDt
            // 
            this.colTxDt.Caption = "操作日期";
            this.colTxDt.FieldName = "TxDt";
            this.colTxDt.Name = "colTxDt";
            this.colTxDt.Visible = true;
            this.colTxDt.VisibleIndex = 9;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 10;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.dateTxdt2);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.dateTxdt);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1108, 85);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "搜索条件";
            // 
            // dateTxdt2
            // 
            this.dateTxdt2.EditValue = null;
            this.dateTxdt2.Location = new System.Drawing.Point(214, 36);
            this.dateTxdt2.MenuManager = this.barManager1;
            this.dateTxdt2.Name = "dateTxdt2";
            this.dateTxdt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTxdt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTxdt2.Size = new System.Drawing.Size(100, 20);
            this.dateTxdt2.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(196, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(12, 14);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "～";
            // 
            // dateTxdt
            // 
            this.dateTxdt.EditValue = null;
            this.dateTxdt.Location = new System.Drawing.Point(90, 36);
            this.dateTxdt.MenuManager = this.barManager1;
            this.dateTxdt.Name = "dateTxdt";
            this.dateTxdt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTxdt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTxdt.Size = new System.Drawing.Size(100, 20);
            this.dateTxdt.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "操作日期：";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(334, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 27);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // K041PDARecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 573);
            this.Controls.Add(this.ykGridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "K041PDARecords";
            this.Text = "K041PDARecords";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k041PDARecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTxdt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProduct;
        private System.Windows.Forms.BindingSource k041PDARecordsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStockID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPType;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxQty;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colProdDt;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiredDt;
        private DevExpress.XtraGrid.Columns.GridColumn colTxDt;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit dateTxdt2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dateTxdt;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}