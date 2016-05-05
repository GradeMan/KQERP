using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using COM.Service;
using ERP.Domain.Order.ViewModel;
namespace ERP.Winform.Order.Report
{
    public partial class JobReportForm : ReportForm
    {
        public IJobReportService jobReportService = Unity.Instance.GetService<IJobReportService>();
        public IJobService jobService = Unity.Instance.GetService<IJobService>();
        public JobReportForm()
        {
            InitializeComponent();
            
        }
        public override void InitData()
        {
            ERPHelper.Instance.SetGridLookUpEdit(txtJobNo, jobService.GetInputDataList(), 0);
        }
        public void GetData(string jobNo,List<string> lotList)
        {
            var JobHeaderList = jobReportService.GetByJobNoList(jobNo, lotList);

        }
        //搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string jobno = txtJobNo.Text.Trim();
            List<string> lotNoList = txtLotNo.EditValue.ToString().Split(';').ToList();
            List<string> LotNoTemp = new List<string>();
            if (lotNoList.Count > 0)
            {
                foreach (string m in lotNoList)
                    LotNoTemp.Add(m.Trim());
            }
            CreateReport(jobno, LotNoTemp);
        }

        public  void CreateReport(string jobno, List<string> LotNoTemp)
        {
            JobReportModel model = this.jobReportService.GetByJobNoList(jobno, LotNoTemp);
            JobReport jobreport = new JobReport(model);
            documentViewer1.DocumentSource = jobreport;
            jobreport.CreateDocument();
        }
        private void txtJobNo_EditValueChanged(object sender, EventArgs e)
        {
            if (txtJobNo.EditValue != null)
            {
                string jobno = txtJobNo.EditValue.ToString();
                txtLotNo.Properties.DataSource = jobService.GetJobLotListByJobNo(jobno).Select(i=>new {i.LotNo}).OrderBy(i=>i.LotNo).ToList();
                txtLotNo.Properties.DisplayMember = "LotNo";
                txtLotNo.Properties.ValueMember = "LotNo";
            }
        }
    }
}