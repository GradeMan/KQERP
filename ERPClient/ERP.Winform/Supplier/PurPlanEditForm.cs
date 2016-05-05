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
using DevExpress.XtraTab;
using ERP.Winform.Properties;
using COM.Domain;
namespace ERP.Winform.Supplier
{
    public partial class PurPlanEditForm : EditForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private IERP_M001_MaterialService materialServer = Unity.Instance.GetService<IERP_M001_MaterialService>(); 
        private SUPP_M001_PurPlan tempData;
        public PurPlanEditForm(SUPP_M001_PurPlan tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
           
        }
        protected override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            var materialData = materialServer.GetMaterial().Select(a => new InputItem { DisPlayName = a.MatName, Value = a.MatCode, InputCode1 = a.MatCode,InputCode2 = a.MatSpec }).ToList();
            SetGridLookUpEdit(repositoryMatCode, materialData, 2);
            SetGridLookUpEdit(repositoryMatCode2, materialData, 2);
            SetGridLookUpEdit(repositoryMatSpec, materialData, 2);
            repositoryMatCode2.DisplayMember = "InputCode1";
            repositoryMatSpec.DisplayMember = "InputCode2";
            this.sUPPM001PurPlanBindingSource.DataSource = tempData;
            if (this.Tag.ToString() == BtnCommandEnum.Add)
            {
                var purDetailData = purPlanService.GetPurDetail().Where(a => a.PurPlNo == tempData.PurPlNo).ToList();
                var matCodeList = purDetailData.Select(a => a.MatCode).Distinct().ToList();
                var matSuppData = materialServer.GetMatSupp().Where(a => matCodeList.Contains(a.MatCode)).ToList();
                var purMatData = matSuppData.Select(a => new SUPP_M001_PurPlan_Material() { CompCode = a.CompCode, MatCode = a.MatCode, PurPlNo = tempData.PurPlNo, SuppCode = a.SuppCode, SuppPurPer = a.PurPer, SuppLevel = a.Level, PurQty = a.DeliveryDays??0 }).ToList();
                foreach (var purMat in purMatData)
                {
                    if (purMat.PurQty > 0)
                        purMat.DeliveryDt = ((DateTime)tempData.TxDt).AddDays((Int32)purMat.PurQty);
                    SUPP_M001_PurPlan_Detail purDetail = purDetailData.Where(a => a.MatCode == purMat.MatCode).FirstOrDefault();
                    if (purDetail != null)
                    {
                        purMat.PurQty = purDetail.PurQty;
                        purMat.SuppQty = purMat.PurQty * purMat.SuppPurPer;
                    }
                }
                this.sUPPM001PurPlanMaterialBindingSource.DataSource = purMatData.OrderBy(a=>a.MatCode).ToList();
            }
            else
                this.sUPPM001PurPlanMaterialBindingSource.DataSource = purPlanService.GetPurMat().Where(a => a.PurPlNo == tempData.PurPlNo).OrderBy(a=>a.MatCode).ToList();
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForPurPlNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForTxDt, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.gridView1.CloseEditor();
                this.sUPPM001PurPlanBindingSource.EndEdit();
                this.sUPPM001PurPlanMaterialBindingSource.EndEdit();
                var purMatData = this.sUPPM001PurPlanMaterialBindingSource.DataSource as List<SUPP_M001_PurPlan_Material>;
                purPlanService.Save(tempData, purMatData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        protected override void CreateToolBar()
        {
            //XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
            //foreach (var contr in page.Controls)
            //{
            //    if (contr is ToolStrip)
            //        return;
            //}
            //ToolStrip toolStrip = new ToolStrip();
            //ToolStripButton btnAdd = new ToolStripButton();
            //btnAdd.Text = "新增明细";
            //btnAdd.Image = (Image)Resources.ResourceManager.GetObject("edit_add");
            //btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            //btnAdd.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            //btnAdd.Click += new EventHandler(btnAdd_Click);
            //toolStrip.Items.Add(btnAdd);
            //ToolStripSeparator toolSep = new ToolStripSeparator();
            //toolStrip.Items.Add(toolSep);
            //ToolStripButton btnDel = new ToolStripButton();
            //btnDel.Text = "删除明细";
            //btnDel.Image = (Image)Resources.ResourceManager.GetObject("cancel");
            //btnDel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            //btnDel.TextImageRelation = TextImageRelation.ImageAboveText;
            //btnDel.Click += new EventHandler(btnDel_Click);
            //toolStrip.Items.Add(btnDel);
            //toolStrip.Dock = DockStyle.Top;
            //toolStrip.BringToFront();
            //page.Controls.Add(toolStrip);
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            var temp = this.sUPPM001PurPlanMaterialBindingSource.Current as SUPP_M001_PurPlan_Material;
            purPlanService.MarkDelPurMat(temp);
            sUPPM001PurPlanMaterialBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.sUPPM001PurPlanBindingSource.EndEdit();
            if (string.IsNullOrWhiteSpace(tempData.PurPlNo))
                throw new AppException("请先输入编号");

            //MatChooseForm matFrm = new MatChooseForm();
            //if (matFrm.ShowDialog() == DialogResult.OK)
            //{
            //    if (matFrm.matSuppData != null)
            //    {
            //        foreach (var matSupp in matFrm.matSuppData)
            //        {
            //            sUPPM001PurPlanMaterialBindingSource.AddNew();
            //            var temp = this.sUPPM001PurPlanMaterialBindingSource.Current as SUPP_M001_PurPlan_Material;
            //            temp.PurPlNo = tempData.PurPlNo;
            //            temp.MatCode = matSupp.MatCode;
            //            temp.SuppCode = matSupp.SuppCode;
            //            temp.SuppQty = matSupp.Qty;
            //            temp.SuppPurPer = matSupp.PurPer;
            //            temp.PurQty = matFrm.matCount;
            //        }
            //    }
                
               
            //}
        }

        private void PurPlanEditForm_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToStr() == BtnCommandEnum.Edit)
                this.PurPlNoTextEdit.Properties.ReadOnly = true;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colSuppPurPer)
            {
                var temp = this.sUPPM001PurPlanMaterialBindingSource.Current as SUPP_M001_PurPlan_Material;
                temp.SuppQty = temp.PurQty * temp.SuppPurPer;
            }
        }
    }
}
