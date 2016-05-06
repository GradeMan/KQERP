using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ERP.Domain;
using System.Collections.Generic;
using ERP.Service;
using COM.Service;
using System.Linq;
namespace ERP.Winform.Report
{
    public partial class JobLotPreReport : DevExpress.XtraReports.UI.XtraReport
    {
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private MES_M202_Task_Detail taskDetail;
        private List<ERP_M001_Product_ProdInfo> prodInfoList;
        private List<ERP_M001_Product_ProcessFlow> processList;
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public JobLotPreReport(MES_M202_Task_Detail taskDetail, List<ERP_M001_Product_ProcessFlow> processList)
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
            //switch (xrTableCell1.Text.Trim())
            //{
            //    case "细拉半成品2": 
            //         JobLot_CuLaInnerReport prod3= new JobLot_CuLaInnerReport(2);
            //         this.xrSubreport2.ReportSource = prod3;
            //        //xrTable3.InsertRowBelow(new XRTableRow());
            //        break;
            //    case "细拉成品": JobLot_CuLaInnerReport prod = new JobLot_CuLaInnerReport(3);
            //         this.xrSubreport2.ReportSource = prod;
            //        break;
            //    case "成品清洗":
            //        var prodList = productService.GetProdInfoByProdutCode(taskDetail.PartNo);
            //        JobLot_CuLaInner2Report prod2 = new JobLot_CuLaInner2Report(prodList);
            //        this.xrSubreport1.ReportSource = prod2;
            //        JobLot_CuLaInnerReport prod4 = new JobLot_CuLaInnerReport(5);
            //        this.xrSubreport2.ReportSource = prod4;
            //        break;
            //}
            //xrTableRow2
        }

        private void JobLotPreReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {


        }

        private void xrTableCell10_TextChanged(object sender, EventArgs e)
        {
            var processCode = xrTableCell10.Text;
            if (!string.IsNullOrEmpty(processCode))
            {
                var process = processList.FirstOrDefault(a => a.ProcessCode == processCode);
                var prodList = prodInfoList.Where(a => a.PFCode == taskDetail.ProcessFlow && a.ProcessCode == processCode).ToList();
                JobLot_CuLaInnerProcess innerProcess = new JobLot_CuLaInnerProcess(prodList);
                this.xrSubreport1.ReportSource = innerProcess;
                List<string> processNameList = new List<string>() {"粗拉", "中拉及清洗(酸洗线)", "电镀"};
                //if(process.ProcessName.Contains())
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
                        JobLot_CulaInner3 inner6= new JobLot_CulaInner3(process.ProcessKey);
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
