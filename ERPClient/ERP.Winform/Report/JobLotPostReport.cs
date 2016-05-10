using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ERP.Domain;
using ERP.Service;
using COM.Service;
using System.Linq;
using ERP.Service.Dtos;
using Util;

namespace ERP.Winform.Report
{
    public partial class JobLotPostReport : DevExpress.XtraReports.UI.XtraReport
    {
        private readonly IProductService productService = Unity.Instance.GetService<IProductService>();
        private IProductProdInfoService productProdInfoService = Unity.Instance.GetService<IProductProdInfoService>();
        private readonly IProductProcessFlowService productProcessFlowService = Unity.Instance.GetService<IProductProcessFlowService>();
        private readonly List<TaskReportHead> taskReportHeadList;

        private readonly ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public JobLotPostReport(List<TaskReportHead> taskReportHeadList)
        {
            InitializeComponent();
            this.taskReportHeadList = taskReportHeadList;
            this.bindingSource3.DataSource = taskReportHeadList;
        }

        private void txtJobLotNo_TextChanged(object sender, EventArgs e)
        {
            string jobLotNo = txtJobLotNo.Text.Trim();
            if (!string.IsNullOrWhiteSpace(jobLotNo))
            {
                var taskReportHead = taskReportHeadList.FirstOrDefault(a => a.JobLotNo == jobLotNo);
                if (taskReportHead != null)
                {
                    List<ERP_M001_Product_ProcessFlow> processList = productService.GetProcessFlowByProdutCode(taskReportHead.PartNo).Where(a => a.ProcessType == "后制程").OrderBy(a => a.ProcessSeqNo).ToList();
                    var procNameList = codeService.GetListByCodeID("PROC");
                    foreach (var process in processList)
                    {
                        process.ProcessName = procNameList.Where(a => a.Code == process.ProcessCode).Select(a => a.Description).FirstOrDefault();
                    }
                    this.bindingSource2.DataSource = processList;
                }
            }
        }

        private void txtProcessId_TextChanged(object sender, EventArgs e)
        {
            var processId = txtProcessId.Text;//产品制程ID
            if (!string.IsNullOrEmpty(processId))
            {
                //1.0 获取对应产品制程跟制程名称
                var process = productProcessFlowService.GetById(processId.ToGuid());
                var processNameList = codeService.GetListByCodeID("PROC");
                process.ProcessName =
                    processNameList.Where(a => a.Code == process.ProcessCode)
                        .Select(a => a.Description)
                        .FirstOrDefault();
                //2.0 获取对应产品制程参数及名称
                var prodList =
                    productProdInfoService.GetQueryable()
                        .Where(a => a.PartNo == process.PartNo && a.ProcessCode == process.ProcessCode).ToList();
                var prodNameList = codeService.GetListByCodeID("PROCPMS");
                foreach (var prodInfo in prodList)
                {
                    prodInfo.TechName = prodNameList.Where(a => a.Code == prodInfo.TechCode).Select(a => a.Description).FirstOrDefault();
                }
                //3.0把模板套用进去
                //JobLot_CuLaInnerProcess innerProcess = new JobLot_CuLaInnerProcess(prodList);
                //this.xrSubreport1.ReportSource = innerProcess;
                foreach (var processName in Enum.GetNames(typeof(ProcessType)))
                {
                    if (process.ProcessName != null && !process.ProcessName.Contains(processName)) continue;
                    //xrSubreport2.ReportSource = null;
                    switch (processName)
                    {
                        case "粗拉":
                            JobLot_CulaInner1 inner1 = new JobLot_CulaInner1(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner1;
                            break;
                        case "中拉及清洗":
                            JobLot_CulaInner1 inner2 = new JobLot_CulaInner1(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner2;
                            break;
                        case "电镀":
                            JobLot_CulaInner2 inner3 = new JobLot_CulaInner2(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner3;
                            break;
                        case "细拉半成品1":
                            JobLot_CulaInner3 inner4 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner4;
                            break;
                        case "半成品退火":
                            JobLot_CulaInner3 inner5 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner5;
                            break;
                        case "细拉半成品2":
                            JobLot_CulaInner3 inner6 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner6;
                            break;
                        case "细拉成品":
                            JobLot_CulaInner3 inner7 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner7;
                            break;
                        case "成品清洗":
                            JobLot_CulaInner3 inner8 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner8;
                            break;
                        case "成品退火":
                            JobLot_CulaInner3 inner9 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner9;
                            break;
                        case "成品绕线":
                            JobLot_CulaInner3 inner10 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner10;
                            break;
                        case "成品内包":
                            JobLot_CulaInner3 inner11 = new JobLot_CulaInner3(process.ProcessKey);
                            this.xrSubreport2.ReportSource = inner11;
                            break;

                    }
                }
            }
        }
    }
}
