namespace ERP.Winform.WMS
{
    partial class WMS105MatReturnEditForm
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
            this.wMSM105MatReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCompCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ReturnNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForReturnNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForTxDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ykGridControl2 = new COM.YKControls.YKGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatSpecCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMatSpecCode = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSupplier = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRemarks1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wMSM105MatReturnDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colRetQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReturnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTxDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMatSpecCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatReturnDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1060, 607);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.xtraTabControl1);
            this.dataLayoutControl1.Controls.Add(this.CompCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ReturnNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TxDtDateEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.DataSource = this.wMSM105MatReturnBindingSource;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCompCode});
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1056, 603);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(1056, 603);
            // 
            // wMSM105MatReturnBindingSource
            // 
            this.wMSM105MatReturnBindingSource.DataSource = typeof(ERP.Domain.WMS_M105_MatReturn);
            // 
            // CompCodeTextEdit
            // 
            this.CompCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM105MatReturnBindingSource, "CompCode", true));
            this.CompCodeTextEdit.Location = new System.Drawing.Point(91, 24);
            this.CompCodeTextEdit.Name = "CompCodeTextEdit";
            this.CompCodeTextEdit.Size = new System.Drawing.Size(941, 20);
            this.CompCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CompCodeTextEdit.TabIndex = 4;
            // 
            // ItemForCompCode
            // 
            this.ItemForCompCode.Control = this.CompCodeTextEdit;
            this.ItemForCompCode.CustomizationFormText = "Comp Code";
            this.ItemForCompCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompCode.Name = "ItemForCompCode";
            this.ItemForCompCode.Size = new System.Drawing.Size(1012, 24);
            this.ItemForCompCode.Text = "Comp Code";
            this.ItemForCompCode.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForCompCode.TextToControlDistance = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1036, 583);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ReturnNoTextEdit
            // 
            this.ReturnNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM105MatReturnBindingSource, "ReturnNo", true));
            this.ReturnNoTextEdit.Location = new System.Drawing.Point(76, 24);
            this.ReturnNoTextEdit.Name = "ReturnNoTextEdit";
            this.ReturnNoTextEdit.Size = new System.Drawing.Size(956, 20);
            this.ReturnNoTextEdit.StyleController = this.dataLayoutControl1;
            this.ReturnNoTextEdit.TabIndex = 5;
            // 
            // ItemForReturnNo
            // 
            this.ItemForReturnNo.Control = this.ReturnNoTextEdit;
            this.ItemForReturnNo.CustomizationFormText = "退料单号";
            this.ItemForReturnNo.Location = new System.Drawing.Point(0, 0);
            this.ItemForReturnNo.Name = "ItemForReturnNo";
            this.ItemForReturnNo.Size = new System.Drawing.Size(1012, 24);
            this.ItemForReturnNo.Text = "退料单号";
            this.ItemForReturnNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // TxDtDateEdit
            // 
            this.TxDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM105MatReturnBindingSource, "TxDt", true));
            this.TxDtDateEdit.EditValue = null;
            this.TxDtDateEdit.Location = new System.Drawing.Point(76, 48);
            this.TxDtDateEdit.Name = "TxDtDateEdit";
            this.TxDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxDtDateEdit.Size = new System.Drawing.Size(956, 20);
            this.TxDtDateEdit.StyleController = this.dataLayoutControl1;
            this.TxDtDateEdit.TabIndex = 6;
            // 
            // ItemForTxDt
            // 
            this.ItemForTxDt.Control = this.TxDtDateEdit;
            this.ItemForTxDt.CustomizationFormText = "日期";
            this.ItemForTxDt.Location = new System.Drawing.Point(0, 24);
            this.ItemForTxDt.Name = "ItemForTxDt";
            this.ItemForTxDt.Size = new System.Drawing.Size(1012, 24);
            this.ItemForTxDt.Text = "日期";
            this.ItemForTxDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSM105MatReturnBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(76, 72);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(956, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 7;
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.CustomizationFormText = "备注";
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 48);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(1012, 24);
            this.ItemForRemarks.Text = "备注";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForReturnNo,
            this.ItemForTxDt,
            this.ItemForRemarks,
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1036, 583);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(24, 96);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1008, 483);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1012, 487);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.ykGridControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1002, 454);
            this.xtraTabPage1.Text = "退料明细";
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.wMSM105MatReturnDetailBindingSource;
            this.ykGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl2.MainView = this.gridView1;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMatSpecCode,
            this.repositoryItemSupplier});
            this.ykGridControl2.Size = new System.Drawing.Size(1002, 454);
            this.ykGridControl2.TabIndex = 13;
            this.ykGridControl2.UseEmbeddedNavigator = true;
            this.ykGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode1,
            this.colMatSpecCode,
            this.colMatSpec,
            this.colMatType,
            this.colSuppode,
            this.colRemarks1,
            this.colModifyDt1,
            this.colModifyUser1,
            this.colCreateDt1,
            this.colCreateUser1,
            this.colVersion1,
            this.colId1,
            this.colRetQty,
            this.colReturnNo});
            this.gridView1.GridControl = this.ykGridControl2;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCompCode1
            // 
            this.colCompCode1.FieldName = "CompCode";
            this.colCompCode1.Name = "colCompCode1";
            // 
            // colMatSpecCode
            // 
            this.colMatSpecCode.Caption = "材料规格代号";
            this.colMatSpecCode.ColumnEdit = this.repositoryItemMatSpecCode;
            this.colMatSpecCode.FieldName = "MatSpecCode";
            this.colMatSpecCode.Name = "colMatSpecCode";
            this.colMatSpecCode.Visible = true;
            this.colMatSpecCode.VisibleIndex = 0;
            // 
            // repositoryItemMatSpecCode
            // 
            this.repositoryItemMatSpecCode.AutoHeight = false;
            this.repositoryItemMatSpecCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMatSpecCode.Name = "repositoryItemMatSpecCode";
            this.repositoryItemMatSpecCode.NullText = "";
            this.repositoryItemMatSpecCode.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMatSpec
            // 
            this.colMatSpec.Caption = "材料规格";
            this.colMatSpec.FieldName = "MatSpec";
            this.colMatSpec.Name = "colMatSpec";
            this.colMatSpec.Visible = true;
            this.colMatSpec.VisibleIndex = 1;
            // 
            // colMatType
            // 
            this.colMatType.Caption = "材质";
            this.colMatType.FieldName = "MatType";
            this.colMatType.Name = "colMatType";
            this.colMatType.Visible = true;
            this.colMatType.VisibleIndex = 2;
            // 
            // colSuppode
            // 
            this.colSuppode.Caption = "供应商";
            this.colSuppode.ColumnEdit = this.repositoryItemSupplier;
            this.colSuppode.FieldName = "Suppode";
            this.colSuppode.Name = "colSuppode";
            this.colSuppode.Visible = true;
            this.colSuppode.VisibleIndex = 3;
            // 
            // repositoryItemSupplier
            // 
            this.repositoryItemSupplier.AutoHeight = false;
            this.repositoryItemSupplier.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSupplier.Name = "repositoryItemSupplier";
            this.repositoryItemSupplier.NullText = "";
            this.repositoryItemSupplier.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colRemarks1
            // 
            this.colRemarks1.Caption = "备注";
            this.colRemarks1.FieldName = "Remarks";
            this.colRemarks1.Name = "colRemarks1";
            this.colRemarks1.Visible = true;
            this.colRemarks1.VisibleIndex = 4;
            // 
            // colModifyDt1
            // 
            this.colModifyDt1.FieldName = "ModifyDt";
            this.colModifyDt1.Name = "colModifyDt1";
            // 
            // colModifyUser1
            // 
            this.colModifyUser1.FieldName = "ModifyUser";
            this.colModifyUser1.Name = "colModifyUser1";
            // 
            // colCreateDt1
            // 
            this.colCreateDt1.FieldName = "CreateDt";
            this.colCreateDt1.Name = "colCreateDt1";
            // 
            // colCreateUser1
            // 
            this.colCreateUser1.FieldName = "CreateUser";
            this.colCreateUser1.Name = "colCreateUser1";
            // 
            // colVersion1
            // 
            this.colVersion1.FieldName = "Version";
            this.colVersion1.Name = "colVersion1";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // wMSM105MatReturnDetailBindingSource
            // 
            this.wMSM105MatReturnDetailBindingSource.DataSource = typeof(ERP.Domain.WMS_M105_MatReturnDetail);
            // 
            // colRetQty
            // 
            this.colRetQty.Caption = "退料数量";
            this.colRetQty.FieldName = "RetQty";
            this.colRetQty.Name = "colRetQty";
            this.colRetQty.Visible = true;
            this.colRetQty.VisibleIndex = 5;
            // 
            // colReturnNo
            // 
            this.colReturnNo.FieldName = "ReturnNo";
            this.colReturnNo.Name = "colReturnNo";
            // 
            // WMS105MatReturnEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 640);
            this.Name = "WMS105MatReturnEditForm";
            this.Text = "WMS105MatReturnEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReturnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTxDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMatSpecCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatReturnDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit CompCodeTextEdit;
        private System.Windows.Forms.BindingSource wMSM105MatReturnBindingSource;
        private DevExpress.XtraEditors.TextEdit ReturnNoTextEdit;
        private DevExpress.XtraEditors.DateEdit TxDtDateEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReturnNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTxDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private COM.YKControls.YKGridControl ykGridControl2;
        private System.Windows.Forms.BindingSource wMSM105MatReturnDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colMatSpecCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemMatSpecCode;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMatSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colMatType;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppode;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colRetQty;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnNo;
    }
}