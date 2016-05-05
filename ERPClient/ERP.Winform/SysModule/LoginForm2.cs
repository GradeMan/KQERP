using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.Service;
using COM.Service;
using Util;
using ERP.Domain;
using COM.Domain;
namespace ERP.Winform.SysModule
{
    public partial class LoginForm2 : DevExpress.XtraEditors.XtraForm
    {
        private IAppLoginService appLoginService = Unity.Instance.GetService<IAppLoginService>();
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        private string IniFilePath = "D:\\MIS\\Project\\KQERP\\KQERP.INI";
        public int formStyle = 0;
        public LoginForm2()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            appLoginService.LoginAsERPUser(txtUser.Text.ToStr(), txtPassword.Text.ToStr(),txtCompany.EditValue.ToStr(), txtCompany.Text.ToStr());
            formStyle = this.txtFormStyle.SelectedIndex;
            INIFile inifile = new INIFile(IniFilePath);
            inifile.IniWriteValue("Login", "UserName", txtUser.Text);
            inifile.IniWriteValue("Login", "Company", txtCompany.EditValue.ToStr());
            if (this.txtReamberPwd.Checked)
                inifile.IniWriteValue("Login", "Pwd", txtPassword.Text);
            else
                inifile.IniWriteValue("Login", "Pwd", "");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void LoginForm2_Load(object sender, EventArgs e)
        {
            var companyData = companyService.GetList().Select(a => new { a.Alias,a.CompCode}).ToList();
            txtCompany.Properties.DisplayMember = "Alias";
            txtCompany.Properties.ValueMember = "CompCode";
            txtCompany.Properties.DataSource = companyData;
            ERP_C002_Company company = companyService.GetList().FirstOrDefault();
            if (company != null)
            {
                this.txtCompanyName.Text = company.CompName;
                this.txtSystemName.Text = company.SysName;
            }
            txtFormStyle.SelectedIndex = 0;
            if (!System.IO.Directory.Exists("D:\\MIS"))
            {
                System.IO.Directory.CreateDirectory("D:\\MIS");
            }
            if (!System.IO.Directory.Exists("D:\\MIS\\Project"))
            {
                System.IO.Directory.CreateDirectory("D:\\MIS\\Project");
            }
            if (!System.IO.Directory.Exists("D:\\MIS\\Project\\KQERP"))
            {
                System.IO.Directory.CreateDirectory("D:\\MIS\\Project\\KQERP");
            }
            INIFile inifile = new INIFile(IniFilePath);
            txtUser.Text = inifile.IniReadValue("Login", "UserName");
            txtPassword.Text = inifile.IniReadValue("Login", "Pwd");
            txtCompany.EditValue = inifile.IniReadValue("Login", "Company");
            if (string.IsNullOrEmpty(inifile.IniReadValue("PrintLabelSet", "BarPath")))
            {
                inifile.IniWriteValue("PrintLabelSet", "BarPath", @"C:\Program Files (x86)\Seagull\BarTender Suite");
            }
            if (string.IsNullOrEmpty(inifile.IniReadValue("PrintLabelSet", "LabelPath")))
            {
                inifile.IniWriteValue("PrintLabelSet", "LabelPath", @"/f=D:\MIS\Project\KQERP\Label");
            }
            if (string.IsNullOrEmpty(inifile.IniReadValue("PrintLabelSet", "DefaultName")))
            {
                inifile.IniWriteValue("PrintLabelSet", "DefaultName", "200-ALL");
            }
            if (string.IsNullOrEmpty(inifile.IniReadValue("PrintLabelSet", "L")))
            {
                inifile.IniWriteValue("PrintLabelSet", "L", @"/p /x /s=1 /c=2 /prn=PrintName");
            }
            if (string.IsNullOrEmpty(inifile.IniReadValue("PrintLabelSet", "M")))
            {
                inifile.IniWriteValue("PrintLabelSet", "M", @"/p /x /s=1 /c=2 /prn=PrintName");
            }
            if (string.IsNullOrEmpty(inifile.IniReadValue("PrintLabelSet", "S")))
            {
                inifile.IniWriteValue("PrintLabelSet", "S", @"/p /x /s=1 /c=2 /prn=PrintName");
            }
            if (string.IsNullOrEmpty(inifile.IniReadValue("JobLot", "ProcessCode")))
            {
                inifile.IniWriteValue("JobLot", "ProcessCode", "");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}