namespace ERP.Winform.Supplier.Report
{
    partial class PurPlanMatForm
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
            this.purPlanMatViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldPurPlNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTxDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatLevel1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatClass11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatClass21 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatClass31 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatSpec1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSuppCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLevel1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPurPer1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnit1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRemarks1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPriceRemarks1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProdModel1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDeliveryTerm1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPayTerm1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSuppQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPurQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAlias = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.purPlanMatViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // purPlanMatViewModelBindingSource
            // 
            this.purPlanMatViewModelBindingSource.DataSource = typeof(ERP.Domain.Supplier.PurPlanMatViewModel);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.purPlanMatViewModelBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldPurPlNo1,
            this.fieldTxDt1,
            this.fieldMatCode1,
            this.fieldMatLevel1,
            this.fieldMatClass11,
            this.fieldMatClass21,
            this.fieldMatClass31,
            this.fieldMatName1,
            this.fieldMatSpec1,
            this.fieldSuppCode1,
            this.fieldLevel1,
            this.fieldPurPer1,
            this.fieldUnit1,
            this.fieldUnitPrice1,
            this.fieldRemarks1,
            this.fieldPriceRemarks1,
            this.fieldProdModel1,
            this.fieldDeliveryTerm1,
            this.fieldPayTerm1,
            this.fieldSuppQty1,
            this.fieldPurQty1,
            this.fieldAlias});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(803, 469);
            this.pivotGridControl1.TabIndex = 4;
            // 
            // fieldPurPlNo1
            // 
            this.fieldPurPlNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPurPlNo1.AreaIndex = 0;
            this.fieldPurPlNo1.Caption = "采购单号";
            this.fieldPurPlNo1.FieldName = "PurPlNo";
            this.fieldPurPlNo1.Name = "fieldPurPlNo1";
            // 
            // fieldTxDt1
            // 
            this.fieldTxDt1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTxDt1.AreaIndex = 0;
            this.fieldTxDt1.Caption = "采购日期";
            this.fieldTxDt1.FieldName = "TxDt";
            this.fieldTxDt1.Name = "fieldTxDt1";
            // 
            // fieldMatCode1
            // 
            this.fieldMatCode1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatCode1.AreaIndex = 2;
            this.fieldMatCode1.Caption = "物料编号";
            this.fieldMatCode1.FieldName = "MatCode";
            this.fieldMatCode1.Name = "fieldMatCode1";
            // 
            // fieldMatLevel1
            // 
            this.fieldMatLevel1.AreaIndex = 0;
            this.fieldMatLevel1.Caption = "物料等级";
            this.fieldMatLevel1.FieldName = "MatLevel";
            this.fieldMatLevel1.Name = "fieldMatLevel1";
            // 
            // fieldMatClass11
            // 
            this.fieldMatClass11.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatClass11.AreaIndex = 4;
            this.fieldMatClass11.Caption = "物料类比1";
            this.fieldMatClass11.FieldName = "MatClass1";
            this.fieldMatClass11.Name = "fieldMatClass11";
            // 
            // fieldMatClass21
            // 
            this.fieldMatClass21.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatClass21.AreaIndex = 5;
            this.fieldMatClass21.Caption = "物料类别2";
            this.fieldMatClass21.FieldName = "MatClass2";
            this.fieldMatClass21.Name = "fieldMatClass21";
            // 
            // fieldMatClass31
            // 
            this.fieldMatClass31.AreaIndex = 1;
            this.fieldMatClass31.Caption = "物料类别3";
            this.fieldMatClass31.FieldName = "MatClass3";
            this.fieldMatClass31.Name = "fieldMatClass31";
            // 
            // fieldMatName1
            // 
            this.fieldMatName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatName1.AreaIndex = 3;
            this.fieldMatName1.Caption = "物料名称";
            this.fieldMatName1.FieldName = "MatName";
            this.fieldMatName1.Name = "fieldMatName1";
            // 
            // fieldMatSpec1
            // 
            this.fieldMatSpec1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatSpec1.AreaIndex = 6;
            this.fieldMatSpec1.Caption = "物料规格";
            this.fieldMatSpec1.FieldName = "MatSpec";
            this.fieldMatSpec1.Name = "fieldMatSpec1";
            // 
            // fieldSuppCode1
            // 
            this.fieldSuppCode1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSuppCode1.AreaIndex = 7;
            this.fieldSuppCode1.Caption = "供应商代号";
            this.fieldSuppCode1.FieldName = "SuppCode";
            this.fieldSuppCode1.Name = "fieldSuppCode1";
            // 
            // fieldLevel1
            // 
            this.fieldLevel1.AreaIndex = 2;
            this.fieldLevel1.Caption = "供应商等级";
            this.fieldLevel1.FieldName = "Level";
            this.fieldLevel1.Name = "fieldLevel1";
            // 
            // fieldPurPer1
            // 
            this.fieldPurPer1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPurPer1.AreaIndex = 0;
            this.fieldPurPer1.Caption = "采购比例";
            this.fieldPurPer1.CellFormat.FormatString = "p";
            this.fieldPurPer1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPurPer1.FieldName = "PurPer";
            this.fieldPurPer1.Name = "fieldPurPer1";
            // 
            // fieldUnit1
            // 
            this.fieldUnit1.AreaIndex = 3;
            this.fieldUnit1.Caption = "Unit";
            this.fieldUnit1.FieldName = "Unit";
            this.fieldUnit1.Name = "fieldUnit1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 4;
            this.fieldUnitPrice1.Caption = "Unit Price";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // fieldRemarks1
            // 
            this.fieldRemarks1.AreaIndex = 5;
            this.fieldRemarks1.Caption = "Remarks";
            this.fieldRemarks1.FieldName = "Remarks";
            this.fieldRemarks1.Name = "fieldRemarks1";
            // 
            // fieldPriceRemarks1
            // 
            this.fieldPriceRemarks1.AreaIndex = 6;
            this.fieldPriceRemarks1.Caption = "Price Remarks";
            this.fieldPriceRemarks1.FieldName = "PriceRemarks";
            this.fieldPriceRemarks1.Name = "fieldPriceRemarks1";
            // 
            // fieldProdModel1
            // 
            this.fieldProdModel1.AreaIndex = 7;
            this.fieldProdModel1.Caption = "Prod Model";
            this.fieldProdModel1.FieldName = "ProdModel";
            this.fieldProdModel1.Name = "fieldProdModel1";
            // 
            // fieldDeliveryTerm1
            // 
            this.fieldDeliveryTerm1.AreaIndex = 8;
            this.fieldDeliveryTerm1.Caption = "Delivery Term";
            this.fieldDeliveryTerm1.FieldName = "DeliveryTerm";
            this.fieldDeliveryTerm1.Name = "fieldDeliveryTerm1";
            // 
            // fieldPayTerm1
            // 
            this.fieldPayTerm1.AreaIndex = 9;
            this.fieldPayTerm1.Caption = "Pay Term";
            this.fieldPayTerm1.FieldName = "PayTerm";
            this.fieldPayTerm1.Name = "fieldPayTerm1";
            // 
            // fieldSuppQty1
            // 
            this.fieldSuppQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSuppQty1.AreaIndex = 1;
            this.fieldSuppQty1.Caption = "采购数量";
            this.fieldSuppQty1.CellFormat.FormatString = "{0:n0}";
            this.fieldSuppQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSuppQty1.FieldName = "SuppQty";
            this.fieldSuppQty1.Name = "fieldSuppQty1";
            // 
            // fieldPurQty1
            // 
            this.fieldPurQty1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPurQty1.AreaIndex = 1;
            this.fieldPurQty1.Caption = "采购总数";
            this.fieldPurQty1.CellFormat.FormatString = "{0:n0}";
            this.fieldPurQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPurQty1.FieldName = "PurQty";
            this.fieldPurQty1.Name = "fieldPurQty1";
            // 
            // fieldAlias
            // 
            this.fieldAlias.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAlias.AreaIndex = 8;
            this.fieldAlias.Caption = "供应商名称";
            this.fieldAlias.FieldName = "Alias";
            this.fieldAlias.Name = "fieldAlias";
            // 
            // PurPlanMatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 498);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "PurPlanMatForm";
            this.Text = "PurPlanMatForm";
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.purPlanMatViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource purPlanMatViewModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPurPlNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTxDt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatLevel1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatClass11;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatClass21;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatClass31;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatSpec1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSuppCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLevel1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPurPer1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnit1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRemarks1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPriceRemarks1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdModel1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDeliveryTerm1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPayTerm1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSuppQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPurQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAlias;
    }
}