namespace ERP.Winform.WMS
{
    partial class WMSPackingForm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.wMSM104PackingHdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingHdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.ykGridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1128, 526);
            this.splitContainerControl1.SplitterPosition = 365;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.wMSM104PackingHdBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl1.MainView = this.gridView1;
            this.ykGridControl1.MenuManager = this.barManager1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(1128, 365);
            this.ykGridControl1.TabIndex = 5;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // wMSM104PackingHdBindingSource
            // 
            this.wMSM104PackingHdBindingSource.DataSource = typeof(ERP.Domain.WMS_M104_Packing_Hd);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colCustCode,
            this.colCode,
            this.colPoNo,
            this.colPartNo,
            this.colInvoiceNo,
            this.colDocNo,
            this.colModel,
            this.colCreateUser,
            this.colCreateDt,
            this.colModifyUser,
            this.colModifyDt,
            this.colId});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "DATE";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colCustCode
            // 
            this.colCustCode.Caption = "CUSTOMER";
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 1;
            // 
            // colCode
            // 
            this.colCode.Caption = "SUPPLIER";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 2;
            // 
            // colPoNo
            // 
            this.colPoNo.Caption = "PO NO";
            this.colPoNo.FieldName = "PoNo";
            this.colPoNo.Name = "colPoNo";
            this.colPoNo.Visible = true;
            this.colPoNo.VisibleIndex = 3;
            // 
            // colPartNo
            // 
            this.colPartNo.Caption = "PART NO";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "INVOICE NO";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 4;
            // 
            // colDocNo
            // 
            this.colDocNo.Caption = "DOC NO";
            this.colDocNo.FieldName = "DocNo";
            this.colDocNo.Name = "colDocNo";
            // 
            // colModel
            // 
            this.colModel.Caption = "MODEL";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            // 
            // colCreateUser
            // 
            this.colCreateUser.Caption = "创建者";
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 5;
            // 
            // colCreateDt
            // 
            this.colCreateDt.Caption = "创建日期";
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            this.colCreateDt.Visible = true;
            this.colCreateDt.VisibleIndex = 6;
            // 
            // colModifyUser
            // 
            this.colModifyUser.Caption = "修改者";
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 7;
            // 
            // colModifyDt
            // 
            this.colModifyDt.Caption = "修改日期";
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            this.colModifyDt.Visible = true;
            this.colModifyDt.VisibleIndex = 8;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.wMSM104PackingDetailBindingSource;
            this.ykGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl2.MainView = this.gridView3;
            this.ykGridControl2.MenuManager = this.barManager1;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.ykGridControl2.Size = new System.Drawing.Size(1128, 156);
            this.ykGridControl2.TabIndex = 6;
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
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView3.OptionsView.ShowFooter = true;
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
            this.colMFGLotNo.Caption = "MFG LOT NO";
            this.colMFGLotNo.FieldName = "MFGLotNo";
            this.colMFGLotNo.Name = "colMFGLotNo";
            this.colMFGLotNo.Visible = true;
            this.colMFGLotNo.VisibleIndex = 1;
            // 
            // colMFGDate
            // 
            this.colMFGDate.Caption = "MFG DATE";
            this.colMFGDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.colMFGDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMFGDate.FieldName = "MFGDate";
            this.colMFGDate.Name = "colMFGDate";
            this.colMFGDate.Visible = true;
            this.colMFGDate.VisibleIndex = 2;
            // 
            // colExpiredDate
            // 
            this.colExpiredDate.Caption = "EXPIRED DATE";
            this.colExpiredDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.colExpiredDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colExpiredDate.FieldName = "ExpiredDate";
            this.colExpiredDate.Name = "colExpiredDate";
            this.colExpiredDate.Visible = true;
            this.colExpiredDate.VisibleIndex = 3;
            // 
            // colQty
            // 
            this.colQty.Caption = "QUANTITY";
            this.colQty.DisplayFormat.FormatString = "{0:#,#}";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:#,#}")});
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
            // WMSPackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 555);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "WMSPackingForm";
            this.Text = "WMSPackingForm";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingHdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM104PackingDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource wMSM104PackingHdBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNo;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource wMSM104PackingDetailBindingSource;
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

    }
}