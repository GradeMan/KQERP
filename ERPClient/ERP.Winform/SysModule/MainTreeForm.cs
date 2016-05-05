using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.Domain;
using DevExpress.XtraNavBar;
using COM.Service;
using ERP.Service;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using COM.Winform;
using Util;
using DevExpress.XtraTabbedMdi;

namespace ERP.Winform.SysModule
{
    public partial class MainTreeForm : DevExpress.XtraEditors.XtraForm
    {
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private Itb_Sys_ButtonService buttonService = Unity.Instance.GetService<Itb_Sys_ButtonService>();
        public MainTreeForm()
        {

            InitializeComponent();
            LoadNavBarMenus();
        }
        /// <summary>
        /// 加载一级菜单
        /// </summary>
        private void LoadNavBarMenus()
        {
            //ImageList imageList = new ImageList();
           // imageList.Images.Add("")
            List<tb_Sys_Menu> menus = appCacheService.GetItem("menus") as List<tb_Sys_Menu>;
            if (menus == null)
                return;
            foreach (var m in menus.Where(m => m.ParentMenuId == null).OrderBy(i => i.SeqNo))
            {
                NavBarGroup navGroup = new NavBarGroup();
                navGroup.Caption = m.MenuName;
                navGroup.SmallImage = ERPHelper.Instance.BufferToImage(m.MenuIcon);
                navGroup.Tag = m;
                this.navBarControl1.Groups.Add(navGroup);
                //DevExpress.XtraEditors.DateControl dc = new DevExpress.XtraEditors.DateControl();
                //TreeList treeList = new TreeList();
                //treeList.lis
                TreeView treeView = new TreeView();
                treeView.ImageList = this.imageList1;
                treeView.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(treeView_NodeMouseDoubleClick);
                navGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
                //navGroup.ControlContainer = new NavBarGroupControlContainer();
                navGroup.ControlContainer.Controls.Add(treeView);
                navGroup.ControlContainer.Height = treeView.Height + 3;
               // treeList.Dock = DockStyle.Fill;
               // treeList.OptionsView.ShowColumns = false;
                treeView.Dock = DockStyle.Fill;
                menus.Where(a => a.ParentMenuId == m.Id).OrderBy(a=>a.SeqNo).ToList().ForEach(a =>
                    {
                        TreeNode node = new TreeNode();
                        node.Text = a.MenuName;
                        node.ImageIndex = 0;
                        node.Tag = a;
                        treeView.Nodes.Add(node);
                        NextNode(node, a.Id);
                       // TreeListNode node2 = new TreeListNode();
                        
                    });          
               //navGroup.GroupClientHeight = treeList.Height+3;
               treeView.ExpandAll();
            }
           
        }
        private void NextNode(TreeNode preNoede,Guid id)
        {
            List<tb_Sys_Menu> menus = appCacheService.GetItem("menus") as List<tb_Sys_Menu>;
            menus.Where(a => a.ParentMenuId == id).OrderBy(a => a.SeqNo).ToList().ForEach(a =>
            {
                TreeNode node = new TreeNode();
                node.Text = a.MenuName;
                node.ImageIndex = 0;
                node.Tag = a;
                preNoede.Nodes.Add(node);
                NextNode(node, a.Id);
                // TreeListNode node2 = new TreeListNode();
            });       
        }
        void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tb_Sys_Menu menuInfo = e.Node.Tag as tb_Sys_Menu;
            if (menuInfo != null && !string.IsNullOrEmpty(menuInfo.NameSpeace))
                OpenMenu(menuInfo);
        }

        private void OpenMenu(tb_Sys_Menu menuInfo)
        {
            if (SelecedTabByName(menuInfo.MenuName))
                return;
            //var m = this.MdiChildren.Where(i => i.Text ==menuInfo.MenuName).FirstOrDefault();
            //if (m != null)
            //{
            //    //m.WindowState = FormWindowState.Maximized;
            //    m.Show();
            //    return;
            //}
            if (string.IsNullOrWhiteSpace(menuInfo.NameSpeace))
                return;
            if (menuInfo.MenuName == "权限管理")
            {
                A004_RoleControl frm = new A004_RoleControl();
                frm.MdiParent = this;
                frm.Text = menuInfo.MenuName;
                frm.Show();
                return;
            }
            Type type = Type.GetType(menuInfo.NameSpeace);
            if (type == null)
                throw new AppException("没有对应的窗体类型，创建失败");
            ListForm obj = (ListForm)Activator.CreateInstance(type);
            tb_Sys_Roles rolesData = appCacheService.GetItem("roles") as tb_Sys_Roles;
            //Guid roleId = rolesDataXml.Element("Id").Value.ToGuid();
            var buttonList = buttonService.GetButtonsByMenu(menuInfo.Id, rolesData.Id);
            obj.Text = menuInfo.MenuName;
            obj.Tag = menuInfo;
            obj.CreateToolBar(buttonList);
            obj.MdiParent = this;
            //obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            //obj.ShowDig(this,menuInfo.MenuName);
        }
        private bool SelecedTabByName(string menuName)
        {
            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                if (page.Text == menuName)
                {
                    this.xtraTabbedMdiManager1.SelectedPage = page;
                    return true;
                }
            }
            return false;
        }

        private void MainTreeForm_Load(object sender, EventArgs e)
        {
            this.Text = "MES管理系统 (" + appCacheService.GetItem("CompName") as string + ")" ;
            tb_Sys_User user = appCacheService.GetItem("user") as tb_Sys_User;
            labUserName.Text = "用户名:" + user.UserName;
            labLoginTime.Text = "登录时间:" + DateTime.Now.ToString();
        }
    }
}