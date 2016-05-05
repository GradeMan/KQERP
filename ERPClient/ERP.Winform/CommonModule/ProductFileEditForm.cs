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
namespace ERP.Winform.CommonModule
{
    public partial class ProductFileEditForm : EditForm
    {
        public ProductFileEditForm(ERP_M001_Product_File tempData)
        {
            InitializeComponent();
            this.eRPM001ProductFileBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForItemCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForDocName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var file = eRPM001ProductFileBindingSource.DataSource as ERP_M001_Product_File;
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eRPM001ProductFileBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
        private void DocNameTextEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog openDig = new OpenFileDialog();
            openDig.FileOk += new CancelEventHandler(openDig_FileOk);
            openDig.ShowDialog();
        }

        void openDig_FileOk(object sender, CancelEventArgs e)
        {
            var file = eRPM001ProductFileBindingSource.DataSource as ERP_M001_Product_File;
            OpenFileDialog openDig = sender as OpenFileDialog;
            UpLoadTextEdit.Text = openDig.FileName;
            file.DocName = openDig.FileName.Substring(openDig.FileName.LastIndexOf("\\") + 1);//获取文件名
            DocNameTextEdit.EditValue = file.DocName;
            file.Content = Util.FileStreamHelp.FileToBytes(openDig.FileName);
        }
    }
}
