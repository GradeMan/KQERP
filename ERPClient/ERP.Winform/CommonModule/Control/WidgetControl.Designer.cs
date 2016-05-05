namespace ERP.Winform.Control
{
    partial class WidgetControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(21, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 31);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Name";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl10.Location = new System.Drawing.Point(21, 137);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 14);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Volume";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl6.Location = new System.Drawing.Point(21, 67);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 14);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Hi Price";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl7.Location = new System.Drawing.Point(21, 102);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Open Price";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl8.Location = new System.Drawing.Point(21, 120);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 14);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Close Price";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl9.Location = new System.Drawing.Point(21, 85);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 14);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "Low Price";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::ERP.Winform.Properties.Resources.yezi3;
            this.pictureEdit1.Location = new System.Drawing.Point(128, 33);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(156, 131);
            this.pictureEdit1.TabIndex = 30;
            // 
            // WidgetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl9);
            this.Name = "WidgetControl";
            this.Size = new System.Drawing.Size(322, 189);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
