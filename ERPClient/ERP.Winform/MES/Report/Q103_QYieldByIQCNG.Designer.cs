namespace ERP.Winform.MES.Report
{
    partial class Q103_QYieldByIQCNG
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
            this.chkiqc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldJobType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQPartNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProdDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGQtyInK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPIQCNGQtyInk1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldENGQtyInK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldEIQCNGQtyInk1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCNGQtyInK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCIQCNGQtyInk1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFNGQtyInK1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFIQCNGQtyInk1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPinqtyink1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldEinqtyink1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCinqtyink1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFinqtyink1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOutQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colNgQtyPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPNGQtyPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colENGQtyPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colCNGQtyPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colFNGQtyPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPNGQtyInKbyQCAmt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldENGQtyInKbyQCAmt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkiqc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkiqc);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtProdDt1);
            this.groupControl1.Controls.Add(this.txtProdDt2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1100, 88);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "查询条件";
            // 
            // chkiqc
            // 
            this.chkiqc.EditValue = true;
            this.chkiqc.Location = new System.Drawing.Point(421, 37);
            this.chkiqc.MenuManager = this.barManager1;
            this.chkiqc.Name = "chkiqc";
            this.chkiqc.Properties.Caption = "含制程报废";
            this.chkiqc.Size = new System.Drawing.Size(97, 19);
            this.chkiqc.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(236, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "生产日期:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(524, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(105, 39);
            this.txtProdDt1.MenuManager = this.barManager1;
            this.txtProdDt1.Name = "txtProdDt1";
            this.txtProdDt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.Mask.EditMask = "";
            this.txtProdDt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt1.Size = new System.Drawing.Size(127, 20);
            this.txtProdDt1.TabIndex = 7;
            // 
            // txtProdDt2
            // 
            this.txtProdDt2.EditValue = null;
            this.txtProdDt2.Location = new System.Drawing.Point(246, 39);
            this.txtProdDt2.MenuManager = this.barManager1;
            this.txtProdDt2.Name = "txtProdDt2";
            this.txtProdDt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.Mask.EditMask = "";
            this.txtProdDt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt2.Size = new System.Drawing.Size(152, 20);
            this.txtProdDt2.TabIndex = 8;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldJobType1,
            this.fieldCategory1,
            this.fieldQPartNo1,
            this.fieldProdDt1,
            this.fieldNgQty1,
            this.fieldPNGQtyInK1,
            this.fieldPIQCNGQtyInk1,
            this.fieldENGQtyInK1,
            this.fieldEIQCNGQtyInk1,
            this.fieldCNGQtyInK1,
            this.fieldCIQCNGQtyInk1,
            this.fieldFNGQtyInK1,
            this.fieldFIQCNGQtyInk1,
            this.fieldPinqtyink1,
            this.fieldEinqtyink1,
            this.fieldCinqtyink1,
            this.fieldFinqtyink1,
            this.fieldInQty1,
            this.fieldOutQty1,
            this.colNgQtyPercent,
            this.colPNGQtyPercent,
            this.colENGQtyPercent,
            this.colCNGQtyPercent,
            this.colFNGQtyPercent,
            this.fieldPNGQtyInKbyQCAmt1,
            this.fieldENGQtyInKbyQCAmt1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 88);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
            this.pivotGridControl1.Size = new System.Drawing.Size(1100, 427);
            this.pivotGridControl1.TabIndex = 5;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            // 
            // fieldJobType1
            // 
            this.fieldJobType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldJobType1.AreaIndex = 0;
            this.fieldJobType1.Caption = "生产类型";
            this.fieldJobType1.FieldName = "JobType";
            this.fieldJobType1.Name = "fieldJobType1";
            this.fieldJobType1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldJobType1.Width = 85;
            // 
            // fieldCategory1
            // 
            this.fieldCategory1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory1.AreaIndex = 1;
            this.fieldCategory1.Caption = "系列";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            // 
            // fieldQPartNo1
            // 
            this.fieldQPartNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldQPartNo1.AreaIndex = 2;
            this.fieldQPartNo1.Caption = "产品";
            this.fieldQPartNo1.FieldName = "QPartNo";
            this.fieldQPartNo1.Name = "fieldQPartNo1";
            // 
            // fieldProdDt1
            // 
            this.fieldProdDt1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProdDt1.AreaIndex = 0;
            this.fieldProdDt1.Caption = "生产日期";
            this.fieldProdDt1.FieldName = "ProdDt";
            this.fieldProdDt1.Name = "fieldProdDt1";
            // 
            // fieldNgQty1
            // 
            this.fieldNgQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNgQty1.AreaIndex = 2;
            this.fieldNgQty1.Caption = "报废K数";
            this.fieldNgQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldNgQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNgQty1.FieldName = "NgQty";
            this.fieldNgQty1.Name = "fieldNgQty1";
            // 
            // fieldPNGQtyInK1
            // 
            this.fieldPNGQtyInK1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGQtyInK1.AreaIndex = 5;
            this.fieldPNGQtyInK1.Caption = "冲压报废";
            this.fieldPNGQtyInK1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGQtyInK1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGQtyInK1.FieldName = "PNGQtyInK";
            this.fieldPNGQtyInK1.Name = "fieldPNGQtyInK1";
            // 
            // fieldPIQCNGQtyInk1
            // 
            this.fieldPIQCNGQtyInk1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPIQCNGQtyInk1.AreaIndex = 6;
            this.fieldPIQCNGQtyInk1.Caption = "冲压废料";
            this.fieldPIQCNGQtyInk1.CellFormat.FormatString = "{0:N2}";
            this.fieldPIQCNGQtyInk1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPIQCNGQtyInk1.FieldName = "PIQCNGQtyInk";
            this.fieldPIQCNGQtyInk1.Name = "fieldPIQCNGQtyInk1";
            // 
            // fieldENGQtyInK1
            // 
            this.fieldENGQtyInK1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldENGQtyInK1.AreaIndex = 10;
            this.fieldENGQtyInK1.Caption = "电镀报废";
            this.fieldENGQtyInK1.CellFormat.FormatString = "{0:N2}";
            this.fieldENGQtyInK1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldENGQtyInK1.FieldName = "ENGQtyInK";
            this.fieldENGQtyInK1.Name = "fieldENGQtyInK1";
            // 
            // fieldEIQCNGQtyInk1
            // 
            this.fieldEIQCNGQtyInk1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldEIQCNGQtyInk1.AreaIndex = 11;
            this.fieldEIQCNGQtyInk1.Caption = "电镀废料";
            this.fieldEIQCNGQtyInk1.CellFormat.FormatString = "{0:N2}";
            this.fieldEIQCNGQtyInk1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldEIQCNGQtyInk1.FieldName = "EIQCNGQtyInk";
            this.fieldEIQCNGQtyInk1.Name = "fieldEIQCNGQtyInk1";
            // 
            // fieldCNGQtyInK1
            // 
            this.fieldCNGQtyInK1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCNGQtyInK1.AreaIndex = 15;
            this.fieldCNGQtyInK1.Caption = "切断报废";
            this.fieldCNGQtyInK1.CellFormat.FormatString = "{0:N2}";
            this.fieldCNGQtyInK1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCNGQtyInK1.FieldName = "CNGQtyInK";
            this.fieldCNGQtyInK1.Name = "fieldCNGQtyInK1";
            // 
            // fieldCIQCNGQtyInk1
            // 
            this.fieldCIQCNGQtyInk1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCIQCNGQtyInk1.AreaIndex = 16;
            this.fieldCIQCNGQtyInk1.Caption = "切断废料";
            this.fieldCIQCNGQtyInk1.CellFormat.FormatString = "{0:N2}";
            this.fieldCIQCNGQtyInk1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCIQCNGQtyInk1.FieldName = "CIQCNGQtyInk";
            this.fieldCIQCNGQtyInk1.Name = "fieldCIQCNGQtyInk1";
            // 
            // fieldFNGQtyInK1
            // 
            this.fieldFNGQtyInK1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldFNGQtyInK1.AreaIndex = 19;
            this.fieldFNGQtyInK1.Caption = "其他报废";
            this.fieldFNGQtyInK1.CellFormat.FormatString = "{0:N2}";
            this.fieldFNGQtyInK1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldFNGQtyInK1.FieldName = "FNGQtyInK";
            this.fieldFNGQtyInK1.Name = "fieldFNGQtyInK1";
            // 
            // fieldFIQCNGQtyInk1
            // 
            this.fieldFIQCNGQtyInk1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldFIQCNGQtyInk1.AreaIndex = 20;
            this.fieldFIQCNGQtyInk1.Caption = "其他废料";
            this.fieldFIQCNGQtyInk1.CellFormat.FormatString = "{0:N2}";
            this.fieldFIQCNGQtyInk1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldFIQCNGQtyInk1.FieldName = "FIQCNGQtyInk";
            this.fieldFIQCNGQtyInk1.Name = "fieldFIQCNGQtyInk1";
            // 
            // fieldPinqtyink1
            // 
            this.fieldPinqtyink1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPinqtyink1.AreaIndex = 4;
            this.fieldPinqtyink1.Caption = "冲压投入数";
            this.fieldPinqtyink1.CellFormat.FormatString = "{0:N2}";
            this.fieldPinqtyink1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPinqtyink1.FieldName = "Pinqtyink";
            this.fieldPinqtyink1.Name = "fieldPinqtyink1";
            // 
            // fieldEinqtyink1
            // 
            this.fieldEinqtyink1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldEinqtyink1.AreaIndex = 9;
            this.fieldEinqtyink1.Caption = "电镀投入数";
            this.fieldEinqtyink1.CellFormat.FormatString = "{0:N2}";
            this.fieldEinqtyink1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldEinqtyink1.FieldName = "Einqtyink";
            this.fieldEinqtyink1.Name = "fieldEinqtyink1";
            // 
            // fieldCinqtyink1
            // 
            this.fieldCinqtyink1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCinqtyink1.AreaIndex = 14;
            this.fieldCinqtyink1.Caption = "切断投入数";
            this.fieldCinqtyink1.CellFormat.FormatString = "{0:N2}";
            this.fieldCinqtyink1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldCinqtyink1.FieldName = "Cinqtyink";
            this.fieldCinqtyink1.Name = "fieldCinqtyink1";
            // 
            // fieldFinqtyink1
            // 
            this.fieldFinqtyink1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldFinqtyink1.AreaIndex = 18;
            this.fieldFinqtyink1.Caption = "其他投入数";
            this.fieldFinqtyink1.CellFormat.FormatString = "{0:N2}";
            this.fieldFinqtyink1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldFinqtyink1.FieldName = "Finqtyink";
            this.fieldFinqtyink1.Name = "fieldFinqtyink1";
            // 
            // fieldInQty1
            // 
            this.fieldInQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInQty1.AreaIndex = 0;
            this.fieldInQty1.Caption = "投入总数";
            this.fieldInQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldInQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.FieldName = "InQty";
            this.fieldInQty1.Name = "fieldInQty1";
            // 
            // fieldOutQty1
            // 
            this.fieldOutQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldOutQty1.AreaIndex = 1;
            this.fieldOutQty1.Caption = "良品数";
            this.fieldOutQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldOutQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldOutQty1.FieldName = "OutQty";
            this.fieldOutQty1.Name = "fieldOutQty1";
            // 
            // colNgQtyPercent
            // 
            this.colNgQtyPercent.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colNgQtyPercent.Appearance.Cell.Options.UseBackColor = true;
            this.colNgQtyPercent.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colNgQtyPercent.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.colNgQtyPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colNgQtyPercent.AreaIndex = 3;
            this.colNgQtyPercent.Caption = "报废率";
            this.colNgQtyPercent.CellFormat.FormatString = "p";
            this.colNgQtyPercent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNgQtyPercent.Name = "colNgQtyPercent";
            this.colNgQtyPercent.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // colPNGQtyPercent
            // 
            this.colPNGQtyPercent.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colPNGQtyPercent.Appearance.Cell.Options.UseBackColor = true;
            this.colPNGQtyPercent.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colPNGQtyPercent.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.colPNGQtyPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colPNGQtyPercent.AreaIndex = 7;
            this.colPNGQtyPercent.Caption = "冲压报废率";
            this.colPNGQtyPercent.CellFormat.FormatString = "p";
            this.colPNGQtyPercent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPNGQtyPercent.Name = "colPNGQtyPercent";
            this.colPNGQtyPercent.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // colENGQtyPercent
            // 
            this.colENGQtyPercent.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colENGQtyPercent.Appearance.Cell.Options.UseBackColor = true;
            this.colENGQtyPercent.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colENGQtyPercent.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.colENGQtyPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colENGQtyPercent.AreaIndex = 12;
            this.colENGQtyPercent.Caption = "电镀报废率";
            this.colENGQtyPercent.CellFormat.FormatString = "p";
            this.colENGQtyPercent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colENGQtyPercent.Name = "colENGQtyPercent";
            this.colENGQtyPercent.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // colCNGQtyPercent
            // 
            this.colCNGQtyPercent.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colCNGQtyPercent.Appearance.Cell.Options.UseBackColor = true;
            this.colCNGQtyPercent.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colCNGQtyPercent.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.colCNGQtyPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colCNGQtyPercent.AreaIndex = 17;
            this.colCNGQtyPercent.Caption = "切断报废率";
            this.colCNGQtyPercent.CellFormat.FormatString = "p";
            this.colCNGQtyPercent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCNGQtyPercent.Name = "colCNGQtyPercent";
            this.colCNGQtyPercent.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // colFNGQtyPercent
            // 
            this.colFNGQtyPercent.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colFNGQtyPercent.Appearance.Cell.Options.UseBackColor = true;
            this.colFNGQtyPercent.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colFNGQtyPercent.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.colFNGQtyPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colFNGQtyPercent.AreaIndex = 21;
            this.colFNGQtyPercent.Caption = "其他报废率";
            this.colFNGQtyPercent.CellFormat.FormatString = "p";
            this.colFNGQtyPercent.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFNGQtyPercent.Name = "colFNGQtyPercent";
            this.colFNGQtyPercent.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // fieldPNGQtyInKbyQCAmt1
            // 
            this.fieldPNGQtyInKbyQCAmt1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPNGQtyInKbyQCAmt1.AreaIndex = 8;
            this.fieldPNGQtyInKbyQCAmt1.Caption = "冲压金额";
            this.fieldPNGQtyInKbyQCAmt1.CellFormat.FormatString = "{0:N2}";
            this.fieldPNGQtyInKbyQCAmt1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPNGQtyInKbyQCAmt1.FieldName = "PNGQtyInKbyQCAmt";
            this.fieldPNGQtyInKbyQCAmt1.Name = "fieldPNGQtyInKbyQCAmt1";
            // 
            // fieldENGQtyInKbyQCAmt1
            // 
            this.fieldENGQtyInKbyQCAmt1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldENGQtyInKbyQCAmt1.AreaIndex = 13;
            this.fieldENGQtyInKbyQCAmt1.Caption = "电镀金额";
            this.fieldENGQtyInKbyQCAmt1.CellFormat.FormatString = "{0:N2}";
            this.fieldENGQtyInKbyQCAmt1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldENGQtyInKbyQCAmt1.FieldName = "ENGQtyInKbyQCAmt";
            this.fieldENGQtyInKbyQCAmt1.Name = "fieldENGQtyInKbyQCAmt1";
            // 
            // Q103_QYieldByIQCNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 544);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Q103_QYieldByIQCNG";
            this.Text = "Q103_QYieldByIQCNG";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkiqc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkiqc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJobType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQPartNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdDt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGQtyInK1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPIQCNGQtyInk1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldENGQtyInK1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldEIQCNGQtyInk1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCNGQtyInK1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCIQCNGQtyInk1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFNGQtyInK1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFIQCNGQtyInk1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPinqtyink1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldEinqtyink1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCinqtyink1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFinqtyink1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOutQty1;
        private DevExpress.XtraPivotGrid.PivotGridField colNgQtyPercent;
        private DevExpress.XtraPivotGrid.PivotGridField colPNGQtyPercent;
        private DevExpress.XtraPivotGrid.PivotGridField colENGQtyPercent;
        private DevExpress.XtraPivotGrid.PivotGridField colCNGQtyPercent;
        private DevExpress.XtraPivotGrid.PivotGridField colFNGQtyPercent;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPNGQtyInKbyQCAmt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldENGQtyInKbyQCAmt1;
    }
}