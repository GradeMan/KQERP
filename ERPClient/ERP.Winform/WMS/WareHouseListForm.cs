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
    public partial class WareHouseListForm : ListForm
    {
        private IWMSWareHouseService wareHourseService = Unity.Instance.GetService<IWMSWareHouseService>();
        public WareHouseListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            wMSC101WareHouseBindingSource.DataSource = wareHourseService.GetList();
            //eRPC001CodeBindingSource.DataSource = codeService.GetList();  
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                wMSC101WareHouseBindingSource.AddNew();
                EditForm("基础代号新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("基础代号修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = wMSC101WareHouseBindingSource.Current as WMS_C101_WareHouse;
                    wareHourseService.Delete(temp.Id);
                    wMSC101WareHouseBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            WMS_C101_WareHouse temp = wMSC101WareHouseBindingSource.Current as WMS_C101_WareHouse;
            WareHouseEditForm edit = new WareHouseEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                wMSC101WareHouseBindingSource.CancelEdit();
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
