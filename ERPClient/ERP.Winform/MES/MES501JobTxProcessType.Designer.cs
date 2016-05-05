namespace ERP.Winform.MES
{
    partial class MES501JobTxProcessType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MES501JobTxProcessType));
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtLayoutType = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLayoutType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(158, 89);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 33);
            this.btnOk.TabIndex = 37;
            this.btnOk.Text = "确认";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labName
            // 
            this.labName.Location = new System.Drawing.Point(86, 41);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(36, 14);
            this.labName.TabIndex = 36;
            this.labName.Text = "类别：";
            // 
            // txtLayoutType
            // 
            this.txtLayoutType.Location = new System.Drawing.Point(133, 38);
            this.txtLayoutType.Name = "txtLayoutType";
            this.txtLayoutType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLayoutType.Properties.PopupSizeable = true;
            this.txtLayoutType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtLayoutType.Size = new System.Drawing.Size(150, 20);
            this.txtLayoutType.TabIndex = 35;
            // 
            // MES501JobTxProcessType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 168);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtLayoutType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MES501JobTxProcessType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseDateForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtLayoutType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraEditors.ComboBoxEdit txtLayoutType;

    }
}