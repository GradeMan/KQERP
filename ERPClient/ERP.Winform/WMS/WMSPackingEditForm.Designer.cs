namespace ERP.Winform.WMS
{
    partial class WMSPackingEditForm
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
            this.wMSM104PackingHdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCustCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.CustCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPoNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.PoNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForInvoiceNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.InvoiceNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDocNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.DocNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ykGridControl2 = new COM.YKControls.YKGridControl();
            this.wMSM104PackingDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPackingHdId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMFGLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMFGDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingHdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPoNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoiceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(915, 522);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.ykGridControl2);
            this.dataLayoutControl1.Controls.Add(this.DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CustCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PoNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.InvoiceNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DocNoTextEdit);
            this.dataLayoutControl1.DataSource = this.wMSM104PackingHdBindingSource;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDocNo});
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(947, 265, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(911, 518);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(911, 518);
            // 
            // wMSM104PackingHdBindingSource
            // 
            this.wMSM104PackingHdBindingSource.DataSource = typeof(ERP.Domain.WMS_M104_Packing_Hd);
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM104PackingHdBindingSource, "Date", true));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(88, 12);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Size = new System.Drawing.Size(811, 20);
            this.DateDateEdit.StyleController = this.dataLayoutControl1;
            this.DateDateEdit.TabIndex = 4;
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.CustomizationFormText = "Date";
            this.ItemForDate.Location = new System.Drawing.Point(0, 0);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(891, 24);
            this.ItemForDate.Text = "DATA";
            this.ItemForDate.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDate,
            this.ItemForCustCode,
            this.ItemForCode,
            this.ItemForPoNo,
            this.ItemForInvoiceNo,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(891, 498);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForCustCode
            // 
            this.ItemForCustCode.Control = this.CustCodeTextEdit;
            this.ItemForCustCode.CustomizationFormText = "Cust Code";
            this.ItemForCustCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForCustCode.Name = "ItemForCustCode";
            this.ItemForCustCode.Size = new System.Drawing.Size(891, 24);
            this.ItemForCustCode.Text = "CUSTOMER";
            this.ItemForCustCode.TextSize = new System.Drawing.Size(72, 14);
            // 
            // CustCodeTextEdit
            // 
            this.CustCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM104PackingHdBindingSource, "CustCode", true));
            this.CustCodeTextEdit.Location = new System.Drawing.Point(88, 36);
            this.CustCodeTextEdit.Name = "CustCodeTextEdit";
            this.CustCodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustCodeTextEdit.Size = new System.Drawing.Size(811, 20);
            this.CustCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CustCodeTextEdit.TabIndex = 5;
            // 
            // ItemForCode
            // 
            this.ItemForCode.Control = this.CodeTextEdit;
            this.ItemForCode.CustomizationFormText = "Code";
            this.ItemForCode.Location = new System.Drawing.Point(0, 48);
            this.ItemForCode.Name = "ItemForCode";
            this.ItemForCode.Size = new System.Drawing.Size(891, 24);
            this.ItemForCode.Text = "SUPPLIER";
            this.ItemForCode.TextSize = new System.Drawing.Size(72, 14);
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM104PackingHdBindingSource, "Code", true));
            this.CodeTextEdit.Location = new System.Drawing.Point(88, 60);
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CodeTextEdit.Size = new System.Drawing.Size(811, 20);
            this.CodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CodeTextEdit.TabIndex = 6;
            // 
            // ItemForPoNo
            // 
            this.ItemForPoNo.Control = this.PoNoTextEdit;
            this.ItemForPoNo.CustomizationFormText = "Po No";
            this.ItemForPoNo.Location = new System.Drawing.Point(0, 72);
            this.ItemForPoNo.Name = "ItemForPoNo";
            this.ItemForPoNo.Size = new System.Drawing.Size(891, 24);
            this.ItemForPoNo.Text = "PO    NO";
            this.ItemForPoNo.TextSize = new System.Drawing.Size(72, 14);
            // 
            // PoNoTextEdit
            // 
            this.PoNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM104PackingHdBindingSource, "PoNo", true));
            this.PoNoTextEdit.Location = new System.Drawing.Point(88, 84);
            this.PoNoTextEdit.Name = "PoNoTextEdit";
            this.PoNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PoNoTextEdit.Size = new System.Drawing.Size(811, 20);
            this.PoNoTextEdit.StyleController = this.dataLayoutControl1;
            this.PoNoTextEdit.TabIndex = 7;
            // 
            // ItemForInvoiceNo
            // 
            this.ItemForInvoiceNo.Control = this.InvoiceNoTextEdit;
            this.ItemForInvoiceNo.CustomizationFormText = "Invoice No";
            this.ItemForInvoiceNo.Location = new System.Drawing.Point(0, 96);
            this.ItemForInvoiceNo.Name = "ItemForInvoiceNo";
            this.ItemForInvoiceNo.Size = new System.Drawing.Size(891, 24);
            this.ItemForInvoiceNo.Text = "INVOICE  NO";
            this.ItemForInvoiceNo.TextSize = new System.Drawing.Size(72, 14);
            // 
            // InvoiceNoTextEdit
            // 
            this.InvoiceNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM104PackingHdBindingSource, "InvoiceNo", true));
            this.InvoiceNoTextEdit.Location = new System.Drawing.Point(88, 108);
            this.InvoiceNoTextEdit.Name = "InvoiceNoTextEdit";
            this.InvoiceNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InvoiceNoTextEdit.Size = new System.Drawing.Size(811, 20);
            this.InvoiceNoTextEdit.StyleController = this.dataLayoutControl1;
            this.InvoiceNoTextEdit.TabIndex = 9;
            // 
            // ItemForDocNo
            // 
            this.ItemForDocNo.Control = this.DocNoTextEdit;
            this.ItemForDocNo.CustomizationFormText = "Doc No";
            this.ItemForDocNo.Location = new System.Drawing.Point(0, 120);
            this.ItemForDocNo.Name = "ItemForDocNo";
            this.ItemForDocNo.Size = new System.Drawing.Size(891, 24);
            this.ItemForDocNo.Text = "DOC  NO";
            this.ItemForDocNo.TextSize = new System.Drawing.Size(72, 14);
            this.ItemForDocNo.TextToControlDistance = 5;
            // 
            // DocNoTextEdit
            // 
            this.DocNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM104PackingHdBindingSource, "DocNo", true));
            this.DocNoTextEdit.Location = new System.Drawing.Point(88, 132);
            this.DocNoTextEdit.Name = "DocNoTextEdit";
            this.DocNoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DocNoTextEdit.Size = new System.Drawing.Size(811, 20);
            this.DocNoTextEdit.StyleController = this.dataLayoutControl1;
            this.DocNoTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "明细";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 120);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup3.Size = new System.Drawing.Size(891, 378);
            this.layoutControlGroup3.Text = "明细";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ykGridControl2;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(879, 301);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.wMSM104PackingDetailBindingSource;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(18, 203);
            this.ykGridControl2.MainView = this.gridView3;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.ykGridControl2.Size = new System.Drawing.Size(875, 297);
            this.ykGridControl2.TabIndex = 7;
            this.ykGridControl2.UseEmbeddedNavigator = true;
            this.ykGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // wMSM104PackingDetailBindingSource
            // 
            this.wMSM104PackingDetailBindingSource.DataSource = typeof(ERP.Domain.WMS_M104_Packing_Detail);
            // 
            // gridView3
            // 
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPackingHdId,
            this.colSeqNo,
            this.colSuppPartNo,
            this.colMFGLotNo,
            this.colMFGDate,
            this.colExpiredDate,
            this.colQty,
            this.colId1});
            this.gridView3.GridControl = this.ykGridControl2;
            this.gridView3.IndicatorWidth = 40;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colPackingHdId
            // 
            this.colPackingHdId.FieldName = "PackingHdId";
            this.colPackingHdId.Name = "colPackingHdId";
            // 
            // colSeqNo
            // 
            this.colSeqNo.FieldName = "SeqNo";
            this.colSeqNo.Name = "colSeqNo";
            // 
            // colSuppPartNo
            // 
            this.colSuppPartNo.Caption = "SUPPLIER PART NUMBER";
            this.colSuppPartNo.FieldName = "SuppPartNo";
            this.colSuppPartNo.Name = "colSuppPartNo";
            this.colSuppPartNo.Visible = true;
            this.colSuppPartNo.VisibleIndex = 0;
            // 
            // colMFGLotNo
            // 
            this.colMFGLotNo.Caption = "MFG LOT NO.";
            this.colMFGLotNo.FieldName = "MFGLotNo";
            this.colMFGLotNo.Name = "colMFGLotNo";
            this.colMFGLotNo.Visible = true;
            this.colMFGLotNo.VisibleIndex = 1;
            // 
            // colMFGDate
            // 
            this.colMFGDate.Caption = "MFG DATE";
            this.colMFGDate.FieldName = "MFGDate";
            this.colMFGDate.Name = "colMFGDate";
            this.colMFGDate.Visible = true;
            this.colMFGDate.VisibleIndex = 2;
            // 
            // colExpiredDate
            // 
            this.colExpiredDate.Caption = "EXPIRED DATE";
            this.colExpiredDate.FieldName = "ExpiredDate";
            this.colExpiredDate.Name = "colExpiredDate";
            this.colExpiredDate.Visible = true;
            this.colExpiredDate.VisibleIndex = 3;
            // 
            // colQty
            // 
            this.colQty.Caption = "QUANTITY";
            this.colQty.DisplayFormat.FormatString = "n0";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 4;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(879, 45);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(18, 158);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(875, 41);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // WMSPackingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 555);
            this.Name = "WMSPackingEditForm";
            this.Text = "WMSPackingEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingHdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPoNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoiceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private System.Windows.Forms.BindingSource wMSM104PackingHdBindingSource;
        private DevExpress.XtraEditors.TextEdit CustCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
        private DevExpress.XtraEditors.TextEdit PoNoTextEdit;
        private DevExpress.XtraEditors.TextEdit InvoiceNoTextEdit;
        private DevExpress.XtraEditors.TextEdit DocNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPoNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInvoiceNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocNo;
        private COM.YKControls.YKGridControl ykGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingHdId;
        private DevExpress.XtraGrid.Columns.GridColumn colSeqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMFGLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMFGDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource wMSM104PackingDetailBindingSource;
    }
}