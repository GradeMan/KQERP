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
using ERP.Winform.Properties;
using DevExpress.XtraEditors;
using Util;
using COM.Domain;

namespace ERP.Winform.WMS
{
    public partial class InStoreEditForm : EditForm
    {
        private IWMS_C101_InStoreService instoreService;//= Unity.Instance.GetService<IWMS_C101_InStoreService>();
        private IJobService jobService = Unity.Instance.GetService<IJobService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        private WMS_C101_InStore tempData;
        private IERP_M001_MaterialService materialServer = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private List<InputItem> materialData;
        private string suppLot;//供应商编号
        private IWMSAreaService areaService = Unity.Instance.GetService<IWMSAreaService>();
        public InStoreEditForm(WMS_C101_InStore inStore, IWMS_C101_InStoreService instoreService)
        {
            InitializeComponent();
            this.tempData = inStore;
            this.SuppCodeTextEdit.Focus();
            this.instoreService = instoreService;
        }
        protected override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(SuppCodeTextEdit, suppData, 1);
            materialData = materialServer.GetMaterial().Select(a => new InputItem { DisPlayName = a.MatName, Value = a.MatCode, InputCode1 = a.MatCode, InputCode2 = a.MatSpec, InputCode3 = a.MatClass2 }).ToList();
            SetGridLookUpEdit(repositoryMatCode, materialData, 3);
            var areaData = areaService.GetAreaQuery().Where(a=>a.StockArea == tempData.StockArea).Select(a => new InputItem { DisPlayName = a.ARName, Value = a.ARCode }).ToList();
            SetGridLookUpEdit(repositoryAreaCode, areaData,0);
            //SetGridLookUpEdit(repositoryMatSpec, materialData, 2);
            //SetGridLookUpEdit(repositoryMatClass2, materialData, 2);
            //repositoryMatClass2.DisplayMember = "InputCode3";
            //repositoryMatSpec.DisplayMember = "InputCode2";
            //repositoryMatClass2.ValueMember = "InputCode3";
            //repositoryMatSpec.ValueMember = "InputCode2";
            this.wMSC101InStoreBindingSource.DataSource = tempData;
            var storeDetailList = instoreService.GetDetailListByInstoreId(tempData.Id);
            if (this.Tag.ToString() == BtnCommandEnum.Add)
            {
                for (int i = 0; i < 20; i++)
                {
                    WMS_C102_InStoreDetail storeDetail = new WMS_C102_InStoreDetail();
                    
                    storeDetailList.Add(storeDetail);
                }
            }
            this.wMSC102InStoreDetailBindingSource.DataSource = storeDetailList;
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForInStoreNo, ItemBindingType.Required);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.wMSC101InStoreBindingSource.EndEdit();
                this.wMSC102InStoreDetailBindingSource.EndEdit();
                var instoreDetailList = this.wMSC102InStoreDetailBindingSource.DataSource as List<WMS_C102_InStoreDetail>;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                {
                    instoreDetailList = instoreDetailList.Where(a => a.ARCode != null).ToList();
                    foreach (var storeDetail in instoreDetailList)
                    {
                        storeDetail.InStoreId = tempData.Id;
                        storeDetail.InStoreNo = tempData.InStoreNo;
                    }
                }
                this.instoreService.Save(tempData, instoreDetailList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void InStoreEditForm_Load(object sender, EventArgs e)
        {
            this.gridInstoreDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridInstoreDetail_CellValueChanged);
            if (this.Tag.ToString() == BtnCommandEnum.Edit)
                this.InStoreNoTextEdit.Enabled = false;
        }
        
        //根据明细数量生成实际入库数量
        void gridInstoreDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Amount")
            {
                var instoreDetailList = this.wMSC102InStoreDetailBindingSource.DataSource as List<WMS_C102_InStoreDetail>;
                tempData.ActualAmount = instoreDetailList.Sum(i => i.Amount);
                this.wMSC101InStoreBindingSource.ResetCurrentItem();
            }
            if (e.Column.FieldName == "LotNo")
            {
                var instoreDetailList = this.wMSC102InStoreDetailBindingSource.DataSource as List<WMS_C102_InStoreDetail>;
                //if (instoreDetailList.Where(i => i.LotNo == e.Value.ToString()).Count() > 1)
                //{
                //    XtraMessageBox.Show("批号不能重复，请重新输入");
                //    this.gridInstoreDetail.SetFocusedRowCellValue(colLotNo, "");
                //}
            }
           
        }

        protected override void  CreateToolBar()
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
            var temp = this.wMSC102InStoreDetailBindingSource.Current as WMS_C102_InStoreDetail;
            instoreService.MarkDelDetail(temp.Id);
            this.wMSC102InStoreDetailBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.wMSC101InStoreBindingSource.EndEdit();
            //var tempData = this.wMSC102InStoreDetailBindingSource.DataSource as WMS_C101_InStore;
            // string jobNo = this.JobNoTextEdit.Text;
            //if (string.IsNullOrWhiteSpace(tempData.JobNo))
            //{
            //    XtraMessageBox.Show("入库工单号为空，请先输入库工单号");
            //    return;
            //}
            this.wMSC102InStoreDetailBindingSource.AddNew();
            var tempDetail = this.wMSC102InStoreDetailBindingSource.Current as WMS_C102_InStoreDetail;
            tempDetail.InStoreId = tempData.Id;
            //tempDetail.JobNo = tempData.JobNo;
        }

        private void gridInstoreDetail_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colMatCode)
            {
                var tempDetail = this.wMSC102InStoreDetailBindingSource.Current as WMS_C102_InStoreDetail;
                var material = materialData.Where(a => a.Value == e.Value.ToString()).Single();
                tempDetail.MatClass2 = material.InputCode3;
                tempDetail.PartSpec = material.InputCode2;
                tempDetail.SuppLot = suppLot;
            }
            else if (e.Column == colSuppLot)
            {
                suppLot = suppLot ?? e.Value.ToString();
            }
            else if (e.Column == colAmount || e.Column == colUnitPrice)
            {
                var tempDetail = this.wMSC102InStoreDetailBindingSource.Current as WMS_C102_InStoreDetail;
                tempDetail.SumPrice = tempDetail.Amount * tempDetail.UnitPrice;
            }

        }
    }
}
