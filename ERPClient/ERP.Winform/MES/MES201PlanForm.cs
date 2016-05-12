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
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using DevExpress.XtraSplashScreen;

namespace ERP.Winform.MES
{
    public partial class MES201PlanForm : ListForm
    {
        private IMES_M201_PlanService planService = Unity.Instance.GetService<IMES_M201_PlanService>();
        private IMES_M201_Plan_MaterialService planMaterialService = Unity.Instance.GetService<IMES_M201_Plan_MaterialService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public MES201PlanForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载初始化
        /// </summary>
        public override void OnAttachEvent()
        {
            //客户
            var customerData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(repositoryItemCustomer, customerData, 1);

            //级别
            SetGridLookUpEdit(repositoryItemLevel, codeService.GetCodeDataByCodeId("PLLEVEL"), 1);
            //状态
            SetGridLookUpEdit(repositoryItemStatus, codeService.GetCodeDataByCodeId("PLSTATUS"), 1);
            this.mESM201PlanBindingSource.CurrentChanged += mESM201PlanBindingSource_CurrentChanged;
            this.mESM201PlanDetailBindingSource.CurrentChanged += mESM201PlanDetailBindingSource_CurrentChanged;
            txtProdDt1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtProdDt2.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        public override void InitData()
        {
            //var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            //SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            var planQuery = planService.GetQuery();
            if (string.IsNullOrWhiteSpace(txtProdDt1.Text) || string.IsNullOrWhiteSpace(txtProdDt2.Text))
                throw new AppException("请先输入日期");
            var planList = planQuery.Where(a => a.PLDt >= txtProdDt1.DateTime && a.PLDt <= txtProdDt2.DateTime).ToList(); ;
            this.mESM201PlanBindingSource.DataSource = planList;
            this.gridPlan.BestFitColumns();
            this.gridProduct.BestFitColumns();
            this.gridMaterial.BestFitColumns();
            
        }

        void mESM201PlanBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var tempData = this.mESM201PlanBindingSource.Current as MES_M201_Plan;
            if (tempData != null)
            {
                this.mESM201PlanDetailBindingSource.DataSource =
                    planService.GetProductQuery().Where(a => a.PlanId == tempData.Id).ToList();
                this.mESM201PlanDailyBindingSource.DataSource =
                planService.GetPlanDailiesQuery().Where(a => a.PLNo == tempData.PLNo).ToList();
            }
            else
            {
                this.mESM201PlanDetailBindingSource.DataSource = null;
            }
        }

        void mESM201PlanDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var product = this.mESM201PlanDetailBindingSource.Current as MES_M201_Plan_Detail;
            if (product != null)
            {

                this.gridControl2.DataSource = viewService.GetPlanProductMaterialView(product.PlanId.ToStr());
                this.mESM201PlanDailyBindingSource.DataSource = planService.GetPlanDailiesQuery().Where(a=>a.PlanDetailId == product.Id).OrderBy(a=>a.TxDt).ToList();
            }
            else
                this.gridControl2.DataSource = null;
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
                mESM201PlanBindingSource.AddNew();
                MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
                temp.PLDt = DateTime.Now.Date;
                temp.PLType = "周计划";
                EditForm("生产计划单新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
                if (temp == null )
                    throw new AppException("请先选择要修改的数据");
                if (!string.IsNullOrWhiteSpace(temp.PLAuditing))
                    throw new AppException("已审核的计划单不能修改");
                EditForm("生产计划单修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
                    if (!string.IsNullOrEmpty(temp.PLAuditing))
                        throw new AppException("单子已审核，无法删除");
                    planService.Delete(temp.Id);
                    mESM201PlanBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Watch)
            {
                MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
                if (temp == null)
                    throw new AppException("请先选择要查看的数据");
                EditForm("生产计划单查看", BtnCommandEnum.Watch);
            }
            else if (e.Item.Caption == BtnCommandEnum.Refresh)
            {
                InitData();
            }
            else if (e.Item.Caption == "生成物料清单")
            {
                MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
                if (temp != null)
                {
                    MES201ProductMaterialForm frm = new MES201ProductMaterialForm(temp.Id.ToString());
                    frm.Tag = BtnCommandEnum.Add;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                         mESM201PlanDetailBindingSource_CurrentChanged(null,null);
                    }
                }
                
            }
            else if (e.Item.Caption == "审核")
            {
                MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
                if (temp != null && string.IsNullOrWhiteSpace(temp.PLAuditing))
                {
                    planService.ShenHe(temp);
                    XtraMessageBox.Show("审核成功");
                }
                else
                {
                    XtraMessageBox.Show("已审核");
                }
            }
            else if (e.Item.Caption == "反审")
            {
                MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
                if (temp != null && !string.IsNullOrWhiteSpace(temp.PLAuditing))
                {
                    temp.PLAuditing = "";
                    temp.PLAuditingDt = null;
                    planService.Update(temp);
                    XtraMessageBox.Show("反审成功");
                }
                else
                {
                    XtraMessageBox.Show("未审核");
                }
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            MES_M201_Plan temp = mESM201PlanBindingSource.Current as MES_M201_Plan;
            MES201PlanEditForm edit = new MES201PlanEditForm(temp,planService);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                mESM201PlanBindingSource.CancelEdit();
            }
            else
            {
                mESM201PlanBindingSource_CurrentChanged(null, null);
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
