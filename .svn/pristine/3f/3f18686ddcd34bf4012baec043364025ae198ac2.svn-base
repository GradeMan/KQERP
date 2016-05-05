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
using ERP.Service;
using COM.Service;
using ERP.Domain;
using ERP.Winform.Order.Report;
namespace ERP.Winform.Order
{
    public partial class JobListForm : ListForm
    {
        private IJobService jobService = Unity.Instance.GetService<IJobService>();
        public IJobReportService jobReportService = Unity.Instance.GetService<IJobReportService>();
        public JobListForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            mESM002JobBindingSource.DataSource = jobService.GetList();
            
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                mESM002JobBindingSource.AddNew();
                EditForm("工作单资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("工作单资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = mESM002JobBindingSource.Current as MES_M002_Job ;
                    jobService.Delete(temp.Id);
                    mESM002JobBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.PrintJobNo)
            {
                PrintJobNo();
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            MES_M002_Job temp = mESM002JobBindingSource.Current as MES_M002_Job;
            JobEditForm edit = new JobEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                mESM002JobBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("工作单资料查看", BtnCommandEnum.Watch);
            }
        }

        private void 打印报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintJobNo();
        }
        private void PrintJobNo()
        {
            MES_M002_Job temp = mESM002JobBindingSource.Current as MES_M002_Job;
            JobReportForm jobReportForm = new JobReportForm();
            jobReportForm.CreateReport(temp.JobNo, null);
            jobReportForm.Show();
        }
        public override void CreateToolBar(List<tb_Sys_Button> buttonList)
        {
            base.CreateToolBar(buttonList);
            OnAddToolBtn(BtnCommandEnum.PrintJobNo, (Image)ERP.Winform.Properties.Resources.ResourceManager.GetObject("note"));
        }
    }
}