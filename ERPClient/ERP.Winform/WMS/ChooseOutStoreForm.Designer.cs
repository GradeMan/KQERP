namespace ERP.Winform.WMS
{
    partial class ChooseOutStoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseOutStoreForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtMatCode = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.wMSC103StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInStoreDetailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInStoreId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorySuppCode = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryMatCode = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryPurPer = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.txtCount = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC103StockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySuppCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPurPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(731, 436);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(727, 432);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Size = new System.Drawing.Size(727, 432);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtMatCode);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtCount);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(735, 113);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "搜索条件 ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(237, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "材质:";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(416, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMatCode
            // 
            this.txtMatCode.Location = new System.Drawing.Point(78, 41);
            this.txtMatCode.Name = "txtMatCode";
            this.txtMatCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMatCode.Properties.NullText = "";
            this.txtMatCode.Properties.View = this.gridLookUpEdit1View;
            this.txtMatCode.Size = new System.Drawing.Size(142, 20);
            this.txtMatCode.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "规格:";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.wMSC103StockBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 113);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorySuppCode,
            this.repositoryMatCode,
            this.repositoryPurPer});
            this.gridControl1.Size = new System.Drawing.Size(735, 327);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // wMSC103StockBindingSource
            // 
            this.wMSC103StockBindingSource.DataSource = typeof(ERP.Domain.WMS_C103_Stock);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInStoreDetailId,
            this.colInStoreId,
            this.colARCode,
            this.colPartSpec,
            this.colMaterCode,
            this.colSuppLot,
            this.colStoreAmount,
            this.colStockStatus,
            this.colSuppCode,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId,
            this.colOutAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInStoreDetailId
            // 
            this.colInStoreDetailId.FieldName = "InStoreDetailId";
            this.colInStoreDetailId.Name = "colInStoreDetailId";
            // 
            // colInStoreId
            // 
            this.colInStoreId.FieldName = "InStoreId";
            this.colInStoreId.Name = "colInStoreId";
            // 
            // colARCode
            // 
            this.colARCode.Caption = "区域";
            this.colARCode.FieldName = "ARCode";
            this.colARCode.Name = "colARCode";
            this.colARCode.Visible = true;
            this.colARCode.VisibleIndex = 0;
            this.colARCode.Width = 79;
            // 
            // colPartSpec
            // 
            this.colPartSpec.Caption = "规格";
            this.colPartSpec.FieldName = "PartSpec";
            this.colPartSpec.Name = "colPartSpec";
            this.colPartSpec.Visible = true;
            this.colPartSpec.VisibleIndex = 1;
            this.colPartSpec.Width = 79;
            // 
            // colMaterCode
            // 
            this.colMaterCode.Caption = "材质";
            this.colMaterCode.FieldName = "MaterCode";
            this.colMaterCode.Name = "colMaterCode";
            this.colMaterCode.Visible = true;
            this.colMaterCode.VisibleIndex = 2;
            this.colMaterCode.Width = 79;
            // 
            // colSuppLot
            // 
            this.colSuppLot.Caption = "供应商批号";
            this.colSuppLot.FieldName = "SuppLot";
            this.colSuppLot.Name = "colSuppLot";
            this.colSuppLot.Visible = true;
            this.colSuppLot.VisibleIndex = 3;
            this.colSuppLot.Width = 83;
            // 
            // colStoreAmount
            // 
            this.colStoreAmount.Caption = "库存";
            this.colStoreAmount.FieldName = "StoreAmount";
            this.colStoreAmount.Name = "colStoreAmount";
            this.colStoreAmount.Visible = true;
            this.colStoreAmount.VisibleIndex = 4;
            this.colStoreAmount.Width = 78;
            // 
            // colStockStatus
            // 
            this.colStockStatus.FieldName = "StockStatus";
            this.colStockStatus.Name = "colStockStatus";
            // 
            // colSuppCode
            // 
            this.colSuppCode.Caption = "供应商";
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.Visible = true;
            this.colSuppCode.VisibleIndex = 5;
            this.colSuppCode.Width = 78;
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
            this.colCreateDt.Caption = "录入时间";
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            this.colCreateDt.Visible = true;
            this.colCreateDt.VisibleIndex = 6;
            this.colCreateDt.Width = 78;
            // 
            // colCreateUser
            // 
            this.colCreateUser.Caption = "录入人员";
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 7;
            this.colCreateUser.Width = 78;
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
            // colOutAmount
            // 
            this.colOutAmount.Caption = "预出库数量";
            this.colOutAmount.FieldName = "OutAmount";
            this.colOutAmount.Name = "colOutAmount";
            this.colOutAmount.Visible = true;
            this.colOutAmount.VisibleIndex = 8;
            this.colOutAmount.Width = 85;
            // 
            // repositorySuppCode
            // 
            this.repositorySuppCode.AutoHeight = false;
            this.repositorySuppCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorySuppCode.Name = "repositorySuppCode";
            this.repositorySuppCode.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryMatCode
            // 
            this.repositoryMatCode.AutoHeight = false;
            this.repositoryMatCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryMatCode.Name = "repositoryMatCode";
            this.repositoryMatCode.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryPurPer
            // 
            this.repositoryPurPer.AutoHeight = false;
            this.repositoryPurPer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryPurPer.DisplayFormat.FormatString = "p";
            this.repositoryPurPer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryPurPer.EditFormat.FormatString = "p";
            this.repositoryPurPer.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryPurPer.Name = "repositoryPurPer";
            // 
            // txtCount
            // 
            this.txtCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCount.Location = new System.Drawing.Point(271, 41);
            this.txtCount.Name = "txtCount";
            this.txtCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtCount.Properties.NullText = "";
            this.txtCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtCount.Properties.View = this.gridView3;
            this.txtCount.Size = new System.Drawing.Size(121, 20);
            this.txtCount.TabIndex = 4;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ChooseOutStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 466);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ChooseOutStoreForm";
            this.Text = "ChooseOutStoreForm";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC103StockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySuppCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryPurPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.GridLookUpEdit txtMatCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource wMSC103StockBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colInStoreDetailId;
        private DevExpress.XtraGrid.Columns.GridColumn colInStoreId;
        private DevExpress.XtraGrid.Columns.GridColumn colARCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppLot;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colStockStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppCode;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositorySuppCode;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryMatCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryPurPer;
        private DevExpress.XtraGrid.Columns.GridColumn colOutAmount;
        private DevExpress.XtraEditors.GridLookUpEdit txtCount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;

    }
}