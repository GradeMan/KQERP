namespace ERP.Winform.MES.Report
{
    partial class Q102_DailyQCForm
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.mESQ102DailyQCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldYYYYMM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWeek1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProdDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategorySeqNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProcess1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldmacCode11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMacCode21 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMacCode31 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSuppervisor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJobQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIQCNGQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgQty = new DevExpress.XtraPivotGrid.PivotGridField();
            this.FieldNGRate = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESQ102DailyQCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel1.ID = new System.Guid("2c3e095e-c194-43d7-a8ff-28e3340df1cf");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 88);
            this.dockPanel1.Size = new System.Drawing.Size(1123, 88);
            this.dockPanel1.Text = "查询条件";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.simpleButton1);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt1);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1115, 61);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(220, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "生产日期:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(432, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(89, 13);
            this.txtProdDt1.MenuManager = this.barManager1;
            this.txtProdDt1.Name = "txtProdDt1";
            this.txtProdDt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.Mask.EditMask = "";
            this.txtProdDt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt1.Size = new System.Drawing.Size(127, 20);
            this.txtProdDt1.TabIndex = 0;
            // 
            // txtProdDt2
            // 
            this.txtProdDt2.EditValue = null;
            this.txtProdDt2.Location = new System.Drawing.Point(230, 13);
            this.txtProdDt2.MenuManager = this.barManager1;
            this.txtProdDt2.Name = "txtProdDt2";
            this.txtProdDt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.Mask.EditMask = "";
            this.txtProdDt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt2.Size = new System.Drawing.Size(152, 20);
            this.txtProdDt2.TabIndex = 1;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.mESQ102DailyQCBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYYYYMM1,
            this.fieldWeek1,
            this.fieldProdDt1,
            this.fieldCategorySeqNo1,
            this.fieldCategory1,
            this.fieldProcess1,
            this.fieldmacCode11,
            this.fieldMacCode21,
            this.fieldMacCode31,
            this.fieldSuppervisor1,
            this.fieldJobQty1,
            this.fieldGQty1,
            this.fieldInQty1,
            this.fieldIQCNGQty1,
            this.fieldNgQty,
            this.FieldNGRate});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 88);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1123, 435);
            this.pivotGridControl1.TabIndex = 5;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            this.pivotGridControl1.CustomAppearance += new DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(this.pivotGridControl1_CustomAppearance);
            // 
            // mESQ102DailyQCBindingSource
            // 
            this.mESQ102DailyQCBindingSource.DataSource = typeof(ERP.Domain.MES_Q102_DailyQC);
            // 
            // fieldYYYYMM1
            // 
            this.fieldYYYYMM1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYYYYMM1.AreaIndex = 0;
            this.fieldYYYYMM1.Caption = "年度";
            this.fieldYYYYMM1.FieldName = "YYYYMM";
            this.fieldYYYYMM1.Name = "fieldYYYYMM1";
            // 
            // fieldWeek1
            // 
            this.fieldWeek1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldWeek1.AreaIndex = 1;
            this.fieldWeek1.Caption = "周";
            this.fieldWeek1.FieldName = "Week";
            this.fieldWeek1.Name = "fieldWeek1";
            // 
            // fieldProdDt1
            // 
            this.fieldProdDt1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProdDt1.AreaIndex = 2;
            this.fieldProdDt1.Caption = "日期";
            this.fieldProdDt1.FieldName = "ProdDt";
            this.fieldProdDt1.Name = "fieldProdDt1";
            // 
            // fieldCategorySeqNo1
            // 
            this.fieldCategorySeqNo1.AreaIndex = 0;
            this.fieldCategorySeqNo1.Caption = "系列序号";
            this.fieldCategorySeqNo1.FieldName = "CategorySeqNo";
            this.fieldCategorySeqNo1.Name = "fieldCategorySeqNo1";
            // 
            // fieldCategory1
            // 
            this.fieldCategory1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory1.AreaIndex = 1;
            this.fieldCategory1.Caption = "系列";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            // 
            // fieldProcess1
            // 
            this.fieldProcess1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProcess1.AreaIndex = 0;
            this.fieldProcess1.Caption = "部门";
            this.fieldProcess1.FieldName = "Process";
            this.fieldProcess1.Name = "fieldProcess1";
            // 
            // fieldmacCode11
            // 
            this.fieldmacCode11.AreaIndex = 1;
            this.fieldmacCode11.Caption = "机台1";
            this.fieldmacCode11.FieldName = "macCode1";
            this.fieldmacCode11.Name = "fieldmacCode11";
            // 
            // fieldMacCode21
            // 
            this.fieldMacCode21.AreaIndex = 2;
            this.fieldMacCode21.Caption = "机台2";
            this.fieldMacCode21.FieldName = "MacCode2";
            this.fieldMacCode21.Name = "fieldMacCode21";
            // 
            // fieldMacCode31
            // 
            this.fieldMacCode31.AreaIndex = 3;
            this.fieldMacCode31.Caption = "机台3";
            this.fieldMacCode31.FieldName = "MacCode3";
            this.fieldMacCode31.Name = "fieldMacCode31";
            // 
            // fieldSuppervisor1
            // 
            this.fieldSuppervisor1.AreaIndex = 4;
            this.fieldSuppervisor1.Caption = "负责人";
            this.fieldSuppervisor1.FieldName = "Suppervisor";
            this.fieldSuppervisor1.Name = "fieldSuppervisor1";
            // 
            // fieldJobQty1
            // 
            this.fieldJobQty1.AreaIndex = 5;
            this.fieldJobQty1.Caption = "现品票数量";
            this.fieldJobQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldJobQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldJobQty1.FieldName = "JobQty";
            this.fieldJobQty1.Name = "fieldJobQty1";
            this.fieldJobQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldJobQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldGQty1
            // 
            this.fieldGQty1.AreaIndex = 6;
            this.fieldGQty1.Caption = "良品数";
            this.fieldGQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldGQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGQty1.FieldName = "GQty";
            this.fieldGQty1.Name = "fieldGQty1";
            this.fieldGQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldGQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldInQty1
            // 
            this.fieldInQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInQty1.AreaIndex = 0;
            this.fieldInQty1.Caption = "投入数";
            this.fieldInQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldInQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.FieldName = "InQty";
            this.fieldInQty1.Name = "fieldInQty1";
            this.fieldInQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldInQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldIQCNGQty1
            // 
            this.fieldIQCNGQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldIQCNGQty1.AreaIndex = 2;
            this.fieldIQCNGQty1.Caption = "制程报废数";
            this.fieldIQCNGQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldIQCNGQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldIQCNGQty1.FieldName = "IQCNGQty";
            this.fieldIQCNGQty1.Name = "fieldIQCNGQty1";
            this.fieldIQCNGQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldIQCNGQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldNgQty
            // 
            this.fieldNgQty.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNgQty.AreaIndex = 1;
            this.fieldNgQty.Caption = "报废数";
            this.fieldNgQty.CellFormat.FormatString = "{0:N2}";
            this.fieldNgQty.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNgQty.FieldName = "NgQty";
            this.fieldNgQty.Name = "fieldNgQty";
            this.fieldNgQty.ValueFormat.FormatString = "{0:N2}";
            this.fieldNgQty.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // FieldNGRate
            // 
            this.FieldNGRate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.FieldNGRate.AreaIndex = 3;
            this.FieldNGRate.Caption = "报废率";
            this.FieldNGRate.CellFormat.FormatString = "p";
            this.FieldNGRate.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FieldNGRate.Name = "FieldNGRate";
            this.FieldNGRate.ValueFormat.FormatString = "p";
            this.FieldNGRate.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // Q102_DailyQCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 552);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "Q102_DailyQCForm";
            this.Text = "Q102-质量日报表";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESQ102DailyQCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource mESQ102DailyQCBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYYYYMM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWeek1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdDt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategorySeqNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProcess1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldmacCode11;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMacCode21;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMacCode31;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSuppervisor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJobQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIQCNGQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgQty;
        private DevExpress.XtraPivotGrid.PivotGridField FieldNGRate;
    }
}