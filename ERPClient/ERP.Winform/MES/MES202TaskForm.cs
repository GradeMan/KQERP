using COM.Service;
using COM.Winform;
using ERP.Service;
using ERP.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;
using ERP.Winform.Report;

namespace ERP.Winform.MES
{
    public partial class MES202TaskForm : ListForm
    {
        private IMES_M202_TaskService TaskService = Unity.Instance.GetService<IMES_M202_TaskService>();
        private ICustomerService customerService = Unity.Instance.GetService<ICustomerService>();
        private IMES_M201_Plan_DetailService planDetailService = Unity.Instance.GetService<IMES_M201_Plan_DetailService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        public MES202TaskForm()
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

            this.mESM202TaskBindingSource.CurrentChanged += mESM202TaskBindingSource_CurrentChanged;

            txtTxDt1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtTxDt2.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

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

            //客户
            var customerData = customerService.GetCustomerInputData();
            SetGridLookUpEdit(repositoryItemCustomer, customerData, 1);

            var tastQuery = TaskService.GetQuery();

            if (string.IsNullOrWhiteSpace(txtTxDt1.Text) || string.IsNullOrWhiteSpace(txtTxDt2.Text))
                throw new AppException("请先输入任务单日期");

            var taskList = tastQuery.Where(a => a.TaskDt >= txtTxDt1.DateTime && a.TaskDt <= txtTxDt2.DateTime).ToList();
            this.mESM202TaskBindingSource.DataSource = taskList;

            this.gridTask.BestFitColumns();
            //this.gridTaskDetail.BestFitColumns();
        }
        void mESM202TaskBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var tempData = this.mESM202TaskBindingSource.Current as MES_M202_Task;
            if (tempData != null)
            {
                var TaskDtlList = TaskService.GetProductQuery().Where(a => a.TaskNo == tempData.TaskNo).ToList();
                foreach (var taskDtl in TaskDtlList)
                {
                    var planDetail = planDetailService.GetById(taskDtl.PlanDetailId.ToGuid());
                    if (planDetail != null)
                    {
                        taskDtl.PlanSumQty = planDetail.SumQty;
                        taskDtl.PlanFQty = planDetail.FQty;
                    }
                }
                this.mESM202TaskDetailBindingSource.DataSource = TaskDtlList;
            }
            else
            {
                this.mESM202TaskDetailBindingSource.DataSource = null;
            }
        }

       

        private void gridProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                mESM202TaskBindingSource.AddNew();

                EditForm("跟踪单新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                MES_M202_Task temp = mESM202TaskBindingSource.Current as MES_M202_Task;
                if (temp == null)
                    throw new AppException("请先选择要修改的数据");
                EditForm("跟踪单修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    MES_M202_Task temp = mESM202TaskBindingSource.Current as MES_M202_Task;
                    if (temp == null)
                        throw new AppException("请先选择要删除的数据");
                    TaskService.Delete(temp.Id);
                    mESM202TaskBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Watch)
            {
                MES_M202_Task temp = mESM202TaskBindingSource.Current as MES_M202_Task;
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
                MES_M202_Task temp = mESM202TaskBindingSource.Current as MES_M202_Task;
                    //班次
               var codeData = codeService.GetCodeDataByCodeId("SHIFT");

                //客户
                 var customerData = customerService.GetCustomerInputData();
                foreach (var taskdetail in taskDetailList)
                {
                    taskdetail.TaskDt = temp.TaskDt;
                    taskdetail.ShiftName = codeData.Where(a => a.Value == taskdetail.ShiftCode).Select(a=>a.DisPlayName).FirstOrDefault();
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
            if (taskDetail != null)
            {
                var product = productService.GetProduct().Where(a => a.PartNo == taskDetail.PartNo).Select(a => new { a.PartSpec, a.PartType, a.ProcessFlow }).FirstOrDefault();
                if (product == null)
                    throw new AppException("没有对应的产品基础资料，请检查产品基础信息");
                taskDetail.PartSpec = product.PartSpec;
                taskDetail.PartType = product.PartType;
                taskDetail.ProcessFlow = product.ProcessFlow;
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
            MES_M202_Task temp = mESM202TaskBindingSource.Current as MES_M202_Task;
            MES202TaskEditForm edit = new MES202TaskEditForm(temp, TaskService);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                mESM202TaskBindingSource.CancelEdit();
            }
            else
            {
                mESM202TaskBindingSource_CurrentChanged(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
