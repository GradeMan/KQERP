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
using DevExpress.XtraEditors;

namespace ERP.Winform.Product
{
    public partial class MaterialListForm : ListForm
    {
        private IMaterialService materialService = Unity.Instance.GetService<IMaterialService>();
        public MaterialListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator+=new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            eRPM002MaterialBindingSource.DataSource = materialService.GetList();

        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPM002MaterialBindingSource.AddNew();
                EditForm(this.Text+"新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm(this.Text+"修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                   var temp = eRPM002MaterialBindingSource.Current as ERP_M002_Material;
                    materialService.Delete(temp.Id);
                    eRPM002MaterialBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            ERP_M002_Material temp = eRPM002MaterialBindingSource.Current as ERP_M002_Material;
            if (temp == null)
            {
                XtraMessageBox.Show("请先选择行");
                return;
            }
            MaterialEditForm edit = new MaterialEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPM002MaterialBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm(this.Text+"查看", BtnCommandEnum.Watch);
            }
        }
    }
}
