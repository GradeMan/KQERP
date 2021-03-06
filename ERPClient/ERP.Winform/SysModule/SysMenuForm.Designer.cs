﻿namespace ERP.Winform.SysModule
{
    partial class SysMenuForm
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
            this.tbSysMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryMenuParentId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSeqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameSpeace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryMenuParentId)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.tbSysMenuBindingSource;
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
            this.ykGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryMenuParentId});
            this.ykGridControl1.Size = new System.Drawing.Size(686, 489);
            this.ykGridControl1.TabIndex = 4;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbSysMenuBindingSource
            // 
            this.tbSysMenuBindingSource.DataSource = typeof(ERP.Domain.tb_Sys_Menu);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenuName,
            this.colMenuIcon,
            this.colParentMenuId,
            this.colSeqNo,
            this.colNameSpeace,
            this.colCreateTime,
            this.colModifyTime,
            this.colCreateUser,
            this.colModifyUser,
            this.colVersion,
            this.colId,
            this.colMenuType});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "菜单名称";
            this.colMenuName.FieldName = "MenuName";
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.Visible = true;
            this.colMenuName.VisibleIndex = 0;
            // 
            // colMenuIcon
            // 
            this.colMenuIcon.Caption = "菜单图标";
            this.colMenuIcon.FieldName = "MenuIcon";
            this.colMenuIcon.Name = "colMenuIcon";
            this.colMenuIcon.Visible = true;
            this.colMenuIcon.VisibleIndex = 1;
            // 
            // colParentMenuId
            // 
            this.colParentMenuId.Caption = "父菜单";
            this.colParentMenuId.ColumnEdit = this.repositoryMenuParentId;
            this.colParentMenuId.FieldName = "ParentMenuId";
            this.colParentMenuId.Name = "colParentMenuId";
            this.colParentMenuId.Visible = true;
            this.colParentMenuId.VisibleIndex = 2;
            // 
            // repositoryMenuParentId
            // 
            this.repositoryMenuParentId.AutoHeight = false;
            this.repositoryMenuParentId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryMenuParentId.DisplayMember = "MenuName";
            this.repositoryMenuParentId.Name = "repositoryMenuParentId";
            this.repositoryMenuParentId.NullText = "";
            this.repositoryMenuParentId.ValueMember = "Id";
            // 
            // colSeqNo
            // 
            this.colSeqNo.FieldName = "SeqNo";
            this.colSeqNo.Name = "colSeqNo";
            // 
            // colNameSpeace
            // 
            this.colNameSpeace.Caption = "命名空间";
            this.colNameSpeace.FieldName = "NameSpeace";
            this.colNameSpeace.Name = "colNameSpeace";
            this.colNameSpeace.Visible = true;
            this.colNameSpeace.VisibleIndex = 3;
            // 
            // colCreateTime
            // 
            this.colCreateTime.Caption = "创建日期";
            this.colCreateTime.FieldName = "CreateTime";
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.Visible = true;
            this.colCreateTime.VisibleIndex = 4;
            // 
            // colModifyTime
            // 
            this.colModifyTime.Caption = "修改日期";
            this.colModifyTime.FieldName = "ModifyTime";
            this.colModifyTime.Name = "colModifyTime";
            this.colModifyTime.Visible = true;
            this.colModifyTime.VisibleIndex = 5;
            // 
            // colCreateUser
            // 
            this.colCreateUser.Caption = "创建者";
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 6;
            // 
            // colModifyUser
            // 
            this.colModifyUser.Caption = "修改者";
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 7;
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
            // colMenuType
            // 
            this.colMenuType.Caption = "类别";
            this.colMenuType.FieldName = "MenuType";
            this.colMenuType.Name = "colMenuType";
            this.colMenuType.Visible = true;
            this.colMenuType.VisibleIndex = 8;
            // 
            // SysMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 518);
            this.Controls.Add(this.ykGridControl1);
            this.Name = "SysMenuForm";
            this.Text = "SysMenuForm";
            this.Load += new System.EventHandler(this.SysMenuForm_Load);
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryMenuParentId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tbSysMenuBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuIcon;
        private DevExpress.XtraGrid.Columns.GridColumn colParentMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colSeqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNameSpeace;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryMenuParentId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuType;
    }
}