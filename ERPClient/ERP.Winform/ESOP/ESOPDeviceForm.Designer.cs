namespace ERP.Winform.ESOP
{
    partial class ESOPDeviceForm
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
            this.eSOPDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSOPDeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.eSOPDeviceBindingSource;
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
            this.ykGridControl1.Size = new System.Drawing.Size(721, 400);
            this.ykGridControl1.TabIndex = 4;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // eSOPDeviceBindingSource
            // 
            this.eSOPDeviceBindingSource.DataSource = typeof(ERP.Domain.ESOP_Device);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colDevName,
            this.colAlias,
            this.colState,
            this.colRemarks,
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
            // 
            // colDevName
            // 
            this.colDevName.Caption = "设备名称";
            this.colDevName.FieldName = "DevName";
            this.colDevName.Name = "colDevName";
            this.colDevName.Visible = true;
            this.colDevName.VisibleIndex = 0;
            // 
            // colAlias
            // 
            this.colAlias.Caption = "简称";
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 1;
            // 
            // colState
            // 
            this.colState.Caption = "状态";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 3;
            // 
            // colModifyDt
            // 
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            // 
            // colModifyUser
            // 
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
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
            // ESOPDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 429);
            this.Controls.Add(this.ykGridControl1);
            this.Name = "ESOPDeviceForm";
            this.Text = "ESOPDeviceForm";
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSOPDeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource eSOPDeviceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDevName;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}