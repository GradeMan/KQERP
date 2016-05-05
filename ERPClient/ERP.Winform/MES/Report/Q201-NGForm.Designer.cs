namespace ERP.Winform.MES.Report
{
    partial class Q201_NGForm
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldYYYYMM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProdDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProcess1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNGItemNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNGItemQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYYYYMM1,
            this.fieldProdDt1,
            this.fieldCategory1,
            this.fieldPartNo1,
            this.fieldProcess1,
            this.fieldNGItemNo1,
            this.fieldNGItemQty1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 70);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGridControl1.Size = new System.Drawing.Size(910, 417);
            this.pivotGridControl1.TabIndex = 4;
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            // 
            // fieldYYYYMM1
            // 
            this.fieldYYYYMM1.AreaIndex = 0;
            this.fieldYYYYMM1.Caption = "月份";
            this.fieldYYYYMM1.FieldName = "YYYYMM";
            this.fieldYYYYMM1.Name = "fieldYYYYMM1";
            // 
            // fieldProdDt1
            // 
            this.fieldProdDt1.AreaIndex = 2;
            this.fieldProdDt1.Caption = "日期";
            this.fieldProdDt1.FieldName = "ProdDt";
            this.fieldProdDt1.Name = "fieldProdDt1";
            // 
            // fieldCategory1
            // 
            this.fieldCategory1.AreaIndex = 1;
            this.fieldCategory1.Caption = "系列";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            // 
            // fieldPartNo1
            // 
            this.fieldPartNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartNo1.AreaIndex = 0;
            this.fieldPartNo1.Caption = "品名";
            this.fieldPartNo1.FieldName = "PartNo";
            this.fieldPartNo1.Name = "fieldPartNo1";
            // 
            // fieldProcess1
            // 
            this.fieldProcess1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProcess1.AreaIndex = 0;
            this.fieldProcess1.Caption = "制程";
            this.fieldProcess1.FieldName = "Process";
            this.fieldProcess1.Name = "fieldProcess1";
            // 
            // fieldNGItemNo1
            // 
            this.fieldNGItemNo1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldNGItemNo1.AreaIndex = 1;
            this.fieldNGItemNo1.Caption = "报废项目";
            this.fieldNGItemNo1.FieldName = "NGItemNo";
            this.fieldNGItemNo1.Name = "fieldNGItemNo1";
            // 
            // fieldNGItemQty1
            // 
            this.fieldNGItemQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNGItemQty1.AreaIndex = 0;
            this.fieldNGItemQty1.Caption = "报废数";
            this.fieldNGItemQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldNGItemQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNGItemQty1.FieldName = "NGItemQty";
            this.fieldNGItemQty1.Name = "fieldNGItemQty1";
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
            this.groupControl1.Size = new System.Drawing.Size(910, 70);
            this.groupControl1.TabIndex = 5;
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
            // Q201_NGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 516);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Q201_NGForm";
            this.Text = "Q201_NGForm";
            this.Load += new System.EventHandler(this.Q201_NGForm_Load);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYYYYMM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdDt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProcess1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNGItemNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNGItemQty1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
    }
}