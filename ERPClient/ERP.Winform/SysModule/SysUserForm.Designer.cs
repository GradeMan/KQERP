namespace ERP.Winform.SysModule
{
    partial class SysUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysUserForm));
            this.ykGridControl2 = new COM.YKControls.YKGridControl();
            this.tbSysUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateuser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCompCode = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCompCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.tbSysUserBindingSource;
            this.ykGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "第 {0} 总 {1}";
            this.ykGridControl2.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl2.MainView = this.gridView2;
            this.ykGridControl2.MenuManager = this.barManager1;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCompCode});
            this.ykGridControl2.Size = new System.Drawing.Size(1088, 606);
            this.ykGridControl2.TabIndex = 9;
            this.ykGridControl2.UseEmbeddedNavigator = true;
            this.ykGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // tbSysUserBindingSource
            // 
            this.tbSysUserBindingSource.DataSource = typeof(ERP.Domain.tb_Sys_User);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserCode,
            this.colUserName,
            this.colUserPassword,
            this.colCreateTime,
            this.colModifyTime,
            this.colCreateuser,
            this.colModifyUser,
            this.colVersion,
            this.colId,
            this.colCompCode});
            this.gridView2.GridControl = this.ykGridControl2;
            this.gridView2.IndicatorWidth = 40;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colUserCode
            // 
            this.colUserCode.Caption = "用户代号";
            this.colUserCode.FieldName = "UserCode";
            this.colUserCode.Name = "colUserCode";
            this.colUserCode.Visible = true;
            this.colUserCode.VisibleIndex = 1;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "用户姓名";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            // 
            // colUserPassword
            // 
            this.colUserPassword.FieldName = "UserPassword";
            this.colUserPassword.Name = "colUserPassword";
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
            // colCreateuser
            // 
            this.colCreateuser.Caption = "创建者";
            this.colCreateuser.FieldName = "Createuser";
            this.colCreateuser.Name = "colCreateuser";
            this.colCreateuser.Visible = true;
            this.colCreateuser.VisibleIndex = 5;
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
            // colCompCode
            // 
            this.colCompCode.Caption = "公司";
            this.colCompCode.ColumnEdit = this.repositoryItemCompCode;
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // repositoryItemCompCode
            // 
            this.repositoryItemCompCode.AutoHeight = false;
            this.repositoryItemCompCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCompCode.Name = "repositoryItemCompCode";
            this.repositoryItemCompCode.NullText = "";
            this.repositoryItemCompCode.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // SysUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 635);
            this.Controls.Add(this.ykGridControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysUserForm";
            this.Text = "SysUserForm";
            this.Controls.SetChildIndex(this.ykGridControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCompCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource tbSysUserBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateuser;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemCompCode;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;

    }
}