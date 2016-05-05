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
using COM.Domain;
using DevExpress.XtraTab;
using ERP.Winform.Properties;
using Util;

namespace ERP.Winform.Supplier
{
    public partial class PlaningEditForm : EditForm
    {
        private ISUPP_M001_PurPlanService purPlanService = Unity.Instance.GetService<ISUPP_M001_PurPlanService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private IERP_M001_MaterialService materialServer = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private SUPP_M001_PurPlan tempData;
        public PlaningEditForm(SUPP_M001_PurPlan tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            var materialData = materialServer.GetMaterial().Select(a => new InputItem { DisPlayName = a.MatName, Value = a.MatCode, InputCode1 = a.MatCode,InputCode2 = a.MatSpec }).ToList();
            SetGridLookUpEdit(repositoryMatCode, materialData, 2);
            SetGridLookUpEdit(repositoryMatCode2, materialData, 2);
            SetGridLookUpEdit(repositoryMatSpec, materialData, 2);
            repositoryMatCode2.DisplayMember = "InputCode1";
            repositoryMatSpec.DisplayMember = "InputCode2";
            this.sUPPM001PurPlanBindingSource.DataSource = tempData;
            //this.sUPPM001PurPlanDetailBindingSource.DataSource = purPlanService.GetPurDetail().Where(a => a.PurPlNo == tempData.PurPlNo).ToList();
            var purDetailData = purPlanService.GetPurDetail().Where(a => a.PurPlNo == tempData.PurPlNo).ToList();
            if (this.Tag.ToString() == BtnCommandEnum.Add)
            {
                for (int i = 0; i < 20; i++)
                {
                    SUPP_M001_PurPlan_Detail bomMat = new SUPP_M001_PurPlan_Detail();
                    purDetailData.Add(bomMat);
                }
            }
            this.sUPPM001PurPlanDetailBindingSource.DataSource = purDetailData;
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
                this.gridView2.CloseEditor();
                this.sUPPM001PurPlanBindingSource.EndEdit();
                this.sUPPM001PurPlanDetailBindingSource.EndEdit();
                var purMatData = this.sUPPM001PurPlanDetailBindingSource.DataSource as List<SUPP_M001_PurPlan_Detail>;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                {
                    purMatData = purMatData.Where(a => a.MatCode != null).ToList();
                    foreach (var bomMat in purMatData)
                        bomMat.PurPlNo = tempData.PurPlNo;
                }
                purPlanService.Save(tempData, purMatData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
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
            toolStrip.Dock = DockStyle.Top;
            toolStrip.BringToFront();
            page.Controls.Add(toolStrip);
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            var temp = this.sUPPM001PurPlanDetailBindingSource.Current as SUPP_M001_PurPlan_Detail;
            purPlanService.MarkDelPurDetail(temp);
            sUPPM001PurPlanDetailBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            sUPPM001PurPlanDetailBindingSource.AddNew();
            var temp = this.sUPPM001PurPlanDetailBindingSource.Current as SUPP_M001_PurPlan_Detail;
            temp.PurPlNo = tempData.PurPlNo;
            //this.sUPPM001PurPlanBindingSource.EndEdit();
            //if (string.IsNullOrWhiteSpace(tempData.PurPlNo))
            //    throw new AppException("请先输入编号");
            //MatChooseForm matFrm = new MatChooseForm();
            //if (matFrm.ShowDialog() == DialogResult.OK)
            //{
            //    if (matFrm.matSuppData != null)
            //    {
            //        foreach (var matSupp in matFrm.matSuppData)
            //        {
            //            sUPPM001PurPlanDetailBindingSource.AddNew();
            //            var temp = this.sUPPM001PurPlanDetailBindingSource.Current as SUPP_M001_PurPlan_Material;
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

        private void PlaningEditForm_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == BtnCommandEnum.Edit)
            {
                PurPlNoTextEdit.Properties.ReadOnly = true;
            }
        }
    }
}
