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
using ERP.Domain;
using Util;
using COM.Domain;

namespace ERP.Winform.Supplier
{
    public partial class PurPlanForm : ListForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private IERP_M001_MaterialService materialServer = Unity.Instance.GetService<IERP_M001_MaterialService>(); 
        public PurPlanForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            var materialData = materialServer.GetMaterial().Select(a => new InputItem { DisPlayName = a.MatName, Value = a.MatCode, InputCode1 = a.MatCode }).ToList();
            SetGridLookUpEdit(repositoryMatCode, materialData, 1);
            gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView1_FocusedRowChanged);
            this.sUPPM001PurPlanBindingSource.DataSource = purPlanService.GetList();
            this.gridView1.BestFitColumns();
        }

        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SUPP_M001_PurPlan temp = sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
            if (temp != null)
            {
                var ppServer = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
                this.gridControl1.DataSource = ppServer.GetPurMat().Where(a => a.PurPlNo == temp.PurPlNo).ToList();
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
                    purPlanService.Delete(temp.Id);
                    sUPPM001PurPlanBindingSource.RemoveCurrent();
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
        }
        private void EditForm(string formText, string btnCommand)
        {
            SUPP_M001_PurPlan temp = this.sUPPM001PurPlanBindingSource.Current as SUPP_M001_PurPlan;
            PurPlanEditForm edit = new PurPlanEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                sUPPM001PurPlanBindingSource.CancelEdit();
            }
        }
    }
}
