namespace ERP.Winform.Device
{
    partial class DeviceForm
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
            this.dEVD001DeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevFunction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevExFacDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevCompanyNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStorageAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevInProdDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstMaintain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgreementNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVD001DeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.dEVD001DeviceBindingSource;
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
            this.ykGridControl1.Size = new System.Drawing.Size(1233, 505);
            this.ykGridControl1.TabIndex = 4;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dEVD001DeviceBindingSource
            // 
            this.dEVD001DeviceBindingSource.DataSource = typeof(ERP.Domain.DEV_D001_Device);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colDevNo,
            this.colDevName,
            this.colDevVersion,
            this.colDepartNo,
            this.colSuppCode,
            this.colDevFunction,
            this.colDevSpec,
            this.colDevExFacDt,
            this.colDevCompanyNo,
            this.colDevType,
            this.colStatus,
            this.colStorageAddress,
            this.colDevInProdDt,
            this.colDevManager,
            this.colFirstMaintain,
            this.colAgreementNo,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Width = 42;
            // 
            // colDevNo
            // 
            this.colDevNo.Caption = "设备编号";
            this.colDevNo.FieldName = "DevNo";
            this.colDevNo.Name = "colDevNo";
            this.colDevNo.Visible = true;
            this.colDevNo.VisibleIndex = 0;
            this.colDevNo.Width = 42;
            // 
            // colDevName
            // 
            this.colDevName.Caption = "设备名称";
            this.colDevName.FieldName = "DevName";
            this.colDevName.Name = "colDevName";
            this.colDevName.Visible = true;
            this.colDevName.VisibleIndex = 1;
            this.colDevName.Width = 42;
            // 
            // colDevVersion
            // 
            this.colDevVersion.Caption = "设备型号";
            this.colDevVersion.FieldName = "DevVersion";
            this.colDevVersion.Name = "colDevVersion";
            this.colDevVersion.Visible = true;
            this.colDevVersion.VisibleIndex = 2;
            this.colDevVersion.Width = 42;
            // 
            // colDepartNo
            // 
            this.colDepartNo.Caption = "使用部门";
            this.colDepartNo.FieldName = "DepartNo";
            this.colDepartNo.Name = "colDepartNo";
            this.colDepartNo.Visible = true;
            this.colDepartNo.VisibleIndex = 3;
            this.colDepartNo.Width = 42;
            // 
            // colSuppCode
            // 
            this.colSuppCode.Caption = "制造厂商";
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.Visible = true;
            this.colSuppCode.VisibleIndex = 4;
            this.colSuppCode.Width = 42;
            // 
            // colDevFunction
            // 
            this.colDevFunction.Caption = "设备用途";
            this.colDevFunction.FieldName = "DevFunction";
            this.colDevFunction.Name = "colDevFunction";
            this.colDevFunction.Visible = true;
            this.colDevFunction.VisibleIndex = 5;
            this.colDevFunction.Width = 42;
            // 
            // colDevSpec
            // 
            this.colDevSpec.Caption = "设备规格";
            this.colDevSpec.FieldName = "DevSpec";
            this.colDevSpec.Name = "colDevSpec";
            this.colDevSpec.Visible = true;
            this.colDevSpec.VisibleIndex = 6;
            this.colDevSpec.Width = 42;
            // 
            // colDevExFacDt
            // 
            this.colDevExFacDt.Caption = "制造日期";
            this.colDevExFacDt.FieldName = "DevExFacDt";
            this.colDevExFacDt.Name = "colDevExFacDt";
            this.colDevExFacDt.Visible = true;
            this.colDevExFacDt.VisibleIndex = 7;
            this.colDevExFacDt.Width = 42;
            // 
            // colDevCompanyNo
            // 
            this.colDevCompanyNo.Caption = "出厂编号";
            this.colDevCompanyNo.FieldName = "DevCompanyNo";
            this.colDevCompanyNo.Name = "colDevCompanyNo";
            this.colDevCompanyNo.Visible = true;
            this.colDevCompanyNo.VisibleIndex = 8;
            this.colDevCompanyNo.Width = 42;
            // 
            // colDevType
            // 
            this.colDevType.Caption = "设备类型";
            this.colDevType.FieldName = "DevType";
            this.colDevType.Name = "colDevType";
            this.colDevType.Visible = true;
            this.colDevType.VisibleIndex = 9;
            this.colDevType.Width = 42;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 10;
            this.colStatus.Width = 42;
            // 
            // colStorageAddress
            // 
            this.colStorageAddress.Caption = "存放地点";
            this.colStorageAddress.FieldName = "StorageAddress";
            this.colStorageAddress.Name = "colStorageAddress";
            this.colStorageAddress.Visible = true;
            this.colStorageAddress.VisibleIndex = 11;
            this.colStorageAddress.Width = 42;
            // 
            // colDevInProdDt
            // 
            this.colDevInProdDt.Caption = "投入生产日期";
            this.colDevInProdDt.FieldName = "DevInProdDt";
            this.colDevInProdDt.Name = "colDevInProdDt";
            this.colDevInProdDt.Visible = true;
            this.colDevInProdDt.VisibleIndex = 12;
            this.colDevInProdDt.Width = 42;
            // 
            // colDevManager
            // 
            this.colDevManager.Caption = "管理负责人";
            this.colDevManager.FieldName = "DevManager";
            this.colDevManager.Name = "colDevManager";
            this.colDevManager.Visible = true;
            this.colDevManager.VisibleIndex = 13;
            this.colDevManager.Width = 42;
            // 
            // colFirstMaintain
            // 
            this.colFirstMaintain.Caption = "第一次保养日期";
            this.colFirstMaintain.FieldName = "FirstMaintain";
            this.colFirstMaintain.Name = "colFirstMaintain";
            this.colFirstMaintain.Visible = true;
            this.colFirstMaintain.VisibleIndex = 14;
            this.colFirstMaintain.Width = 42;
            // 
            // colAgreementNo
            // 
            this.colAgreementNo.Caption = "合同号";
            this.colAgreementNo.FieldName = "AgreementNo";
            this.colAgreementNo.Name = "colAgreementNo";
            this.colAgreementNo.Visible = true;
            this.colAgreementNo.VisibleIndex = 15;
            this.colAgreementNo.Width = 42;
            // 
            // colModifyDt
            // 
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            this.colModifyDt.Width = 42;
            // 
            // colModifyUser
            // 
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Width = 42;
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
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 534);
            this.Controls.Add(this.ykGridControl1);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVD001DeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dEVD001DeviceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDevNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDevName;
        private DevExpress.XtraGrid.Columns.GridColumn colDevVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDevFunction;
        private DevExpress.XtraGrid.Columns.GridColumn colDevSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colDevExFacDt;
        private DevExpress.XtraGrid.Columns.GridColumn colDevCompanyNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDevType;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colStorageAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDevInProdDt;
        private DevExpress.XtraGrid.Columns.GridColumn colDevManager;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstMaintain;
        private DevExpress.XtraGrid.Columns.GridColumn colAgreementNo;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}