using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP.Service;
using COM.Service;
using ERP.Domain;
using COM.Winform;
using DevExpress.XtraTab;
using ERP.Winform.Properties;
using System.IO;
using Util;
using DevExpress.XtraEditors;

namespace ERP.Winform.CommonModule
{
    public partial class SupplierEditForm : EditForm
    {
        private IERP_C003_SupplierService supplierService = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private IERP_C003_Supplier_FileService suppFileServer = Unity.Instance.GetService<IERP_C003_Supplier_FileService>();
        private ERP_C003_Supplier tempData;
        public SupplierEditForm(ERP_C003_Supplier tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            //ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("IST"), 2);//状态
           this.eRPC003SupplierBindingSource.DataSource = tempData;
           this.eRPC003SupplierFileBindingSource.DataSource = suppFileServer.GetQuery().Where(a => a.SuppCode == tempData.SuppCode).ToList();
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForSuppCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForSuppName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eRPC003SupplierBindingSource.EndEdit();
                this.gridView1.CloseEditor();
                this.eRPC003SupplierFileBindingSource.EndEdit();
                var files = this.eRPC003SupplierFileBindingSource.DataSource as List<ERP_C003_Supplier_File>;
                supplierService.Save(tempData, files);
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
            var temp = this.eRPC003SupplierFileBindingSource.Current as ERP_C003_Supplier_File;
            supplierService.MarkDeleteSuppFile(temp);
            eRPC003SupplierFileBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.eRPC003SupplierBindingSource.EndEdit();
            if (string.IsNullOrWhiteSpace(tempData.SuppCode))
                throw new AppException("请先输入供应商编号");
            OpenFileDialog openDig = new OpenFileDialog();
            if (openDig.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openDig.FileName);
                this.eRPC003SupplierFileBindingSource.AddNew();
                var temp = eRPC003SupplierFileBindingSource.Current as ERP_C003_Supplier_File;
                temp.DocName = file.Name;
                temp.SuppCode = tempData.SuppCode;
                temp.CompCode = tempData.CompCode;
                FileStream fs = new FileStream(openDig.FileName, FileMode.Open);
                temp.Content = new byte[fs.Length];
                BinaryReader brs = new BinaryReader(fs, Encoding.UTF8);
                temp.Content = brs.ReadBytes(Convert.ToInt32(fs.Length));
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
