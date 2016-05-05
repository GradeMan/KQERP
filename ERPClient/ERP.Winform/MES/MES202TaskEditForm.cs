using COM.Domain;
using COM.Service;
using COM.Winform;
using DevExpress.XtraTab;
using ERP.Domain;
using ERP.Service;
using ERP.Winform.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;
using DevExpress.XtraEditors.Repository;
namespace ERP.Winform.MES
{
    public partial class MES202TaskEditForm : EditForm
    {
        private IMES_M202_TaskService TaskService = Unity.Instance.GetService<IMES_M202_TaskService>();
        private IMES_M202_Task_DetailService TaskDetailService = Unity.Instance.GetService<IMES_M202_Task_DetailService>();
        
        //LookUp
        private IMES_M201_Plan_DetailService planDetailService = Unity.Instance.GetService<IMES_M201_Plan_DetailService>();
        private IMES_M201_PlanService planService = Unity.Instance.GetService<IMES_M201_PlanService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();

        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private MES_M202_Task tempData;
        public MES202TaskEditForm(MES_M202_Task task,IMES_M202_TaskService taskservice)
        {
            InitializeComponent();
            this.tempData = task;
            this.TaskService = taskservice;

            tempData.TaskDt = DateTime.Now.Date;
        }
        protected override void InitData()
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
            //产品
            var productData = productService.GetProductInputData();
            SetGridLookUpEdit(repositoryProduct, productData, 1);
            //客户
            var customerData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(repositoryItemCustomer, customerData, 1);
            repositoryItemCustomer.DisplayMember = "Value";
            //计划单
            var planData = planDetailService.GetInputList();
            SetGridLookUpEdit(repositoryItemPlan, planData, 5);
            //repositoryItemPlan.DisplayMember = "Value";
            //repositoryItemPlan.View.Columns[0].Caption = "计划单号";
            repositoryItemPlan.View.Columns[1].Caption = "SO工单";
            repositoryItemPlan.View.Columns[2].Caption = "料号";
            repositoryItemPlan.View.Columns[3].Caption = "品名";
            repositoryItemPlan.View.Columns[4].Caption = "数量";
            repositoryItemPlan.View.Columns[5].Caption = "完成数量";
            this.mESM202TaskBindingSource.DataSource = tempData;
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
            var count = TaskDtlList.Count;
            //新增自动添加20空行
            for (int i = 0; i < 20 - count; i++)
            {
                MES_M202_Task_Detail taskdtl = new MES_M202_Task_Detail();
                taskdtl.TaskNo = tempData.TaskNo;
                taskdtl.FQty = 0;
                taskdtl.JobQty = 0;
                TaskDtlList.Add(taskdtl);
            }
            this.mESM202TaskDetailBindingSource.DataSource = TaskDtlList;
            
            
            //this.gridProduct.BestFitColumns();
            //this.gridMaterial.BestFitColumns();
        }

        private void gridProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //var product = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
            //if (product != null)
            //{
            //    mESM201PlanMaterialBindingSource.DataSource = planMaterialService.GetQuery().Where(a => a.PlanDetailId == product.Id).ToList();
            //}
            var taskdtl = this.mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            string filterSql = string.Format(" [PlanDetailId] = '{0}'","999999");
            if (taskdtl != null)
                filterSql = string.Format(" [PlanDetailId] = '{0}'", taskdtl.Id);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.gridProduct.CloseEditor();
                if (this.Tag.ToStr() == BtnCommandEnum.Add)
                {
                    //保存时自动生成单号
                    string ls_TaskNo = "";
                    ls_TaskNo = viewService.GetGenerateOrderCode(4);
                    tempData.TaskNo = ls_TaskNo;
                }

                var taskdtllist = (this.mESM202TaskDetailBindingSource.DataSource as List<MES_M202_Task_Detail>).Where(a => a.PartNo != null).ToList();

                //foreach (var taskdtl in taskdtllist)
                //{
                //    taskdtl.TaskNo = ls_TaskNo;
                //}
                TaskService.Save(tempData, taskdtllist);
                DialogResult = DialogResult.OK;
            }
            else if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
            
        }
        protected override void CreateToolBar()
        {
            XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
            foreach (var contr in page.Controls)
            {
                if (contr is ToolStrip)
                    return;
            }
            ToolStrip toolStrip = new ToolStrip();
            ToolStripButton btnAdd = new ToolStripButton();
            btnAdd.Text = "新增明细";
            btnAdd.Image = (Image)Resources.ResourceManager.GetObject("edit_add");
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnAdd.Click += new EventHandler(btnAdd_Click);
            toolStrip.Items.Add(btnAdd);
            ToolStripSeparator toolSep = new ToolStripSeparator();
            toolStrip.Items.Add(toolSep);
            ToolStripButton btnDel = new ToolStripButton();
            btnDel.Text = "删除明细";
            btnDel.Image = (Image)Resources.ResourceManager.GetObject("cancel");
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnDel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDel.Click += new EventHandler(btnDel_Click);
            toolStrip.Items.Add(btnDel);
            ToolStripSeparator toolSep2 = new ToolStripSeparator();
            toolStrip.Items.Add(toolSep2);
            ToolStripButton btnAdd2 = new ToolStripButton();
            btnAdd2.Text = "批量添加";
            btnAdd2.Image = (Image)Resources.ResourceManager.GetObject("edit_add");
            btnAdd2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnAdd2.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd2.Click += btnAdd2_Click;
            toolStrip.Dock = DockStyle.Top;
            toolStrip.BringToFront();
            page.Controls.Add(toolStrip);
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAdd2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            var taskdtl = this.mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            
            mESM202TaskDetailBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.mESM202TaskDetailBindingSource.AddNew();
        }

        private void repositoryProduct_EditValueChanged(object sender, EventArgs e)
        {
            this.gridProduct.CloseEditor();
            var taskdtl = this.mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            if (taskdtl != null)
            {
                var product = productService.GetByPartNo(taskdtl.PartNo) ?? new ERP_M001_Product();
                taskdtl.PartNo = product.PartNo;
                taskdtl.JobQty = 0;
                taskdtl.FQty = 0;
                this.mESM202TaskDetailBindingSource.ResetCurrentItem();

                //this.gridProduct.BestFitColumns();
            }
            
        }

        private void repositoryItemPlan_EditValueChanged(object sender, EventArgs e)
        {
            this.gridProduct.CloseEditor();
            var taskdtl = this.mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            if (taskdtl != null)
            {
                var planDetail = planDetailService.GetById(taskdtl.PlanDetailId.ToGuid());
                var plan = planService.GetQuery().Where(a => a.PLNo == planDetail.PLNo).FirstOrDefault();
                taskdtl.PLNo = planDetail.PLNo;
                taskdtl.CustCode = planDetail.CustCode;
                taskdtl.PartNo = planDetail.PartNo;
                taskdtl.SONo = planDetail.SONo;
                taskdtl.SOQty = planDetail.SOQty;
                //taskdtl.JobType = plan.PLType;
                taskdtl.PlanSumQty = planDetail.SumQty;
                taskdtl.PlanFQty = planDetail.FQty;
                this.mESM202TaskDetailBindingSource.ResetCurrentItem();

            }
        }

        

    }
}
