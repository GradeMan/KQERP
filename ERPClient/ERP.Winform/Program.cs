using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ERP.Winform.Service;
using Util;
using System.Data.Entity.Validation;
using COM.Data;
using ERP.Winform.SysModule;
using DevExpress.XtraEditors;
using ERP.Winform.FileManager;
using ERP.Winform.MES.Report;
namespace ERP.Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //处理未捕获的异常   
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2013 Light Gray");
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppStartService.Instance.Start();
            //ERP.Winform.Report.PackingListReport reportFrm = new ERP.Winform.Report.PackingListReport();
            //ERP.Winform.Report.ReportShowForm reportShowFrm = new ERP.Winform.Report.ReportShowForm(reportFrm);
            //Application.Run(new R103_JobTxDetail());
            LoginForm2 frm = new LoginForm2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.formStyle == 0)
                    Application.Run(new MainTreeForm());
                else
                    Application.Run(new MainForm());
            }
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("抱歉，您的操作没有能够完成，请再试一次或者联系软件提供商");
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception is AppException)
            {
                AppException appexception = e.Exception as AppException;
                LogServive.Instance.Log.Warn(appexception.Message, null);
                XtraMessageBox.Show("一般错误警告:" + appexception.Message);
            }
            else if (e.Exception is EfValidationException)
            {
                LogServive.Instance.Log.Error(e.Exception.Data, null);
                XtraMessageBox.Show("EF实体错误:" + e.Exception.Data);
                
            }
            else if (e.Exception is ConcurrencyException)
            {
                XtraMessageBox.Show("EF并发错误:" + e.Exception.Message + e.Exception.InnerException);
                LogServive.Instance.Log.Debug(e.Exception.Message + e.Exception.InnerException, null);
            }
            else
            {
                XtraMessageBox.Show("错误:" + e.Exception.Message);
                LogServive.Instance.Log.Error(e.Exception.Message, null);
            }
           // MessageBox.Show("致命错误:" + e.Exception.Message);
           
        }
    }
}
