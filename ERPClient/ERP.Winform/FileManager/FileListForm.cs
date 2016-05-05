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
using ERP.Domain;
using COM.Service;
using Util;
using DevExpress.XtraEditors;
using System.IO;
namespace ERP.Winform.FileManager
{
    public partial class FileListForm : ListForm
    {
        private IFileService fileService = Unity.Instance.GetService<IFileService>();
        FTPHelper ftpHepler = new FTPHelper();
        public FileListForm()
        {
            InitializeComponent();
            BindingEvent();
            this.txtPath.Text = "boot";
            OnBindData("boot");
        }
       

        /// <summary>
        /// 绑定事件
        /// </summary>
        private void BindingEvent()
        {
            this.winExplorerView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(winExplorerView1_CellValueChanged);
            this.winExplorerView1.DoubleClick += new EventHandler(winExplorerView1_DoubleClick);
            this.winExplorerView1.OptionsBehavior.Editable = false;
            this.winExplorerView1.KeyDown += new KeyEventHandler(winExplorerView1_KeyDown);
            this.btnBack.Click += new EventHandler(btnBack_Click);
            this.txtPath.EditValueChanged += new EventHandler(txtPath_EditValueChanged);
        }

        void txtPath_EditValueChanged(object sender, EventArgs e)
        {
            if (this.txtPath.Text == "boot")
                this.btnBack.Enabled = false;
            else
                this.btnBack.Enabled = true;
        }

        void btnBack_Click(object sender, EventArgs e)
        {
            if (this.txtPath.Text != "boot")
            {
                string path = this.txtPath.Text;
                this.txtPath.Text = path.Substring(0, path.LastIndexOf("\\"));
                OnBindData(this.txtPath.Text);
            }
        }
    
       
        /// <summary>
        /// F2进入修改模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void winExplorerView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                this.winExplorerView1.OptionsBehavior.Editable = true;
                this.winExplorerView1.ShowEditor();
            }
        }
        /// <summary>
        /// 双击，如果是文件夹则打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void winExplorerView1_DoubleClick(object sender, EventArgs e)
        {
            var tempData = this.fTPF002FileBindingSource.Current as FTP_F002_File;
            if (tempData.Extension == "Dir")
            {
                this.txtPath.Text += "\\"+tempData.FileName;
                OnBindData(this.txtPath.Text);
            }
            else
            {
                OnDowloadFile();
            }
        }

       
        void winExplorerView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var tempData = this.fTPF002FileBindingSource.Current as FTP_F002_File;
            fileService.Update(tempData);
            this.winExplorerView1.OptionsBehavior.Editable = false;
        }

        public void OnBindData(string path)
        {
            var fileList = fileService.GetListWithRole(path);//new List<FTP_F002_File>() { new FTP_F002_File { Id = Guid.NewGuid(), FileName = "2014萌恒秋游四队.doc", ServiceName = "2014萌恒秋游四队.doc", Extension = ".doc", Path = "D" } };
            if (fileList != null)
                fileList.ForEach(i =>
                    {
                        if (i.Extension == "Dir")
                            i.Image = (Image)ERP.Winform.Properties.Resources.ResourceManager.GetObject("dir");
                        else
                            i.Image = Util.WindowsHelper.FromExtension(i.Extension, false).ToBitmap();
                    }
                        );
                    
            this.fTPF002FileBindingSource.DataSource = fileList;
        }

        public override  void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FTPHelper ftpHepler = new FTPHelper();
            // MessageBox.Show(e.Item.Caption)
            if (e.Item.Caption == BtnCommandEnum.AddDir)
            {
                fTPF002FileBindingSource.AddNew();
                var tempDir = this.fTPF002FileBindingSource.Current as FTP_F002_File;
                tempDir.FileName = "新建文件夹";
                tempDir.Extension = "Dir";
                tempDir.Path = this.txtPath.Text;
                tempDir.Image = (Image)ERP.Winform.Properties.Resources.ResourceManager.GetObject("dir");
                fileService.Create(tempDir);
                this.winExplorerView1.RefreshData();
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)//数据库里软删除，FTP不删除
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = fTPF002FileBindingSource.Current as FTP_F002_File;
                    temp.Status = false;
                    fileService.Update(temp);
                    fTPF002FileBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.AddFile)
            {
                OpenFileDialog openDig = new OpenFileDialog();
                if (openDig.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(openDig.FileName);
                    fTPF002FileBindingSource.AddNew();
                    var temp = fTPF002FileBindingSource.Current as FTP_F002_File;
                    temp.FileName = file.Name;
                    temp.Extension = file.Extension;
                    temp.ServiceName = file.Name;
                    temp.Path = this.txtPath.Text;
                    temp.Image = Util.WindowsHelper.FromExtension(temp.Extension, false).ToBitmap();
                    fileService.Create(temp);
                    ftpHepler.Upload(openDig.FileName);
                    this.winExplorerView1.RefreshData();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                this.winExplorerView1.OptionsBehavior.Editable = true;
                this.winExplorerView1.ShowEditor();
            }
            else if (e.Item.Caption == BtnCommandEnum.DownloadFile)
            {
                OnDowloadFile();
            }
            
        }
        /// <summary>
        /// 下载文件
        /// </summary>
        private void OnDowloadFile()
        {
            var temp = fTPF002FileBindingSource.Current as FTP_F002_File;
            SaveFileDialog saveDig = new SaveFileDialog();
            saveDig.Filter = "(*" + temp.Extension + ")" + "|*" + temp.Extension;//"*"+temp.Extension;//文本文件(*.txt)|*.txt
            saveDig.FileName = temp.ServiceName;
            if (saveDig.ShowDialog() == DialogResult.OK)
            {
                ftpHepler.Download(saveDig.FileName, temp.ServiceName);
            }
        }

        //public override void CreateToolBar(List<tb_Sys_Button> buttonList)
        //{
        //    base.CreateToolBar(buttonList);
        //    OnAddToolBtn(BtnCommandEnum.AddDir,null);
        //    OnAddToolBtn(BtnCommandEnum.AddFile, null);
        //    OnAddToolBtn(BtnCommandEnum.Watch, null);
        //    OnAddToolBtn(BtnCommandEnum.DownloadFile, null);
        //}
        BreadCrumbNode CreateNode(string name,string value)
        {
            return new BreadCrumbNode(name, value, true);
        }

        private void FileListForm_Load(object sender, EventArgs e)
        {
            
        }

        private void EditSearch_Properties_Click(object sender, EventArgs e)
        {
            this.winExplorerView1.FindFilterText = EditSearch.Text;
        }
    }
}
