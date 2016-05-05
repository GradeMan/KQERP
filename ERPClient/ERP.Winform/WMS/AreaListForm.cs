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
    public partial class AreaListForm : ListForm
    {
        private IWMSAreaService areaService = Unity.Instance.GetService<IWMSAreaService>();
        public AreaListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            wMSC102AreaBindingSource.DataSource = areaService.GetList();
            //eRPC001CodeBindingSource.DataSource = codeService.GetList();  
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                wMSC102AreaBindingSource.AddNew();
                WMS_C102_Area temp = wMSC102AreaBindingSource.Current as WMS_C102_Area;
                temp.State = "在用";
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
                    var temp = wMSC102AreaBindingSource.Current as WMS_C102_Area;
                    areaService.Delete(temp.Id);
                    wMSC102AreaBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            WMS_C102_Area temp = wMSC102AreaBindingSource.Current as WMS_C102_Area;
            AreaEditForm edit = new AreaEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                wMSC102AreaBindingSource.CancelEdit();
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
