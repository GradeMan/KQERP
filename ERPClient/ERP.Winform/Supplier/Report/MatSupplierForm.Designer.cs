﻿namespace ERP.Winform.Supplier.Report
{
    partial class MatSupplierForm
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
            this.purPlanReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatClass1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatClass2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatClass3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurPer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purPlanReportViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.purPlanReportViewModelBindingSource;
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
            this.ykGridControl1.Size = new System.Drawing.Size(741, 354);
            this.ykGridControl1.TabIndex = 7;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purPlanReportViewModelBindingSource
            // 
            this.purPlanReportViewModelBindingSource.DataSource = typeof(ERP.Domain.Supplier.PurPlanViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatCode,
            this.colMatLevel,
            this.colMatClass1,
            this.colMatClass2,
            this.colMatClass3,
            this.colMatName,
            this.colMatSpec,
            this.colSuppCode,
            this.colLevel,
            this.colPurPer,
            this.colUnit,
            this.colUnitPrice,
            this.colRemarks,
            this.colPriceRemarks,
            this.colProdModel,
            this.colDeliveryTerm,
            this.colPayTerm,
            this.colAlias});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMatCode
            // 
            this.colMatCode.Caption = "物料编码";
            this.colMatCode.FieldName = "MatCode";
            this.colMatCode.Name = "colMatCode";
            this.colMatCode.Visible = true;
            this.colMatCode.VisibleIndex = 0;
            // 
            // colMatLevel
            // 
            this.colMatLevel.Caption = "物料等级";
            this.colMatLevel.FieldName = "MatLevel";
            this.colMatLevel.Name = "colMatLevel";
            this.colMatLevel.Visible = true;
            this.colMatLevel.VisibleIndex = 1;
            // 
            // colMatClass1
            // 
            this.colMatClass1.Caption = "物料类别1";
            this.colMatClass1.FieldName = "MatClass1";
            this.colMatClass1.Name = "colMatClass1";
            this.colMatClass1.Visible = true;
            this.colMatClass1.VisibleIndex = 2;
            // 
            // colMatClass2
            // 
            this.colMatClass2.Caption = "物料类别2";
            this.colMatClass2.FieldName = "MatClass2";
            this.colMatClass2.Name = "colMatClass2";
            this.colMatClass2.Visible = true;
            this.colMatClass2.VisibleIndex = 3;
            // 
            // colMatClass3
            // 
            this.colMatClass3.Caption = "物料类别3";
            this.colMatClass3.FieldName = "MatClass3";
            this.colMatClass3.Name = "colMatClass3";
            this.colMatClass3.Visible = true;
            this.colMatClass3.VisibleIndex = 4;
            // 
            // colMatName
            // 
            this.colMatName.Caption = "物料名称";
            this.colMatName.FieldName = "MatName";
            this.colMatName.Name = "colMatName";
            this.colMatName.Visible = true;
            this.colMatName.VisibleIndex = 5;
            // 
            // colMatSpec
            // 
            this.colMatSpec.Caption = "物料规格";
            this.colMatSpec.FieldName = "MatSpec";
            this.colMatSpec.Name = "colMatSpec";
            this.colMatSpec.Visible = true;
            this.colMatSpec.VisibleIndex = 6;
            // 
            // colSuppCode
            // 
            this.colSuppCode.Caption = "供应商代号";
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.Visible = true;
            this.colSuppCode.VisibleIndex = 7;
            // 
            // colLevel
            // 
            this.colLevel.Caption = "供应商等级";
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Visible = true;
            this.colLevel.VisibleIndex = 8;
            // 
            // colPurPer
            // 
            this.colPurPer.Caption = "采购比例";
            this.colPurPer.FieldName = "PurPer";
            this.colPurPer.Name = "colPurPer";
            this.colPurPer.Visible = true;
            this.colPurPer.VisibleIndex = 9;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "单位";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 10;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 11;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 12;
            // 
            // colPriceRemarks
            // 
            this.colPriceRemarks.Caption = "价格备注";
            this.colPriceRemarks.FieldName = "PriceRemarks";
            this.colPriceRemarks.Name = "colPriceRemarks";
            this.colPriceRemarks.Visible = true;
            this.colPriceRemarks.VisibleIndex = 13;
            // 
            // colProdModel
            // 
            this.colProdModel.Caption = "采购模式";
            this.colProdModel.FieldName = "ProdModel";
            this.colProdModel.Name = "colProdModel";
            this.colProdModel.Visible = true;
            this.colProdModel.VisibleIndex = 14;
            // 
            // colDeliveryTerm
            // 
            this.colDeliveryTerm.Caption = "供货方式";
            this.colDeliveryTerm.FieldName = "DeliveryTerm";
            this.colDeliveryTerm.Name = "colDeliveryTerm";
            this.colDeliveryTerm.Visible = true;
            this.colDeliveryTerm.VisibleIndex = 15;
            // 
            // colPayTerm
            // 
            this.colPayTerm.Caption = "付款方式";
            this.colPayTerm.FieldName = "PayTerm";
            this.colPayTerm.Name = "colPayTerm";
            this.colPayTerm.Visible = true;
            this.colPayTerm.VisibleIndex = 16;
            // 
            // colAlias
            // 
            this.colAlias.Caption = "供应商名称";
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 17;
            // 
            // MatSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 383);
            this.Controls.Add(this.ykGridControl1);
            this.Name = "MatSupplierForm";
            this.Text = "PurPlanMatForm";
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purPlanReportViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource purPlanReportViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMatCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMatLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colMatClass1;
        private DevExpress.XtraGrid.Columns.GridColumn colMatClass2;
        private DevExpress.XtraGrid.Columns.GridColumn colMatClass3;
        private DevExpress.XtraGrid.Columns.GridColumn colMatName;
        private DevExpress.XtraGrid.Columns.GridColumn colMatSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colPurPer;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colProdModel;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryTerm;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTerm;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
    }
}