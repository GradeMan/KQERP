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
    public partial class StockForm : ListForm
    {
        private IWMS_C103_StockService stockService = Unity.Instance.GetService<IWMS_C103_StockService>();
        public StockForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.wMSC103StockBindingSource.DataSource = stockService.GetList();
            this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.wMSC103StockBindingSource.AddNew();
                OpenForm("库存资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("库存资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    WMS_C103_Stock user = this.wMSC103StockBindingSource.Current as WMS_C103_Stock;
                    stockService.Delete(user.Id);
                    this.wMSC103StockBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            WMS_C103_Stock temp = this.wMSC103StockBindingSource.Current as WMS_C103_Stock;
            StockEditForm edit = new StockEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.wMSC103StockBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("公司资料查看", BtnCommandEnum.Watch);
        }
    }
}
