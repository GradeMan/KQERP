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
using System.IO;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using Util;
using ERP.Service;
using COM.Service;
using COM.Domain;
namespace ERP.Winform.ESOP
{
    public partial class ESOPDocEditForm : EditForm
    {
        private Task<int> taskConvertImage;
        private string imagePath = "C:\\ImageFile";
        private string filePath;
        private IESOP_DocService docService = Unity.Instance.GetService<IESOP_DocService>();
        private IESOP_DocIndexService docIndexServer = Unity.Instance.GetService<IESOP_DocIndexService>();
        private ESOP_Doc tempData;
        public ESOPDocEditForm(ESOP_Doc tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            var docIndexData = docIndexServer.GetDocIndex().Select(a => new InputItem { DisPlayName = a.DocIndexName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(DocIndexIdTextEdit, docIndexData, 0);
            this.DocIndexIdTextEdit.Properties.ValueMember = "Value2";
            //ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("IST"), 2);//状态
            this.eSOPDocBindingSource.DataSource = tempData;
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                FTPHelper ftpHepler = new FTPHelper();
                var tempData = this.eSOPDocBindingSource.DataSource as ESOP_Doc;
                if (string.IsNullOrWhiteSpace(tempData.CreateUser))
                {
                    taskConvertImage.Wait();
                    tempData.PageCount = taskConvertImage.Result;
                    ftpHepler.Upload(tempData.FilePath, tempData.Id.ToString() + tempData.Fomat);
                    if (!ftpHepler.FileExist(tempData.Id.ToString()))
                    {
                        ftpHepler.MakeDir(tempData.Id.ToString());
                    }
                    ftpHepler.GotoDirectory(tempData.Id.ToString(), false);
                    foreach (var file in Directory.GetFiles(imagePath))
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        ftpHepler.Upload(file);
                    }
                }
                docService.Save(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void FilePathTextEdit_Properties_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDig = new OpenFileDialog();
            openDig.FileOk += new CancelEventHandler(openDig_FileOk);//点击确定
            openDig.ShowDialog();
        }

        private void openDig_FileOk(object sender, CancelEventArgs e)
        {
            //var docData = this.eSOPDocBindingSource.DataSource as ESOP_Doc;
            OpenFileDialog openDig = sender as OpenFileDialog;
            tempData.FilePath = openDig.FileName;
            FileInfo file = new FileInfo(openDig.FileName);

            filePath = openDig.FileName;
            tempData.DocName = file.Name;// filePath.Substring(filePath.LastIndexOf("\\") + 1);//获取文件名
            //btnUpLoadFile.Text = 
            tempData.Fomat = file.Extension;
            this.eSOPDocBindingSource.ResetCurrentItem();
            // TaskFactory tf = new TaskFactory();
            // taskConvertImage = tf.StartNew<int>(ConvertPDF2Image);
            taskConvertImage = new Task<int>(ConvertPDF2Image);
            taskConvertImage.Start();

            // taskConvertImage.Start();
        }
        /// <summary>
        /// PDF转Image
        /// </summary>
        private int ConvertPDF2Image()
        {
            if (Directory.Exists(imagePath))
                Directory.Delete(imagePath, true);
            int pageCount = ERPHelper.Instance.ConvertPDF2Image(filePath, imagePath, "A", 1, 5, ImageFormat.Jpeg, Definition.Nine);
            return pageCount;
        }
    }
}
