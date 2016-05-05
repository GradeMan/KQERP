namespace ERP.Winform.MES.Report
{
    partial class Q202_PNGForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldJobNO1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQPartNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldplot1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldinqtyink1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAMC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAHDBX1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIADY1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIADJBX1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAWD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIABJC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIACTD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAWJY1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIASX1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAHS1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAZH1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAHW1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIABJD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGCRITERIAOTHER1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGQtyInK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQCFactor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQCUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQCAmount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProdDt = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.filedQcPer = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtProdDt1);
            this.groupControl1.Controls.Add(this.txtProdDt2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1056, 70);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "搜索条件";
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
            this.btnSearch.Location = new System.Drawing.Point(391, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
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
            this.fieldJobNO1,
            this.fieldQPartNo1,
            this.fieldplot1,
            this.fieldName1,
            this.fieldInQty1,
            this.fieldinqtyink1,
            this.fieldPNGCRITERIAMC1,
            this.fieldPNGCRITERIAHDBX1,
            this.fieldPNGCRITERIADY1,
            this.fieldPNGCRITERIADJBX1,
            this.fieldPNGCRITERIAWD1,
            this.fieldPNGCRITERIABJC1,
            this.fieldPNGCRITERIACTD1,
            this.fieldPNGCRITERIAWJY1,
            this.fieldPNGCRITERIASX1,
            this.fieldPNGCRITERIAHS1,
            this.fieldPNGCRITERIAZH1,
            this.fieldPNGCRITERIAHW1,
            this.fieldPNGCRITERIABJD1,
            this.fieldPNGCRITERIAOTHER1,
            this.fieldPNGQtyInK1,
            this.fieldQCFactor1,
            this.fieldQCUnitPrice1,
            this.fieldQCAmount1,
            this.fieldProdDt,
            this.pivotGridField1,
            this.pivotGridField2,
            this.filedQcPer});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 70);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(1056, 463);
            this.pivotGridControl1.TabIndex = 7;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            // 
            // fieldJobNO1
            // 
            this.fieldJobNO1.AreaIndex = 5;
            this.fieldJobNO1.Caption = "生产批号";
            this.fieldJobNO1.FieldName = "JobNO";
            this.fieldJobNO1.Name = "fieldJobNO1";
            // 
            // fieldQPartNo1
            // 
            this.fieldQPartNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldQPartNo1.AreaIndex = 1;
            this.fieldQPartNo1.Caption = "品名";
            this.fieldQPartNo1.FieldName = "QPartNo";
            this.fieldQPartNo1.Name = "fieldQPartNo1";
            // 
            // fieldplot1
            // 
            this.fieldplot1.AreaIndex = 4;
            this.fieldplot1.Caption = "冲压批号";
            this.fieldplot1.FieldName = "plot";
            this.fieldplot1.Name = "fieldplot1";
            // 
            // fieldName1
            // 
            this.fieldName1.AreaIndex = 2;
            this.fieldName1.Caption = "操作员";
            this.fieldName1.FieldName = "Name";
            this.fieldName1.Name = "fieldName1";
            // 
            // fieldInQty1
            // 
            this.fieldInQty1.AreaIndex = 0;
            this.fieldInQty1.Caption = "投入数";
            this.fieldInQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldInQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.FieldName = "InQty";
            this.fieldInQty1.Name = "fieldInQty1";
            // 
            // fieldinqtyink1
            // 
            this.fieldinqtyink1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldinqtyink1.AreaIndex = 14;
            this.fieldinqtyink1.Caption = "投入K数";
            this.fieldinqtyink1.CellFormat.FormatString = "{0:N2}";
            this.fieldinqtyink1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldinqtyink1.FieldName = "inqtyink";
            this.fieldinqtyink1.Name = "fieldinqtyink1";
            // 
            // fieldPNGCRITERIAMC1
            // 
            this.fieldPNGCRITERIAMC1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAMC1.AreaIndex = 0;
            this.fieldPNGCRITERIAMC1.Caption = "毛刺";
            this.fieldPNGCRITERIAMC1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAMC1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAMC1.FieldName = "PNGCRITERIA_MC";
            this.fieldPNGCRITERIAMC1.Name = "fieldPNGCRITERIAMC1";
            // 
            // fieldPNGCRITERIAHDBX1
            // 
            this.fieldPNGCRITERIAHDBX1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAHDBX1.AreaIndex = 3;
            this.fieldPNGCRITERIAHDBX1.Caption = "焊点变形";
            this.fieldPNGCRITERIAHDBX1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAHDBX1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAHDBX1.FieldName = "PNGCRITERIA_HDBX";
            this.fieldPNGCRITERIAHDBX1.Name = "fieldPNGCRITERIAHDBX1";
            // 
            // fieldPNGCRITERIADY1
            // 
            this.fieldPNGCRITERIADY1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIADY1.AreaIndex = 7;
            this.fieldPNGCRITERIADY1.Caption = "打印";
            this.fieldPNGCRITERIADY1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIADY1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIADY1.FieldName = "PNGCRITERIA_DY";
            this.fieldPNGCRITERIADY1.Name = "fieldPNGCRITERIADY1";
            // 
            // fieldPNGCRITERIADJBX1
            // 
            this.fieldPNGCRITERIADJBX1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIADJBX1.AreaIndex = 8;
            this.fieldPNGCRITERIADJBX1.Caption = "导脚变形";
            this.fieldPNGCRITERIADJBX1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIADJBX1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIADJBX1.FieldName = "PNGCRITERIA_DJBX";
            this.fieldPNGCRITERIADJBX1.Name = "fieldPNGCRITERIADJBX1";
            // 
            // fieldPNGCRITERIAWD1
            // 
            this.fieldPNGCRITERIAWD1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAWD1.AreaIndex = 9;
            this.fieldPNGCRITERIAWD1.Caption = "弯刀";
            this.fieldPNGCRITERIAWD1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAWD1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAWD1.FieldName = "PNGCRITERIA_WD";
            this.fieldPNGCRITERIAWD1.Name = "fieldPNGCRITERIAWD1";
            // 
            // fieldPNGCRITERIABJC1
            // 
            this.fieldPNGCRITERIABJC1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIABJC1.AreaIndex = 11;
            this.fieldPNGCRITERIABJC1.Caption = "步距长";
            this.fieldPNGCRITERIABJC1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIABJC1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIABJC1.FieldName = "PNGCRITERIA_BJC";
            this.fieldPNGCRITERIABJC1.Name = "fieldPNGCRITERIABJC1";
            // 
            // fieldPNGCRITERIACTD1
            // 
            this.fieldPNGCRITERIACTD1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIACTD1.AreaIndex = 1;
            this.fieldPNGCRITERIACTD1.Caption = "冲头断";
            this.fieldPNGCRITERIACTD1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIACTD1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIACTD1.FieldName = "PNGCRITERIA_CTD";
            this.fieldPNGCRITERIACTD1.Name = "fieldPNGCRITERIACTD1";
            // 
            // fieldPNGCRITERIAWJY1
            // 
            this.fieldPNGCRITERIAWJY1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAWJY1.AreaIndex = 2;
            this.fieldPNGCRITERIAWJY1.Caption = "无精压";
            this.fieldPNGCRITERIAWJY1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAWJY1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAWJY1.FieldName = "PNGCRITERIA_WJY";
            this.fieldPNGCRITERIAWJY1.Name = "fieldPNGCRITERIAWJY1";
            // 
            // fieldPNGCRITERIASX1
            // 
            this.fieldPNGCRITERIASX1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIASX1.AreaIndex = 4;
            this.fieldPNGCRITERIASX1.Caption = "S形";
            this.fieldPNGCRITERIASX1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIASX1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIASX1.FieldName = "PNGCRITERIA_SX";
            this.fieldPNGCRITERIASX1.Name = "fieldPNGCRITERIASX1";
            // 
            // fieldPNGCRITERIAHS1
            // 
            this.fieldPNGCRITERIAHS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAHS1.AreaIndex = 5;
            this.fieldPNGCRITERIAHS1.Caption = "划伤";
            this.fieldPNGCRITERIAHS1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAHS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAHS1.FieldName = "PNGCRITERIA_HS";
            this.fieldPNGCRITERIAHS1.Name = "fieldPNGCRITERIAHS1";
            // 
            // fieldPNGCRITERIAZH1
            // 
            this.fieldPNGCRITERIAZH1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAZH1.AreaIndex = 6;
            this.fieldPNGCRITERIAZH1.Caption = "折痕";
            this.fieldPNGCRITERIAZH1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAZH1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAZH1.FieldName = "PNGCRITERIA_ZH";
            this.fieldPNGCRITERIAZH1.Name = "fieldPNGCRITERIAZH1";
            // 
            // fieldPNGCRITERIAHW1
            // 
            this.fieldPNGCRITERIAHW1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAHW1.AreaIndex = 10;
            this.fieldPNGCRITERIAHW1.Caption = "横弯";
            this.fieldPNGCRITERIAHW1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAHW1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAHW1.FieldName = "PNGCRITERIA_HW";
            this.fieldPNGCRITERIAHW1.Name = "fieldPNGCRITERIAHW1";
            // 
            // fieldPNGCRITERIABJD1
            // 
            this.fieldPNGCRITERIABJD1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIABJD1.AreaIndex = 12;
            this.fieldPNGCRITERIABJD1.Caption = "步距短";
            this.fieldPNGCRITERIABJD1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIABJD1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIABJD1.FieldName = "PNGCRITERIA_BJD";
            this.fieldPNGCRITERIABJD1.Name = "fieldPNGCRITERIABJD1";
            // 
            // fieldPNGCRITERIAOTHER1
            // 
            this.fieldPNGCRITERIAOTHER1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGCRITERIAOTHER1.AreaIndex = 13;
            this.fieldPNGCRITERIAOTHER1.Caption = "其他";
            this.fieldPNGCRITERIAOTHER1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGCRITERIAOTHER1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGCRITERIAOTHER1.FieldName = "PNGCRITERIA_OTHER";
            this.fieldPNGCRITERIAOTHER1.Name = "fieldPNGCRITERIAOTHER1";
            // 
            // fieldPNGQtyInK1
            // 
            this.fieldPNGQtyInK1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGQtyInK1.AreaIndex = 15;
            this.fieldPNGQtyInK1.Caption = "报废数";
            this.fieldPNGQtyInK1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGQtyInK1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGQtyInK1.FieldName = "PNGQtyInK";
            this.fieldPNGQtyInK1.Name = "fieldPNGQtyInK1";
            // 
            // fieldQCFactor1
            // 
            this.fieldQCFactor1.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fieldQCFactor1.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.fieldQCFactor1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQCFactor1.AreaIndex = 17;
            this.fieldQCFactor1.Caption = "指标";
            this.fieldQCFactor1.CellFormat.FormatString = "{0:p}";
            this.fieldQCFactor1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCFactor1.FieldName = "QCFactor";
            this.fieldQCFactor1.Name = "fieldQCFactor1";
            this.fieldQCFactor1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // fieldQCUnitPrice1
            // 
            this.fieldQCUnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQCUnitPrice1.AreaIndex = 18;
            this.fieldQCUnitPrice1.Caption = "单价";
            this.fieldQCUnitPrice1.CellFormat.FormatString = "{0:N2}";
            this.fieldQCUnitPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCUnitPrice1.FieldName = "QCUnitPrice";
            this.fieldQCUnitPrice1.Name = "fieldQCUnitPrice1";
            this.fieldQCUnitPrice1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // fieldQCAmount1
            // 
            this.fieldQCAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQCAmount1.AreaIndex = 19;
            this.fieldQCAmount1.Caption = "金额";
            this.fieldQCAmount1.CellFormat.FormatString = "{0:N2}";
            this.fieldQCAmount1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCAmount1.FieldName = "QCAmount";
            this.fieldQCAmount1.Name = "fieldQCAmount1";
            // 
            // fieldProdDt
            // 
            this.fieldProdDt.AreaIndex = 1;
            this.fieldProdDt.Caption = "生产日期";
            this.fieldProdDt.FieldName = "ProdDt";
            this.fieldProdDt.Name = "fieldProdDt";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "系列";
            this.pivotGridField1.FieldName = "Category";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 84;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.AreaIndex = 3;
            this.pivotGridField2.Caption = "负责人";
            this.pivotGridField2.FieldName = "suppervisor";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // filedQcPer
            // 
            this.filedQcPer.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.filedQcPer.AreaIndex = 16;
            this.filedQcPer.Caption = "报废率";
            this.filedQcPer.CellFormat.FormatString = "p";
            this.filedQcPer.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.filedQcPer.Name = "filedQcPer";
            this.filedQcPer.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // Q202_PNGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 562);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Q202_PNGForm";
            this.Text = "Q202_PNGForm";
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
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJobNO1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQPartNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldplot1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldinqtyink1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAMC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAHDBX1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIADY1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIADJBX1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAWD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIABJC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIACTD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAWJY1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIASX1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAHS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAZH1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAHW1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIABJD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGCRITERIAOTHER1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGQtyInK1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQCFactor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQCUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQCAmount1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdDt;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField filedQcPer;
    }
}