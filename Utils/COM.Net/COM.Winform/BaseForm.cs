using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Domain;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using System.Reflection;

namespace COM.Winform
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        #region 下拉菜单设置 + SetGridLookUpEdit(GridLookUpEdit ykgridLookUp, List<InputItem> listData, int inputitemCount)
        /// <summary>
        /// 设置GridLookUpEdit下拉列表
        /// </summary>
        /// <param name="ykgridLookUp"></param>
        /// <param name="listData">查询数据源</param>
        /// <param name="inputitemCount">记住码个数</param>
        public void SetGridLookUpEdit(GridLookUpEdit ykgridLookUp, List<InputItem> listData, int inputitemCount, bool IsNewValue = true)
        {
            ykgridLookUp.Properties.View.Columns.Clear();
            ykgridLookUp.Properties.DataSource = listData;
            //初始化一些状态
            GridColumn col1 = ykgridLookUp.Properties.View.Columns.AddField("DisPlayName");
            col1.VisibleIndex = 0;
            col1.Caption = "描述";
            for (int i = 1; i <= inputitemCount; i++)
            {
                GridColumn col = ykgridLookUp.Properties.View.Columns.AddField("InputCode" + i);
                col.VisibleIndex = i;
                col.Caption = "记住码" + i;
            }
            ykgridLookUp.Properties.NullText = "";
            ykgridLookUp.Properties.View.OptionsBehavior.AutoPopulateColumns = true;
            ykgridLookUp.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            //ykgridLookUp.Properties.View.OptionsBehavior.
            ykgridLookUp.Properties.View.BestFitColumns();
            ykgridLookUp.Properties.ShowFooter = true;
            ykgridLookUp.Properties.View.OptionsView.ShowAutoFilterRow = false;
            ykgridLookUp.Properties.AutoComplete = false;
            ykgridLookUp.Properties.ImmediatePopup = true;
            ykgridLookUp.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            ykgridLookUp.Properties.PopupFilterMode = PopupFilterMode.Contains;
            ykgridLookUp.Properties.TextEditStyle = TextEditStyles.Standard;
            ykgridLookUp.Properties.DisplayMember = "DisPlayName";
            ykgridLookUp.Properties.ValueMember = "Value";
            ykgridLookUp.EditValueChanging += new ChangingEventHandler(ykgridLookUp_EditValueChanging);
            if (IsNewValue)
                ykgridLookUp.ProcessNewValue += new ProcessNewValueEventHandler(ykgridLookUp_ProcessNewValue);
        }


        /// <summary>
        /// 新的下拉菜单
        /// </summary>
        /// <param name="ykgridLookUp"></param>
        /// <param name="displayName"></param>
        /// <param name="valueName"></param>
        public virtual void SetGridLookUpEdit(RepositoryItemGridLookUpEdit ykgridLookUp, List<InputItem> listData, int inputitemCount = 1)
        {
            ykgridLookUp.View.Columns.Clear();
            ykgridLookUp.DataSource = listData.OrderBy(a => a.Value).ToList();
            //初始化一些状态
            GridColumn col1 = ykgridLookUp.View.Columns.AddField("DisPlayName");
            col1.VisibleIndex = 0;
            col1.Caption = "描述";
            for (int i = 1; i <= inputitemCount; i++)
            {
                GridColumn col = ykgridLookUp.View.Columns.AddField("InputCode" + i);
                col.VisibleIndex = i;
                col.Caption = "代号" + i;
            }
            ykgridLookUp.NullText = "";
            ykgridLookUp.View.OptionsBehavior.AutoPopulateColumns = false;
            ykgridLookUp.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            ykgridLookUp.View.BestFitColumns();
            ykgridLookUp.ShowFooter = true;
            ykgridLookUp.View.OptionsView.ShowAutoFilterRow = false;
            ykgridLookUp.AutoComplete = false;
            ykgridLookUp.ImmediatePopup = true;
            ykgridLookUp.PopupFilterMode = PopupFilterMode.Contains;
            ykgridLookUp.TextEditStyle = TextEditStyles.Standard;
            ykgridLookUp.DisplayMember = "DisPlayName";
            ykgridLookUp.ValueMember = "Value";
            ykgridLookUp.View.BestFitColumns();
            ykgridLookUp.BestFitMode = BestFitMode.BestFitResizePopup;
            ykgridLookUp.EditValueChanging += ykgridLookUp_EditValueChanging;

        }

        /// <summary>
        /// 2016-01-28更新，可以使用中文表头，实现定制化
        /// </summary>
        /// <param name="ykgridLookUp"></param>
        /// <param name="displayName"></param>
        /// <param name="valueName"></param>
        public virtual void SetGridLookUpEdit(GridLookUpEdit ykgridLookUp, dynamic listData, string displayMember, string valueMember)
        {
            ykgridLookUp.Properties.View.Columns.Clear();
            ykgridLookUp.Properties.DataSource = listData;
            ykgridLookUp.Properties.NullText = "";
            ykgridLookUp.Properties.View.OptionsBehavior.AutoPopulateColumns = true;
            ykgridLookUp.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            //ykgridLookUp.Properties.View.OptionsBehavior.
            ykgridLookUp.Properties.View.BestFitColumns();
            ykgridLookUp.Properties.ShowFooter = true;
            ykgridLookUp.Properties.View.OptionsView.ShowAutoFilterRow = false;
            ykgridLookUp.Properties.AutoComplete = false;
            ykgridLookUp.Properties.ImmediatePopup = true;
            ykgridLookUp.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            ykgridLookUp.Properties.PopupFilterMode = PopupFilterMode.Contains;
            ykgridLookUp.Properties.TextEditStyle = TextEditStyles.Standard;
            ykgridLookUp.Properties.DisplayMember = displayMember;
            ykgridLookUp.Properties.ValueMember = valueMember;
            ykgridLookUp.EditValueChanging += new ChangingEventHandler(ykgridLookUp_EditValueChanging);
            // if (IsNewValue)
            //  ykgridLookUp.ProcessNewValue += new ProcessNewValueEventHandler(ykgridLookUp_ProcessNewValue);

        }

        void ykgridLookUp_EditValueChanging(object sender, ChangingEventArgs e)
        {
            GridLookUpEdit ykgridLookUp = sender as GridLookUpEdit;
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                FilterLookup(sender);
            }));
        }

        void ykgridLookUp_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            GridLookUpEdit ykgridLookUp = sender as GridLookUpEdit;
            string displayName = ykgridLookUp.Properties.DisplayMember;
            string valueName = ykgridLookUp.Properties.ValueMember;
            string display = e.DisplayValue.ToString();

            List<InputItem> listData = ykgridLookUp.Properties.DataSource as List<InputItem>;
            if (listData != null)
            {

                int dataCount = listData.Where(i => i.DisPlayName == display).Count();
                if (dataCount == 0)
                {
                    InputItem item = new InputItem { DisPlayName = display, Value = display };
                    listData.Add(item);
                    ykgridLookUp.EditValue = display;
                }
            }
        }

        public void FilterLookup(object sender)
        {
            GridLookUpEdit edit = sender as GridLookUpEdit;

            GridView gridView = edit.Properties.View as GridView;
            System.Reflection.FieldInfo fi = gridView.GetType().GetField("extraFilter", BindingFlags.NonPublic | BindingFlags.Instance);
            var columnsList = gridView.Columns.ToList();
            List<CriteriaOperator> cpList = new List<CriteriaOperator>();
            foreach (var columns in columnsList)
            {
                BinaryOperator op1 = new BinaryOperator(columns.FieldName, "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
                cpList.Add(op1);
            }
            string filterCondition = new GroupOperator(GroupOperatorType.Or, cpList).ToString();
            //BinaryOperator op1 = new BinaryOperator("InputCode1", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            //BinaryOperator op2 = new BinaryOperator("InputCode2", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            //BinaryOperator op3 = new BinaryOperator("InputCode3", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            //BinaryOperator op4 = new BinaryOperator("Value", "%" + edit.AutoSearchText + "%", BinaryOperatorType.Like);
            //string filterCondition = new GroupOperator(GroupOperatorType.Or, new CriteriaOperator[] { op1, op2, op3 }).ToString();
            fi.SetValue(gridView, filterCondition);

            MethodInfo mi = gridView.GetType().GetMethod("ApplyColumnsFilterEx", BindingFlags.NonPublic | BindingFlags.Instance);
            mi.Invoke(gridView, null);
        }

        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            try
            {
                //判D断?是?否?是?按恪?下?回?车μ键ü
                if (msg.Msg == 256 && keyData == Keys.Enter)
                {
                    //发ぁ?送ítab 
                    SendKeys.Send("{tab}");
                    return true;
                }
                return base.ProcessCmdKey(ref msg, keyData);
            }
            catch
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }


        }
        #endregion
    }
}