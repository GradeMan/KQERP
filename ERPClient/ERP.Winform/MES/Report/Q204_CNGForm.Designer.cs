namespace ERP.Winform.MES.Report
{
    partial class Q204_CNGForm
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
            this.fieldClot1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldinqtyink1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIACDBF1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAMGS1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIADJBX1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIALW1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIADY1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAOTHER1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAMC1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAHS1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAZS1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAZJFQ1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAHW1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAZW1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAHMQX1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGCRITERIAJDTL1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGQtyInK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQCFactor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQCUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQCAmount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQcper = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.groupControl1.Size = new System.Drawing.Size(906, 70);
            this.groupControl1.TabIndex = 8;
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
            this.fieldClot1,
            this.fieldName1,
            this.fieldInQty1,
            this.fieldinqtyink1,
            this.fieldCNGCRITERIACDBF1,
            this.fieldCNGCRITERIAMGS1,
            this.fieldCNGCRITERIADJBX1,
            this.fieldCNGCRITERIALW1,
            this.fieldCNGCRITERIADY1,
            this.fieldCNGCRITERIAOTHER1,
            this.fieldCNGCRITERIAMC1,
            this.fieldCNGCRITERIAHS1,
            this.fieldCNGCRITERIAZS1,
            this.fieldCNGCRITERIAZJFQ1,
            this.fieldCNGCRITERIAHW1,
            this.fieldCNGCRITERIAZW1,
            this.fieldCNGCRITERIAHMQX1,
            this.fieldCNGCRITERIAJDTL1,
            this.fieldCNGQtyInK1,
            this.fieldQCFactor1,
            this.fieldQCUnitPrice1,
            this.fieldQCAmount1,
            this.pivotGridField1,
            this.pivotGridField2,
            this.fieldQcper});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 70);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(906, 310);
            this.pivotGridControl1.TabIndex = 9;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            // 
            // fieldJobNO1
            // 
            this.fieldJobNO1.AreaIndex = 0;
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
            // fieldClot1
            // 
            this.fieldClot1.AreaIndex = 4;
            this.fieldClot1.Caption = "切断批号";
            this.fieldClot1.FieldName = "Clot";
            this.fieldClot1.Name = "fieldClot1";
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
            this.fieldInQty1.AreaIndex = 1;
            this.fieldInQty1.Caption = "投入数";
            this.fieldInQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldInQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.FieldName = "InQty";
            this.fieldInQty1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldInQty1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.Name = "fieldInQty1";
            this.fieldInQty1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldInQty1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldInQty1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldInQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldinqtyink1
            // 
            this.fieldinqtyink1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldinqtyink1.AreaIndex = 14;
            this.fieldinqtyink1.Caption = "投入K数";
            this.fieldinqtyink1.CellFormat.FormatString = "{0:N2}";
            this.fieldinqtyink1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldinqtyink1.FieldName = "inqtyink";
            this.fieldinqtyink1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldinqtyink1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldinqtyink1.Name = "fieldinqtyink1";
            this.fieldinqtyink1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldinqtyink1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldinqtyink1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldinqtyink1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldinqtyink1.ValueFormat.FormatString = "{0:N2}";
            this.fieldinqtyink1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIACDBF1
            // 
            this.fieldCNGCRITERIACDBF1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIACDBF1.AreaIndex = 0;
            this.fieldCNGCRITERIACDBF1.Caption = "长度不符";
            this.fieldCNGCRITERIACDBF1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIACDBF1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIACDBF1.FieldName = "CNGCRITERIA_CDBF";
            this.fieldCNGCRITERIACDBF1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIACDBF1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIACDBF1.Name = "fieldCNGCRITERIACDBF1";
            this.fieldCNGCRITERIACDBF1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIACDBF1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIACDBF1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIACDBF1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIACDBF1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIACDBF1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAMGS1
            // 
            this.fieldCNGCRITERIAMGS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAMGS1.AreaIndex = 4;
            this.fieldCNGCRITERIAMGS1.Caption = "磨刮伤";
            this.fieldCNGCRITERIAMGS1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMGS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMGS1.FieldName = "CNGCRITERIA_MGS";
            this.fieldCNGCRITERIAMGS1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMGS1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMGS1.Name = "fieldCNGCRITERIAMGS1";
            this.fieldCNGCRITERIAMGS1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMGS1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMGS1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMGS1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMGS1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMGS1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIADJBX1
            // 
            this.fieldCNGCRITERIADJBX1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIADJBX1.AreaIndex = 2;
            this.fieldCNGCRITERIADJBX1.Caption = "导脚变形";
            this.fieldCNGCRITERIADJBX1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADJBX1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADJBX1.FieldName = "CNGCRITERIA_DJBX";
            this.fieldCNGCRITERIADJBX1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADJBX1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADJBX1.Name = "fieldCNGCRITERIADJBX1";
            this.fieldCNGCRITERIADJBX1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADJBX1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADJBX1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADJBX1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADJBX1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADJBX1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIALW1
            // 
            this.fieldCNGCRITERIALW1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIALW1.AreaIndex = 1;
            this.fieldCNGCRITERIALW1.Caption = "拉弯";
            this.fieldCNGCRITERIALW1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIALW1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIALW1.FieldName = "CNGCRITERIA_LW";
            this.fieldCNGCRITERIALW1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIALW1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIALW1.Name = "fieldCNGCRITERIALW1";
            this.fieldCNGCRITERIALW1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIALW1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIALW1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIALW1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIALW1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIALW1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIADY1
            // 
            this.fieldCNGCRITERIADY1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIADY1.AreaIndex = 3;
            this.fieldCNGCRITERIADY1.Caption = "打印";
            this.fieldCNGCRITERIADY1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADY1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADY1.FieldName = "CNGCRITERIA_DY";
            this.fieldCNGCRITERIADY1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADY1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADY1.Name = "fieldCNGCRITERIADY1";
            this.fieldCNGCRITERIADY1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADY1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADY1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADY1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIADY1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIADY1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAOTHER1
            // 
            this.fieldCNGCRITERIAOTHER1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAOTHER1.AreaIndex = 13;
            this.fieldCNGCRITERIAOTHER1.Caption = "其他";
            this.fieldCNGCRITERIAOTHER1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAOTHER1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAOTHER1.FieldName = "CNGCRITERIA_OTHER";
            this.fieldCNGCRITERIAOTHER1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAOTHER1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAOTHER1.Name = "fieldCNGCRITERIAOTHER1";
            this.fieldCNGCRITERIAOTHER1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAOTHER1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAOTHER1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAOTHER1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAOTHER1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAOTHER1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAMC1
            // 
            this.fieldCNGCRITERIAMC1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAMC1.AreaIndex = 5;
            this.fieldCNGCRITERIAMC1.Caption = "毛刺";
            this.fieldCNGCRITERIAMC1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMC1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMC1.FieldName = "CNGCRITERIA_MC";
            this.fieldCNGCRITERIAMC1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMC1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMC1.Name = "fieldCNGCRITERIAMC1";
            this.fieldCNGCRITERIAMC1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMC1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMC1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMC1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAMC1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAMC1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAHS1
            // 
            this.fieldCNGCRITERIAHS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAHS1.AreaIndex = 6;
            this.fieldCNGCRITERIAHS1.Caption = "划伤";
            this.fieldCNGCRITERIAHS1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHS1.FieldName = "CNGCRITERIA_HS";
            this.fieldCNGCRITERIAHS1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHS1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHS1.Name = "fieldCNGCRITERIAHS1";
            this.fieldCNGCRITERIAHS1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHS1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHS1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHS1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHS1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHS1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAZS1
            // 
            this.fieldCNGCRITERIAZS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAZS1.AreaIndex = 7;
            this.fieldCNGCRITERIAZS1.Caption = "撞伤";
            this.fieldCNGCRITERIAZS1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZS1.FieldName = "CNGCRITERIA_ZS";
            this.fieldCNGCRITERIAZS1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZS1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZS1.Name = "fieldCNGCRITERIAZS1";
            this.fieldCNGCRITERIAZS1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZS1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZS1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZS1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZS1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZS1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAZJFQ1
            // 
            this.fieldCNGCRITERIAZJFQ1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAZJFQ1.AreaIndex = 8;
            this.fieldCNGCRITERIAZJFQ1.Caption = "中筋浮起";
            this.fieldCNGCRITERIAZJFQ1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZJFQ1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZJFQ1.FieldName = "CNGCRITERIA_ZJFQ";
            this.fieldCNGCRITERIAZJFQ1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZJFQ1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZJFQ1.Name = "fieldCNGCRITERIAZJFQ1";
            this.fieldCNGCRITERIAZJFQ1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZJFQ1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZJFQ1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZJFQ1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZJFQ1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZJFQ1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAHW1
            // 
            this.fieldCNGCRITERIAHW1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAHW1.AreaIndex = 9;
            this.fieldCNGCRITERIAHW1.Caption = "横弯";
            this.fieldCNGCRITERIAHW1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHW1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHW1.FieldName = "CNGCRITERIA_HW";
            this.fieldCNGCRITERIAHW1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHW1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHW1.Name = "fieldCNGCRITERIAHW1";
            this.fieldCNGCRITERIAHW1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHW1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHW1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHW1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHW1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHW1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAZW1
            // 
            this.fieldCNGCRITERIAZW1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAZW1.AreaIndex = 10;
            this.fieldCNGCRITERIAZW1.Caption = "玷污";
            this.fieldCNGCRITERIAZW1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZW1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZW1.FieldName = "CNGCRITERIA_ZW";
            this.fieldCNGCRITERIAZW1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZW1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZW1.Name = "fieldCNGCRITERIAZW1";
            this.fieldCNGCRITERIAZW1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZW1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZW1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZW1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAZW1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAZW1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAHMQX1
            // 
            this.fieldCNGCRITERIAHMQX1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAHMQX1.AreaIndex = 11;
            this.fieldCNGCRITERIAHMQX1.Caption = "焊面倾斜";
            this.fieldCNGCRITERIAHMQX1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHMQX1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHMQX1.FieldName = "CNGCRITERIA_HMQX";
            this.fieldCNGCRITERIAHMQX1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHMQX1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHMQX1.Name = "fieldCNGCRITERIAHMQX1";
            this.fieldCNGCRITERIAHMQX1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHMQX1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHMQX1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHMQX1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAHMQX1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAHMQX1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGCRITERIAJDTL1
            // 
            this.fieldCNGCRITERIAJDTL1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGCRITERIAJDTL1.AreaIndex = 12;
            this.fieldCNGCRITERIAJDTL1.Caption = "胶带脱落";
            this.fieldCNGCRITERIAJDTL1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAJDTL1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAJDTL1.FieldName = "CNGCRITERIA_JDTL";
            this.fieldCNGCRITERIAJDTL1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAJDTL1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAJDTL1.Name = "fieldCNGCRITERIAJDTL1";
            this.fieldCNGCRITERIAJDTL1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAJDTL1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAJDTL1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAJDTL1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGCRITERIAJDTL1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGCRITERIAJDTL1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldCNGQtyInK1
            // 
            this.fieldCNGQtyInK1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGQtyInK1.AreaIndex = 15;
            this.fieldCNGQtyInK1.Caption = "报废数";
            this.fieldCNGQtyInK1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGQtyInK1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGQtyInK1.FieldName = "CNGQtyInK";
            this.fieldCNGQtyInK1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGQtyInK1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGQtyInK1.Name = "fieldCNGQtyInK1";
            this.fieldCNGQtyInK1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldCNGQtyInK1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGQtyInK1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldCNGQtyInK1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGQtyInK1.ValueFormat.FormatString = "{0:N2}";
            this.fieldCNGQtyInK1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldQCFactor1
            // 
            this.fieldQCFactor1.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fieldQCFactor1.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.fieldQCFactor1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQCFactor1.AreaIndex = 17;
            this.fieldQCFactor1.Caption = "指标";
            this.fieldQCFactor1.CellFormat.FormatString = "p";
            this.fieldQCFactor1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCFactor1.FieldName = "QCFactor";
            this.fieldQCFactor1.GrandTotalCellFormat.FormatString = "p";
            this.fieldQCFactor1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCFactor1.Name = "fieldQCFactor1";
            this.fieldQCFactor1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldQCFactor1.TotalCellFormat.FormatString = "p";
            this.fieldQCFactor1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCFactor1.TotalValueFormat.FormatString = "p";
            this.fieldQCFactor1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCFactor1.ValueFormat.FormatString = "p";
            this.fieldQCFactor1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldQCUnitPrice1
            // 
            this.fieldQCUnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQCUnitPrice1.AreaIndex = 18;
            this.fieldQCUnitPrice1.Caption = "单价";
            this.fieldQCUnitPrice1.CellFormat.FormatString = "{0:N2}";
            this.fieldQCUnitPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCUnitPrice1.FieldName = "QCUnitPrice";
            this.fieldQCUnitPrice1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldQCUnitPrice1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCUnitPrice1.Name = "fieldQCUnitPrice1";
            this.fieldQCUnitPrice1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldQCUnitPrice1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldQCUnitPrice1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCUnitPrice1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldQCUnitPrice1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCUnitPrice1.ValueFormat.FormatString = "{0:N2}";
            this.fieldQCUnitPrice1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldQCAmount1
            // 
            this.fieldQCAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQCAmount1.AreaIndex = 19;
            this.fieldQCAmount1.Caption = "金额";
            this.fieldQCAmount1.CellFormat.FormatString = "{0:N2}";
            this.fieldQCAmount1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCAmount1.FieldName = "QCAmount";
            this.fieldQCAmount1.GrandTotalCellFormat.FormatString = "{0:N2}";
            this.fieldQCAmount1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCAmount1.Name = "fieldQCAmount1";
            this.fieldQCAmount1.TotalCellFormat.FormatString = "{0:N2}";
            this.fieldQCAmount1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCAmount1.TotalValueFormat.FormatString = "{0:N2}";
            this.fieldQCAmount1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQCAmount1.ValueFormat.FormatString = "{0:N2}";
            this.fieldQCAmount1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "系列";
            this.pivotGridField1.FieldName = "Category";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.AreaIndex = 3;
            this.pivotGridField2.Caption = "负责人";
            this.pivotGridField2.FieldName = "Suppervisor";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // fieldQcper
            // 
            this.fieldQcper.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQcper.AreaIndex = 16;
            this.fieldQcper.Caption = "报废率";
            this.fieldQcper.CellFormat.FormatString = "p";
            this.fieldQcper.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQcper.Name = "fieldQcper";
            this.fieldQcper.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // Q204_CNGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 409);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Q204_CNGForm";
            this.Text = "Q204_CNGForm";
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldClot1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldinqtyink1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIACDBF1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAMGS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIADJBX1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIALW1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIADY1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAOTHER1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAMC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAHS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAZS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAZJFQ1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAHW1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAZW1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAHMQX1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGCRITERIAJDTL1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGQtyInK1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQCFactor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQCUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQCAmount1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQcper;
    }
}