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
using DevExpress.XtraTab;
using ERP.Winform.Properties;
using DevExpress.XtraEditors;

namespace ERP.Winform.CommonModule
{
    public partial class ProductEditForm : EditForm
    {
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private ERP_M001_Product tempData;
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IProcessFlowService processFlowService = Unity.Instance.GetService<IProcessFlowService>();
        private IERP_C006_ProcessFlow_ProdInfoService prodInfoService = Unity.Instance.GetService<IERP_C006_ProcessFlow_ProdInfoService>();
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        public ProductEditForm(ERP_M001_Product tempData, IProductService productService)
        {
            InitializeComponent();
            this.productService = productService;
            this.tempData = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForPartNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForPartName, ItemBindingType.Required);
            var custData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(repositoryCustCode, custData, 3);
            var processFlowList = processFlowService.GetProcessFlowInputData();
            SetGridLookUpEdit(ProcessFlowTextEdit, processFlowList, 1);
            SetGridLookUpEdit(repositoryItemPROC, codeService.GetCodeDataByCodeId("PROC"));
            SetGridLookUpEdit(repositoryItemPROCPMS, codeService.GetCodeDataByCodeId("PROCPMS"));
            SetGridLookUpEdit(repositoryItemPROCPMSTATUS, codeService.GetCodeDataByCodeId("PROCPMSTATUS"));
            SetGridLookUpEdit(repositoryItemMatCode, materialService.GetInputData());
            this.eRPM001ProductProcessFlowBindingSource.CurrentChanged += eRPM001ProductProcessFlowBindingSource_CurrentChanged;
        }

        void eRPM001ProductProcessFlowBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ERP_M001_Product_ProcessFlow PF = this.eRPM001ProductProcessFlowBindingSource.Current as ERP_M001_Product_ProcessFlow;
            string filterSql = string.Format("[ProcessCode]= '{0}' ", "999999");
            if (PF != null)
                filterSql = string.Format("[ProcessCode]= '{0}'", PF.ProcessCode);
            this.gridProdInfo.ActiveFilterString = filterSql;
        }
        protected override void InitData()
        {
            // ERPHelper.Instance.SetGridLookUpEdit(SpecRowsTextEdit, codeService.GetCodeDataByCodeId("IPL"), 2);//排数
            // ERPHelper.Instance.SetGridLookUpEdit(SpecAlignHoleTextEdit, codeService.GetCodeDataByCodeId("IUS"), 2);//定位孔
            
            eRPM001ProductBindingSource.DataSource = tempData;
            this.eRPM001ProductMaterialBindingSource.DataSource = productService.GetMaterialByProdutCode(tempData.PartNo);
            this.eRPM001ProductPackInfoBindingSource.DataSource = productService.GetPackInfoByPartNo(tempData.PartNo);
            this.eRPM001ProductSemiProductBindingSource.DataSource = productService.GetProductSemiByPartNo(tempData.PartNo);
            this.eRPM001ProductProcessFlowBindingSource.DataSource = productService.GetProcessFlowByProdutCode(tempData.PartNo).OrderBy(a=>a.ProcessSeqNo).ToList();
            this.eRPM001ProductProdInfoBindingSource.DataSource = productService.GetProdInfoByProdutCode(tempData.PartNo).OrderBy(a => a.TechSeqNo).ToList();
            ProcessFlowTextEdit.EditValueChanged+=ProcessFlowTextEdit_EditValueChanged;
        }
        /// <summary>
        /// 把默认流程带过来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessFlowTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.eRPM001ProductBindingSource.EndEdit();
            var processList = this.processFlowService.GetProcessFlowDetail(tempData.ProcessFlow)
                    .Select(a => new ERP_M001_Product_ProcessFlow() { CompCode = tempData.CompCode, PartNo = tempData.PartNo, PFCode = a.PFCode, ProcessCode = a.ProcessCode, ProcessSeqNo = a.ProcessSeqNo, Remarks = a.Remarks,ProcessKey =a.ProcessKey,ProcessType=a.ProcessType }).OrderBy(a=>a.ProcessSeqNo).ToList();
            this.eRPM001ProductProcessFlowBindingSource.DataSource = processList;
            var prodInfoList = prodInfoService.GetQuery().Where(a => a.PFCode == tempData.ProcessFlow).ToList()
                    .Select(a => new ERP_M001_Product_ProdInfo() { CompCode = tempData.CompCode, PartNo = tempData.PartNo, PFCode = a.PFCode, ProcessCode = a.ProcessCode, TechCode = a.TechCode, TechType = a.TechType, IsVisible = a.IsVisible, TechContent = a.TechContent, TechSeqNo = a.TechSeqNo }).OrderBy(a => a.TechSeqNo).ToList();
            this.eRPM001ProductProdInfoBindingSource.DataSource = prodInfoList;
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPM001ProductBindingSource.EndEdit();
                gridViewPack.CloseEditor();
                gridProcess.CloseEditor();
                gridProdInfo.CloseEditor();
                gridViewMaterial.CloseEditor();
                gridViewSemi.CloseEditor();
                var materialList = this.eRPM001ProductMaterialBindingSource.DataSource as List<ERP_M001_Product_Material>;
                var packInfoList = this.eRPM001ProductPackInfoBindingSource.DataSource as List<ERP_M001_Product_PackInfo>;
                var semiProdList = this.eRPM001ProductSemiProductBindingSource.DataSource as List<ERP_M001_Product_SemiProduct>;
                var processList = this.eRPM001ProductProcessFlowBindingSource.DataSource as List<ERP_M001_Product_ProcessFlow>;
                var prodInfoList = this.eRPM001ProductProdInfoBindingSource.DataSource as List<ERP_M001_Product_ProdInfo>;
                productService.Save(tempData, materialList, packInfoList, semiProdList, processList, prodInfoList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            CreateToolBar();
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

        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnDel_Click(object sender, EventArgs e)
        {
            // XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
            switch (this.xtraTabControl1.SelectedTabPageIndex)
            {
                case 2: this.eRPM001ProductMaterialBindingSource.RemoveCurrent();
                    break;
                case 0:
                    this.eRPM001ProductPackInfoBindingSource.RemoveCurrent();
                    //productService.DeletePackInfo(packInfo.Id);
                    //this.eRPM001ProductPackInfoBindingSource.RemoveCurrent();
                   // packInfo.PartNo = PartNoTextEdit.Text.Trim();
                    break;
                case 3: this.eRPM001ProductSemiProductBindingSource.RemoveCurrent();
                    //var semiProductData = eRPM001ProductSemiProductBindingSource.Current as ERP_M001_Product_SemiProduct;
                    //semiProductData.PartNo = PartNoTextEdit.Text.Trim();
                    break;

            }
        }

        /// <summary>
        /// 新增明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAdd_Click(object sender, EventArgs e)
        {
            //if (this.PartNoTextEdit.Text.Trim() == "")
            //{
            //    XtraMessageBox.Show("产品代号不能为空，请先输入产品代号");
            //    return;
            //}
            XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
            switch (this.xtraTabControl1.SelectedTabPageIndex)
            {
                case 2: this.eRPM001ProductMaterialBindingSource.AddNew();
                    //var materialData = eRPM001ProductMaterialBindingSource.Current as ERP_M001_Product_Material;
                    //materialData.ProductCode = PartNoTextEdit.Text.Trim();
                    break;
                case 0: 
                   this.eRPM001ProductPackInfoBindingSource.AddNew();
                    //var packInfo = this.eRPM001ProductPackInfoBindingSource.Current as ERP_M001_Product_PackInfo;
                    //packInfo.PartNo = PartNoTextEdit.Text.Trim();
                    break;
                case 3: this.eRPM001ProductSemiProductBindingSource.AddNew();
                    //var semiProductData = eRPM001ProductSemiProductBindingSource.Current as ERP_M001_Product_SemiProduct;
                    //semiProductData.PartNo = PartNoTextEdit.Text.Trim();
                    break;

            }
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Enter || keyData == Keys.Down)
        //    {
        //        SendKeys.SendWait("{ENTER}");
        //        return true;
        //    }
        //    if (keyData == Keys.Up)
        //    {
        //        SendKeys.SendWait("+{TAB}");
        //        return true;
        //    }
        //    return ProcessCmdKey(ref msg, keyData);
        //}

    }
}
