using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;
namespace ERP.Winform.MES.Report
{
    public partial class R102_JobDelayForm : ListForm
    {
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public R102_JobDelayForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            int mouth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            txtProdDt1.DateTime = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + "1");
            txtProdDt2.DateTime = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + mouth.ToString());
            ShowData();
        }

        public void ShowData()
        {
            DateTime lbStart;
            DateTime lbEnd;
            try
            {
                lbStart = txtProdDt1.DateTime.Date;
                lbEnd = txtProdDt2.DateTime.Date;
                if (lbStart > lbEnd)
                {
                    XtraMessageBox.Show("结束时间不能大于开始时间,请检查");
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("输入的时间格式不正确，请查阅");
                return;
            }
            this.pivotGridControl1.DataSource = viewService.GetJobDelay(lbStart, lbEnd, Conv.ToInt(txtDays.Value));
            this.pivotGridControl1.BestFit();
            //this.gridView1.BestFitColumns();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
