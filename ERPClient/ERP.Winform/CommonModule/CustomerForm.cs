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
using ERP.Domain;
using COM.Service;
using COM.Domain;
using Util;
namespace ERP.Winform.CommonModule
{
    public partial class CustomerForm : ListForm
    {
        private ICustomerService customerService = Unity.Instance.GetService<ICustomerService>();
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        public CustomerForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            //左边树形-客户类别
            treeView1.Nodes.Clear();
            treeView1.ImageList = imageList1;
            treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseClick);


            TreeNode node = new TreeNode();
            node.Text = "全部";
            node.ImageIndex = 0;
            node.Tag = "全部";
            treeView1.Nodes.Add(node);
            var CustTypeList = customerService.GetCustomer().Select(a => a.CustType).Distinct().ToList();
            foreach (var custtype in CustTypeList)
            {
                TreeNode node2 = new TreeNode();
                node2.Text = custtype;
                node2.ImageIndex = 0;
                node2.Tag = custtype;
                node.Nodes.Add(node2);
            }
            treeView1.ExpandAll();
            this.eRPC003CustomerBindingSource.DataSource = customerService.GetCustomer().ToList();
            //this.gridView1.BestFitColumns();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string custtype = e.Node.Tag.ToStr();
            var CustomerData = customerService.GetCustomer();
            if (custtype != "全部")
                CustomerData = CustomerData.Where(a => a.CustType == custtype);
            this.eRPC003CustomerBindingSource.DataSource = CustomerData.ToList();
            this.gridView1.BestFitColumns();
            //gridView1_FocusedRowChanged(null, null);
        }
        
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPC003CustomerBindingSource.AddNew();
                OpenForm("客户资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("客户资料修改",BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_C003_Customer temp = eRPC003CustomerBindingSource.Current as ERP_C003_Customer;
                    customerService.Delete(temp.Id);
                    //eRPC003CustomerBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            ERP_C003_Customer temp = eRPC003CustomerBindingSource.Current as ERP_C003_Customer;
            CustomerEditForm edit = new CustomerEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPC003CustomerBindingSource.CancelEdit();
                InitData();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("客户资料查看", BtnCommandEnum.Watch);
        }
    }
}
