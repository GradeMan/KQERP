namespace ERP.Winform.SysModule
{
    partial class SysButtonForm
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbSysButtonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBtn_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtn_Icon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtn_SeqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysButtonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.tbSysButtonBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "第 {0} 总 {1}";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl1.MainView = this.gridView1;
            this.ykGridControl1.MenuManager = this.barManager1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(778, 438);
            this.ykGridControl1.TabIndex = 4;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBtn_Name,
            this.colBtn_Icon,
            this.colBtn_SeqNo,
            this.colCreateTime,
            this.colModifyTime,
            this.colCreateUser,
            this.colModifyUser,
            this.colVersion,
            this.colId});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tbSysButtonBindingSource
            // 
            this.tbSysButtonBindingSource.DataSource = typeof(ERP.Domain.tb_Sys_Button);
            // 
            // colBtn_Name
            // 
            this.colBtn_Name.Caption = "按钮名称";
            this.colBtn_Name.FieldName = "Btn_Name";
            this.colBtn_Name.Name = "colBtn_Name";
            this.colBtn_Name.Visible = true;
            this.colBtn_Name.VisibleIndex = 0;
            // 
            // colBtn_Icon
            // 
            this.colBtn_Icon.Caption = "图标";
            this.colBtn_Icon.FieldName = "Btn_Icon";
            this.colBtn_Icon.Name = "colBtn_Icon";
            this.colBtn_Icon.Visible = true;
            this.colBtn_Icon.VisibleIndex = 1;
            // 
            // colBtn_SeqNo
            // 
            this.colBtn_SeqNo.Caption = "排序";
            this.colBtn_SeqNo.FieldName = "Btn_SeqNo";
            this.colBtn_SeqNo.Name = "colBtn_SeqNo";
            this.colBtn_SeqNo.Visible = true;
            this.colBtn_SeqNo.VisibleIndex = 2;
            // 
            // colCreateTime
            // 
            this.colCreateTime.Caption = "创建日期";
            this.colCreateTime.FieldName = "CreateTime";
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.Visible = true;
            this.colCreateTime.VisibleIndex = 3;
            // 
            // colModifyTime
            // 
            this.colModifyTime.Caption = "修改日期";
            this.colModifyTime.FieldName = "ModifyTime";
            this.colModifyTime.Name = "colModifyTime";
            this.colModifyTime.Visible = true;
            this.colModifyTime.VisibleIndex = 4;
            // 
            // colCreateUser
            // 
            this.colCreateUser.Caption = "创建者";
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 5;
            // 
            // colModifyUser
            // 
            this.colModifyUser.Caption = "修改者";
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 6;
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
            // SysButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 467);
            this.Controls.Add(this.ykGridControl1);
            this.Name = "SysButtonForm";
            this.Text = "SysButtonForm";
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysButtonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tbSysButtonBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBtn_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colBtn_Icon;
        private DevExpress.XtraGrid.Columns.GridColumn colBtn_SeqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}