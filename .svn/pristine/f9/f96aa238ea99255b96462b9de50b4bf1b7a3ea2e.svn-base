using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
namespace COM.YKControls
{
    
    /// <summary>
    /// 自定义的GridLookUpEdit控件
    /// </summary>
    public partial class YKGridLookUpEdit : GridLookUpEdit
    {
        /// <summary>
        /// 是否禁止新增内容
        /// </summary>
        [Browsable(true), Description("是否禁止新增内容")]
        public bool DisableAddNew { get; set; }

        [Browsable(true), Description("注释码个数")]
        public int InputItemCount { get; set; }

        //static CustomGridLookUpEdit()
        //{
        //    RepositoryItemCustomGridLookUpEdit.RegisterCustomGridLookUpEdit();
        //}
        public YKGridLookUpEdit()
            : base()
        {
            //初始化一些状态
            this.Properties.View.OptionsBehavior.AutoPopulateColumns = true;
            this.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Properties.View.BestFitColumns();
            this.Properties.ShowFooter = false;
            this.Properties.View.OptionsView.ShowAutoFilterRow = false;
            this.Properties.AutoComplete = false;
            this.Properties.ImmediatePopup = true;
            this.Properties.PopupFilterMode = PopupFilterMode.Contains;
            this.Properties.TextEditStyle = TextEditStyles.Standard;
            this.Properties.DisplayMember = "DisPlayName";
            this.Properties.ValueMember = "Value";
            GridColumn col1 = this.Properties.View.Columns.AddField("DisPlayName");
            col1.VisibleIndex = 0;
            col1.Caption = "描述";
            for (int i = 1; i <= InputItemCount; i++)
            {
                GridColumn col = this.Properties.View.Columns.AddField("InputCode" + i);
                col.VisibleIndex = i;
                col.Caption = "记住码" + i;
            }
            //this.Properties.View.
            this.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(CustomGridLookUpEdit_ProcessNewValue);
        }

        /// <summary>
        /// 实现在列表没有记录的时候，可以录入一个不存在的记录，类似ComoboEidt功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomGridLookUpEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (!DisableAddNew && !this.DesignMode)
            {
                string displayName = this.Properties.DisplayMember;
                string valueName = this.Properties.ValueMember;
                string display = e.DisplayValue.ToString();

                DataTable dtTemp = this.Properties.DataSource as DataTable;
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
        }
    }
}
