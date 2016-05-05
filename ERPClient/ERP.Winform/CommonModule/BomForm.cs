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
using Util;

namespace ERP.Winform.CommonModule
{
    public partial class BomForm : ListForm
    {
        private IERP_M002_BOMService bomService = Unity.Instance.GetService<IERP_M002_BOMService>();
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public BomForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            this.eRPM002BOMBindingSource.DataSource = bomService.GetList();
            this.gridView1.BestFitColumns();
        }
        /// <summary>
        /// 根据供应商显示物料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ERP_M002_BOM temp = this.eRPM002BOMBindingSource.Current as ERP_M002_BOM;
            if (temp != null)
            {
                IERP_M002_BOM_MaterialService bomMaterialService = Unity.Instance.GetService<IERP_M002_BOM_MaterialService>();
                this.ykGridControl2.DataSource = bomMaterialService.GetQuery().Where(a => a.PartNo == temp.PartNo).ToList();
                this.gridView2.BestFitColumns();
            }
            else
                this.ykGridControl2.DataSource = null;
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.eRPM002BOMBindingSource.AddNew();
                ERP_M002_BOM temp = eRPM002BOMBindingSource.Current as ERP_M002_BOM;
                temp.StartDt = DateTime.Now.Date;
                temp.Status = "在用";
                temp.BOMNo = viewService.GetGenerateOrderCode(4);
                EditForm("BOM资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                ERP_M002_BOM temp = eRPM002BOMBindingSource.Current as ERP_M002_BOM;
                if (temp == null)
                    throw new AppException("请先选择要修改的数据");
                EditForm("BOM资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_M002_BOM temp = eRPM002BOMBindingSource.Current as ERP_M002_BOM;
                    this.bomService.Delete(temp.Id);
                    eRPM002BOMBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Watch)
            {
                ERP_M002_BOM temp = this.eRPM002BOMBindingSource.Current as ERP_M002_BOM;
                if (temp == null)
                    throw new AppException("请先选择要查看的数据");
                EditForm("供应商资料查看", BtnCommandEnum.Watch);
            }
            else if (e.Item.Caption == BtnCommandEnum.Refresh)
            {
                InitData();
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            ERP_M002_BOM temp = this.eRPM002BOMBindingSource.Current as ERP_M002_BOM;
            BomEditForm edit = new BomEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPM002BOMBindingSource.CancelEdit();
            }
            else
            {
                gridView1_FocusedRowChanged(null, null);
            }
        }
    }
}
