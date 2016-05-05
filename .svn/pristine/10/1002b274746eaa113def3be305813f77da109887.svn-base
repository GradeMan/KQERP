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

namespace ERP.Winform.WMS
{
    public partial class ShelfListForm : ListForm
    {
        private IWMSShelfService shelfService = Unity.Instance.GetService<IWMSShelfService>();
        public ShelfListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {

            wMSC103ShelfBindingSource.DataSource = shelfService.GetList();
            //eRPC001CodeBindingSource.DataSource = codeService.GetList();  
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                wMSC103ShelfBindingSource.AddNew();
                EditForm("货架资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("货架资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = wMSC103ShelfBindingSource.Current as WMS_C103_Shelf;
                    shelfService.Delete(temp.Id);
                    wMSC103ShelfBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            WMS_C103_Shelf temp = wMSC103ShelfBindingSource.Current as WMS_C103_Shelf;
            ShelfEditForm edit = new ShelfEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                wMSC103ShelfBindingSource.CancelEdit();
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("代码资料查看", BtnCommandEnum.Watch);
            }
        }
    }
}
