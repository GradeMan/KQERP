using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using COM.Service;
using DevExpress.XtraTab;
using ERP.Winform.Properties;
using Util;

namespace ERP.Winform.CommonModule
{
    public partial class BomEditForm : EditForm
    {
        private IERP_M002_BOMService bomService = Unity.Instance.GetService<IERP_M002_BOMService>();
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private ERP_M002_BOM tempData;
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        
        public BomEditForm(ERP_M002_BOM tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            var productData = productService.GetProductInputData();
            SetGridLookUpEdit(PartNoTextEdit, productData, 2);
            var materialData = materialService.GetInputData();
            SetGridLookUpEdit(repositoryItemMaterial, materialData, 2);
            this.eRPM002BOMBindingSource.DataSource = tempData;
            var bomMatData = bomService.GetBomMatQuery().Where(a => a.PartNo == tempData.PartNo).ToList();
            if (this.Tag.ToString() == BtnCommandEnum.Add)
            {
                for (int i = 0; i < 10; i++)
                {
                    ERP_M002_BOM_Material bomMat = new ERP_M002_BOM_Material();
                    bomMatData.Add(bomMat);
                }
            }
            this.eRPM002BOMMaterialBindingSource.DataSource = bomMatData;
            PartNoTextEdit.Focus();
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForPartNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForPartName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.gridMaterial.CloseEditor();
                this.eRPM002BOMBindingSource.EndEdit();
                this.eRPM002BOMMaterialBindingSource.EndEdit();
                var matSuppDatas = this.eRPM002BOMMaterialBindingSource.DataSource as List<ERP_M002_BOM_Material>;
                tempData.PartName = PartNoTextEdit.Text;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                {
                    matSuppDatas = matSuppDatas.Where(a => a.MatCode != null).ToList();
                    foreach (var bomMat in matSuppDatas)
                        bomMat.PartNo = tempData.PartNo;
                }
                bomService.Save(tempData, matSuppDatas);
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
            var temp = this.eRPM002BOMMaterialBindingSource.Current as ERP_M002_BOM_Material;
            bomService.MarkDelMat(temp);
            eRPM002BOMMaterialBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            eRPM002BOMMaterialBindingSource.AddNew();
            var temp = this.eRPM002BOMMaterialBindingSource.Current as ERP_M002_BOM_Material;
            temp.PartNo = tempData.PartNo;
        }

        private void MaterialEditForm_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToStr() == BtnCommandEnum.Edit)
                this.PartNoTextEdit.Properties.ReadOnly = true;
        }

        private void BomEditForm_Load(object sender, EventArgs e)
        {
            
        }

        private void repositoryItemMaterial_EditValueChanged(object sender, EventArgs e)
        {
            this.gridMaterial.CloseEditor();
            var detail = this.eRPM002BOMMaterialBindingSource.Current as ERP_M002_BOM_Material;
            if (detail != null)
            {
                var material = materialService.GetMaterial().Where(a=>a.MatCode == detail.MatCode).FirstOrDefault()?? new ERP_M001_Material();
                detail.MatName = material.MatName;
                detail.MatSpec = material.MatSpec;
                this.eRPM002BOMMaterialBindingSource.ResetCurrentItem();
                //this.gridProduct.BestFitColumns();
            }
        }
    }
}
