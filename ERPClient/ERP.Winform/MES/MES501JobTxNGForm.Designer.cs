namespace ERP.Winform.MES
{
    partial class MES501JobTxNGForm
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
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.mESM501JobTxNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrProcessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemNgItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM501JobTxNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1135, 600);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1131, 596);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Size = new System.Drawing.Size(1131, 596);
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.mESM501JobTxNGBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl1.MainView = this.gridProduct;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemNgItem});
            this.ykGridControl1.Size = new System.Drawing.Size(1139, 604);
            this.ykGridControl1.TabIndex = 11;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridProduct});
            // 
            // mESM501JobTxNGBindingSource
            // 
            this.mESM501JobTxNGBindingSource.DataSource = typeof(ERP.Domain.MES_M501_JobTx_NG);
            // 
            // gridProduct
            // 
            this.gridProduct.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridProduct.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridProduct.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridProduct.Appearance.OddRow.Options.UseBackColor = true;
            this.gridProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colProcessCode,
            this.colCurrProcessCode,
            this.colNGCode,
            this.colNGQty,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId,
            this.colJobNo});
            this.gridProduct.GridControl = this.ykGridControl1;
            this.gridProduct.IndicatorWidth = 40;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.OptionsCustomization.AllowSort = false;
            this.gridProduct.OptionsView.EnableAppearanceEvenRow = true;
            this.gridProduct.OptionsView.EnableAppearanceOddRow = true;
            this.gridProduct.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridProduct.OptionsView.ShowGroupPanel = false;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colProcessCode
            // 
            this.colProcessCode.FieldName = "ProcessCode";
            this.colProcessCode.Name = "colProcessCode";
            // 
            // colCurrProcessCode
            // 
            this.colCurrProcessCode.FieldName = "CurrProcessCode";
            this.colCurrProcessCode.Name = "colCurrProcessCode";
            // 
            // colNGCode
            // 
            this.colNGCode.Caption = "异常项目";
            this.colNGCode.ColumnEdit = this.repositoryItemNgItem;
            this.colNGCode.FieldName = "NGCode";
            this.colNGCode.Name = "colNGCode";
            this.colNGCode.Visible = true;
            this.colNGCode.VisibleIndex = 1;
            // 
            // repositoryItemNgItem
            // 
            this.repositoryItemNgItem.AutoHeight = false;
            this.repositoryItemNgItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemNgItem.Name = "repositoryItemNgItem";
            this.repositoryItemNgItem.NullText = "";
            this.repositoryItemNgItem.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNGQty
            // 
            this.colNGQty.Caption = "数量";
            this.colNGQty.FieldName = "NGQty";
            this.colNGQty.Name = "colNGQty";
            this.colNGQty.Visible = true;
            this.colNGQty.VisibleIndex = 2;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 3;
            // 
            // colModifyDt
            // 
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            // 
            // colModifyUser
            // 
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            // 
            // colCreateDt
            // 
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            // 
            // colCreateUser
            // 
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colJobNo
            // 
            this.colJobNo.Caption = "生产批号";
            this.colJobNo.FieldName = "JobNo";
            this.colJobNo.Name = "colJobNo";
            this.colJobNo.Visible = true;
            this.colJobNo.VisibleIndex = 0;
            // 
            // MES501JobTxNGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 633);
            this.Controls.Add(this.ykGridControl1);
            this.Name = "MES501JobTxNGForm";
            this.Text = "MES501JobTxNGForm";
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM501JobTxNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProduct;
        private System.Windows.Forms.BindingSource mESM501JobTxNGBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrProcessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNGCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNGQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colJobNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemNgItem;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    }
}