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
using COM.Service;
using System.Xml.Linq;
using Util;
using ERP.Service;
using ERP.Domain;
namespace ERP.Winform.SysModule
{
    public partial class HomeForm : XtraForm
    {
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private Itb_Sys_MenuService menuService = Unity.Instance.GetService<Itb_Sys_MenuService>();
        public delegate void del(tb_Sys_Menu menuInfo);
        public event del OnShowDig;
        public HomeForm()
        {
            InitializeComponent();
            winExplorerView1.ItemDoubleClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventHandler(winExplorerView1_ItemDoubleClick);
            winExplorerView1.KeyDown += new KeyEventHandler(winExplorerView1_KeyDown);
        }

        void winExplorerView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            ShowDig();
        }

        void winExplorerView1_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventArgs e)
        {
            if (e.MouseInfo.Button != MouseButtons.Left) return;
            ShowDig();
            //int row = winExplorerView1.GetSelectedRows()[0];
            //tb_Sys_Menu menu = winExplorerView1.GetRow(row) as tb_Sys_Menu;
            //MessageBox.Show(menu.NameSpeace);
        }
        public void IntitData()
        {
            tb_Sys_Menu menuInfo = appCacheService.GetItem("ParentMenu") as tb_Sys_Menu;
            tb_Sys_Roles role = appCacheService.GetItem("roles") as tb_Sys_Roles;
            //Guid MenuId =
            gridControl1.DataSource = menuService.GetMenusByRoleId(role.Id).Where(i=>i.ParentMenuId == menuInfo.Id).OrderBy(i=>i.SeqNo);
        }
        /// <summary>
        /// 双击打开页面
        /// </summary>
        private void ShowDig()
        {
            int row = winExplorerView1.GetSelectedRows()[0];
            tb_Sys_Menu menu = winExplorerView1.GetRow(row) as tb_Sys_Menu;
            if (OnShowDig != null)
                OnShowDig(menu);
        }
    }
}