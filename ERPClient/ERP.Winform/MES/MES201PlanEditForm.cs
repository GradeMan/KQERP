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
using DevExpress.XtraEditors.Helpers;
using Util;
using DevExpress.XtraEditors.Repository;
namespace ERP.Winform.MES
{
    public partial class MES201PlanEditForm : EditForm
    {
        private IMES_M201_PlanService planService = Unity.Instance.GetService<IMES_M201_PlanService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private IMES_M201_Plan_DetailService planDetailService = Unity.Instance.GetService<IMES_M201_Plan_DetailService>();
        private IMES_M201_Plan_MaterialService planMaterialService = Unity.Instance.GetService<IMES_M201_Plan_MaterialService>();
        private IERP_M002_BOMService bomService = Unity.Instance.GetService<IERP_M002_BOMService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private MES_M201_Plan tempData;
        public MES201PlanEditForm(MES_M201_Plan model,IMES_M201_PlanService planService)
        {
            InitializeComponent();
            this.tempData = model;
            this.planService = planService;
           
        }
        protected override void InitData()
        {
            //级别
            SetGridLookUpEdit(repositoryItemLevel, codeService.GetCodeDataByCodeId("PLLEVEL"), 1);
            //状态
            SetGridLookUpEdit(repositoryItemStatus, codeService.GetCodeDataByCodeId("PLSTATUS"), 1);

            SetGridLookUpEdit(repositoryItemUnit, codeService.GetCodeDataByCodeId("UNIT"), 1);
            this.mESM201PlanDetailBindingSource.CurrentChanged += mESM201PlanDetailBindingSource_CurrentChanged;
            var productData = productService.GetProductInputData();
            SetGridLookUpEdit(repositoryProduct, productData, 1);
            var customerData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(repositoryItemCustomer, customerData, 1);
            repositoryProduct.DisplayMember = "Value";
            this.mESM201PlanBindingSource.DataSource = tempData;
            var productList = planService.GetProductQuery().Where(a => a.PlanId == tempData.Id).ToList();
            //var count = productList.Count;
            //for (int i = 0; i < 20 - count; i++)
            //{
            //    MES_M201_Plan_Detail bomMat = new MES_M201_Plan_Detail();
            //    bomMat.PlanId = tempData.Id;
            //    productList.Add(bomMat);
            //}
            if (this.Tag.ToStr() == BtnCommandEnum.Add)
            {
                
                for (int i = 0; i < 20; i++)
                {
                    MES_M201_Plan_Detail bomMat = new MES_M201_Plan_Detail();
                    bomMat.PlanId = tempData.Id;
                    bomMat.Status = "01";
                    bomMat.PLevel = "01";
                    productList.Add(bomMat);
                }
            }
            //else
            //{
            //    colQty.OptionsColumn.AllowEdit = false;
            //}
            this.mESM201PlanDetailBindingSource.DataSource = productList;
            this.mESM201PlanMaterialBindingSource.DataSource = planService.GetMaterialQuery().Where(a => a.PLNo == tempData.PLNo).ToList();
            this.mESM201PlanDailyBindingSource.DataSource =
                planService.GetPlanDailiesQuery().Where(a => a.PLNo == tempData.PLNo).ToList();
            //this.gridProduct.BestFitColumns();
            //this.gridMaterial.BestFitColumns();

        }

        void mESM201PlanDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var product = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
            string filterSql = string.Format(" [PlanDetailId] = '{0}'", "999999");
            if (product != null)
            {
                filterSql = string.Format(" [PlanDetailId] = '{0}'", product.Id);
                //如果为新增单，则不可修改调整数量
                if (this.Tag.ToStr() == BtnCommandEnum.Add)
                {
                    colAdJustQty.OptionsColumn.AllowEdit = false;
                }
                //如果是紧急单 状态为修改，则可以修改 数量跟调整数量
                else if (product.Status == "02" && this.Tag.ToStr() == BtnCommandEnum.Edit)
                {
                    colAdJustQty.OptionsColumn.AllowEdit = true;
                    colQty.OptionsColumn.AllowEdit = true;
                }
                //如果是正常单 状态为修改，则可以修改 数量跟调整数量
                else if (product.Status == "01" && this.Tag.ToStr() == BtnCommandEnum.Edit)
                {
                    colAdJustQty.OptionsColumn.AllowEdit = true;
                    colQty.OptionsColumn.AllowEdit = false;
                }
            }
            this.gridMaterial.ActiveFilterString = filterSql;
            this.gridPlanDaily.ActiveFilterString = filterSql;
        }

        private void gridProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //var product = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
            //if (product != null)
            //{
            //    mESM201PlanMaterialBindingSource.DataSource = planMaterialService.GetQuery().Where(a => a.PlanDetailId == product.Id).ToList();
            //}
           
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.gridProduct.CloseEditor();
                this.gridMaterial.CloseEditor();
                if (this.Tag.ToStr() == BtnCommandEnum.Add)
                {
                    switch (PLTypeTextEdit.SelectedText)
                    {
                        case "月计划": tempData.PLNo = viewService.GetGenerateOrderCode(1);
                            break;
                        case "周计划": tempData.PLNo = viewService.GetGenerateOrderCode(2);
                            break;
                        case "日计划": tempData.PLNo = viewService.GetGenerateOrderCode(3);
                            break;
                    }
                }
                var productList = (this.mESM201PlanDetailBindingSource.DataSource as List<MES_M201_Plan_Detail>).Where(a => a.PartNo != null).ToList();
                var planDailyList =
                    (this.mESM201PlanDailyBindingSource.DataSource as List<MES_M201_Plan_Daily>).Where(a => a.Qty > 0)
                        .ToList();
                //var materialList = this.mESM201PlanMaterialBindingSource.DataSource as List<MES_M201_Plan_Material>;
                planService.Save(tempData, productList, planDailyList);
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
            if (this.Tag.ToStr() == BtnCommandEnum.Edit)
            {
                ToolStripButton btnAdd = new ToolStripButton();
                btnAdd.Text = "增单";
                btnAdd.Image = (Image)Resources.ResourceManager.GetObject("edit_add");
                btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
                btnAdd.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                btnAdd.Click += new EventHandler(btnAdd_Click);
                toolStrip.Items.Add(btnAdd);
                ToolStripSeparator toolSep = new ToolStripSeparator();
                toolStrip.Items.Add(toolSep);
            }
            ToolStripButton btnDel = new ToolStripButton();
            btnDel.Text = "删除";
            btnDel.Image = (Image)Resources.ResourceManager.GetObject("cancel");
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnDel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDel.Click += new EventHandler(btnDel_Click);
            toolStrip.Items.Add(btnDel);

            toolStrip.Dock = DockStyle.Top;
            toolStrip.BringToFront();
            page.Controls.Add(toolStrip);
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            var product = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
            planService.MarkDelProduct(product);
            mESM201PlanDetailBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.mESM201PlanDetailBindingSource.AddNew();
            var product = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
            product.Status = "01";
            mESM201PlanDetailBindingSource_CurrentChanged(null, null);
            //if (string.IsNullOrWhiteSpace(tempData.PLNo))
            //    throw new AppException("请先输入计划单号");
            //MES201BOMChooseFrom chooseForm = new MES201BOMChooseFrom();
            //if (chooseForm.ShowDialog() == DialogResult.OK)
            //{
            //    var bom = chooseForm.bomModel;
            //    MES_M201_Plan_Detail detail = new MES_M201_Plan_Detail() { PlanId = tempData.Id, PartNo = bom.PartNo, PartName = bom.PartName, PLNo = tempData.PLNo };
            //    this.mESM201PlanDetailBindingSource.Add(detail);
            //    var materialList = bomService.GetBomMatQuery().Where(a => a.PartNo == bom.PartNo).ToList().Select(a => new MES_M201_Plan_Material() { PlanDetailId = detail.Id, MatCode = a.MatCode, PLNo = tempData.PLNo }).ToList();
            //    foreach (var material in materialList)
            //        this.mESM201PlanMaterialBindingSource.Add(material);

            //}
        }

        private void repositoryProduct_EditValueChanged(object sender, EventArgs e)
        {
            this.gridProduct.CloseEditor();
            var detail = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
            if (detail != null)
            {
                var product = productService.GetByPartNo(detail.PartNo)?? new ERP_M001_Product();
                detail.PartName = product.PartName;
                detail.PartSpec = product.PartSpec;
                detail.Qty = 0;
                detail.AdJustQty = 0;
                detail.SumQty = 0;
                detail.FQty = 0;
                this.mESM201PlanDetailBindingSource.ResetCurrentItem();
                var planDailyList = mESM201PlanDailyBindingSource.DataSource as List<MES_M201_Plan_Daily>;
                if (planDailyList.Count(a => a.PlanDetailId == detail.Id) == 0)
                {
                    DateTime dt1 = txtPlanStartDt.DateTime, dt2 = txtPlanDeliveryDt.DateTime;
                    for (; dt1 <= dt2;)
                    {
                        MES_M201_Plan_Daily planDaily = new MES_M201_Plan_Daily();
                        planDaily.PlanDetailId = detail.Id;
                        planDaily.TxDt = dt1;
                        dt1 = dt1.AddDays(1);
                        this.mESM201PlanDailyBindingSource.Add(planDaily);
                    }
                }
                
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridProduct_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQty || e.Column == colAdJustQty)
            {
                this.gridProduct.CloseEditor();
                var detail = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
                if (detail != null)
                {
                    detail.SumQty = detail.Qty + detail.AdJustQty;
                    this.mESM201PlanDetailBindingSource.ResetCurrentItem();
                }
            }
        }
        /// <summary>
        /// 根据类别不同生成不同的单号 1:月计划，2：周计划,3：日计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PLTypeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            //if (this.Tag.ToStr() == BtnCommandEnum.Add)
            //{
            //    tempData.PLDt = DateTime.Now.Date;
            //    switch (PLTypeTextEdit.SelectedText)
            //    {
            //        case "月计划": tempData.PLNo = viewService.GetGenerateOrderCode(1);
            //            break;
            //        case "周计划": tempData.PLNo = viewService.GetGenerateOrderCode(2);
            //            break;
            //        case "日计划": tempData.PLNo = viewService.GetGenerateOrderCode(3);
            //            break;
            //    }
            //}
            //else
            //{
            //    PLTypeTextEdit.Enabled = false;
            //}
            
            
        }

        private void gridPlanDaily_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column == colQty2)
            {
                this.gridPlanDaily.CloseEditor();
                var detail = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
                var planDailyList = this.mESM201PlanDailyBindingSource.DataSource as List<MES_M201_Plan_Daily>;
                if (detail != null&& planDailyList != null)
                {
                    detail.Qty = planDailyList.Where(a => a.PlanDetailId == detail.Id).Sum(a => a.Qty);
                    this.mESM201PlanDetailBindingSource.ResetCurrentItem();
                }
            }
        }

        private void txtWeekly_Leave(object sender, EventArgs e)
        {
            DateTime dt1, dt2;
            Util.Helper.DateTimeHepler.GetWeek(DateTime.Now.Year, Convert.ToInt32(txtWeekly.Value), out dt1, out dt2);
            tempData.Weekly = Convert.ToInt32(txtWeekly.Value);
            tempData.PlanCompleteDt = dt1;
            tempData.PlanDeliveryDt = dt2;
            this.mESM201PlanBindingSource.ResetCurrentItem();
        }
    }
}
