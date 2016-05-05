using COM.Service;
using COM.Winform;
using DevExpress.XtraGrid.Views.Grid;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP.Winform.MES
{
    public partial class PackingMainForm : ListForm
    {
        private IERP_M002_BOMService bomService = Unity.Instance.GetService<IERP_M002_BOMService>();

        public PackingMainForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        public override void InitData()
        {
            
        }
        /// <summary>
        /// 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //扫描
            if (e.Item.Caption == "扫描")
            {
               
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
