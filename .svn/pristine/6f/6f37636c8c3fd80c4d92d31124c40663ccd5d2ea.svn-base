using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using ERP.Service;
using ERP.Domain;
using COM.Service;
namespace ERP.Winform.Order
{
    public partial class PlanJobEditForm : EditForm
    {
        private bool m_checkStatus = false;
        private IJobService jobservice = Unity.Instance.GetService<IJobService>();
        public PlanJobEditForm()
        {
            InitializeComponent();
        }
        protected override void InitData()
        {
            this.gridView1.Click += new EventHandler(gridView1_Click);
            this.gridView1.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(gridView1_CustomDrawColumnHeader);
            this.gridView1.DataSourceChanged += new EventHandler(gridView1_DataSourceChanged);
           this.gridControl1.DataSource = jobservice.GetJobLotListByJobNo("J0001");
           this.gridControl2.DataSource = new List<MES_M004_PlanJob>();
        }

        void gridView1_DataSourceChanged(object sender, EventArgs e)
        {
            GridColumn column =
 this.gridView1.Columns.ColumnByFieldName("CheckBox");
            if (column != null)
            {
                column.Width = 80;
                column.OptionsColumn.ShowCaption = false;
                column.ColumnEdit = new RepositoryItemCheckEdit();
            } 

        }

        void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == "CheckBox")
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                ERPHelper.DrawCheckBox(e, m_checkStatus);
                e.Handled = true;
            } 

        }

        void gridView1_Click(object sender, EventArgs e)
        {
            if (ERPHelper.ClickGridCheckBox(this.gridView1, "CheckBox", m_checkStatus))
            {
                m_checkStatus = !m_checkStatus;
            } 

        }

        private void btnGoFord_Click(object sender, EventArgs e)
        {
            List<MES_M002_Job_Lot> jobLotList = this.gridControl1.DataSource as List<MES_M002_Job_Lot>;
            var goList = jobLotList.Where(i => i.CheckBox == true).Select(i=> new MES_M004_PlanJob()
                {
                     JobNo = i.JobNo,
                     LotNo = i.LotNo,
                     PlanDt = datePlan.DateTime.Date
                }).ToList();
            var PlanJob = this.gridControl2.DataSource as List<MES_M004_PlanJob>;
            PlanJob.AddRange(goList);
            this.gridControl2.DataSource = PlanJob;
            this.gridControl2.RefreshDataSource();
            //this.gridView1.
        }
    }
}
