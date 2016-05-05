/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-2014 LayeredSkin Corporation All rights reserved.
 * * 作者： 小红帽  QQ:761716178
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2014-04-13
 * * 说明：QQ.Designer.cs
 * *
********************************************************************/
namespace ERP.Winform.SysModule
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            System.Drawing.Imaging.ImageAttributes imageAttributes1 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes2 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes3 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes4 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes5 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes6 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes7 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes8 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes9 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes10 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes11 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes12 = new System.Drawing.Imaging.ImageAttributes();
            this.layeredPictureBox1 = new LayeredSkin.Controls.LayeredPictureBox();
            this.layeredPictureBox2 = new LayeredSkin.Controls.LayeredPictureBox();
            this.btnMin = new LayeredSkin.Controls.LayeredButton();
            this.btnClose = new LayeredSkin.Controls.LayeredButton();
            this.txtUser = new LayeredSkin.Controls.LayeredTextBox();
            this.layeredLabel1 = new LayeredSkin.Controls.LayeredLabel();
            this.txtPassword = new LayeredSkin.Controls.LayeredTextBox();
            this.layeredLabel2 = new LayeredSkin.Controls.LayeredLabel();
            this.btnLogin = new LayeredSkin.Controls.LayeredButton();
            this.layeredLabel3 = new LayeredSkin.Controls.LayeredLabel();
            this.layeredCheckButton1 = new LayeredSkin.Controls.LayeredCheckButton();
            this.btnRemember = new LayeredSkin.Controls.LayeredLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // layeredPictureBox1
            // 
            this.layeredPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.layeredPictureBox1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredPictureBox1.Canvas")));
            this.layeredPictureBox1.Image = global::ERP.Winform.Properties.Resources.sun2;
            this.layeredPictureBox1.ImageAttribute = imageAttributes1;
            this.layeredPictureBox1.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::ERP.Winform.Properties.Resources.sun2))};
            this.layeredPictureBox1.Interval = 100;
            this.layeredPictureBox1.Location = new System.Drawing.Point(46, 48);
            this.layeredPictureBox1.MultiImageAnimation = false;
            this.layeredPictureBox1.Name = "layeredPictureBox1";
            this.layeredPictureBox1.Size = new System.Drawing.Size(105, 53);
            this.layeredPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.layeredPictureBox1.TabIndex = 0;
            this.layeredPictureBox1.Text = "layeredPictureBox1";
            // 
            // layeredPictureBox2
            // 
            this.layeredPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.layeredPictureBox2.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredPictureBox2.Canvas")));
            this.layeredPictureBox2.Image = global::ERP.Winform.Properties.Resources.yezi2;
            this.layeredPictureBox2.ImageAttribute = imageAttributes2;
            this.layeredPictureBox2.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::ERP.Winform.Properties.Resources.yezi2))};
            this.layeredPictureBox2.Interval = 100;
            this.layeredPictureBox2.Location = new System.Drawing.Point(142, 71);
            this.layeredPictureBox2.MultiImageAnimation = false;
            this.layeredPictureBox2.Name = "layeredPictureBox2";
            this.layeredPictureBox2.Size = new System.Drawing.Size(338, 82);
            this.layeredPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.layeredPictureBox2.TabIndex = 1;
            this.layeredPictureBox2.Text = "layeredPictureBox2";
            this.layeredPictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMoveMouseDown);
            // 
            // btnMin
            // 
            this.btnMin.AdaptImage = true;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BaseColor = System.Drawing.Color.Wheat;
            this.btnMin.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btnMin.Canvas")));
            this.btnMin.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.btnMin.HaloColor = System.Drawing.Color.White;
            this.btnMin.HaloSize = 5;
            this.btnMin.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnMin.HoverImage")));
            this.btnMin.ImageAttribute = imageAttributes3;
            this.btnMin.Location = new System.Drawing.Point(564, 114);
            this.btnMin.Name = "btnMin";
            this.btnMin.NormalImage = global::ERP.Winform.Properties.Resources.mini1;
            this.btnMin.PressedImage = null;
            this.btnMin.Size = new System.Drawing.Size(22, 22);
            this.btnMin.TabIndex = 2;
            this.btnMin.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.btnMin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnMin.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.btnMin.Click += new System.EventHandler(this.layeredButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AdaptImage = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Wheat;
            this.btnClose.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btnClose.Canvas")));
            this.btnClose.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.btnClose.HaloColor = System.Drawing.Color.White;
            this.btnClose.HaloSize = 5;
            this.btnClose.HoverImage = global::ERP.Winform.Properties.Resources.close1;
            this.btnClose.ImageAttribute = imageAttributes4;
            this.btnClose.Location = new System.Drawing.Point(592, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalImage = global::ERP.Winform.Properties.Resources.close1;
            this.btnClose.PressedImage = null;
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.btnClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnClose.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.btnClose.Click += new System.EventHandler(this.layeredButton2_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderColor = System.Drawing.Color.Empty;
            this.txtUser.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("txtUser.Canvas")));
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.ImageAttribute = imageAttributes5;
            this.txtUser.Location = new System.Drawing.Point(317, 287);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(254, 26);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "admin";
            this.txtUser.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.WaterFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.WaterText = "";
            // 
            // layeredLabel1
            // 
            this.layeredLabel1.AutoSize = true;
            this.layeredLabel1.BackColor = System.Drawing.Color.Transparent;
            this.layeredLabel1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel1.Canvas")));
            this.layeredLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel1.ForeColor = System.Drawing.Color.White;
            this.layeredLabel1.HaloColor = System.Drawing.Color.DimGray;
            this.layeredLabel1.HaloSize = 5;
            this.layeredLabel1.ImageAttribute = imageAttributes6;
            this.layeredLabel1.Location = new System.Drawing.Point(235, 287);
            this.layeredLabel1.Name = "layeredLabel1";
            this.layeredLabel1.Size = new System.Drawing.Size(58, 23);
            this.layeredLabel1.TabIndex = 4;
            this.layeredLabel1.Text = "账号：";
            this.layeredLabel1.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Empty;
            this.txtPassword.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("txtPassword.Canvas")));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.ImageAttribute = imageAttributes7;
            this.txtPassword.Location = new System.Drawing.Point(317, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(254, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "admin";
            this.txtPassword.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.WaterFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.WaterText = "";
            // 
            // layeredLabel2
            // 
            this.layeredLabel2.AutoSize = true;
            this.layeredLabel2.BackColor = System.Drawing.Color.Transparent;
            this.layeredLabel2.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel2.Canvas")));
            this.layeredLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel2.ForeColor = System.Drawing.Color.White;
            this.layeredLabel2.HaloColor = System.Drawing.Color.DimGray;
            this.layeredLabel2.HaloSize = 5;
            this.layeredLabel2.ImageAttribute = imageAttributes8;
            this.layeredLabel2.Location = new System.Drawing.Point(235, 255);
            this.layeredLabel2.Name = "layeredLabel2";
            this.layeredLabel2.Size = new System.Drawing.Size(58, 23);
            this.layeredLabel2.TabIndex = 4;
            this.layeredLabel2.Text = "密码：";
            this.layeredLabel2.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // btnLogin
            // 
            this.btnLogin.AdaptImage = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.White;
            this.btnLogin.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btnLogin.Canvas")));
            this.btnLogin.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.HaloColor = System.Drawing.Color.White;
            this.btnLogin.HaloSize = 5;
            this.btnLogin.HoverImage = null;
            this.btnLogin.ImageAttribute = imageAttributes9;
            this.btnLogin.Location = new System.Drawing.Point(499, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalImage = null;
            this.btnLogin.PressedImage = null;
            this.btnLogin.Size = new System.Drawing.Size(72, 27);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnLogin.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // layeredLabel3
            // 
            this.layeredLabel3.AutoSize = true;
            this.layeredLabel3.BackColor = System.Drawing.Color.Transparent;
            this.layeredLabel3.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel3.Canvas")));
            this.layeredLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel3.ForeColor = System.Drawing.Color.Black;
            this.layeredLabel3.HaloSize = 5;
            this.layeredLabel3.ImageAttribute = imageAttributes10;
            this.layeredLabel3.Location = new System.Drawing.Point(317, 193);
            this.layeredLabel3.Name = "layeredLabel3";
            this.layeredLabel3.Size = new System.Drawing.Size(78, 20);
            this.layeredLabel3.TabIndex = 6;
            this.layeredLabel3.Text = "ERP概念版";
            this.layeredLabel3.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.layeredLabel3.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // layeredCheckButton1
            // 
            this.layeredCheckButton1.AdaptImage = true;
            this.layeredCheckButton1.BackColor = System.Drawing.Color.Transparent;
            this.layeredCheckButton1.BaseColor = System.Drawing.Color.Wheat;
            this.layeredCheckButton1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredCheckButton1.Canvas")));
            this.layeredCheckButton1.Checked = true;
            this.layeredCheckButton1.CheckedHover = null;
            this.layeredCheckButton1.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.CheckedNormal")));
            this.layeredCheckButton1.CheckedPressed = null;
            this.layeredCheckButton1.CheckOnClick = true;
            this.layeredCheckButton1.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredCheckButton1.HoverImage = null;
            this.layeredCheckButton1.ImageAttribute = imageAttributes11;
            this.layeredCheckButton1.Location = new System.Drawing.Point(314, 322);
            this.layeredCheckButton1.Name = "layeredCheckButton1";
            this.layeredCheckButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.NormalImage")));
            this.layeredCheckButton1.PressedImage = null;
            this.layeredCheckButton1.Size = new System.Drawing.Size(35, 31);
            this.layeredCheckButton1.TabIndex = 7;
            this.layeredCheckButton1.UncheckedHover = null;
            this.layeredCheckButton1.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.UncheckedNormal")));
            this.layeredCheckButton1.UncheckedPressed = null;
            // 
            // btnRemember
            // 
            this.btnRemember.AutoSize = true;
            this.btnRemember.BackColor = System.Drawing.Color.Transparent;
            this.btnRemember.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btnRemember.Canvas")));
            this.btnRemember.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemember.ForeColor = System.Drawing.Color.Black;
            this.btnRemember.HaloSize = 5;
            this.btnRemember.ImageAttribute = imageAttributes12;
            this.btnRemember.Location = new System.Drawing.Point(355, 332);
            this.btnRemember.Name = "btnRemember";
            this.btnRemember.Size = new System.Drawing.Size(65, 21);
            this.btnRemember.TabIndex = 8;
            this.btnRemember.Text = "记住密码";
            this.btnRemember.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnRemember.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginForm
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.GradualCurtainEffect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ERP.Winform.Properties.Resources.Load_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CaptionShowMode = LayeredSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(653, 582);
            this.Controls.Add(this.btnRemember);
            this.Controls.Add(this.layeredCheckButton1);
            this.Controls.Add(this.layeredLabel3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.layeredLabel2);
            this.Controls.Add(this.layeredLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.layeredPictureBox2);
            this.Controls.Add(this.layeredPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsPartPaint = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ";
            this.Load += new System.EventHandler(this.QQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LayeredSkin.Controls.LayeredPictureBox layeredPictureBox1;
        private LayeredSkin.Controls.LayeredPictureBox layeredPictureBox2;
        private LayeredSkin.Controls.LayeredButton btnMin;
        private LayeredSkin.Controls.LayeredButton btnClose;
        private LayeredSkin.Controls.LayeredTextBox txtUser;
        private LayeredSkin.Controls.LayeredLabel layeredLabel1;
        private LayeredSkin.Controls.LayeredTextBox txtPassword;
        private LayeredSkin.Controls.LayeredLabel layeredLabel2;
        private LayeredSkin.Controls.LayeredButton btnLogin;
        private LayeredSkin.Controls.LayeredLabel layeredLabel3;
        private LayeredSkin.Controls.LayeredCheckButton layeredCheckButton1;
        private LayeredSkin.Controls.LayeredLabel btnRemember;
        private System.Windows.Forms.Timer timer1;
    }
}