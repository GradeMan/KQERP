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
    public partial class EmployeeForm : ListForm
    {
        private IEmployeeService employeeService = Unity.Instance.GetService<IEmployeeService>();
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        public EmployeeForm()
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
            var DeparmentList = employeeService.GetEmployee().Select(a => a.DeptCode).Distinct().ToList();
            foreach (var department in DeparmentList)
            {
                TreeNode node2 = new TreeNode();
                node2.Text = department;
                node2.ImageIndex = 0;
                node2.Tag = department;
                node.Nodes.Add(node2);
            }
            treeView1.ExpandAll();
            this.eRPC005EmployeeBindingSource.DataSource = employeeService.GetEmployee().ToList();
            //this.gridView1.BestFitColumns();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string department = e.Node.Tag.ToStr();
            var EmployeeData = employeeService.GetEmployee();
            if (department != "全部")
                EmployeeData = EmployeeData.Where(a => a.DeptCode == department);
            this.eRPC005EmployeeBindingSource.DataSource = EmployeeData.ToList();
            this.gridView1.BestFitColumns();
            //gridView1_FocusedRowChanged(null, null);
        }
        
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPC005EmployeeBindingSource.AddNew();
                OpenForm("员工资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("员工资料修改",BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_C005_Employee temp = eRPC005EmployeeBindingSource.Current as ERP_C005_Employee;
                    employeeService.Delete(temp.Id);
                    //eRPC003CustomerBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            ERP_C005_Employee temp = eRPC005EmployeeBindingSource.Current as ERP_C005_Employee;
            EmployeeEditForm edit = new EmployeeEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPC005EmployeeBindingSource.CancelEdit();
                InitData();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("员工资料查看", BtnCommandEnum.Watch);
        }
    }
}
