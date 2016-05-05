namespace ERP.Winform.MES.Report
{
    partial class P106_ActMat_Daily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P106_ActMat_Daily));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnMouthCheck = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddP106 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCompCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatSpec1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShortName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTxDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldReqQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRetQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRemarks1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatSpecCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSuppCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnMouthCheck);
            this.groupControl1.Controls.Add(this.btnAddP106);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtProdDt1);
            this.groupControl1.Controls.Add(this.txtProdDt2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(833, 83);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "搜索条件";
            // 
            // btnMouthCheck
            // 
            this.btnMouthCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnMouthCheck.Image")));
            this.btnMouthCheck.Location = new System.Drawing.Point(590, 31);
            this.btnMouthCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMouthCheck.Name = "btnMouthCheck";
            this.btnMouthCheck.Size = new System.Drawing.Size(79, 30);
            this.btnMouthCheck.TabIndex = 64;
            this.btnMouthCheck.Text = "当月盘点";
            // 
            // btnAddP106
            // 
            this.btnAddP106.Image = ((System.Drawing.Image)(resources.GetObject("btnAddP106.Image")));
            this.btnAddP106.Location = new System.Drawing.Point(494, 31);
            this.btnAddP106.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddP106.Name = "btnAddP106";
            this.btnAddP106.Size = new System.Drawing.Size(79, 30);
            this.btnAddP106.TabIndex = 63;
            this.btnAddP106.Text = "新增领用";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(203, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "生产日期:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(72, 34);
            this.txtProdDt1.MenuManager = this.barManager1;
            this.txtProdDt1.Name = "txtProdDt1";
            this.txtProdDt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.Mask.EditMask = "";
            this.txtProdDt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt1.Size = new System.Drawing.Size(127, 20);
            this.txtProdDt1.TabIndex = 13;
            // 
            // txtProdDt2
            // 
            this.txtProdDt2.EditValue = null;
            this.txtProdDt2.Location = new System.Drawing.Point(213, 34);
            this.txtProdDt2.MenuManager = this.barManager1;
            this.txtProdDt2.Name = "txtProdDt2";
            this.txtProdDt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.Mask.EditMask = "";
            this.txtProdDt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt2.Size = new System.Drawing.Size(152, 20);
            this.txtProdDt2.TabIndex = 14;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCompCode1,
            this.fieldMatSpec1,
            this.fieldShortName,
            this.fieldMatName,
            this.fieldTxDt1,
            this.fieldReqQty1,
            this.fieldRetQty1,
            this.fieldRemarks1,
            this.fieldMatSpecCode,
            this.fieldMatCode,
            this.fieldSuppCode,
            this.pivotGridField1,
            this.pivotGridField2});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 83);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(833, 367);
            this.pivotGridControl1.TabIndex = 7;
            // 
            // fieldCompCode1
            // 
            this.fieldCompCode1.AreaIndex = 0;
            this.fieldCompCode1.Caption = "公司";
            this.fieldCompCode1.FieldName = "CompCode";
            this.fieldCompCode1.Name = "fieldCompCode1";
            // 
            // fieldMatSpec1
            // 
            this.fieldMatSpec1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatSpec1.AreaIndex = 1;
            this.fieldMatSpec1.Caption = "材料规格";
            this.fieldMatSpec1.FieldName = "MatSpec";
            this.fieldMatSpec1.Name = "fieldMatSpec1";
            // 
            // fieldShortName
            // 
            this.fieldShortName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldShortName.AreaIndex = 2;
            this.fieldShortName.Caption = "供应商";
            this.fieldShortName.FieldName = "ShortName";
            this.fieldShortName.Name = "fieldShortName";
            // 
            // fieldMatName
            // 
            this.fieldMatName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatName.AreaIndex = 3;
            this.fieldMatName.Caption = "材质";
            this.fieldMatName.FieldName = "MatName";
            this.fieldMatName.Name = "fieldMatName";
            // 
            // fieldTxDt1
            // 
            this.fieldTxDt1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTxDt1.AreaIndex = 0;
            this.fieldTxDt1.Caption = "日期";
            this.fieldTxDt1.CellFormat.FormatString = "d";
            this.fieldTxDt1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldTxDt1.FieldName = "TxDt";
            this.fieldTxDt1.Name = "fieldTxDt1";
            this.fieldTxDt1.ValueFormat.FormatString = "d";
            this.fieldTxDt1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldReqQty1
            // 
            this.fieldReqQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldReqQty1.AreaIndex = 0;
            this.fieldReqQty1.Caption = "领用数量";
            this.fieldReqQty1.CellFormat.FormatString = "{0:N1}";
            this.fieldReqQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldReqQty1.FieldName = "ReqQty";
            this.fieldReqQty1.Name = "fieldReqQty1";
            // 
            // fieldRetQty1
            // 
            this.fieldRetQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRetQty1.AreaIndex = 1;
            this.fieldRetQty1.Caption = "退料数量";
            this.fieldRetQty1.CellFormat.FormatString = "{0:N1}";
            this.fieldRetQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRetQty1.FieldName = "RetQty";
            this.fieldRetQty1.Name = "fieldRetQty1";
            // 
            // fieldRemarks1
            // 
            this.fieldRemarks1.AreaIndex = 1;
            this.fieldRemarks1.Caption = "备注";
            this.fieldRemarks1.FieldName = "Remarks";
            this.fieldRemarks1.Name = "fieldRemarks1";
            // 
            // fieldMatSpecCode
            // 
            this.fieldMatSpecCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatSpecCode.AreaIndex = 0;
            this.fieldMatSpecCode.Caption = "材料规格代号";
            this.fieldMatSpecCode.FieldName = "MatSpecCode";
            this.fieldMatSpecCode.Name = "fieldMatSpecCode";
            // 
            // fieldMatCode
            // 
            this.fieldMatCode.AreaIndex = 3;
            this.fieldMatCode.Caption = "材质代号";
            this.fieldMatCode.FieldName = "MatCode";
            this.fieldMatCode.Name = "fieldMatCode";
            // 
            // fieldSuppCode
            // 
            this.fieldSuppCode.AreaIndex = 2;
            this.fieldSuppCode.Caption = "供应商代号";
            this.fieldSuppCode.FieldName = "SuppCode";
            this.fieldSuppCode.Name = "fieldSuppCode";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 4;
            this.pivotGridField1.Caption = "期初数";
            this.pivotGridField1.CellFormat.FormatString = "{0:N1}";
            this.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField1.FieldName = "LastCheckQty";
            this.pivotGridField1.GrandTotalCellFormat.FormatString = "{0:N1}";
            this.pivotGridField1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.ValueFormat.FormatString = "{0:N1}";
            this.pivotGridField1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 5;
            this.pivotGridField2.Caption = "盘点数";
            this.pivotGridField2.CellFormat.FormatString = "{0:N1}";
            this.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField2.FieldName = "CheckQty";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.ValueFormat.FormatString = "{0:N1}";
            this.pivotGridField2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // P106_ActMat_Daily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 479);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "P106_ActMat_Daily";
            this.Text = "P106_ActMat_Daily";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraEditors.SimpleButton btnMouthCheck;
        private DevExpress.XtraEditors.SimpleButton btnAddP106;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatSpec1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShortName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTxDt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldReqQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRetQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRemarks1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatSpecCode;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatCode;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSuppCode;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;

    }
}