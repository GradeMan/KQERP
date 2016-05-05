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

namespace ERP.Winform.CommonModule
{
    public partial class MaterialForm : ListForm
    {
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public MaterialForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositorySuppCode, suppData, 1);

            //左边树形-物料类别
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;
            treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseClick);

       
            TreeNode node = new TreeNode();
            node.Text = "全部";
            node.ImageIndex = 0;
            node.Tag = "全部";
            treeView1.Nodes.Add(node);
            var MatClassList =materialService.GetList().Select(a => a.MatClass1).Distinct().ToList();
            foreach (var matclass in MatClassList)
            {
                TreeNode node2 = new TreeNode();
                node2.Text = matclass;
                node2.ImageIndex = 0;
                node2.Tag = matclass;
                node.Nodes.Add(node2);
            }
            treeView1.ExpandAll();
            this.eRPM001MaterialBindingSource.DataSource = materialService.GetList();
            //this.gridView1.BestFitColumns();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string matclass = e.Node.Tag.ToStr();
            var materialData = materialService.GetMaterial();
            if (matclass != "全部")
                materialData = materialData.Where(a => a.MatClass1 == matclass);
            this.eRPM001MaterialBindingSource.DataSource = materialData.ToList();
            this.gridView1.BestFitColumns();
            gridView1_FocusedRowChanged(null, null);
        }

        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ERP_M001_Material temp = eRPM001MaterialBindingSource.Current as ERP_M001_Material;
            if (temp != null)
            {
                IERP_M001_Material_SuppService matSuppServer = Unity.Instance.GetService<IERP_M001_Material_SuppService>();
                this.gridControlSupplier.DataSource = matSuppServer.GetListByMatCode(temp.MatCode);
            }
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPM001MaterialBindingSource.AddNew();
                
                EditForm("物料资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                ERP_M001_Material temp = eRPM001MaterialBindingSource.Current as ERP_M001_Material;
                if (temp == null)
                    throw new AppException("请先选择要修改的数据");
                EditForm("物料资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_M001_Material temp = eRPM001MaterialBindingSource.Current as ERP_M001_Material;
                    materialService.Delete(temp.Id);
                    eRPM001MaterialBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Watch)
            {
                ERP_M001_Material temp = eRPM001MaterialBindingSource.Current as ERP_M001_Material;
                if (temp == null)
                    throw new AppException("请先选择要查看的数据");
                EditForm("物料资料查看", BtnCommandEnum.Watch);
            }
            else if (e.Item.Caption == BtnCommandEnum.Refresh)
            {
                InitData();
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            ERP_M001_Material temp = this.eRPM001MaterialBindingSource.Current as ERP_M001_Material;
            MaterialEditForm edit = new MaterialEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPM001MaterialBindingSource.CancelEdit();
                InitData();
            }
            else
            {
                gridView1_FocusedRowChanged(null, null);
            }
        }
    }

    public class MatType
    {
        

    }
}
