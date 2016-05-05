using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using COM.Winform.Properties;
using DevExpress.XtraLayout;
using DevExpress.XtraTab;

namespace COM.Winform
{
    public partial class EditForm : BaseForm
    {
        public EditForm()
        {
            InitializeComponent();
           
        }
        protected virtual void OnSetLayoutItemStyle()
        {
           
        }
        protected virtual void InitData()
        {

        }
        protected virtual void SetToolBarItem()
        {
            if (this.Tag == null) return;
            if (this.Tag.ToString() == BtnCommandEnum.Watch)
            {
                dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
                //foreach (Control tool in dataLayoutControl1.Controls)
                //{
                //    if (tool is BaseEdit)
                //    {
                //        BaseEdit txtTol = tool as BaseEdit;
                //        txtTol.Properties.ReadOnly = true;
                //    }
                //    //if (tool is DateEdit)
                //    //{
                //    //    DateEdit txtTol = tool as DateEdit;
                //    //    txtTol.Properties.ReadOnly = true;
                //    //}
                //}
                OnAddToolBtn("取消", "cancel");
            }
            else
            {
                OnAddToolBtn("保存", "ok");
                OnAddToolBtn("取消", "cancel");
                CreateToolBar();
            }
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            SetToolBarItem();
            OnSetLayoutItemStyle();
            InitData();
        }

        protected void OnAddToolBtn(string caption,string imageName)
        {
            BarLargeButtonItem btnItem = new BarLargeButtonItem();
            btnItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            if (imageName != null)
                btnItem.LargeGlyph = (Image)Resources.ResourceManager.GetObject(imageName);
            btnItem.Caption = caption;
            btnItem.ItemClick += new ItemClickEventHandler(OnBtnCommand);
            bar1.AddItem(btnItem);
        }
        protected virtual void CreateToolBar()
        {
           
        }
        protected virtual void OnBtnCommand(object sender, ItemClickEventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Down)
            {
                SendKeys.SendWait("{Tab}");
                return true;
            }
            if (keyData == Keys.Up)
            {
                SendKeys.SendWait("+{TAB}");
                return true;
            } return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}