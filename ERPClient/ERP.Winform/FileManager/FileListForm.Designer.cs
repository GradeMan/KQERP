﻿namespace ERP.Winform.FileManager
{
    partial class FileListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileListForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.fTPF002FileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgArrows = new DevExpress.Utils.ImageCollection(this.components);
            this.navigationPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnNavigationHistory = new DevExpress.XtraEditors.LabelControl();
            this.btnUpTo = new DevExpress.XtraEditors.LabelControl();
            this.btnForward = new DevExpress.XtraEditors.LabelControl();
            this.btnBack = new DevExpress.XtraEditors.LabelControl();
            this.EditSearch = new DevExpress.XtraEditors.ButtonEdit();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.上传文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTPF002FileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanel)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.fTPF002FileBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 34);
            this.gridControl1.MainView = this.winExplorerView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(654, 277);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
            // 
            // fTPF002FileBindingSource
            // 
            this.fTPF002FileBindingSource.DataSource = typeof(ERP.Domain.FTP_F002_File);
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colFileName,
            this.colPath,
            this.colStatus,
            this.colSizes,
            this.colPwd,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId,
            this.colImage});
            this.winExplorerView1.ColumnSet.DescriptionColumn = this.colPath;
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = this.colImage;
            this.winExplorerView1.ColumnSet.ExtraLargeImageIndexColumn = this.colImage;
            this.winExplorerView1.ColumnSet.LargeImageColumn = this.colImage;
            this.winExplorerView1.ColumnSet.LargeImageIndexColumn = this.colImage;
            this.winExplorerView1.ColumnSet.MediumImageColumn = this.colImage;
            this.winExplorerView1.ColumnSet.MediumImageIndexColumn = this.colImage;
            this.winExplorerView1.ColumnSet.SmallImageColumn = this.colImage;
            this.winExplorerView1.ColumnSet.SmallImageIndexColumn = this.colImage;
            this.winExplorerView1.ColumnSet.TextColumn = this.colFileName;
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            // 
            // colPath
            // 
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.Visible = true;
            this.colPath.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // colSizes
            // 
            this.colSizes.FieldName = "Sizes";
            this.colSizes.Name = "colSizes";
            this.colSizes.Visible = true;
            this.colSizes.VisibleIndex = 4;
            // 
            // colPwd
            // 
            this.colPwd.FieldName = "Pwd";
            this.colPwd.Name = "colPwd";
            this.colPwd.Visible = true;
            this.colPwd.VisibleIndex = 5;
            // 
            // colModifyDt
            // 
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            this.colModifyDt.Visible = true;
            this.colModifyDt.VisibleIndex = 6;
            // 
            // colModifyUser
            // 
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 7;
            // 
            // colCreateDt
            // 
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            this.colCreateDt.Visible = true;
            this.colCreateDt.VisibleIndex = 8;
            // 
            // colCreateUser
            // 
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 9;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.Visible = true;
            this.colVersion.VisibleIndex = 10;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 11;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 1;
            // 
            // imgArrows
            // 
            this.imgArrows.ImageSize = new System.Drawing.Size(24, 24);
            this.imgArrows.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgArrows.ImageStream")));
            this.imgArrows.Images.SetKeyName(0, "hoverBack.png");
            this.imgArrows.Images.SetKeyName(1, "hoverNext.png");
            this.imgArrows.Images.SetKeyName(2, "hoverUp.png");
            this.imgArrows.Images.SetKeyName(3, "normalBack.png");
            this.imgArrows.Images.SetKeyName(4, "normalNext.png");
            this.imgArrows.Images.SetKeyName(5, "normalUp.png");
            this.imgArrows.Images.SetKeyName(6, "pressedBack.png");
            this.imgArrows.Images.SetKeyName(7, "pressedNext.png");
            this.imgArrows.Images.SetKeyName(8, "pressedUp.png");
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.btnNavigationHistory);
            this.navigationPanel.Controls.Add(this.btnUpTo);
            this.navigationPanel.Controls.Add(this.btnForward);
            this.navigationPanel.Controls.Add(this.btnBack);
            this.navigationPanel.Controls.Add(this.EditSearch);
            this.navigationPanel.Controls.Add(this.txtPath);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(654, 34);
            this.navigationPanel.TabIndex = 6;
            // 
            // btnNavigationHistory
            // 
            this.btnNavigationHistory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnNavigationHistory.Appearance.HoverImageIndex = 1;
            this.btnNavigationHistory.Appearance.ImageIndex = 2;
            this.btnNavigationHistory.Appearance.PressedImageIndex = 3;
            this.btnNavigationHistory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnNavigationHistory.Location = new System.Drawing.Point(60, 8);
            this.btnNavigationHistory.Name = "btnNavigationHistory";
            this.btnNavigationHistory.Size = new System.Drawing.Size(16, 18);
            this.btnNavigationHistory.TabIndex = 8;
            // 
            // btnUpTo
            // 
            this.btnUpTo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnUpTo.Appearance.HoverImageIndex = 2;
            this.btnUpTo.Appearance.ImageIndex = 5;
            this.btnUpTo.Appearance.ImageList = this.imgArrows;
            this.btnUpTo.Appearance.PressedImageIndex = 8;
            this.btnUpTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnUpTo.Location = new System.Drawing.Point(76, 5);
            this.btnUpTo.Name = "btnUpTo";
            this.btnUpTo.Size = new System.Drawing.Size(24, 24);
            this.btnUpTo.TabIndex = 7;
            // 
            // btnForward
            // 
            this.btnForward.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnForward.Appearance.HoverImageIndex = 1;
            this.btnForward.Appearance.ImageIndex = 4;
            this.btnForward.Appearance.ImageList = this.imgArrows;
            this.btnForward.Appearance.PressedImageIndex = 7;
            this.btnForward.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnForward.Location = new System.Drawing.Point(36, 8);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(18, 18);
            this.btnForward.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnBack.Appearance.HoverImageIndex = 0;
            this.btnBack.Appearance.ImageIndex = 3;
            this.btnBack.Appearance.ImageList = this.imgArrows;
            this.btnBack.Appearance.PressedImageIndex = 6;
            this.btnBack.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnBack.Location = new System.Drawing.Point(7, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(18, 18);
            this.btnBack.TabIndex = 5;
            // 
            // EditSearch
            // 
            this.EditSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditSearch.Location = new System.Drawing.Point(477, 5);
            this.EditSearch.Name = "EditSearch";
            this.EditSearch.Properties.AutoHeight = false;
            this.EditSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("EditSearch.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.EditSearch.Properties.Click += new System.EventHandler(this.EditSearch_Properties_Click);
            this.EditSearch.Size = new System.Drawing.Size(165, 24);
            this.EditSearch.TabIndex = 4;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(106, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Properties.AutoHeight = false;
            this.txtPath.Size = new System.Drawing.Size(341, 24);
            this.txtPath.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上传文件ToolStripMenuItem,
            this.下载文件ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // 上传文件ToolStripMenuItem
            // 
            this.上传文件ToolStripMenuItem.Name = "上传文件ToolStripMenuItem";
            this.上传文件ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.上传文件ToolStripMenuItem.Text = "上传文件";
            // 
            // 下载文件ToolStripMenuItem
            // 
            this.下载文件ToolStripMenuItem.Name = "下载文件ToolStripMenuItem";
            this.下载文件ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.下载文件ToolStripMenuItem.Text = "下载文件";
            // 
            // FileListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 340);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navigationPanel);
            this.Name = "FileListForm";
            this.Text = "FileListForm";
            this.Load += new System.EventHandler(this.FileListForm_Load);
            this.Controls.SetChildIndex(this.navigationPanel, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTPF002FileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanel)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private System.Windows.Forms.BindingSource fTPF002FileBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSizes;
        private DevExpress.XtraGrid.Columns.GridColumn colPwd;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.Utils.ImageCollection imgArrows;
        private DevExpress.XtraEditors.PanelControl navigationPanel;
        private DevExpress.XtraEditors.LabelControl btnNavigationHistory;
        private DevExpress.XtraEditors.LabelControl btnUpTo;
        private DevExpress.XtraEditors.LabelControl btnForward;
        private DevExpress.XtraEditors.LabelControl btnBack;
        private DevExpress.XtraEditors.ButtonEdit EditSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 上传文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载文件ToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit txtPath;

    }
}