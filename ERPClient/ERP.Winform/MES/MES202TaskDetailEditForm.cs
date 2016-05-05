using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using ERP.Domain;
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

namespace ERP.Winform.MES
{
    public partial class MES202TaskDetailEditForm : EditForm
    {
        private IMES_M202_Task_DetailService TaskDetailService;//= Unity.Instance.GetService<IMES_M202_Task_DetailService>();
        private IMES_M202_Task_JobLotService taskJobLotService = Unity.Instance.GetService<IMES_M202_Task_JobLotService>();
        private ICodeService codeService;//= Unity.Instance.GetService<ICodeService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private MES_M202_Task_Detail tempData;
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private IMES_M201_Plan_DetailService planDetailService = Unity.Instance.GetService<IMES_M201_Plan_DetailService>();
        private IMES_M201_PlanService planService = Unity.Instance.GetService<IMES_M201_PlanService>();
        private IProcessFlowService processFlowService = Unity.Instance.GetService<IProcessFlowService>();
        public MES202TaskDetailEditForm(MES_M202_Task_Detail taskDetail, IMES_M202_Task_DetailService TaskDetailService,ICodeService codeService)
        {
            InitializeComponent();
            this.tempData = taskDetail;
            this.TaskDetailService = TaskDetailService;
            this.codeService = codeService;
        }

        protected override void InitData()
        {
            //级别
            SetGridLookUpEdit(TLevelTextEdit, codeService.GetCodeDataByCodeId("PLLEVEL"), 1);
            //状态
            SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("PLSTATUS"), 1);
            //班次
            var codeData = codeService.GetCodeDataByCodeId("SHIFT");
            SetGridLookUpEdit(ShiftCodeTextEdit, codeData, 1);
            //机台
            codeData = codeService.GetCodeDataByCodeId("MACHINE");
            SetGridLookUpEdit(MacCodeTextEdit, codeData, 1);
            //产品
            var productData = productService.GetProductInputData();
            SetGridLookUpEdit(PartNoTextEdit, productData, 1);
            //客户
            var customerData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(CustCodeTextEdit, customerData, 1);
            //计划单
            var planData = planDetailService.GetInputList();
            SetGridLookUpEdit(txtPlanDetialId, planData, 5);

            var processFlowList = processFlowService.GetProcessFlowInputData();
            SetGridLookUpEdit(ProcessFlowTextEdit, processFlowList, 1);
            //repositoryItemPlan.DisplayMember = "Value";
            //repositoryItemPlan.View.Columns[0].Caption = "计划单号";
            txtPlanDetialId.Properties.View.Columns[1].Caption = "SO工单";
            txtPlanDetialId.Properties.View.Columns[2].Caption = "料号";
            txtPlanDetialId.Properties.View.Columns[3].Caption = "品名";
            txtPlanDetialId.Properties.View.Columns[4].Caption = "数量";
            txtPlanDetialId.Properties.View.Columns[5].Caption = "完成数量";


            if (this.Tag.ToStr() == BtnCommandEnum.Add)
            {
                //保存时自动生成单号
                string ls_TaskNo = "";
                ls_TaskNo = viewService.GetGenerateOrderCode(4);
                tempData.TaskNo = ls_TaskNo;
            }

            this.mESM202TaskDetailBindingSource.DataSource = tempData;
            var taskJobLotList = taskJobLotService.GetQuery().Where(a => a.JobNo == tempData.TaskNo).ToList();
            this.mESM202TaskJobLotBindingSource.DataSource = taskJobLotList;

            //this.gridProduct.BestFitColumns();
            //this.gridMaterial.BestFitColumns();
        }
        /// <summary>
        /// 根据工单数量跟板数批量生产批次号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateLot_Click(object sender, EventArgs e)
        {
            decimal lotCount = LotCountTextEdit.Value;//Lot数
            decimal jobQty = JobQtyTextEdit.Value;//工单数量
            decimal panelQty = ShipQtyTextEdit.Value;//板数量
            string jobNo = this.TaskNoTextEdit.Text.Trim();
            if (string.IsNullOrWhiteSpace(jobNo))
            {
                throw new AppException("请先输入工单号");
            }
            if (jobQty <= 0)
            {
                throw new AppException("开单数量必须大于0");
            }
            if (panelQty <= 0)
            {
                throw new AppException("板数量必须大于0");
            }
            else if ( panelQty > jobQty)
            {
                throw new AppException("板数量不得大于开单数量");
            }
            if (lotCount > 0)
            {
                if (XtraMessageBox.Show("是否要重新生成Lot？", "系统提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var jobLotList = CreateJobLots(jobQty, panelQty, jobNo);
                    mESM202TaskJobLotBindingSource.DataSource = jobLotList;
                    this.tempData.LotCount = jobLotList.Count();

                }
            }
            else
            {
                var jobLotList = CreateJobLots(jobQty, panelQty, jobNo);
                mESM202TaskJobLotBindingSource.DataSource = jobLotList;
                this.tempData.LotCount = jobLotList.Count();
            }


           
        }

        /// <summary>
        ///  生成Lot数 Lot个数 == 工单数量/(每板数量*板数量)  每个Lot数量 ==每板数量*板数量
        /// </summary>
        /// <param name="jobQty">工单数量</param>
        /// <param name="panelQty">板数量</param>
        /// <param name="stripPerPanel">每板数量</param>
        /// <returns></returns>
        public List<MES_M202_Task_JobLot> CreateJobLots(decimal jobQty, decimal panelQty, string jobNo)
        {

            decimal modNumber = jobQty % panelQty;//每Lot数量数是否相等，看下是否有余数
            int totalLotNo = Convert.ToInt32((Math.Ceiling(jobQty / panelQty)));//总Lot数
            List<MES_M202_Task_JobLot> jobLotList = new List<MES_M202_Task_JobLot>();
            for (int i = 1; i <= (modNumber > 0 && totalLotNo > 1 ? totalLotNo - 1 : totalLotNo); i++)
            {
                MES_M202_Task_JobLot jobLot = new MES_M202_Task_JobLot();
                jobLot.JobNo = jobNo;
                jobLot.JobLotNo = jobNo + "-" + (i < 10 ? 0 + i.ToString() : i.ToString());
                jobLot.LotQty = Convert.ToInt16(panelQty);
                jobLotList.Add(jobLot);
            }
            if (modNumber > 0) //最后一Lot的数量
            {
                MES_M202_Task_JobLot jobLot = new MES_M202_Task_JobLot();
                jobLot.JobNo = jobNo;
                jobLot.JobLotNo = jobNo + "-" + (totalLotNo < 10 ? 0 + totalLotNo.ToString() : totalLotNo.ToString());
                jobLot.LotQty = Convert.ToInt16(modNumber);
                jobLotList.Add(jobLot);
            }
            return jobLotList;
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                //this.gridProduct.CloseEditor();

                this.mESM202TaskDetailBindingSource.EndEdit();
                //var taskDetail = this.mESM202TaskDetailBindingSource.DataSource as MES_M202_Task_Detail;
                var taskLotNoList = this.mESM202TaskJobLotBindingSource.DataSource as List<MES_M202_Task_JobLot>;
                //foreach (var taskdtl in taskdtllist)
                //{
                //    taskdtl.TaskNo = ls_TaskNo;
                //}
                TaskDetailService.Save(tempData, taskLotNoList);
                DialogResult = DialogResult.OK;
            }
            else if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;

        }

        private void txtPlanDetialId_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void PartNoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(tempData.PartNo))
            //{
            //    var product = productService.GetProduct().Where(a => a.PartNo == tempData.PartNo).FirstOrDefault();
            //    if (product != null)
            //    {
            //        tempData.PartNo = product.PartNo;
            //        tempData.PartSpec = product.PartSpec;
            //        tempData.PartType = product.PartType;
            //        //tempData.CustCode = product
            //    }
            //}
        }

        private void txtPlanDetialId_Leave(object sender, EventArgs e)
        {
            this.mESM202TaskDetailBindingSource.EndEdit();
            if (!string.IsNullOrEmpty(tempData.PlanDetailId))
            {
                var planDetail = planDetailService.GetById(tempData.PlanDetailId.ToGuid());
                //var plan = planService.GetQuery().Where(a => a.PLNo == planDetail.PLNo).FirstOrDefault();
                if (planDetail != null)
                {
                    tempData.PLNo = planDetail.PLNo;
                    tempData.CustCode = planDetail.CustCode;
                    tempData.PartNo = planDetail.PartNo;
                    tempData.SONo = planDetail.SONo;
                    tempData.SOQty = planDetail.SOQty;
                    //taskdtl.JobType = plan.PLType;
                    tempData.PlanSumQty = planDetail.SumQty;
                    tempData.PlanFQty = planDetail.FQty;
                    var product = productService.GetProduct().Where(a => a.PartNo == tempData.PartNo).FirstOrDefault();
                    if (product != null)
                    {
                        tempData.PartNo = product.PartNo;
                        //tempData.PartSpec = product.PartSpec;
                        //tempData.PartType = product.PartType;
                        tempData.ProcessFlow = product.ProcessFlow;
                    }
                    this.mESM202TaskDetailBindingSource.ResetCurrentItem();
                }
            }
        }

        private void PartNoTextEdit_Leave(object sender, EventArgs e)
        {
            this.mESM202TaskDetailBindingSource.EndEdit();
            if (!string.IsNullOrEmpty(tempData.PartNo))
            {
                var product = productService.GetProduct().Where(a => a.PartNo == tempData.PartNo).FirstOrDefault();
                if (product != null)
                {
                    tempData.PartNo = product.PartNo;
                    tempData.PartSpec = product.PartSpec;
                    tempData.PartType = product.PartType;
                    tempData.ProcessFlow = product.ProcessFlow;
                    this.mESM202TaskDetailBindingSource.ResetCurrentItem();
                }
            }
        }
    }
}
