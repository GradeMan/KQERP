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
namespace ERP.Winform.Report
{
    public partial class JobLotPostReport : DevExpress.XtraReports.UI.XtraReport
    {
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private MES_M202_Task_Detail taskDetail;
        private List<ERP_M001_Product_ProdInfo> prodInfoList;
        private List<ERP_M001_Product_ProcessFlow> processList;
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public JobLotPostReport(MES_M202_Task_Detail taskDetail,List<ERP_M001_Product_ProcessFlow> processList)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = taskDetail;
            this.bindingSource2.DataSource = processList;
            this.taskDetail = taskDetail;
            this.processList = processList;
            prodInfoList = productService.GetProdInfoByProdutCode(taskDetail.PartNo);
            var procNameList = codeService.GetListByCodeID("PROCPMS");
            foreach (var prodInfo in prodInfoList)
            {
                prodInfo.TechName = procNameList.Where(a => a.Code == prodInfo.TechCode).Select(a => a.Description).FirstOrDefault();
            }
        }

        private void xrTableCell1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xrZipCode1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        //后制成变化
        private void xrTableCell10_TextChanged(object sender, EventArgs e)
        {
            var processCode = xrTableCell10.Text;
            if (!string.IsNullOrEmpty(processCode))
            {
                var process = processList.Where(a => a.ProcessCode == processCode).FirstOrDefault();
                //var prodList = prodInfoList.Where(a => a.PFCode == taskDetail.ProcessFlow && a.ProcessCode == processCode).ToList();
                //JobLot_CuLaInnerProcess innerProcess = new JobLot_CuLaInnerProcess(prodList);
                //this.xrSubreport1.ReportSource = innerProcess;
                switch (process.ProcessName)
                {
                    case "粗拉":
                        JobLot_CulaInner1 inner1 = new JobLot_CulaInner1(process.ProcessKey);
                        this.xrSubreport2.ReportSource = inner1;
                        break;
                    case "中拉及清洗(酸洗线)":
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
