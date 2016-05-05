namespace ERP.Winform.SysModule
{
    partial class SysButtonEditForm
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
            this.tbSysButtonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForBtn_Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btn_NameTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBtn_SeqNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btn_SeqNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForBtn_Icon = new DevExpress.XtraLayout.LayoutControlItem();
            this.Btn_IconPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCreateTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForCreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForModifyTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForModifyUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysButtonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBtn_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBtn_SeqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_SeqNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBtn_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_IconPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(420, 298);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Btn_IconPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.Btn_SeqNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateTimeDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyTimeDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Btn_NameTextEdit);
            this.dataLayoutControl1.DataSource = this.tbSysButtonBindingSource;
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(416, 294);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(416, 294);
            // 
            // tbSysButtonBindingSource
            // 
            this.tbSysButtonBindingSource.DataSource = typeof(ERP.Domain.tb_Sys_Button);
            // 
            // ItemForBtn_Name
            // 
            this.ItemForBtn_Name.Control = this.Btn_NameTextEdit;
            this.ItemForBtn_Name.CustomizationFormText = "按钮名称";
            this.ItemForBtn_Name.Location = new System.Drawing.Point(0, 0);
            this.ItemForBtn_Name.Name = "ItemForBtn_Name";
            this.ItemForBtn_Name.Size = new System.Drawing.Size(246, 24);
            this.ItemForBtn_Name.Text = "按钮名称";
            this.ItemForBtn_Name.TextSize = new System.Drawing.Size(48, 14);
            // 
            // Btn_NameTextEdit
            // 
            this.Btn_NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysButtonBindingSource, "Btn_Name", true));
            this.Btn_NameTextEdit.Location = new System.Drawing.Point(64, 12);
            this.Btn_NameTextEdit.Name = "Btn_NameTextEdit";
            this.Btn_NameTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Btn_NameTextEdit.Size = new System.Drawing.Size(190, 20);
            this.Btn_NameTextEdit.StyleController = this.dataLayoutControl1;
            this.Btn_NameTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBtn_Name,
            this.ItemForBtn_SeqNo,
            this.ItemForBtn_Icon,
            this.emptySpaceItem1,
            this.layoutControlGroup3,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(396, 274);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForBtn_SeqNo
            // 
            this.ItemForBtn_SeqNo.Control = this.Btn_SeqNoTextEdit;
            this.ItemForBtn_SeqNo.CustomizationFormText = "按钮排序";
            this.ItemForBtn_SeqNo.Location = new System.Drawing.Point(0, 24);
            this.ItemForBtn_SeqNo.Name = "ItemForBtn_SeqNo";
            this.ItemForBtn_SeqNo.Size = new System.Drawing.Size(246, 24);
            this.ItemForBtn_SeqNo.Text = "按钮排序";
            this.ItemForBtn_SeqNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // Btn_SeqNoTextEdit
            // 
            this.Btn_SeqNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysButtonBindingSource, "Btn_SeqNo", true));
            this.Btn_SeqNoTextEdit.Location = new System.Drawing.Point(64, 36);
            this.Btn_SeqNoTextEdit.Name = "Btn_SeqNoTextEdit";
            this.Btn_SeqNoTextEdit.Size = new System.Drawing.Size(190, 20);
            this.Btn_SeqNoTextEdit.StyleController = this.dataLayoutControl1;
            this.Btn_SeqNoTextEdit.TabIndex = 6;
            // 
            // ItemForBtn_Icon
            // 
            this.ItemForBtn_Icon.Control = this.Btn_IconPictureEdit;
            this.ItemForBtn_Icon.CustomizationFormText = "图标";
            this.ItemForBtn_Icon.Location = new System.Drawing.Point(246, 0);
            this.ItemForBtn_Icon.Name = "ItemForBtn_Icon";
            this.ItemForBtn_Icon.Size = new System.Drawing.Size(150, 107);
            this.ItemForBtn_Icon.Text = "图标";
            this.ItemForBtn_Icon.TextSize = new System.Drawing.Size(48, 14);
            // 
            // Btn_IconPictureEdit
            // 
            this.Btn_IconPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysButtonBindingSource, "Btn_Icon", true));
            this.Btn_IconPictureEdit.Location = new System.Drawing.Point(310, 12);
            this.Btn_IconPictureEdit.Name = "Btn_IconPictureEdit";
            this.Btn_IconPictureEdit.Size = new System.Drawing.Size(94, 103);
            this.Btn_IconPictureEdit.StyleController = this.dataLayoutControl1;
            this.Btn_IconPictureEdit.TabIndex = 5;
            this.Btn_IconPictureEdit.EditValueChanged += new System.EventHandler(this.Btn_IconPictureEdit_EditValueChanged);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 107);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(396, 95);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCreateTime,
            this.ItemForCreateUser,
            this.ItemForModifyTime,
            this.ItemForModifyUser});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 202);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(396, 72);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // ItemForCreateTime
            // 
            this.ItemForCreateTime.Control = this.CreateTimeDateEdit;
            this.ItemForCreateTime.CustomizationFormText = "创建日期";
            this.ItemForCreateTime.Location = new System.Drawing.Point(0, 0);
            this.ItemForCreateTime.Name = "ItemForCreateTime";
            this.ItemForCreateTime.Size = new System.Drawing.Size(186, 24);
            this.ItemForCreateTime.Text = "创建日期";
            this.ItemForCreateTime.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateTimeDateEdit
            // 
            this.CreateTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysButtonBindingSource, "CreateTime", true));
            this.CreateTimeDateEdit.EditValue = null;
            this.CreateTimeDateEdit.Location = new System.Drawing.Point(76, 226);
            this.CreateTimeDateEdit.Name = "CreateTimeDateEdit";
            this.CreateTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateTimeDateEdit.Properties.ReadOnly = true;
            this.CreateTimeDateEdit.Size = new System.Drawing.Size(130, 20);
            this.CreateTimeDateEdit.StyleController = this.dataLayoutControl1;
            this.CreateTimeDateEdit.TabIndex = 7;
            // 
            // ItemForCreateUser
            // 
            this.ItemForCreateUser.Control = this.CreateUserTextEdit;
            this.ItemForCreateUser.CustomizationFormText = "创建者";
            this.ItemForCreateUser.Location = new System.Drawing.Point(186, 0);
            this.ItemForCreateUser.Name = "ItemForCreateUser";
            this.ItemForCreateUser.Size = new System.Drawing.Size(186, 24);
            this.ItemForCreateUser.Text = "创建者";
            this.ItemForCreateUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateUserTextEdit
            // 
            this.CreateUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysButtonBindingSource, "CreateUser", true));
            this.CreateUserTextEdit.Location = new System.Drawing.Point(262, 226);
            this.CreateUserTextEdit.Name = "CreateUserTextEdit";
            this.CreateUserTextEdit.Properties.ReadOnly = true;
            this.CreateUserTextEdit.Size = new System.Drawing.Size(130, 20);
            this.CreateUserTextEdit.StyleController = this.dataLayoutControl1;
            this.CreateUserTextEdit.TabIndex = 9;
            // 
            // ItemForModifyTime
            // 
            this.ItemForModifyTime.Control = this.ModifyTimeDateEdit;
            this.ItemForModifyTime.CustomizationFormText = "修改日期";
            this.ItemForModifyTime.Location = new System.Drawing.Point(0, 24);
            this.ItemForModifyTime.Name = "ItemForModifyTime";
            this.ItemForModifyTime.Size = new System.Drawing.Size(186, 24);
            this.ItemForModifyTime.Text = "修改日期";
            this.ItemForModifyTime.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyTimeDateEdit
            // 
            this.ModifyTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysButtonBindingSource, "ModifyTime", true));
            this.ModifyTimeDateEdit.EditValue = null;
            this.ModifyTimeDateEdit.Location = new System.Drawing.Point(76, 250);
            this.ModifyTimeDateEdit.Name = "ModifyTimeDateEdit";
            this.ModifyTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyTimeDateEdit.Properties.ReadOnly = true;
            this.ModifyTimeDateEdit.Size = new System.Drawing.Size(130, 20);
            this.ModifyTimeDateEdit.StyleController = this.dataLayoutControl1;
            this.ModifyTimeDateEdit.TabIndex = 8;
            // 
            // ItemForModifyUser
            // 
            this.ItemForModifyUser.Control = this.ModifyUserTextEdit;
            this.ItemForModifyUser.CustomizationFormText = "修改者";
            this.ItemForModifyUser.Location = new System.Drawing.Point(186, 24);
            this.ItemForModifyUser.Name = "ItemForModifyUser";
            this.ItemForModifyUser.Size = new System.Drawing.Size(186, 24);
            this.ItemForModifyUser.Text = "修改者";
            this.ItemForModifyUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyUserTextEdit
            // 
            this.ModifyUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysButtonBindingSource, "ModifyUser", true));
            this.ModifyUserTextEdit.Location = new System.Drawing.Point(262, 250);
            this.ModifyUserTextEdit.Name = "ModifyUserTextEdit";
            this.ModifyUserTextEdit.Properties.ReadOnly = true;
            this.ModifyUserTextEdit.Size = new System.Drawing.Size(130, 20);
            this.ModifyUserTextEdit.StyleController = this.dataLayoutControl1;
            this.ModifyUserTextEdit.TabIndex = 10;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(246, 59);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SysButtonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 333);
            this.Name = "SysButtonEditForm";
            this.Text = "SysButtonEditForm";
            this.Load += new System.EventHandler(this.SysButtonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysButtonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBtn_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBtn_SeqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_SeqNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBtn_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_IconPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tbSysButtonBindingSource;
        private DevExpress.XtraEditors.PictureEdit Btn_IconPictureEdit;
        private DevExpress.XtraEditors.TextEdit Btn_SeqNoTextEdit;
        private DevExpress.XtraEditors.DateEdit CreateTimeDateEdit;
        private DevExpress.XtraEditors.DateEdit ModifyTimeDateEdit;
        private DevExpress.XtraEditors.TextEdit CreateUserTextEdit;
        private DevExpress.XtraEditors.TextEdit ModifyUserTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBtn_Name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBtn_SeqNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBtn_Icon;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ComboBoxEdit Btn_NameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}