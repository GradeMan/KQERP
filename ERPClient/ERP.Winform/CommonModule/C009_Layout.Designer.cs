namespace ERP.Winform.CommonModule
{
    partial class C009_Layout
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveLayout = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFrmType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLayoutType = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrmType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLayoutType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 33);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Location = new System.Drawing.Point(118, 204);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(76, 33);
            this.btnSaveLayout.TabIndex = 33;
            this.btnSaveLayout.Text = "保存";
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(100, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "窗体";
            // 
            // txtFrmType
            // 
            this.txtFrmType.Enabled = false;
            this.txtFrmType.Location = new System.Drawing.Point(147, 65);
            this.txtFrmType.Name = "txtFrmType";
            this.txtFrmType.Size = new System.Drawing.Size(150, 20);
            this.txtFrmType.TabIndex = 31;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(100, 143);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "类别";
            // 
            // txtLayoutType
            // 
            this.txtLayoutType.Location = new System.Drawing.Point(147, 140);
            this.txtLayoutType.Name = "txtLayoutType";
            this.txtLayoutType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLayoutType.Properties.PopupSizeable = true;
            this.txtLayoutType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtLayoutType.Size = new System.Drawing.Size(150, 20);
            this.txtLayoutType.TabIndex = 29;
            // 
            // C009_Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveLayout);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFrmType);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtLayoutType);
            this.Name = "C009_Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C009_Layout";
            this.Load += new System.EventHandler(this.C009_Layout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFrmType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLayoutType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSaveLayout;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFrmType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtLayoutType;
    }
}