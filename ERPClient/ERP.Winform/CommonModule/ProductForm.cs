using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Service;
using COM.Service;
using ERP.Domain;
using Util;

namespace ERP.Winform.CommonModule
{
    public partial class ProductForm : ListForm
    {
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IProcessFlowService processFlowService = Unity.Instance.GetService<IProcessFlowService>();
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        public ProductForm()
        {
            InitializeComponent();
            this.gridProduct.DoubleClick+=new EventHandler(gridView1_DoubleClick);
            this.gridProduct.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
            
        }
        public override void OnAttachEvent()
        {
            var custData = customerServer.GetCustomerInputData();
            SetGridLookUpEdit(repositoryCustCode, custData, 3);
            var processFlowList = processFlowService.GetProcessFlowInputData();
            SetGridLookUpEdit(repositoryItemProcessFlow, processFlowList, 1);
            SetGridLookUpEdit(repositoryItemPROC, codeService.GetCodeDataByCodeId("PROC"));
            SetGridLookUpEdit(repositoryItemPROCPMS, codeService.GetCodeDataByCodeId("PROCPMS"));
            SetGridLookUpEdit(repositoryItemPROCPMSTATUS, codeService.GetCodeDataByCodeId("PROCPMSTATUS"));
            SetGridLookUpEdit(repositoryItemMatCode, materialService.GetInputData());
            this.eRPM001ProductProcessFlowBindingSource.CurrentChanged += eRPM001ProductProcessFlowBindingSource_CurrentChanged;
            this.eRPM001ProductBindingSource.CurrentChanged += eRPM001ProductBindingSource_CurrentChanged;
        }
        /// <summary>
        /// 制程改变，筛选制程参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eRPM001ProductProcessFlowBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ERP_M001_Product_ProcessFlow PF = this.eRPM001ProductProcessFlowBindingSource.Current as ERP_M001_Product_ProcessFlow;
            string filterSql = string.Format("[ProcessCode]= '{0}' ", "999999");
            if (PF != null)
                filterSql = string.Format("[ProcessCode]= '{0}'", PF.ProcessCode);
            this.gridProdInfo.ActiveFilterString = filterSql;
        }
        /// <summary>
        /// 产品行改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void eRPM001ProductBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ERP_M001_Product temp = eRPM001ProductBindingSource.Current as ERP_M001_Product?? new ERP_M001_Product();
            if (temp != null)
            {
                this.eRPM001ProductMaterialBindingSource.DataSource = productService.GetMaterialByProdutCode(temp.PartNo);
                this.eRPM001ProductPackInfoBindingSource.DataSource = productService.GetPackInfoByPartNo(temp.PartNo);
                this.eRPM001ProductSemiProductBindingSource.DataSource = productService.GetProductSemiByPartNo(temp.PartNo);
                this.eRPM001ProductProcessFlowBindingSource.DataSource = productService.GetProcessFlowByProdutCode(temp.PartNo).OrderBy(a => a.ProcessSeqNo).ToList(); 
                this.eRPM001ProductProdInfoBindingSource.DataSource = productService.GetProdInfoByProdutCode(temp.PartNo).OrderBy(a => a.TechSeqNo).ToList(); 
                this.gridMaterial.BestFitColumns();
                this.gridPacking.BestFitColumns();
                this.gridSemi.BestFitColumns();
                this.gridProcess.BestFitColumns();
                this.gridProdInfo.BestFitColumns();
            }
        }
        public override void InitData()
        {
            //左边树形-产品系列
            treeView1.Nodes.Clear();
            treeView1.ImageList = this.imageList1;
            treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseClick);
            TreeNode node = new TreeNode();
            node.Text = "全部";
            node.ImageIndex = 0;
            node.Tag = "全部";
            treeView1.Nodes.Add(node);
            var CategoryList = productService.GetList().Select(a => a.Category).Where(a=>!string.IsNullOrEmpty(a)).Distinct().ToList();
            foreach (var category in CategoryList)
            {
                TreeNode node2 = new TreeNode();
                node2.Text = category;
                node2.ImageIndex = 0;
                node2.Tag = category;
                node.Nodes.Add(node2);
            }
            treeView1.ExpandAll();
            
            ////左边树形数据源
            //var q = productService.GetList().Select(a => new { a.Category }).ToList();
            //var d = q.Distinct();
            //this.treeCodeType.DataSource = d.ToList();
            ////this.treeCodeType.DataSource = codeService.GetListByCodeID("ICA");

            this.eRPM001ProductBindingSource.DataSource = productService.GetList();
            this.gridProduct.BestFitColumns();
            
        }
        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string category = e.Node.Tag.ToStr();
            var productData = productService.GetProduct();
            if (category != "全部")
                productData = productData.Where(a => a.Category == category);
            this.eRPM001ProductBindingSource.DataSource = productData.ToList();
            this.gridProduct.BestFitColumns();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPM001ProductBindingSource.AddNew();
                ERP_M001_Product temp = eRPM001ProductBindingSource.Current as ERP_M001_Product;
                //temp.PartType = treeCodeType.FocusedNode[treeColumnCode] != null ? treeCodeType.FocusedNode[treeColumnCode].ToString() : null;
                //temp.CompCode = "K10";
                EditForm("产品资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("产品资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_M001_Product temp = eRPM001ProductBindingSource.Current as ERP_M001_Product;
                    productService.Delete(temp.Id);
                    eRPM001ProductBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            ERP_M001_Product temp = eRPM001ProductBindingSource.Current as ERP_M001_Product;
            ProductEditForm edit = new ProductEditForm(temp, productService);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPM001ProductBindingSource.CancelEdit();
                InitData();
            }
            else
            {
                eRPM001ProductBindingSource_CurrentChanged(null, null);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("产品资料查看", BtnCommandEnum.Watch);
            }
        }
    }
}