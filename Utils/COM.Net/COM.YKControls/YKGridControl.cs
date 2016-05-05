using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;

namespace COM.YKControls
{
    public partial class YKGridControl : GridControl
    {
        public YKGridControl()
        {
            InitializeComponent();
            this.UseEmbeddedNavigator = true;
            this.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.EmbeddedNavigator.Buttons.Remove.Visible = false;
            //this.DataSourceChanged += new EventHandler(YKGridControl_DataSourceChanged);
            this.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.Dock = DockStyle.Fill;
            GridView ykgridview = this.DefaultView as GridView;
            ykgridview.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            ykgridview.OptionsView.ShowGroupPanel = false;
            ykgridview.OptionsView.EnableAppearanceEvenRow = true;
            ykgridview.OptionsFind.AlwaysVisible = true;
            //ykgridview.CustomDrawRowIndicator +=new RowIndicatorCustomDrawEventHandler(ykgridview_CustomDrawRowIndicator);
            ykgridview.IndicatorWidth = 40;
            ykgridview.OptionsView.ColumnAutoWidth = false;
            ykgridview.OptionsBehavior.ReadOnly = true;

            
        }

        //void YKGridControl_DataSourceChanged(object sender, EventArgs e)
        //{
        //    GridView ykgridview = this.DefaultView as GridView;
        //    ykgridview.BestFitColumns();
        //}
        //protected override DevExpress.XtraGrid.Views.Base.BaseView CreateDefaultView()
        //{
        //    //ToolTipController toolTip = new DevExpress.Utils.ToolTipController();
        //   // toolTip.GetActiveObjectInfo += new ToolTipControllerGetActiveObjectInfoEventHandler(toolTip_GetActiveObjectInfo);
        //    GridView ykgridview = base.CreateDefaultView() as GridView;
            
        //   // ykgridview.DataSourceChanged += new EventHandler(ykgridview_DataSourceChanged);
        //    ykgridview.Name = "ykgridview";
        //    return ykgridview;
        //}

        //void ykgridview_DataSourceChanged(object sender, EventArgs e)
        //{
        //    GridView ykgridview = sender as GridView;
        //    ykgridview.BestFitColumns();
        //}
        protected override void OnLoaded()
        {
            base.OnLoaded();
            GridView ykgridview = this.DefaultView as GridView;
            ykgridview.Appearance.OddRow.BackColor = Color.White;  // 设置奇数行颜色 // 默认也是白色 可以省略 
            ykgridview.OptionsView.EnableAppearanceOddRow = true;   // 使能 // 和和上面绑定 同时使用有效 
            ykgridview.Appearance.EvenRow.BackColor = Color.FromArgb(220,234,250); // 设置偶数行颜色 WhiteSmoke
            ykgridview.OptionsView.EnableAppearanceEvenRow = true;   // 使能 // 和和上面绑定 同时使用有效
            ykgridview.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(ykgridview_CustomDrawRowIndicator);

            
        }
        void ykgridview_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                else if (e.RowHandle < 0 && e.RowHandle > -1000)
                {
                    e.Info.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle.ToString();
                }
            }
        }
    }
}
