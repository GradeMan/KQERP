namespace ERP.Winform.CommonModule
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.eRPC003CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPerson1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPerson2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPerson3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCEMail1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCEMail2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCEMail3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPhone3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCFax1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCFax2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCFax3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNAdd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNAdd2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNAdd3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC003CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.eRPC003CustomerBindingSource;
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
            this.ykGridControl1.Size = new System.Drawing.Size(900, 511);
            this.ykGridControl1.TabIndex = 4;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // eRPC003CustomerBindingSource
            // 
            this.eRPC003CustomerBindingSource.DataSource = typeof(ERP.Domain.ERP_C003_Customer);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCustCode,
            this.colCustName,
            this.colAlias,
            this.colAdd1,
            this.colAdd2,
            this.colAdd3,
            this.colCountry,
            this.colPhone,
            this.colFax,
            this.colCPerson1,
            this.colCPerson2,
            this.colCPerson3,
            this.colCEMail1,
            this.colCEMail2,
            this.colCEMail3,
            this.colCPhone1,
            this.colCPhone2,
            this.colCPhone3,
            this.colCFax1,
            this.colCFax2,
            this.colCFax3,
            this.colDNAdd1,
            this.colDNAdd2,
            this.colDNAdd3,
            this.colStatus,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId,
            this.colRemarks,
            this.colCustType});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colCustCode
            // 
            this.colCustCode.Caption = "客户代号";
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 0;
            // 
            // colCustName
            // 
            this.colCustName.Caption = "客户名称";
            this.colCustName.FieldName = "CustName";
            this.colCustName.Name = "colCustName";
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 1;
            // 
            // colAlias
            // 
            this.colAlias.Caption = "简称";
            this.colAlias.FieldName = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 2;
            // 
            // colAdd1
            // 
            this.colAdd1.Caption = "地址1";
            this.colAdd1.FieldName = "Add1";
            this.colAdd1.Name = "colAdd1";
            this.colAdd1.Visible = true;
            this.colAdd1.VisibleIndex = 4;
            // 
            // colAdd2
            // 
            this.colAdd2.FieldName = "Add2";
            this.colAdd2.Name = "colAdd2";
            // 
            // colAdd3
            // 
            this.colAdd3.FieldName = "Add3";
            this.colAdd3.Name = "colAdd3";
            // 
            // colCountry
            // 
            this.colCountry.Caption = "国家";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 5;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "联系电话";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.Caption = "传真";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colCPerson1
            // 
            this.colCPerson1.Caption = "联系人1";
            this.colCPerson1.FieldName = "CPerson1";
            this.colCPerson1.Name = "colCPerson1";
            this.colCPerson1.Visible = true;
            this.colCPerson1.VisibleIndex = 8;
            // 
            // colCPerson2
            // 
            this.colCPerson2.FieldName = "CPerson2";
            this.colCPerson2.Name = "colCPerson2";
            // 
            // colCPerson3
            // 
            this.colCPerson3.FieldName = "CPerson3";
            this.colCPerson3.Name = "colCPerson3";
            // 
            // colCEMail1
            // 
            this.colCEMail1.Caption = "邮箱1";
            this.colCEMail1.FieldName = "CEMail1";
            this.colCEMail1.Name = "colCEMail1";
            this.colCEMail1.Visible = true;
            this.colCEMail1.VisibleIndex = 9;
            // 
            // colCEMail2
            // 
            this.colCEMail2.FieldName = "CEMail2";
            this.colCEMail2.Name = "colCEMail2";
            // 
            // colCEMail3
            // 
            this.colCEMail3.FieldName = "CEMail3";
            this.colCEMail3.Name = "colCEMail3";
            // 
            // colCPhone1
            // 
            this.colCPhone1.Caption = "联系电话1";
            this.colCPhone1.FieldName = "CPhone1";
            this.colCPhone1.Name = "colCPhone1";
            this.colCPhone1.Visible = true;
            this.colCPhone1.VisibleIndex = 10;
            // 
            // colCPhone2
            // 
            this.colCPhone2.FieldName = "CPhone2";
            this.colCPhone2.Name = "colCPhone2";
            // 
            // colCPhone3
            // 
            this.colCPhone3.FieldName = "CPhone3";
            this.colCPhone3.Name = "colCPhone3";
            // 
            // colCFax1
            // 
            this.colCFax1.Caption = "传真1";
            this.colCFax1.FieldName = "CFax1";
            this.colCFax1.Name = "colCFax1";
            this.colCFax1.Visible = true;
            this.colCFax1.VisibleIndex = 11;
            // 
            // colCFax2
            // 
            this.colCFax2.FieldName = "CFax2";
            this.colCFax2.Name = "colCFax2";
            // 
            // colCFax3
            // 
            this.colCFax3.FieldName = "CFax3";
            this.colCFax3.Name = "colCFax3";
            // 
            // colDNAdd1
            // 
            this.colDNAdd1.Caption = "送货地址1";
            this.colDNAdd1.FieldName = "DNAdd1";
            this.colDNAdd1.Name = "colDNAdd1";
            this.colDNAdd1.Visible = true;
            this.colDNAdd1.VisibleIndex = 12;
            // 
            // colDNAdd2
            // 
            this.colDNAdd2.FieldName = "DNAdd2";
            this.colDNAdd2.Name = "colDNAdd2";
            // 
            // colDNAdd3
            // 
            this.colDNAdd3.FieldName = "DNAdd3";
            this.colDNAdd3.Name = "colDNAdd3";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 13;
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
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 14;
            // 
            // colCustType
            // 
            this.colCustType.Caption = "客户类别";
            this.colCustType.FieldName = "CustType";
            this.colCustType.Name = "colCustType";
            this.colCustType.Visible = true;
            this.colCustType.VisibleIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeView1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1098, 511);
            this.splitContainerControl1.SplitterPosition = 193;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(193, 511);
            this.treeView1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 540);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC003CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private System.Windows.Forms.BindingSource eRPC003CustomerBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd2;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd3;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colCPerson1;
        private DevExpress.XtraGrid.Columns.GridColumn colCPerson2;
        private DevExpress.XtraGrid.Columns.GridColumn colCPerson3;
        private DevExpress.XtraGrid.Columns.GridColumn colCEMail1;
        private DevExpress.XtraGrid.Columns.GridColumn colCEMail2;
        private DevExpress.XtraGrid.Columns.GridColumn colCEMail3;
        private DevExpress.XtraGrid.Columns.GridColumn colCPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colCPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colCPhone3;
        private DevExpress.XtraGrid.Columns.GridColumn colCFax1;
        private DevExpress.XtraGrid.Columns.GridColumn colCFax2;
        private DevExpress.XtraGrid.Columns.GridColumn colCFax3;
        private DevExpress.XtraGrid.Columns.GridColumn colDNAdd1;
        private DevExpress.XtraGrid.Columns.GridColumn colDNAdd2;
        private DevExpress.XtraGrid.Columns.GridColumn colDNAdd3;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustType;
        private System.Windows.Forms.ImageList imageList1;
        
    }
}