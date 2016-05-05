using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Service;
using COM.Service;
using COM.Domain;
using ERP.Domain;
using Util;

namespace ERP.Winform.Supplier
{
    public partial class PlaningForm : ListForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private IERP_M001_MaterialService materialServer = Unity.Instance.GetService<IERP_M001_MaterialService>(); 
        public PlaningForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            var materialData = materialServer.GetMaterial().Select(a => new InputItem { DisPlayName = a.MatName, Value = a.MatCode, InputCode1 = a.MatCode,InputCode2 = a.MatSpec }).ToList();
            SetGridLookUpEdit(repositoryMatCode, materialData, 2);
            SetGridLookUpEdit(repositoryMatCode2, materialData, 2);
            SetGridLookUpEdit(repositoryMatSpec, materialData, 2);
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            gridColumn13.ColumnEdit = repositorySuppCode;
            repositoryMatCode2.DisplayMember = "InputCode1";
            repositoryMatSpec.DisplayMember = "InputCode2";
            colMatName.ColumnEdit = repositoryMatCode;
            colMatSpec2.ColumnEdit = repositoryMatSpec;
            colMatCode3.ColumnEdit = repositoryMatCode2;
            gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView1_FocusedRowChanged);
            gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView2_FocusedRowChanged);
            this.sUPPM001PurPlanBindingSource.DataSource = purPlanService.GetList();
            this.gridView1.BestFitColumns();
            gridView1_FocusedRowChanged(null, null);
        }
        //物料类别改变看供应商资料
        void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SUPP_M001_PurPlan_Detail temp = this.sUPPM001PurPlanDetailBindingSource.Current as SUPP_M001_PurPlan_Detail;
            if (temp != null)
            {
                gridControlSupplier.DataSource = materialServer.GetMatSupp().Where(a => a.MatCode == temp.MatCode).ToList();
            }
        }
        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SUPP_M001_PurPlan temp = sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
            if (temp != null)
            {
                var purDetailServer = Unity.Instance.GetService<ISUPP_M001_PurPlan_DetailService>();
                this.sUPPM001PurPlanDetailBindingSource.DataSource = purDetailServer.GetSuppDetail().Where(a => a.PurPlNo == temp.PurPlNo).ToList();
                this.gridControl2.DataSource = purPlanService.GetPurMat().Where(a => a.PurPlNo == temp.PurPlNo).OrderBy(a => a.MatCode).ToList();
                gridView2_FocusedRowChanged(null, null);
            }
            else
            {
                this.sUPPM001PurPlanDetailBindingSource.DataSource = null;
                this.gridControl2.DataSource = null;
            }
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                sUPPM001PurPlanBindingSource.AddNew();
                SUPP_M001_PurPlan temp = this.sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
                temp.TxDt = DateTime.Now.Date;
                EditForm("采购计划新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                SUPP_M001_PurPlan temp = sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
                if (temp == null)
                    throw new AppException("请先选择要修改的数据");
                EditForm("采购计划修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    SUPP_M001_PurPlan temp = sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
                    purPlanService.DelPurAndDetail(temp.Id);
                    sUPPM001PurPlanBindingSource.RemoveCurrent();
                    gridView1_FocusedRowChanged(null, null);
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Watch)
            {
                SUPP_M001_PurPlan temp = sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
                if (temp == null)
                    throw new AppException("请先选择要查看的数据");
                EditForm("采购计划查看", BtnCommandEnum.Watch);
            }
            else if (e.Item.Caption == BtnCommandEnum.Refresh)
            {
                InitData();
            }
            else if (e.Item.Caption == BtnCommandEnum.SuppSet)
            {
                SUPP_M001_PurPlan temp = this.sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
                PurPlanEditForm frm = new PurPlanEditForm(temp);
                frm.Text = "采购安排";
                frm.Tag = BtnCommandEnum.Add;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    InitData();
                }
            }
            else if (e.Item.Caption == "审核")
            {
                SUPP_M001_PurPlan temp = sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
                if (temp == null)
                    throw new AppException("请先选择要审核的数据");
                if (ERPHelper.Instance.MessageIf("确定审核通过吗"))
                {
                    temp.Status = "已审核";
                    purPlanService.Update(temp);
                }
            }
            else if (e.Item.Caption == "取消审核")
            {
                SUPP_M001_PurPlan temp = sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
                if (temp == null)
                    throw new AppException("请先选择要审核的数据");
                if (ERPHelper.Instance.MessageIf("确定审核通过吗"))
                {
                    temp.Status = "";
                    purPlanService.Update(temp);
                }
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            SUPP_M001_PurPlan temp = this.sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
            PlaningEditForm edit = new PlaningEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                sUPPM001PurPlanBindingSource.CancelEdit();
            }
            else
            {
                gridView1_FocusedRowChanged(null, null);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
