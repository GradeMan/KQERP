using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Service;
using COM.Service;
using ERP.Domain;

namespace ERP.Winform.Order
{
    public partial class OrderListForm : ListForm
    {
        private IOrderService orderService = Unity.Instance.GetService<IOrderService>();
        public OrderListForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            mESM001OrderBindingSource.DataSource = orderService.GetList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                mESM001OrderBindingSource.AddNew();
                EditForm("订单资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("订单资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = mESM001OrderBindingSource.Current as MES_M001_Order;
                    orderService.Delete(temp.Id);
                    mESM001OrderBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            MES_M001_Order temp = mESM001OrderBindingSource.Current as MES_M001_Order;
            OrderEditForm edit = new OrderEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                mESM001OrderBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("订单资料查看", BtnCommandEnum.Watch);
            }
        }
    }
}