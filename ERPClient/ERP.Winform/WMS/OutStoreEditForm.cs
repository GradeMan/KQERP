﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Service;
using ERP.Domain;
using COM.Service;
using ERP.Winform.Properties;
using DevExpress.XtraEditors;

namespace ERP.Winform.WMS
{
    public partial class OutStoreEditForm : EditForm
    {
        private IWMS_C104_OutStoreService outStoreService = Unity.Instance.GetService<IWMS_C104_OutStoreService>();
        private IJobService jobService = Unity.Instance.GetService<IJobService>();
        private IWMS_C103_StockService stockService = Unity.Instance.GetService<IWMS_C103_StockService>();
        private WMS_C104_OutStore tempData;
        public OutStoreEditForm(WMS_C104_OutStore tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            //this.repositoryItemJobNo.DataSource = stockService.GetJobNo();
            //this.OutStoreCodeTextEdit.EditValueChanged += new EventHandler(OutStoreCodeTextEdit_EditValueChanged);
            this.wMSC104OutStoreBindingSource.DataSource = tempData;
            
        }
        //出库单改变，改变明细
        void OutStoreCodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.wMSC105OutStoreDetailBindingSource.DataSource = outStoreService.GetDetailListByOutStoreId(tempData.Id);
        }

        protected override void OnSetLayoutItemStyle()
        {
            //ERPHelper.Instance.ApplyBindingSettings(ItemForOutNumber, ItemBindingType.Required);
            //ERPHelper.Instance.ApplyBindingSettings(ItemForOutStoreCode, ItemBindingType.Required);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.wMSC104OutStoreBindingSource.EndEdit();
                this.wMSC105OutStoreDetailBindingSource.EndEdit();
                var outstoreDetailList = this.wMSC105OutStoreDetailBindingSource.DataSource as List<WMS_C105_OutStoreDetail>;
                this.outStoreService.Save(tempData, outstoreDetailList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void OutStoreEditForm_Load(object sender, EventArgs e)
        {
            CreateToolBar();
            this.gridOutStoreDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridOutStoreDetail_CellValueChanged);
        }

        void gridOutStoreDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Amount")
            {
                var outstoreDetailList = this.wMSC105OutStoreDetailBindingSource.DataSource as List<WMS_C105_OutStoreDetail>;
                //this.OutActualNumberSpinEdit.Value = outstoreDetailList.Sum(i => i.Amount);
            }
        }

        protected override void CreateToolBar()
        {
            ToolStripButton btnAdd = new ToolStripButton();
            btnAdd.Text = "转入出库单";
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
        }
        void btnDel_Click(object sender, EventArgs e)
        {
            var temp = this.wMSC105OutStoreDetailBindingSource.Current as WMS_C105_OutStoreDetail;
            outStoreService.MarkDeleteDetail(temp);
            this.wMSC105OutStoreDetailBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.wMSC104OutStoreBindingSource.EndEdit();
            //var tempData = this.wMSC102InStoreDetailBindingSource.DataSource as WMS_C101_InStore;
            // string jobNo = this.JobNoTextEdit.Text;
            //if (string.IsNullOrWhiteSpace(tempData.OutStoreCode))
            //{
            //    XtraMessageBox.Show("出库单号为空，请先输入出库单号");
            //    return;
            //}
            this.wMSC105OutStoreDetailBindingSource.AddNew();
            var tempDetail = this.wMSC105OutStoreDetailBindingSource.Current as WMS_C105_OutStoreDetail;
            tempDetail.OutStoreId = tempData.Id;
        }
    }
}
