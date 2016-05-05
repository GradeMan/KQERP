using COM.Service;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP.Winform.WMS
{
    public partial class WMSMatConsumForm : ListForm
    {
        private IWMS_MatConsume_ActMatService matconsumeService = Unity.Instance.GetService<IWMS_MatConsume_ActMatService>();
        private IWMS_MatConsume_ActMatDetailService matconsumeDetailService = Unity.Instance.GetService<IWMS_MatConsume_ActMatDetailService>();
        private IWMS_MatConsume_ActMatMouthCheckService matconsumeMouthService = Unity.Instance.GetService<IWMS_MatConsume_ActMatMouthCheckService>();
        public WMSMatConsumForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {

            this.wMSMatConsumeActMatBindingSource.DataSource = matconsumeService.GetList();
        }

        private void gridMatConSum_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            WMS_MatConsume_ActMat temp = wMSMatConsumeActMatBindingSource.Current as WMS_MatConsume_ActMat;
            if (temp != null)
            {
                wMSMatConsumeActMatDetailBindingSource.DataSource = matconsumeDetailService.GetQuery().Where(a => a.StampingNo == temp.StampingNo).ToList();
                wMSMatConsumeActMatMouthCheckBindingSource.DataSource = matconsumeMouthService.GetQuery().Where(a => a.SuppCode == temp.StampingNo).ToList();
            }

        }
    }
}
