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
using DevExpress.XtraEditors;

namespace ERP.Winform.Device
{
    public partial class DeviceEditForm : EditForm
    {
        private IDEV_D001_DeviceService devService = Unity.Instance.GetService<IDEV_D001_DeviceService>();
        //private IViewService viewService = Unity.Instance.GetService<IViewService>();
        private DEV_D001_Device tempData;
        public DeviceEditForm(DEV_D001_Device tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            //ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("IST"), 2);//状态
            this.dEVD001DeviceBindingSource.DataSource = tempData;
            this.dEVD001DeviceFileBindingSource.DataSource = devService.GetDevFileList(tempData.Id);
            this.dEVD001DeviceAppurtenBindingSource.DataSource = devService.GetDevAppList(tempData.Id);
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForDevNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForDevName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.dEVD001DeviceBindingSource.EndEdit();
                this.dEVD001DeviceFileBindingSource.EndEdit();
                var devFileList = this.dEVD001DeviceFileBindingSource.DataSource as List<DEV_D001_Device_File>;
                var devAppList = this.dEVD001DeviceAppurtenBindingSource.DataSource as List<DEV_D001_Device_Appurten>;
                devService.Save(tempData, devFileList, devAppList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
        private void DeviceEditForm_Load(object sender, EventArgs e)
        {
            CreateToolBar();
            this.xtraTabControl1.SelectedPageChanged += new TabPageChangedEventHandler(xtraTabControl1_SelectedPageChanged);
        }

        void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            CreateToolBar();
        }
        /// <summary>
        /// 生成子项目工具栏
        /// </summary>
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
                case 0:
                    if (ERPHelper.Instance.MessageDel())
                    {
                        var fileData = this.dEVD001DeviceFileBindingSource.Current as DEV_D001_Device_File;
                        devService.MarkDevFile(fileData.Id);
                        this.dEVD001DeviceFileBindingSource.RemoveCurrent();
                    }
                    break;
                case 1:
                    if (ERPHelper.Instance.MessageDel())
                    {
                        var appData = this.dEVD001DeviceAppurtenBindingSource.Current as DEV_D001_Device_Appurten;
                        devService.MarkDevAppurten(appData.Id);
                        this.dEVD001DeviceAppurtenBindingSource.RemoveCurrent();
                    }
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
            XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
            switch (this.xtraTabControl1.SelectedTabPageIndex)
            {
                case 0: 
                    OpenFileDialog openDig = new OpenFileDialog();
                     openDig.FileOk += new CancelEventHandler(openDig_FileOk);
                     openDig.ShowDialog();
                    break;
                case 1:
                    this.dEVD001DeviceAppurtenBindingSource.AddNew();
                    var appData = this.dEVD001DeviceAppurtenBindingSource.Current as DEV_D001_Device_Appurten;
                    appData.DevId = tempData.Id;
                    break;
            }
        }

        void openDig_FileOk(object sender, CancelEventArgs e)
        {
            this.dEVD001DeviceFileBindingSource.AddNew();
            var fileData = this.dEVD001DeviceFileBindingSource.Current as DEV_D001_Device_File;
            fileData.DevId = tempData.Id;
            OpenFileDialog openDig = sender as OpenFileDialog;
            fileData.DocName = openDig.FileName.Substring(openDig.FileName.LastIndexOf("\\") + 1);//获取文件名
            fileData.Contents = Util.FileStreamHelp.FileToBytes(openDig.FileName);
        }
        //保存文件
        private void repositoryItemFile_Click(object sender, EventArgs e)
        {
            var file = this.dEVD001DeviceFileBindingSource.Current as DEV_D001_Device_File;
            if (file != null)
            {
                saveFileDialog1.FileName = file.DocName;
                saveFileDialog1.Filter = "|*." + file.DocName.Substring(file.DocName.LastIndexOf(".") + 1);//"文本文件(*.txt)|*.txt|所有文件(*.*)|*.*""*."+file2.Format;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Util.FileStreamHelp.BytesToFile(file.Contents, saveFileDialog1.FileName);
                    if (XtraMessageBox.Show("文件已下载，是否打开？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                    }
                }
               
            }
        }
    }
}
