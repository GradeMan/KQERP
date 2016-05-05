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
using COM.Service;
using System.Xml.Linq;
using ERP.Domain;
using Util;
using System.IO;
namespace COM.Winform
{
    public partial class ListForm : BaseForm//,IFunction
    {
       
        public ListForm()
        {
            InitializeComponent();
            
        }

        //public void ShowDig(Form frmMain,string txtFrmName)
        //{
        //    this.Text = txtFrmName;
        //    this.MdiParent = frmMain;
        //    this.WindowState = FormWindowState.Maximized;
        //    this.Show();
        //}
        public List<tb_Sys_Button> ButtonList { get; set; }
        public virtual void CreateToolBar(List<tb_Sys_Button> buttonList)
        {
            this.ButtonList = buttonList;
            if (buttonList != null)
            {
                foreach (var button in buttonList)
                {
                    //BarLargeButtonItem btnItem = new BarLargeButtonItem();
                    //btnItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                    //btnItem.LargeGlyph = BufferToImage(button.Btn_Icon);//(Image)Resources.ResourceManager.GetObject("edit_add");
                    //btnItem.Caption = button.Btn_Name;
                    //btnItem.ItemClick += new ItemClickEventHandler(OnBtnCommand);
                    //bar1.AddItem(btnItem);
                    OnAddToolBtn(button.Btn_Name, BufferToImage(button.Btn_Icon));
                }
            }
        }

        protected void OnAddToolBtn(string caption, Image image)
        {
            BarLargeButtonItem btnItem = new BarLargeButtonItem();
            btnItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            if (image != null)
                btnItem.LargeGlyph = image;
            btnItem.Caption = caption;
            btnItem.ItemClick += new ItemClickEventHandler(OnBtnCommand);
            bar1.AddItem(btnItem);
        }

        private  Image BufferToImage(byte[] Buffer)
        {
            if (Buffer == null) return null;
            MemoryStream ms = new MemoryStream(Buffer);
            Image img = Image.FromStream(ms);
            return img;

        }
        public virtual void OnBtnCommand(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            OnAttachEvent();
            InitData();
        }
        public virtual void OnAttachEvent()
        {
        }
        public virtual void InitData()
        {

        }

       
    }
}