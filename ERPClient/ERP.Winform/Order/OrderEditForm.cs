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
using DevExpress.XtraTab;
using ERP.Winform.Properties;
namespace ERP.Winform.Order
{
    public partial class OrderEditForm : EditForm
    {
        private IOrderService orderService = Unity.Instance.GetService<IOrderService>();
        private MES_M001_Order orderData;
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public OrderEditForm(MES_M001_Order orderData)
        {
            InitializeComponent();
            this.orderData = orderData;
            //this.mESM001OrderDetailBindingSource.DataSource = 
        }
        protected override void InitData()
        {
            this.mESM001OrderBindingSource.DataSource = orderData;
            this.mESM001OrderDetailBindingSource.DataSource = orderService.GetOrderDetailByOrderNo(orderData.OrdNo);
            ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("BC"), 2);//班次
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForOrdNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForOrdNo, ItemBindingType.Upper);
            ERPHelper.Instance.ApplyBindingSettings(ItemForCustCode, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                mESM001OrderBindingSource.EndEdit();
                mESM001OrderDetailBindingSource.EndEdit();
                var orderDetailList = this.mESM001OrderDetailBindingSource.DataSource as List<MES_M001_Order_Detail>;
                this.orderService.Save(orderData, orderDetailList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            CreateToolBar();
        }
        private void CreateToolBar()
        {
            XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
            foreach (var contr in page.Controls)
            {
                if (contr is ToolStrip)
                    return;
            }
            ToolStrip toolStrip = new ToolStrip();
            ToolStripButton btnAdd = new ToolStripButton();
            btnAdd.Text = "新增";
            btnAdd.Image = (Image)Resources.ResourceManager.GetObject("edit_add");
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnAdd.Click += new EventHandler(btnAdd_Click);
            toolStrip.Items.Add(btnAdd);
            ToolStripSeparator toolSep = new ToolStripSeparator();
            toolStrip.Items.Add(toolSep);
            ToolStripButton btnDel = new ToolStripButton();
            btnDel.Text = "删除";
            btnDel.Image = (Image)Resources.ResourceManager.GetObject("cancel");
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnDel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDel.Click += new EventHandler(btnDel_Click);
            toolStrip.Items.Add(btnDel);
            toolStrip.Dock = DockStyle.Top;
            toolStrip.BringToFront();
            page.Controls.Add(toolStrip);
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            var temp = mESM001OrderDetailBindingSource.Current as MES_M001_Order_Detail;
            orderService.MarkDelOrderDetail(temp.Id);
            mESM001OrderDetailBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.mESM001OrderBindingSource.EndEdit();
            var orderData = this.mESM001OrderBindingSource.DataSource as MES_M001_Order;
            // string jobNo = this.JobNoTextEdit.Text;
            if (string.IsNullOrWhiteSpace(orderData.OrdNo))
            {
                XtraMessageBox.Show("订单编号为空，请先输入订单编号");
                return;
            }
            mESM001OrderDetailBindingSource.AddNew();
            var orderDetail = this.mESM001OrderDetailBindingSource.Current as MES_M001_Order_Detail;
            orderDetail.OrdNo = orderData.OrdNo;
        }
    }
}