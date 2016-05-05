using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP.Service;
using ERP.Domain;
using Util;
using COM.Service;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.DocumentServices.ServiceModel.DataContracts.Xpf.Designer;
using DevExpress.Data.Filtering;
using System.Reflection;
using COM.Domain;
namespace ERP.Winform
{
    public partial class Form1 : Form
    {
        private Itb_Sys_UserService sysUserService = Unity.Instance.GetService<Itb_Sys_UserService>();
       // private tb_Sys_User user;
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IJobReportService jobReport = Unity.Instance.GetService<IJobReportService>();
        public Form1()
        {
            InitializeComponent();
            FTPHelper hh = new FTPHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //var userList = sysUserService.Gettb_Sys_UserList().Select(i => new { i.UserCode, i.UserName }).ToList();
           //comboBoxEdit1.DataBindings.Add("")
           //comboBoxEdit1.Properties.dis
            //var q = this.jobReport.GetByItemNo("001");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
          // ToolTipController
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new AppException("字段错误");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //RepositoryItemCustomGridLookUpEdit.RegisterCustomGridLookUpEdit();
           // RepositoryItemLookUpEdit
            var userList = codeService.GetList().Select(i => new { i.Code,i.Description,i.CodeID,i.CodeIDDesc}).ToList();
            eRPC001CodeBindingSource1.DataSource = userList;
            comboBoxEdit1.Properties.Items.AddRange(userList.Select(i=>i.Description).ToList());
            var dataList =  codeService.GetList().Select(i=>new InputItem{ DisPlayName=i.Description, Value = i.Code, InputCode1 = i.CodeIDDesc,InputCode2 =i.CodeID}).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(gridLookUpEdit3, dataList,2);
            gridLookUpEdit3.EditValueChanging += new ChangingEventHandler(gridLookUpEdit3_EditValueChanging);
            add();
            //gridLookUpEdit3.ProcessNewValue += new ProcessNewValueEventHandler(gridLookUpEdit3_ProcessNewValue);
            this.gridLookUpEdit2.Properties.DataSource = dataList;
            gridLookUpEdit2.Properties.DisplayMember = "DisPlayName";
            gridLookUpEdit2.Properties.ValueMember = "Code";
            ykGridLookUpEdit3.Properties.DataSource = userList;
            ykGridLookUpEdit4.Properties.DataSource = dataList;
        }

        void gridLookUpEdit3_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            string displayName = gridLookUpEdit3.Properties.DisplayMember;
            string valueName = gridLookUpEdit3.Properties.ValueMember;
            string display = e.DisplayValue.ToString();

            DataTable dtTemp = gridLookUpEdit3.Properties.DataSource as DataTable;
            if (dtTemp != null)
            {
                DataRow[] selectedRows = dtTemp.Select(string.Format("{0}='{1}'", displayName, display.Replace("'", "‘")));
                if (selectedRows == null || selectedRows.Length == 0)
                {
                    DataRow row = dtTemp.NewRow();
                    row[displayName] = display;
                    row[valueName] = display;
                    dtTemp.Rows.Add(row);
                    dtTemp.AcceptChanges();
                }
            }

            e.Handled = true;
        }

        void gridLookUpEdit3_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }

        private void add()
        {

            this.gridLookUpEdit2.Properties.View.OptionsBehavior.AutoPopulateColumns = false;


            GridColumn col1 = this.gridLookUpEdit2.Properties.View.Columns.AddField("DisPlayName");
            col1.VisibleIndex = 0;
            col1.Caption = "助记码";
            GridColumn col2 = this.gridLookUpEdit2.Properties.View.Columns.AddField("InputCode1");
            col2.VisibleIndex = 1;
            col2.Caption = "描述";
            GridColumn col3 = this.gridLookUpEdit2.Properties.View.Columns.AddField("InputCode2");
            col3.VisibleIndex = 1;
            col3.Caption = "描述";
            this.gridLookUpEdit2.EditValueChanging += new ChangingEventHandler(gridLookUpEdit2_EditValueChanging);
            this.gridLookUpEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.gridLookUpEdit2.Properties.View.BestFitColumns();
            this.gridLookUpEdit2.Properties.ShowFooter = false;
            this.gridLookUpEdit2.Properties.View.OptionsView.ShowAutoFilterRow = false;
            this.gridLookUpEdit2.Properties.AutoComplete = false;
            this.gridLookUpEdit2.Properties.ImmediatePopup = true;
            this.gridLookUpEdit2.Properties.PopupFilterMode = PopupFilterMode.Contains;
            this.gridLookUpEdit2.Properties.TextEditStyle = TextEditStyles.Standard;
            this.gridLookUpEdit2.Properties.View.OptionsView.ShowColumnHeaders = false;
        }

        void gridLookUpEdit2_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                FilterLookup(sender);
            }));
        }
        private void FilterLookup(object sender)
        {

            GridLookUpEdit edit = sender as GridLookUpEdit;
            GridView gridView = edit.Properties.View as GridView;
            System.Reflection.FieldInfo fi = gridView.GetType().GetField("extraFilter", BindingFlags.NonPublic | BindingFlags.Instance);
            BinaryOperator op1 = new BinaryOperator("DisPlayName", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            BinaryOperator op2 = new BinaryOperator("InputCode1", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            BinaryOperator op3 = new BinaryOperator("InputCode2", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            string filterCondition = new GroupOperator(GroupOperatorType.Or, new CriteriaOperator[] { op1, op2,op3 }).ToString();
            fi.SetValue(gridView, filterCondition);

            MethodInfo mi = gridView.GetType().GetMethod("ApplyColumnsFilterEx", BindingFlags.NonPublic | BindingFlags.Instance);
            mi.Invoke(gridView, null);
        }

    }
}
