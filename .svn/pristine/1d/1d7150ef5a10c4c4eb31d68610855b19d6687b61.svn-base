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

namespace ERP.Winform.Product
{
    public partial class ModelListForm : ListForm
    {
        private IModelService modelService = Unity.Instance.GetService<IModelService>();
        public ModelListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            eRPM003ModelBindingSource.DataSource = modelService.GetList();

        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPM003ModelBindingSource.AddNew();
                EditForm("模具资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("模具资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = eRPM003ModelBindingSource.Current as ERP_M003_Model;
                    modelService.Delete(temp.Id);
                    eRPM003ModelBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            ERP_M003_Model temp = eRPM003ModelBindingSource.Current as ERP_M003_Model;
            ModelEditForm edit = new ModelEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPM003ModelBindingSource.CancelEdit();
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
