namespace ERP.Winform.MES
{
    partial class MES201ProductMaterialForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productMaterialViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridMaterial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPlanId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPLNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustAlias = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPartName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPartSpec = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSumQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCompCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPlanDetailId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMatCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMaterial = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMatSpec = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitConsume = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1226, 583);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1222, 579);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Size = new System.Drawing.Size(1222, 579);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.productMaterialViewModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridMaterial;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMaterial});
            this.gridControl1.Size = new System.Drawing.Size(1198, 555);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMaterial});
            // 
            // productMaterialViewModelBindingSource
            // 
            this.productMaterialViewModelBindingSource.DataSource = typeof(ERP.Domain.ProductMaterialViewModel);
            // 
            // gridMaterial
            // 
            this.gridMaterial.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gridMaterial.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colPlanId,
            this.colPLNo,
            this.colCustCode,
            this.colPartNo,
            this.colPartName,
            this.colPartSpec,
            this.colCompCode,
            this.colPlanDetailId,
            this.colMatCode,
            this.colSuppCode,
            this.colUnit,
            this.colUnitPrice,
            this.colQty,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colId,
            this.colMatName,
            this.colMatSpec,
            this.colSumQty,
            this.colUnitConsume,
            this.colCustAlias});
            this.gridMaterial.GridControl = this.gridControl1;
            this.gridMaterial.Name = "gridMaterial";
            this.gridMaterial.OptionsView.AllowCellMerge = true;
            this.gridMaterial.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "产品资料";
            this.gridBand1.Columns.Add(this.colPlanId);
            this.gridBand1.Columns.Add(this.colPLNo);
            this.gridBand1.Columns.Add(this.colCustCode);
            this.gridBand1.Columns.Add(this.colCustAlias);
            this.gridBand1.Columns.Add(this.colPartNo);
            this.gridBand1.Columns.Add(this.colPartName);
            this.gridBand1.Columns.Add(this.colPartSpec);
            this.gridBand1.Columns.Add(this.colSumQty);
            this.gridBand1.Columns.Add(this.colCompCode);
            this.gridBand1.Columns.Add(this.colPlanDetailId);
            this.gridBand1.Columns.Add(this.colRemarks);
            this.gridBand1.Columns.Add(this.colModifyDt);
            this.gridBand1.Columns.Add(this.colModifyUser);
            this.gridBand1.Columns.Add(this.colCreateDt);
            this.gridBand1.Columns.Add(this.colCreateUser);
            this.gridBand1.Columns.Add(this.colId);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 375;
            // 
            // colPlanId
            // 
            this.colPlanId.FieldName = "PlanId";
            this.colPlanId.Name = "colPlanId";
            // 
            // colPLNo
            // 
            this.colPLNo.FieldName = "PLNo";
            this.colPLNo.Name = "colPLNo";
            // 
            // colCustCode
            // 
            this.colCustCode.Caption = "客户";
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colCustAlias
            // 
            this.colCustAlias.Caption = "客户";
            this.colCustAlias.FieldName = "CustAlias";
            this.colCustAlias.Name = "colCustAlias";
            this.colCustAlias.Visible = true;
            // 
            // colPartNo
            // 
            this.colPartNo.Caption = "产品编码";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colPartNo.Visible = true;
            // 
            // colPartName
            // 
            this.colPartName.Caption = "产品名称";
            this.colPartName.FieldName = "PartName";
            this.colPartName.Name = "colPartName";
            this.colPartName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colPartName.Visible = true;
            // 
            // colPartSpec
            // 
            this.colPartSpec.Caption = "产品规格";
            this.colPartSpec.FieldName = "PartSpec";
            this.colPartSpec.Name = "colPartSpec";
            this.colPartSpec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colPartSpec.Visible = true;
            // 
            // colSumQty
            // 
            this.colSumQty.Caption = "产品数量";
            this.colSumQty.DisplayFormat.FormatString = "n0";
            this.colSumQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumQty.FieldName = "SumQty";
            this.colSumQty.Name = "colSumQty";
            this.colSumQty.Visible = true;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colPlanDetailId
            // 
            this.colPlanDetailId.FieldName = "PlanDetailId";
            this.colPlanDetailId.Name = "colPlanDetailId";
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
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
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "物料资料";
            this.gridBand2.Columns.Add(this.colMatCode);
            this.gridBand2.Columns.Add(this.colMatName);
            this.gridBand2.Columns.Add(this.colMatSpec);
            this.gridBand2.Columns.Add(this.colSuppCode);
            this.gridBand2.Columns.Add(this.colUnit);
            this.gridBand2.Columns.Add(this.colUnitPrice);
            this.gridBand2.Columns.Add(this.colUnitConsume);
            this.gridBand2.Columns.Add(this.colQty);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 525;
            // 
            // colMatCode
            // 
            this.colMatCode.Caption = "物料编码";
            this.colMatCode.ColumnEdit = this.repositoryItemMaterial;
            this.colMatCode.FieldName = "MatCode";
            this.colMatCode.Name = "colMatCode";
            this.colMatCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatCode.Visible = true;
            // 
            // repositoryItemMaterial
            // 
            this.repositoryItemMaterial.AutoHeight = false;
            this.repositoryItemMaterial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMaterial.Name = "repositoryItemMaterial";
            this.repositoryItemMaterial.NullText = "";
            this.repositoryItemMaterial.View = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemMaterial.EditValueChanged += new System.EventHandler(this.repositoryItemMaterial_EditValueChanged);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMatName
            // 
            this.colMatName.Caption = "物料名称";
            this.colMatName.FieldName = "MatName";
            this.colMatName.Name = "colMatName";
            this.colMatName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatName.Visible = true;
            // 
            // colMatSpec
            // 
            this.colMatSpec.Caption = "物料规格";
            this.colMatSpec.FieldName = "MatSpec";
            this.colMatSpec.Name = "colMatSpec";
            this.colMatSpec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatSpec.Visible = true;
            // 
            // colSuppCode
            // 
            this.colSuppCode.Caption = "供应商";
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSuppCode.Visible = true;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "单位";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit.Visible = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colUnitConsume
            // 
            this.colUnitConsume.Caption = "单位消耗";
            this.colUnitConsume.DisplayFormat.FormatString = "n0";
            this.colUnitConsume.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitConsume.FieldName = "UnitConsume";
            this.colUnitConsume.Name = "colUnitConsume";
            this.colUnitConsume.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitConsume.Visible = true;
            // 
            // colQty
            // 
            this.colQty.Caption = "数量";
            this.colQty.DisplayFormat.FormatString = "n0";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQty.Visible = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1202, 559);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // MES201ProductMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 616);
            this.Name = "MES201ProductMaterialForm";
            this.Text = "产品物料对应表";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridMaterial;
        private System.Windows.Forms.BindingSource productMaterialViewModelBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPlanId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPLNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPartNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPartName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPartSpec;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCompCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPlanDetailId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRemarks;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModifyDt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModifyUser;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreateDt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCreateUser;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMatCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSuppCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMatName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMatSpec;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSumQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitConsume;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustAlias;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    }
}