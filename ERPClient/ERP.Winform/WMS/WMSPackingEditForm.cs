using COM.Domain;
using COM.Service;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using ERP.Winform.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP.Winform.WMS
{
    public partial class WMSPackingEditForm : EditForm
    {
        private WMS_M104_Packing_Hd tempData;
        private IWMS_M104_Packing_HdService packingService;
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        public WMSPackingEditForm(WMS_M104_Packing_Hd packHd, IWMS_M104_Packing_HdService packingService)
        {
            InitializeComponent();
            this.tempData = packHd;
            this.DateDateEdit.Focus();
            this.packingService = packingService;
        }
        protected override void InitData()
        {
            //var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            //SetGridLookUpEdit(SuppCodeTextEdit, suppData, 1);
            //SetGridLookUpEdit(repositoryMatSpec, materialData, 2);
            //SetGridLookUpEdit(repositoryMatClass2, materialData, 2);
            //repositoryMatClass2.DisplayMember = "InputCode3";
            //repositoryMatSpec.DisplayMember = "InputCode2";
            //repositoryMatClass2.ValueMember = "InputCode3";
            //repositoryMatSpec.ValueMember = "InputCode2";
            this.wMSM104PackingHdBindingSource.DataSource = tempData;
            var storeDetailList = packingService.GetDetailList(tempData.Id);
            if (this.Tag.ToString() == BtnCommandEnum.Add)
            {
                tempData.CustCode = "HANA";
                this.wMSM104PackingHdBindingSource.ResetCurrentItem();
                for (int i = 0; i < 10; i++)
                {
                    WMS_M104_Packing_Detail packingDetail = new WMS_M104_Packing_Detail();
                    packingDetail.PackingHdId = tempData.Id;
                    storeDetailList.Add(packingDetail);
                }
            }
            this.wMSM104PackingDetailBindingSource.DataSource = storeDetailList;
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.wMSM104PackingHdBindingSource.EndEdit();
                this.wMSM104PackingDetailBindingSource.EndEdit();
                this.gridView3.CloseEditor();
                var packingDetailList = this.wMSM104PackingDetailBindingSource.DataSource as List<WMS_M104_Packing_Detail>;
                packingDetailList = packingDetailList.Where(a => a.SuppPartNo != "" && a.SuppPartNo != null).ToList();
                this.packingService.Save(tempData, packingDetailList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        protected override void CreateToolBar()
        {
            // ToolStrip toolStrip = new ToolStrip();
            ToolStripButton btnAdd = new ToolStripButton();
            btnAdd.Text = "新增明细";
            btnAdd.Image = (Image)Resources.ResourceManager.GetObject("edit_add");
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnAdd.Click += new EventHandler(btnAdd_Click);
            toolStrip1.Items.Add(btnAdd);
            ToolStripSeparator toolSep = new ToolStripSeparator();
            toolStrip1.Items.Add(toolSep);
            ToolStripButton btnDel = new ToolStripButton();
            btnDel.Text = "删除明细";
            btnDel.Image = (Image)Resources.ResourceManager.GetObject("cancel");
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnDel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDel.Click += new EventHandler(btnDel_Click);
            toolStrip1.Items.Add(btnDel);
            //toolStrip1.Dock = DockStyle.Top;
            //toolStrip.BringToFront();
            // page.Controls.Add(toolStrip);
        }
        void btnDel_Click(object sender, EventArgs e)
        {
            var temp = this.wMSM104PackingDetailBindingSource.Current as WMS_M104_Packing_Detail;
            packingService.MarkDelDetail(temp.Id);
            this.wMSM104PackingDetailBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.wMSM104PackingHdBindingSource.EndEdit();
            //var tempData = this.wMSC102InStoreDetailBindingSource.DataSource as WMS_C101_InStore;
            // string jobNo = this.JobNoTextEdit.Text;
            //if (string.IsNullOrWhiteSpace(tempData.JobNo))
            //{
            //    XtraMessageBox.Show("入库工单号为空，请先输入库工单号");
            //    return;
            //}
            this.wMSM104PackingDetailBindingSource.AddNew();
            var tempDetail = this.wMSM104PackingDetailBindingSource.Current as WMS_M104_Packing_Detail;
            tempDetail.PackingHdId = tempData.Id;
            //tempDetail.JobNo = tempData.JobNo;
        }
    }
}
