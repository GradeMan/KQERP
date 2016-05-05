namespace ERP.Winform.SysModule
{
    partial class SysUserEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysUserEditForm));
            this.UserCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tbSysUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForUserCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForUserPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.UserPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCreateTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForModifyTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForCreateuser = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateuserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForModifyUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CompCodeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateuserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(428, 286);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CompCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UserCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UserNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UserPasswordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateTimeDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyTimeDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateuserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyUserTextEdit);
            this.dataLayoutControl1.DataSource = this.tbSysUserBindingSource;
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(424, 282);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(424, 282);
            // 
            // UserCodeTextEdit
            // 
            this.UserCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "UserCode", true));
            this.UserCodeTextEdit.Location = new System.Drawing.Point(64, 36);
            this.UserCodeTextEdit.Name = "UserCodeTextEdit";
            this.UserCodeTextEdit.Size = new System.Drawing.Size(348, 20);
            this.UserCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.UserCodeTextEdit.TabIndex = 4;
            // 
            // tbSysUserBindingSource
            // 
            this.tbSysUserBindingSource.DataSource = typeof(ERP.Domain.tb_Sys_User);
            // 
            // ItemForUserCode
            // 
            this.ItemForUserCode.Control = this.UserCodeTextEdit;
            this.ItemForUserCode.CustomizationFormText = "用户代号";
            this.ItemForUserCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForUserCode.Name = "ItemForUserCode";
            this.ItemForUserCode.Size = new System.Drawing.Size(404, 24);
            this.ItemForUserCode.Text = "用户代号";
            this.ItemForUserCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUserCode,
            this.ItemForUserName,
            this.ItemForUserPassword,
            this.layoutControlGroup3,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(404, 262);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForUserName
            // 
            this.ItemForUserName.Control = this.UserNameTextEdit;
            this.ItemForUserName.CustomizationFormText = "用户名";
            this.ItemForUserName.Location = new System.Drawing.Point(0, 48);
            this.ItemForUserName.Name = "ItemForUserName";
            this.ItemForUserName.Size = new System.Drawing.Size(404, 24);
            this.ItemForUserName.Text = "用户名";
            this.ItemForUserName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "UserName", true));
            this.UserNameTextEdit.Location = new System.Drawing.Point(64, 60);
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Size = new System.Drawing.Size(348, 20);
            this.UserNameTextEdit.StyleController = this.dataLayoutControl1;
            this.UserNameTextEdit.TabIndex = 5;
            // 
            // ItemForUserPassword
            // 
            this.ItemForUserPassword.Control = this.UserPasswordTextEdit;
            this.ItemForUserPassword.CustomizationFormText = "密码";
            this.ItemForUserPassword.Location = new System.Drawing.Point(0, 72);
            this.ItemForUserPassword.Name = "ItemForUserPassword";
            this.ItemForUserPassword.Size = new System.Drawing.Size(404, 24);
            this.ItemForUserPassword.Text = "密码";
            this.ItemForUserPassword.TextSize = new System.Drawing.Size(48, 14);
            // 
            // UserPasswordTextEdit
            // 
            this.UserPasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "UserPassword", true));
            this.UserPasswordTextEdit.Location = new System.Drawing.Point(64, 84);
            this.UserPasswordTextEdit.Name = "UserPasswordTextEdit";
            this.UserPasswordTextEdit.Size = new System.Drawing.Size(348, 20);
            this.UserPasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.UserPasswordTextEdit.TabIndex = 6;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCreateTime,
            this.ItemForModifyTime,
            this.ItemForCreateuser,
            this.ItemForModifyUser});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 190);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(404, 72);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // ItemForCreateTime
            // 
            this.ItemForCreateTime.Control = this.CreateTimeDateEdit;
            this.ItemForCreateTime.CustomizationFormText = "Create Time";
            this.ItemForCreateTime.Location = new System.Drawing.Point(0, 0);
            this.ItemForCreateTime.Name = "ItemForCreateTime";
            this.ItemForCreateTime.Size = new System.Drawing.Size(190, 24);
            this.ItemForCreateTime.Text = "创建日期";
            this.ItemForCreateTime.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateTimeDateEdit
            // 
            this.CreateTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "CreateTime", true));
            this.CreateTimeDateEdit.EditValue = null;
            this.CreateTimeDateEdit.Location = new System.Drawing.Point(76, 214);
            this.CreateTimeDateEdit.Name = "CreateTimeDateEdit";
            this.CreateTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateTimeDateEdit.Properties.ReadOnly = true;
            this.CreateTimeDateEdit.Size = new System.Drawing.Size(134, 20);
            this.CreateTimeDateEdit.StyleController = this.dataLayoutControl1;
            this.CreateTimeDateEdit.TabIndex = 7;
            // 
            // ItemForModifyTime
            // 
            this.ItemForModifyTime.Control = this.ModifyTimeDateEdit;
            this.ItemForModifyTime.CustomizationFormText = "Modify Time";
            this.ItemForModifyTime.Location = new System.Drawing.Point(0, 24);
            this.ItemForModifyTime.Name = "ItemForModifyTime";
            this.ItemForModifyTime.Size = new System.Drawing.Size(190, 24);
            this.ItemForModifyTime.Text = "修改日期";
            this.ItemForModifyTime.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyTimeDateEdit
            // 
            this.ModifyTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "ModifyTime", true));
            this.ModifyTimeDateEdit.EditValue = null;
            this.ModifyTimeDateEdit.Location = new System.Drawing.Point(76, 238);
            this.ModifyTimeDateEdit.Name = "ModifyTimeDateEdit";
            this.ModifyTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyTimeDateEdit.Properties.ReadOnly = true;
            this.ModifyTimeDateEdit.Size = new System.Drawing.Size(134, 20);
            this.ModifyTimeDateEdit.StyleController = this.dataLayoutControl1;
            this.ModifyTimeDateEdit.TabIndex = 8;
            // 
            // ItemForCreateuser
            // 
            this.ItemForCreateuser.Control = this.CreateuserTextEdit;
            this.ItemForCreateuser.CustomizationFormText = "Createuser";
            this.ItemForCreateuser.Location = new System.Drawing.Point(190, 0);
            this.ItemForCreateuser.Name = "ItemForCreateuser";
            this.ItemForCreateuser.Size = new System.Drawing.Size(190, 24);
            this.ItemForCreateuser.Text = "创建者";
            this.ItemForCreateuser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateuserTextEdit
            // 
            this.CreateuserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "Createuser", true));
            this.CreateuserTextEdit.Location = new System.Drawing.Point(266, 214);
            this.CreateuserTextEdit.Name = "CreateuserTextEdit";
            this.CreateuserTextEdit.Properties.ReadOnly = true;
            this.CreateuserTextEdit.Size = new System.Drawing.Size(134, 20);
            this.CreateuserTextEdit.StyleController = this.dataLayoutControl1;
            this.CreateuserTextEdit.TabIndex = 9;
            // 
            // ItemForModifyUser
            // 
            this.ItemForModifyUser.Control = this.ModifyUserTextEdit;
            this.ItemForModifyUser.CustomizationFormText = "Modify User";
            this.ItemForModifyUser.Location = new System.Drawing.Point(190, 24);
            this.ItemForModifyUser.Name = "ItemForModifyUser";
            this.ItemForModifyUser.Size = new System.Drawing.Size(190, 24);
            this.ItemForModifyUser.Text = "修改者";
            this.ItemForModifyUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyUserTextEdit
            // 
            this.ModifyUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "ModifyUser", true));
            this.ModifyUserTextEdit.Location = new System.Drawing.Point(266, 238);
            this.ModifyUserTextEdit.Name = "ModifyUserTextEdit";
            this.ModifyUserTextEdit.Properties.ReadOnly = true;
            this.ModifyUserTextEdit.Size = new System.Drawing.Size(134, 20);
            this.ModifyUserTextEdit.StyleController = this.dataLayoutControl1;
            this.ModifyUserTextEdit.TabIndex = 10;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(404, 94);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CompCodeTextEdit;
            this.layoutControlItem1.CustomizationFormText = "公司名称";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem1.Text = "公司名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CompCodeTextEdit
            // 
            this.CompCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysUserBindingSource, "CompCode", true));
            this.CompCodeTextEdit.Location = new System.Drawing.Point(64, 12);
            this.CompCodeTextEdit.Name = "CompCodeTextEdit";
            this.CompCodeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CompCodeTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.CompCodeTextEdit.Size = new System.Drawing.Size(348, 20);
            this.CompCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CompCodeTextEdit.TabIndex = 11;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // SysUserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 316);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysUserEditForm";
            this.Text = "SysUserEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateuserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UserCodeTextEdit;
        private System.Windows.Forms.BindingSource tbSysUserBindingSource;
        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraEditors.TextEdit UserPasswordTextEdit;
        private DevExpress.XtraEditors.DateEdit CreateTimeDateEdit;
        private DevExpress.XtraEditors.DateEdit ModifyTimeDateEdit;
        private DevExpress.XtraEditors.TextEdit CreateuserTextEdit;
        private DevExpress.XtraEditors.TextEdit ModifyUserTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserPassword;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateuser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyUser;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GridLookUpEdit CompCodeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}