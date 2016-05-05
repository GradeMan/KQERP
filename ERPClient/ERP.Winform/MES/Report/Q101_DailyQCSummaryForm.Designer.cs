namespace ERP.Winform.MES.Report
{
    partial class Q101_DailyQCSummaryForm
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
            this.chkiqc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.mESQ101DailyQCSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCategorySeqNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMAT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProcess1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMacCode11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMacCode21 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMacCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSuppervisor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJobType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJobQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIQCNGQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTDInQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTDNgQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTDIQCNGQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.TDNGRate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.NGRate = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkiqc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESQ101DailyQCSummaryBindingSource)).BeginInit();
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
            this.dockPanel1_Container.Controls.Add(this.chkiqc);
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
            // chkiqc
            // 
            this.chkiqc.EditValue = true;
            this.chkiqc.Location = new System.Drawing.Point(409, 16);
            this.chkiqc.MenuManager = this.barManager1;
            this.chkiqc.Name = "chkiqc";
            this.chkiqc.Properties.Caption = "含制程报废";
            this.chkiqc.Size = new System.Drawing.Size(97, 19);
            this.chkiqc.TabIndex = 6;
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
            this.simpleButton1.Location = new System.Drawing.Point(522, 14);
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
            this.pivotGridControl1.DataSource = this.mESQ101DailyQCSummaryBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategorySeqNo1,
            this.fieldCategory1,
            this.fieldMAT1,
            this.fieldProcess1,
            this.fieldMacCode11,
            this.fieldMacCode21,
            this.fieldMacCode1,
            this.fieldSuppervisor1,
            this.fieldJobType1,
            this.fieldJobQty1,
            this.fieldGQty1,
            this.fieldInQty1,
            this.fieldNgQty1,
            this.fieldIQCNGQty1,
            this.fieldTDInQty1,
            this.fieldTDNgQty1,
            this.fieldTDIQCNGQty1,
            this.TDNGRate,
            this.NGRate});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 88);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1123, 435);
            this.pivotGridControl1.TabIndex = 5;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            this.pivotGridControl1.CustomAppearance += new DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(this.pivotGridControl1_CustomAppearance);
            // 
            // mESQ101DailyQCSummaryBindingSource
            // 
            this.mESQ101DailyQCSummaryBindingSource.DataSource = typeof(ERP.Domain.MES_Q101_DailyQCSummary);
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
            this.fieldCategory1.AreaIndex = 3;
            this.fieldCategory1.Caption = "产品系列";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            // 
            // fieldMAT1
            // 
            this.fieldMAT1.AreaIndex = 1;
            this.fieldMAT1.Caption = "材质";
            this.fieldMAT1.FieldName = "MAT";
            this.fieldMAT1.Name = "fieldMAT1";
            // 
            // fieldProcess1
            // 
            this.fieldProcess1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProcess1.AreaIndex = 0;
            this.fieldProcess1.Caption = "部门";
            this.fieldProcess1.FieldName = "Process";
            this.fieldProcess1.Name = "fieldProcess1";
            // 
            // fieldMacCode11
            // 
            this.fieldMacCode11.AreaIndex = 2;
            this.fieldMacCode11.Caption = "机台2";
            this.fieldMacCode11.FieldName = "MacCode1";
            this.fieldMacCode11.Name = "fieldMacCode11";
            // 
            // fieldMacCode21
            // 
            this.fieldMacCode21.AreaIndex = 3;
            this.fieldMacCode21.Caption = "机台3";
            this.fieldMacCode21.FieldName = "MacCode2";
            this.fieldMacCode21.Name = "fieldMacCode21";
            // 
            // fieldMacCode1
            // 
            this.fieldMacCode1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMacCode1.AreaIndex = 2;
            this.fieldMacCode1.Caption = "机台";
            this.fieldMacCode1.FieldName = "MacCode";
            this.fieldMacCode1.Name = "fieldMacCode1";
            // 
            // fieldSuppervisor1
            // 
            this.fieldSuppervisor1.AreaIndex = 4;
            this.fieldSuppervisor1.Caption = "班长";
            this.fieldSuppervisor1.FieldName = "Suppervisor";
            this.fieldSuppervisor1.Name = "fieldSuppervisor1";
            // 
            // fieldJobType1
            // 
            this.fieldJobType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldJobType1.AreaIndex = 1;
            this.fieldJobType1.Caption = "生产类型";
            this.fieldJobType1.FieldName = "JobType";
            this.fieldJobType1.Name = "fieldJobType1";
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
            this.fieldInQty1.AreaIndex = 4;
            this.fieldInQty1.Caption = "总投入数";
            this.fieldInQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldInQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.FieldName = "InQty";
            this.fieldInQty1.Name = "fieldInQty1";
            this.fieldInQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldInQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldNgQty1
            // 
            this.fieldNgQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNgQty1.AreaIndex = 5;
            this.fieldNgQty1.Caption = "总报废数";
            this.fieldNgQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldNgQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNgQty1.FieldName = "NgQty";
            this.fieldNgQty1.Name = "fieldNgQty1";
            this.fieldNgQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldNgQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldIQCNGQty1
            // 
            this.fieldIQCNGQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldIQCNGQty1.AreaIndex = 6;
            this.fieldIQCNGQty1.Caption = "制程报废";
            this.fieldIQCNGQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldIQCNGQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldIQCNGQty1.FieldName = "IQCNGQty";
            this.fieldIQCNGQty1.Name = "fieldIQCNGQty1";
            this.fieldIQCNGQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldIQCNGQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldTDInQty1
            // 
            this.fieldTDInQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTDInQty1.AreaIndex = 0;
            this.fieldTDInQty1.Caption = "投入(当天)";
            this.fieldTDInQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldTDInQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTDInQty1.FieldName = "TDInQty";
            this.fieldTDInQty1.Name = "fieldTDInQty1";
            this.fieldTDInQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldTDInQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldTDNgQty1
            // 
            this.fieldTDNgQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTDNgQty1.AreaIndex = 1;
            this.fieldTDNgQty1.Caption = "报废(当天)";
            this.fieldTDNgQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldTDNgQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTDNgQty1.FieldName = "TDNgQty";
            this.fieldTDNgQty1.Name = "fieldTDNgQty1";
            this.fieldTDNgQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldTDNgQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldTDIQCNGQty1
            // 
            this.fieldTDIQCNGQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTDIQCNGQty1.AreaIndex = 2;
            this.fieldTDIQCNGQty1.Caption = "制程报废(当天)";
            this.fieldTDIQCNGQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldTDIQCNGQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTDIQCNGQty1.FieldName = "TDIQCNGQty";
            this.fieldTDIQCNGQty1.Name = "fieldTDIQCNGQty1";
            this.fieldTDIQCNGQty1.ValueFormat.FormatString = "{0:N2}";
            this.fieldTDIQCNGQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // TDNGRate
            // 
            this.TDNGRate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.TDNGRate.AreaIndex = 3;
            this.TDNGRate.Caption = "报废率(当天)";
            this.TDNGRate.CellFormat.FormatString = "p";
            this.TDNGRate.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TDNGRate.Name = "TDNGRate";
            this.TDNGRate.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.TDNGRate.ValueFormat.FormatString = "p";
            this.TDNGRate.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // NGRate
            // 
            this.NGRate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.NGRate.AreaIndex = 7;
            this.NGRate.Caption = "报废率";
            this.NGRate.CellFormat.FormatString = "p";
            this.NGRate.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGRate.Name = "NGRate";
            this.NGRate.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.NGRate.ValueFormat.FormatString = "p";
            this.NGRate.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // Q101_DailyQCSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 552);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "Q101_DailyQCSummaryForm";
            this.Text = "Q101-质量统计报表";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkiqc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESQ101DailyQCSummaryBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource mESQ101DailyQCSummaryBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategorySeqNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMAT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProcess1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMacCode11;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMacCode21;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMacCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSuppervisor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJobType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJobQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIQCNGQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTDInQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTDNgQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTDIQCNGQty1;
        private DevExpress.XtraPivotGrid.PivotGridField TDNGRate;
        private DevExpress.XtraPivotGrid.PivotGridField NGRate;
        private DevExpress.XtraEditors.CheckEdit chkiqc;
    }
}