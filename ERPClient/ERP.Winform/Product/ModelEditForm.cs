using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using DevExpress.XtraTab;
using ERP.Winform.Properties;
using ERP.Service;
using COM.Service;
using ERP.Domain;
namespace ERP.Winform.Product
{
    public partial class ModelEditForm : EditForm
    {
        private IModelService modelService = Unity.Instance.GetService<IModelService>();
        public ModelEditForm(ERP_M003_Model tempData )
        {
            InitializeComponent();
            eRPM003ModelBindingSource.DataSource = tempData;
            eRPM003ModelProductBindingSource.DataSource = modelService.GetProductListByModelCode(tempData.ModelCode);
        }
        protected override void InitData()
        {
            ERPHelper.Instance.SetGridLookUpEdit(ModelSuppCodeTextEdit, modelService.GetSupplierData(), 2);
            ModelSuppCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(ModelSuppCodeTextEdit_EditValueChanging);
        }

        void ModelSuppCodeTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForModelCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForModelName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPM003ModelBindingSource.EndEdit();
                eRPM003ModelProductBindingSource.EndEdit();
                var model = this.eRPM003ModelBindingSource.DataSource as ERP_M003_Model;
                var modelProductList = this.eRPM003ModelProductBindingSource.DataSource as List<ERP_M003_Model_Product>;
                this.modelService.Save(model, modelProductList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
        private void ModelEditForm_Load(object sender, EventArgs e)
        {
            CreateToolBar();
        }

        private void CreateToolBar()
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
            var temp = eRPM003ModelProductBindingSource.Current as ERP_M003_Model_Product;
            modelService.MarkDeleteProduct(temp.Id);
            eRPM003ModelProductBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            eRPM003ModelProductBindingSource.AddNew();
        }
       
    }
}
