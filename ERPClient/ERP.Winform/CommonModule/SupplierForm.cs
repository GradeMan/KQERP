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
using DevExpress.XtraGrid.Views.Grid;
using Util;
using System.IO;
using DevExpress.XtraEditors;

namespace ERP.Winform.CommonModule
{
    public partial class SupplierForm : ListForm
    {
        private IERP_C003_SupplierService supplierService = Unity.Instance.GetService<IERP_C003_SupplierService>();
        
        public SupplierForm()
        {
            InitializeComponent();
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView1_FocusedRowChanged);
        }
        public override void InitData()
        {
            treeView1.Nodes.Clear();
            treeView1.ImageList = this.imageList1;
            treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseClick);
            TreeNode node = new TreeNode();
            node.Text = "全部";
            node.ImageIndex = 0;
            node.Tag = "全部";
            treeView1.Nodes.Add(node);
            var IndustryTypes = supplierService.GetSuppler().Select(a => a.IndustryType).Distinct().ToList();
            foreach (var intype in IndustryTypes)
            {
                TreeNode node2 = new TreeNode();
                node2.Text = intype;
                node2.ImageIndex = 0;
                node2.Tag = intype;
                node.Nodes.Add(node2);
            }
            treeView1.ExpandAll();
            this.eRPC003SupplierBindingSource.DataSource = supplierService.GetSuppler().ToList();
        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string industryType = e.Node.Tag.ToStr();
            var supplierData = supplierService.GetSuppler();
            if (industryType != "全部")
                supplierData = supplierData.Where(a => a.IndustryType == industryType);
            this.eRPC003SupplierBindingSource.DataSource = supplierData.ToList();
            this.gridView1.BestFitColumns();
            gridView1_FocusedRowChanged(null, null);
        }
        /// <summary>
        /// 根据供应商显示物料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ERP_C003_Supplier temp = eRPC003SupplierBindingSource.Current as ERP_C003_Supplier;
            if (temp != null)
            {
                IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
                IERP_C003_Supplier_FileService suppFileService = Unity.Instance.GetService<IERP_C003_Supplier_FileService>();
                var matCodeData = materialService.GetMatSupp().Where(a => a.SuppCode == temp.SuppCode).Select(a => a.MatCode).Distinct().ToList();
                this.ykGridControl2.DataSource = materialService.GetMaterial().Where(a => matCodeData.Contains(a.MatCode)).ToList();
                this.gridView2.BestFitColumns();
                this.eRPC003SupplierFileBindingSource.DataSource = suppFileService.GetQuery().Where(a => a.SuppCode == temp.SuppCode).ToList();
            }
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPC003SupplierBindingSource.AddNew();
                EditForm("供应商资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                ERP_C003_Supplier temp = eRPC003SupplierBindingSource.Current as ERP_C003_Supplier;
                if (temp == null)
                    throw new AppException("请先选择要修改的数据");
                EditForm("供应商资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_C003_Supplier temp = eRPC003SupplierBindingSource.Current as ERP_C003_Supplier;
                    supplierService.Delete(temp.Id);
                    eRPC003SupplierBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Watch)
            {
                ERP_C003_Supplier temp = eRPC003SupplierBindingSource.Current as ERP_C003_Supplier;
                if (temp == null)
                    throw new AppException("请先选择要查看的数据");
                EditForm("供应商资料查看", BtnCommandEnum.Watch);
            }
            else if (e.Item.Caption == BtnCommandEnum.Refresh)
            {
                InitData();
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            ERP_C003_Supplier temp = this.eRPC003SupplierBindingSource.Current as ERP_C003_Supplier;
            SupplierEditForm edit = new SupplierEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPC003SupplierBindingSource.CancelEdit();
            }
            else
            {
                gridView1_FocusedRowChanged(null, null);
            }
        }

        private void repositoryLinkFile_Click(object sender, EventArgs e)
        {
            var file = this.eRPC003SupplierFileBindingSource.Current as ERP_C003_Supplier_File;
            saveFileDialog1.FileName = file.DocName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                fs.Write(file.Content, 0, file.Content.Length);

                fs.Flush();
                fs.Close();
                if (XtraMessageBox.Show("文件下载完毕,是否打开文档?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }
            }
        }

       
    }
}
