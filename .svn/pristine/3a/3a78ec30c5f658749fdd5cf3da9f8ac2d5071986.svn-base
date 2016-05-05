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
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Ribbon;
using Util;
using ERP.Service;
using DevExpress.XtraTabbedMdi;
using ERP.Domain;
using DevExpress.XtraBars.Helpers;
using ERP.Winform.SysModule.DashboardModules;
using COM.Winform.Controls;
namespace ERP.Winform.SysModule
{
    public partial class MainForm : RibbonForm
    {
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private Itb_Sys_ButtonService buttonService = Unity.Instance.GetService<Itb_Sys_ButtonService>();
        public MainForm()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadNavBarMenus();
            tb_Sys_User user = appCacheService.GetItem("user") as tb_Sys_User;
            barLoginUserName.Caption = user.UserName;
            barLoginTime.Caption = DateTime.Now.ToLocalTime().ToStr();
            if (nbgModules.ItemLinks.Count > 0)
            {
                tb_Sys_Menu menuInfo = nbgModules.ItemLinks[0].Item.Tag as tb_Sys_Menu;
                //OpenFirstMenu(menuInfo);
            }
        }
        /// <summary>
        /// 加载一级菜单
        /// </summary>
        private void LoadNavBarMenus()
        {
            List<tb_Sys_Menu> menus = appCacheService.GetItem("menus") as List<tb_Sys_Menu>;
            if (menus == null)
                return;
            foreach (var m in menus.Where(m => m.ParentMenuId == null).OrderBy(i=>i.SeqNo))
            {
                NavBarItem barItem = new NavBarItem();
                barItem.Caption = m.MenuName;//m.Element("MenuName").Value;
                barItem.LargeImage = ERPHelper.Instance.BufferToImage(m.MenuIcon);//m.Element("MenuIcon").Value;
                barItem.Tag = m;
                barItem.LinkClicked += new NavBarLinkEventHandler(barItem_LinkClicked);
                //navBarMain.Items.Add(barItem);
                nbgModules.ItemLinks.Add(barItem);
               // navBarMain.Refresh();
            }
            nbgModules.SelectedLinkIndex = 0;
        }
        /// <summary>
        /// 打开一级菜单页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void barItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           
            tb_Sys_Menu menuInfo = e.Link.Item.Tag as tb_Sys_Menu;
            OpenFirstMenu(menuInfo);
            
            //MessageBox.Show(e.Link.Item.Tag.ToString());
        }
        private void OpenFirstMenu(tb_Sys_Menu menuInfo)
        {
            if (menuInfo.MenuName.Trim() == "主页")
            {
                var form = this.MdiChildren.Where(i => i.Text == "主页").FirstOrDefault();
                if (form != null)
                {
                    this.xtraTabbedMdiManager1.SelectedPage = this.xtraTabbedMdiManager1.Pages[form];
                    return;
                }
                DashboardMain frmDashboard = new DashboardMain();
                frmDashboard.MdiParent = this;
                frmDashboard.Text = menuInfo.MenuName.Trim();
                frmDashboard.Show();
                //this.xtraTabbedMdiManager1.Pages[frmDashboard]
                return;
            }
            appCacheService.AddItem("ParentMenu", menuInfo);//当前一级菜单信息存入缓存
            string formText = menuInfo.MenuName;
            //if (SelecedTabByName(formText))
            //    return;
            var m = this.MdiChildren.Where(i => i.Name == "HomeForm").FirstOrDefault() as HomeForm;
            if (m != null)
            {
                m.IntitData();
                // m.WindowState = FormWindowState.Maximized;
                m.Text = formText;
                // m.Show();
                this.xtraTabbedMdiManager1.SelectedPage = this.xtraTabbedMdiManager1.Pages[m];
                return;
            }

            string nameSpece = menuInfo.NameSpeace;//ERP.Winform.SysModule.HomForm
            Type type = Type.GetType(nameSpece);
            if (type == null)
                throw new AppException("没有对应的窗体类型，创建失败");
            HomeForm obj = (HomeForm)Activator.CreateInstance(type);
            obj.Text = formText;
            obj.Name = "HomeForm";
            obj.IntitData();
            obj.OnShowDig += new HomeForm.del(obj_OnShowDig);
            obj.MdiParent = this;
            //obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
        /// <summary>
        /// 打开二级菜单页面
        /// </summary>
        /// <param name="menuInfo"></param>
        void obj_OnShowDig(Domain.tb_Sys_Menu menuInfo)
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
            obj.Tag = menuInfo.Id;
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

        private void barBtnCaluar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void barBtnTextBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void btnTianQi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //TianQiForm frm = new TianQiForm();
            //frm.Show();
        }

        private void btnKuaiDi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kuaidi frm = new kuaidi();
            frm.Show();
        }

        private void btnDasboardDesn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DashboardDesignerForm frm = new DashboardDesignerForm();
            frm.Show();
        }

        private void btnScreenCapturer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ScreenCapturer imageCapturer = new ScreenCapturer();
            imageCapturer.ShowDialog();
        }

        private void btnBackLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }
    }
}