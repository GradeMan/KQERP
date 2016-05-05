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

namespace ERP.Winform.CommonModule
{
    public partial class QHProductListForm : ListForm
    {
        private IQHProductService qhProductService = Unity.Instance.GetService<IQHProductService>();
        public QHProductListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            eRPM004QHProductBindingSource.DataSource = qhProductService.GetList();
            
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPM004QHProductBindingSource.AddNew();
                EditForm("企划产品新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("企划产品修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = eRPM004QHProductBindingSource.Current as ERP_M004_QHProduct;
                    qhProductService.Delete(temp.Id);
                    eRPM004QHProductBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            ERP_M004_QHProduct temp = eRPM004QHProductBindingSource.Current as ERP_M004_QHProduct;
            QHProductEditForm edit = new QHProductEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPM004QHProductBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("气化产品查看", BtnCommandEnum.Watch);
            }
        }
    }
}
