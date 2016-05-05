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
using Util;
using COM.Domain;

namespace ERP.Winform.CommonModule
{
    public partial class MaterialEditForm : EditForm
    {
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private ERP_M001_Material tempData;
        public MaterialEditForm(ERP_M001_Material tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
           
        }
        protected override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            this.eRPM001MaterialBindingSource.DataSource = tempData;
            this.eRPM001MaterialSuppBindingSource.DataSource = materialService.GetMatSupp().Where(a => a.MatCode == tempData.MatCode).ToList();
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForMatCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForMatName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.gridView1.CloseEditor();
                this.eRPM001MaterialBindingSource.EndEdit();
                this.eRPM001MaterialSuppBindingSource.EndEdit();
                var matSuppDatas = this.eRPM001MaterialSuppBindingSource.DataSource as List<ERP_M001_Material_Supp>;
                materialService.Save(tempData,matSuppDatas);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        protected override  void CreateToolBar()
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
            //var temp = this.eRPM001MaterialSuppBindingSource.Current as ERP_M001_Material_Supp;
            //materialService.MarkDeleteMatSupp(temp);
            eRPM001MaterialSuppBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(tempData.MatCode))
            //    throw new AppException("请先输入模具编号");
            eRPM001MaterialSuppBindingSource.AddNew();
            //var temp = this.eRPM001MaterialSuppBindingSource.Current as ERP_M001_Material_Supp;
            //temp.MatCode = tempData.MatCode;
        }

        private void MaterialEditForm_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToStr() == BtnCommandEnum.Edit)
                MatCodeTextEdit.Properties.ReadOnly = true;
        }
    }
}
