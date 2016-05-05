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
using COM.Service;
using ERP.Service;
using ERP.Domain;

namespace ERP.Winform.Order
{
    public partial class LotListForm : ListForm
    {
        private ILotTxService lotTxService = Unity.Instance.GetService<ILotTxService>();
        public LotListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            mESM003LotTxBindingSource.DataSource = lotTxService.GetList();
            
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                mESM003LotTxBindingSource.AddNew(); 
                var lotTxData = mESM003LotTxBindingSource.Current as MES_M003_LotTx;
                lotTxData.TxDt = DateTime.Now.Date;
                EditForm("Lot资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("Lot资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = mESM003LotTxBindingSource.Current as MES_M003_LotTx;
                    lotTxService.Delete(temp.Id);
                    mESM003LotTxBindingSource.RemoveCurrent();
                }
            }
         
        }

        private void EditForm(string formText, string btnCommand)
        {
            MES_M003_LotTx temp = mESM003LotTxBindingSource.Current as MES_M003_LotTx;
            LotEditForm edit = new LotEditForm(mESM003LotTxBindingSource);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                mESM003LotTxBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("模具资料查看", BtnCommandEnum.Watch);
            }
        }
     
    }
}