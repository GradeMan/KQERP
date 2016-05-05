using COM.Service;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using ERP.Winform.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;

namespace ERP.Winform.MES
{
    public partial class MES202TaskDetailForm : ListForm
    {
        private IMES_M202_Task_DetailService taskDetailService = Unity.Instance.GetService<IMES_M202_Task_DetailService>();
        private IMES_M202_Task_JobLotService taskJobLotService = Unity.Instance.GetService<IMES_M202_Task_JobLotService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IMES_M201_PlanService planService = Unity.Instance.GetService<IMES_M201_PlanService>();
        private IMES_M201_Plan_DetailService planDetailService = Unity.Instance.GetService<IMES_M201_Plan_DetailService>();
        public MES202TaskDetailForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void OnAttachEvent()
        {
            //var customerData = customerService.GetCustomerInputData();
            //SetGridLookUpEdit(repositoryItemCustomer, customerData, 1);

            this.mESM202TaskDetailBindingSource.CurrentChanged += mESM202TaskDetailBindingSource_CurrentChanged;
            this.eRPM001ProductProcessFlowBindingSource.CurrentChanged += eRPM001ProductProcessFlowBindingSource_CurrentChanged;
            txtTxDt1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtTxDt2.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        }
        /// <summary>
        /// 制程改变，筛选制程参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eRPM001ProductProcessFlowBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ERP_M001_Product_ProcessFlow PF = this.eRPM001ProductProcessFlowBindingSource.Current as ERP_M001_Product_ProcessFlow;
            string filterSql = string.Format("[ProcessCode]= '{0}' ", "999999");
            if (PF != null)
                filterSql = string.Format("[ProcessCode]= '{0}'", PF.ProcessCode);
            this.gridProdInfo.ActiveFilterString = filterSql;
        }

        void mESM202TaskDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var tempData = this.mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            if (tempData != null)
            {
                var taskJobLotList = taskJobLotService.GetQuery().Where(a => a.JobNo == tempData.TaskNo).ToList();
                this.mESM202TaskJobLotBindingSource.DataSource = taskJobLotList;
                this.eRPM001ProductProcessFlowBindingSource.DataSource = productService.GetProcessFlowByProdutCode(tempData.PartNo).OrderBy(a => a.ProcessSeqNo).ToList();
                this.eRPM001ProductProdInfoBindingSource.DataSource = productService.GetProdInfoByProdutCode(tempData.PartNo).OrderBy(a => a.TechSeqNo).ToList(); 
            }
            else
            {
                this.mESM202TaskDetailBindingSource.DataSource = null;
            }
        }

        public override void InitData()
        {
            //级别
            SetGridLookUpEdit(repositoryItemLevel, codeService.GetCodeDataByCodeId("PLLEVEL"), 1);
            //状态
            SetGridLookUpEdit(repositoryItemStatus, codeService.GetCodeDataByCodeId("PLSTATUS"), 1);

            //班次
            var codeData = codeService.GetCodeDataByCodeId("SHIFT");
            SetGridLookUpEdit(repositoryItemShift, codeData, 1);

            //机台
            codeData = codeService.GetCodeDataByCodeId("MACHINE");
            SetGridLookUpEdit(repositoryItemMac, codeData, 1);

            //客户
            var customerData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(repositoryItemCustomer, customerData, 1);

            //计划单
            var planData = planDetailService.GetInputList();
            SetGridLookUpEdit(repositoryItemPlan, planData, 5);

            SetGridLookUpEdit(repositoryItemPROC, codeService.GetCodeDataByCodeId("PROC"));
            SetGridLookUpEdit(repositoryItemPROCPMS, codeService.GetCodeDataByCodeId("PROCPMS"));
            SetGridLookUpEdit(repositoryItemPROCPMSTATUS, codeService.GetCodeDataByCodeId("PROCPMSTATUS"));

            var tastDetailQuery = taskDetailService.GetQuery();
            if (string.IsNullOrWhiteSpace(txtTxDt1.Text) || string.IsNullOrWhiteSpace(txtTxDt2.Text))
                throw new AppException("请先输入任务单日期");

            var taskDetailList = tastDetailQuery.Where(a => a.TaskDt >= txtTxDt1.DateTime && a.TaskDt <= txtTxDt2.DateTime).ToList();
            this.mESM202TaskDetailBindingSource.DataSource = taskDetailList;

            //this.gridTask.BestFitColumns();
            this.gridTaskDetail.BestFitColumns();
        }

        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                mESM202TaskDetailBindingSource.AddNew();
                MES_M202_Task_Detail temp = mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
                temp.TaskDt = DateTime.Now.Date;
                temp.TLevel = "01";
                temp.Status = "02";
                EditForm("跟踪单新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                MES_M202_Task_Detail temp = mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
                if (temp == null)
                    throw new AppException("请先选择要修改的数据");
                EditForm("跟踪单修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    MES_M202_Task_Detail temp = mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
                    if (temp == null)
                        throw new AppException("请先选择要删除的数据");
                    //TaskService.Delete(temp.Id);
                    mESM202TaskDetailBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Watch)
            {
                MES_M202_Task_Detail temp = mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
                if (temp == null)
                    throw new AppException("请先选择要查看的数据");
                EditForm("跟踪单查看", BtnCommandEnum.Watch);
            }
            else if (e.Item.Caption == BtnCommandEnum.Refresh)
            {
                InitData();
            }
            else if (e.Item.Caption == "打印任务单")
            {
                var taskDetailList = mESM202TaskDetailBindingSource.DataSource as List<MES_M202_Task_Detail>;
                if (taskDetailList == null)
                    return;
                //MES_M202_Task temp = mESM202TaskDetailBindingSource.Current as MES_M202_Task;
                //班次
                var codeData = codeService.GetCodeDataByCodeId("SHIFT");

                //客户
                var customerData = customerServer.GetCustomerInputData();
                foreach (var taskdetail in taskDetailList)
                {
                    taskdetail.ShiftName = codeData.Where(a => a.Value == taskdetail.ShiftCode).Select(a => a.DisPlayName).FirstOrDefault();
                    taskdetail.CustName = customerData.Where(a => a.Value == taskdetail.CustCode).Select(a => a.DisPlayName).FirstOrDefault();
                }
                MESTaskReport frmreport = new MESTaskReport(taskDetailList);
                ReportShowForm frm = new ReportShowForm(frmreport);
                frm.Show();
            }
            else if (e.Item.Caption == "打印前制单")
            {
                PrintProcess("前制程");
            }
            else if (e.Item.Caption == "打印后制单")
            {

                //var taskDetail = mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
                //if (taskDetail != null)
                //{
                //    var product = productService.GetProduct().Where(a => a.PartNo == taskDetail.PartNo).Select(a => new { a.PartSpec, a.PartType, a.ProcessFlow }).FirstOrDefault();
                //    if (product == null)
                //        throw new AppException("没有对应的产品基础资料，请检查产品基础信息");
                //    taskDetail.PartSpec = product.PartSpec;
                //    taskDetail.PartType = product.PartType;
                //    taskDetail.ProcessFlow = product.ProcessFlow;
                //    List<ERP_M001_Product_ProcessFlow> processList = productService.GetProcessFlowByProdutCode(taskDetail.PartNo).OrderBy(a => a.ProcessSeqNo).ToList();
                //    var procNameList = codeService.GetListByCodeID("PROC");
                //    foreach (var process in processList)
                //    {
                //        process.ProcessName = procNameList.Where(a => a.Code == process.ProcessCode).Select(a => a.Description).FirstOrDefault();
                //    }
                //    JobLotPostReport frmreport = new JobLotPostReport(taskDetail, processList);
                //    ReportShowForm frm = new ReportShowForm(frmreport);
                //    frm.Show();
                //}
                PrintProcess("后制程");
            }

        }

        private void PrintProcess(string ProcessType)
        {
            var taskDetail = mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            var taskJobLot = mESM202TaskJobLotBindingSource.Current as MES_M202_Task_JobLot;
            if (taskJobLot != null)
            {
                var product = productService.GetProduct().Where(a => a.PartNo == taskDetail.PartNo).Select(a => new { a.PartSpec, a.PartType, a.ProcessFlow }).FirstOrDefault();
                if (product == null)
                    throw new AppException("没有对应的产品基础资料，请检查产品基础信息");
                taskDetail.PartSpec = product.PartSpec;
                taskDetail.PartType = product.PartType;
                taskDetail.ProcessFlow = product.ProcessFlow;
                taskDetail.JobNo = taskJobLot.JobLotNo;
                List<ERP_M001_Product_ProcessFlow> processList = productService.GetProcessFlowByProdutCode(taskDetail.PartNo).Where(a => a.ProcessType == ProcessType).OrderBy(a => a.ProcessSeqNo).ToList();
                var procNameList = codeService.GetListByCodeID("PROC");
                foreach (var process in processList)
                {
                    process.ProcessName = procNameList.Where(a => a.Code == process.ProcessCode).Select(a => a.Description).FirstOrDefault();
                }
                if (ProcessType == "前制程")
                {
                    JobLotPreReport frmreport = new JobLotPreReport(taskDetail, processList);
                    ReportShowForm frm = new ReportShowForm(frmreport);
                    frm.Show();
                }
                else
                {
                    JobLotPostReport frmreport = new JobLotPostReport(taskDetail, processList);
                    ReportShowForm frm = new ReportShowForm(frmreport);
                    frm.Show();
                }
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            MES_M202_Task_Detail temp = mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            MES202TaskDetailEditForm edit = new MES202TaskDetailEditForm(temp, taskDetailService,codeService);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                mESM202TaskDetailBindingSource.CancelEdit();
            }
            else
            {
                mESM202TaskDetailBindingSource_CurrentChanged(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
