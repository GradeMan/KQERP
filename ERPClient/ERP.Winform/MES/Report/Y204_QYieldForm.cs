using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;
namespace ERP.Winform.MES.Report
{
    public partial class Y204_QYieldForm : ListForm
    {
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public Y204_QYieldForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            txtProdDt1.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtProdDt2.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            ShowData();
        }

        public void ShowData()
        {
            DateTime lbStart;
            DateTime lbEnd;
            try
            {
                lbStart = txtProdDt1.DateTime.Date;
                lbEnd = txtProdDt2.DateTime.Date;
                if (lbStart > lbEnd)
                {
                    XtraMessageBox.Show("结束时间不能大于开始时间,请检查");
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("输入的时间格式不正确，请查阅");
                return;
            }

            this.pivotGridControl1.DataSource = viewService.GetQYield(lbStart, lbEnd);
            this.pivotGridControl1.BestFit();
            //this.gridView1.BestFitColumns();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e)
        {
            //Rectangle r;
            //if (e.RowValueType == PivotGridValueType.GrandTotal)
            //{
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.LightBlue,
            //        Color.FromArgb(0x00, 0x66, 0xFF), LinearGradientMode.Vertical), e.Bounds);
            //    r = Rectangle.Inflate(e.Bounds, -3, -3);
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(0x00, 0x66, 0xFF),
            //        Color.LightSkyBlue, LinearGradientMode.Vertical), r);
            //    e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
            //        new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
            //    e.Handled = true;
            //    return;
            //}
            //if (e.RowValueType == PivotGridValueType.Total)
            //{
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.LightBlue,
            //        Color.FromArgb(0x33, 0x66, 0xFF), LinearGradientMode.Vertical), e.Bounds);
            //    r = Rectangle.Inflate(e.Bounds, -3, -3);
            //    e.GraphicsCache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(0x33, 0x66, 0xFF),
            //        Color.LightSkyBlue, LinearGradientMode.Vertical), r);
            //    e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font,
            //        new SolidBrush(Color.White), r, e.Appearance.GetStringFormat());
            //    e.Handled = true;
            //    return;
            //}
        }

        private void pivotGridControl1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {
            decimal firstn = 0;
            decimal sumn = 0;
            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
            if (e.DataField == pivotGridField13)
            { //冲压报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField9]);//冲压投入
                    sumn += Convert.ToDecimal(row[fieldPNGQtyInK1]);//冲压报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == pivotGridField14)
            { //电镀报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField10]);//投入
                    sumn += Convert.ToDecimal(row[fieldENGQtyInK1]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == pivotGridField15)
            { //切断报废率pivotGridField19
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField11]);//投入
                    sumn += Convert.ToDecimal(row[fieldCNGQtyInK1]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == pivotGridField23)
            {//其他报废率
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField12]);//投入
                    sumn += Convert.ToDecimal(row[pivotGridField22]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == pivotGridField19)
            { //冲压报废率（当天）
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField16]);//投入
                    sumn += Convert.ToDecimal(row[pivotGridField6]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == pivotGridField20)
            { //电镀报废率（当天）
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField17]);//投入
                    sumn += Convert.ToDecimal(row[pivotGridField7]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == pivotGridField21)
            { //切断报废率(当天)pivotGridField19
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField18]);//投入
                    sumn += Convert.ToDecimal(row[pivotGridField8]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
            if (e.DataField == pivotGridField26)
            { //切断报废率(当天)pivotGridField19
                for (int i = 0; i < ds.RowCount; i++)
                {
                    PivotDrillDownDataRow row = ds[i];
                    firstn += Convert.ToDecimal(row[pivotGridField25]);//投入
                    sumn += Convert.ToDecimal(row[pivotGridField24]);//报废
                    if (firstn != 0)
                        e.CustomValue = sumn / firstn;

                }
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using DevExpress.XtraEditors;
//using DA;
//using System.Threading;
//using DevExpress.XtraPrinting;
//using DevExpress.XtraPrinting.Drawing;
//using DevExpress.XtraPivotGrid;
//namespace KQMIS.Module.KQMES
//{
//    public partial class MES_Y204_QYield : DevExpress.XtraEditors.XtraForm
//    {
//        public MES_Y204_QYield()
//        {
//            InitializeComponent();
//            int mouth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
//            txtProdDt1.DateTime = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + "1" + " 0:00:00");
//            txtProdDt2.DateTime = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + mouth.ToString() + " 23:59:59");

//            //dtEnd.DateTime = DateTime.Now.Date;
//            //thread1 = new Thread(new ThreadStart(Showdata));
//            //thread1.Start();
//           // Showdata();
//        }
//        private void Showdata()
//        {
//            DateTime lbStart;
//            DateTime lbEnd;
//            try
//            {
//                lbStart = txtProdDt1.DateTime.Date;
//                lbEnd = txtProdDt2.DateTime.Date;
//                if (lbStart > lbEnd)
//                {
//                    XtraMessageBox.Show("结束时间不能大于开始时间,请检查");
//                    return;
//                }
//            }
//            catch
//            {
//                XtraMessageBox.Show("输入的时间格式不正确，请查阅");
//                return;
//            }
//            string sql = string.Format("select * from KQMIS_QYield where ProdDt >='{0}' and ProdDt<= '{1}'  ", lbStart, lbEnd);
//            DataTable dt = DBKQMES.DataToTable(sql);
//            dt.Columns.Add("EInQty", typeof(System.Decimal));//最后一天投入的数量
//            dt.Columns.Add("EInQty_Individual", typeof(System.Decimal));//最后一天投入换算
//            dt.Columns.Add("EOutQty", typeof(System.Decimal));//最后一天产出的数量
//            dt.Columns.Add("EOutQty_Individual", typeof(System.Decimal));//最后一天产出换算
//            dt.Columns.Add("ENgQty", typeof(System.Decimal));//最后一天报废数
//            dt.Columns.Add("EPNGQtyInK", typeof(System.Decimal));//最后一天冲压报废数
//            dt.Columns.Add("EENGQtyInK", typeof(System.Decimal));//最后一天电镀报废数
//            dt.Columns.Add("ECNGQtyInK", typeof(System.Decimal));//最后一天切断报废数
//            dt.Columns.Add("EFNGQtyInK", typeof(System.Decimal));//最后一天其他报废数
//            dt.Columns.Add("EPinqtyink", typeof(System.Decimal));//最后一天冲压投入数
//            dt.Columns.Add("EEinqtyink", typeof(System.Decimal));//最后一天电镀投入数
//            dt.Columns.Add("ECinqtyink", typeof(System.Decimal));//最后一天切断投入数
//            dt.Columns.Add("EFinqtyink", typeof(System.Decimal));//最后一天其他投入数
//            sql = string.Format("select * from KQMIS_QYield where ProdDt = '{0}'", lbEnd);
//            DataTable dt2 = DBKQMES.DataToTable(sql);
//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                for (int j = 0; j < dt2.Rows.Count; j++)
//                {
//                    if (dt.Rows[i]["JobType"].ToString().Trim() == dt2.Rows[j]["JobType"].ToString().Trim() && dt.Rows[i]["Category"].ToString().Trim() == dt2.Rows[j]["Category"].ToString().Trim() && dt.Rows[i]["QPartNo"].ToString().Trim() == dt2.Rows[j]["QPartNo"].ToString().Trim() && dt.Rows[i]["QPartDesc"].ToString().Trim() == dt2.Rows[j]["QPartDesc"].ToString().Trim() && dt.Rows[i]["UnitofSheet"].ToString().Trim() == dt2.Rows[j]["UnitofSheet"].ToString().Trim() && dt.Rows[i]["Operator"].ToString().Trim() == dt2.Rows[j]["Operator"].ToString().Trim() && dt.Rows[i]["JobNO"].ToString().Trim() == dt2.Rows[j]["JobNO"].ToString().Trim() && dt.Rows[i]["YieldFactor"].ToString().Trim() == dt2.Rows[j]["YieldFactor"].ToString().Trim())
//                    {
//                        //decimal Qty = Convert.ToDecimal(dt2.Rows[i]["InQty"]);
//                        dt.Rows[i]["EInQty"] = dt2.Rows[j]["InQty"];
//                        dt.Rows[i]["EInQty_Individual"] = dt2.Rows[j]["InQty_Individual"];
//                        dt.Rows[i]["EOutQty"] = dt2.Rows[j]["OutQty"];
//                        dt.Rows[i]["EOutQty_Individual"] = dt2.Rows[j]["OutQty_Individual"];
//                        dt.Rows[i]["ENgQty"] = dt2.Rows[j]["NgQty"];
//                        dt.Rows[i]["EPNGQtyInK"] = dt2.Rows[j]["PNGQtyInK"];
//                        dt.Rows[i]["EENGQtyInK"] = dt2.Rows[j]["ENGQtyInK"];
//                        dt.Rows[i]["ECNGQtyInK"] = dt2.Rows[j]["CNGQtyInK"];
//                        dt.Rows[i]["EFNGQtyInK"] = dt2.Rows[j]["FNGQtyInK"];
//                        dt.Rows[i]["EPinqtyink"] = dt2.Rows[j]["Pinqtyink"];
//                        dt.Rows[i]["EEinqtyink"] = dt2.Rows[j]["Einqtyink"];
//                        dt.Rows[i]["ECinqtyink"] = dt2.Rows[j]["Cinqtyink"];
//                        dt.Rows[i]["EFinqtyink"] = dt2.Rows[j]["Finqtyink"];
//                    }

//                }

//            }
//            ShowDataEventHandler del = delegate(DataTable dts)
//            {
//                pivotGridControl1.DataSource = dts;
//                pivotGridControl1.BestFit();
//                pivotGridControl1.ExpandAll();
//                progressPanel1.Visible = false;
//            };
//            pivotGridControl1.Invoke(del, dt);
           
//        }
//        private void MES_Y204_QYield_Load(object sender, EventArgs e)
//        {
//            // TODO: This line of code loads data into the 'kQMES_RPT.KQMIS_QYield' table. You can move, or remove it, as needed.
//            //this.kQMIS_QYieldTableAdapter.Fill(this.kQMES_RPT.KQMIS_QYield);

//        }

//        private void btnRead_Click(object sender, EventArgs e)
//        {
//            progressPanel1.Visible = true;
//            progressPanel1.BringToFront();
//            Thread thread1 = new Thread(Showdata);
//            thread1.IsBackground = true;
//            thread1.Start();
//        }

//        private void btnPrint_Click(object sender, EventArgs e)
//        {
//            printableComponentLink1.ClearDocument();
//            //设置纸张
//            printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
//            printableComponentLink1.Margins.Bottom = 40;
//            printableComponentLink1.Margins.Top = 80;
//            printableComponentLink1.Margins.Right = 20;
//            printableComponentLink1.Margins.Left = 20;
//            //水印
//            Watermark textWatermark = new Watermark();
//            // Set watermark options.
//            textWatermark.Text = "框架事业部";
//            textWatermark.TextDirection = DirectionMode.ForwardDiagonal;
//            textWatermark.Font = new Font(textWatermark.Font.FontFamily, 40);
//            textWatermark.ForeColor = Color.Red;
//            textWatermark.TextTransparency = 150;
//            textWatermark.ShowBehind = false;
//            //textWatermark.PageRange = "1,3-5";
//            printingSystem1.Watermark.CopyFrom(textWatermark);
//            //设置页眉
//            string leftColumn = "";
//            string middleColumn = "" + "\r\n" + "质量统计表" + "\r\n" + txtProdDt1.Text.ToString() + "-" + txtProdDt2.Text.ToString();
//            string rightColumn = ""+"\r\n"+"单位:K";
//            string bottomleft = "打印时间:[已打印数据][打印耗时]";
//            string bottommiddle = "第[页#]页";
//            string bottomright = "";
//            // Create a PageHeaderFooter object and initializing it with
//            // the link's PageHeaderFooter.
//            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
//            // Clear the PageHeaderFooter's contents.
//            //phf.Header.Content.Clear();
//            // Add custom information to the link's header.
//            phf.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
//            phf.Footer.Content.AddRange(new string[] { bottomleft, bottommiddle, bottomright });
//            phf.Header.LineAlignment = BrickAlignment.Near;
//            printableComponentLink1.ShowPreview();   
//        }

//        private void 导出xls文件ToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            SaveFileDialog savefile = new SaveFileDialog();
//            savefile.Filter = "xls文件(*.xls)|*.xls|所有文件(*.*)|*.*";
//            if (savefile.ShowDialog() == DialogResult.OK)
//            {
//                string path = savefile.FileName;
//                pivotGridControl1.ExportToXls(path);
//                if (XtraMessageBox.Show("要打开保存的xls文档吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
//                {
//                    System.Diagnostics.Process.Start(path);
//                }
//            }
//        }

//        private void 导出pdf文件ToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            SaveFileDialog savefile = new SaveFileDialog();
//            savefile.Filter = "pdf文件(*.pdf)|*.pdf|所有文件(*.*)|*.*";
//            if (savefile.ShowDialog() == DialogResult.OK)
//            {
//                string path = savefile.FileName;
//                pivotGridControl1.ExportToPdf(path);
//                if (XtraMessageBox.Show("要打开保存的xls文档吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
//                {
//                    System.Diagnostics.Process.Start(path);
//                }
//            }
//        }
       
//        private void btn1_Click(object sender, EventArgs e)
//        {
//            string name = this.Name.Trim() + this.btn1.Tag.ToString().Trim() + ".xml";
//            string fileName = "D:\\MIS\\Project\\KQMIS\\" + name;
//            SaveLayout(fileName);
//        }

//        private void btn2_Click(object sender, EventArgs e)
//        {
//            string name = this.Name.Trim() + this.btn2.Tag.ToString().Trim() + ".xml";
//            string fileName = "D:\\MIS\\Project\\KQMIS\\" + name;
//            SaveLayout(fileName);
//        }

//        private void btn3_Click(object sender, EventArgs e)
//        {
//            string name = this.Name.Trim() + this.btn3.Tag.ToString().Trim() + ".xml";
//            string fileName = "D:\\MIS\\Project\\KQMIS\\" + name;
//            SaveLayout(fileName);
//        }
//        private void SaveLayout(string fileName)
//        {
//            if (!System.IO.Directory.Exists("D:\\MIS"))
//            {
//                System.IO.Directory.CreateDirectory("D:\\MIS");
//            }
//            if (!System.IO.Directory.Exists("D:\\MIS\\Project"))
//            {
//                System.IO.Directory.CreateDirectory("D:\\MIS\\Project");
//            }
//            if (!System.IO.Directory.Exists("D:\\MIS\\Project\\KQMIS"))
//            {
//                System.IO.Directory.CreateDirectory("D:\\MIS\\Project\\KQMIS");
//            }
//            pivotGridControl1.SaveLayoutToXml(fileName);
//            XtraMessageBox.Show("保存成功");
//        }
//        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            string Filename = "";
//            string temp = this.comboBoxEdit1.Text.Trim();
//            switch (temp)
//            {
//                case "界面1": Filename = this.Name.Trim() + this.btn1.Tag.ToString().Trim() + ".xml"; break;
//                case "界面2": Filename = this.Name.Trim() + this.btn2.Tag.ToString().Trim() + ".xml"; break;
//                case "界面3": Filename = this.Name.Trim() + this.btn3.Tag.ToString().Trim() + ".xml"; break;
//            }
//            string Filepath = "D:\\MIS\\Project\\KQMIS\\" + Filename;
//            try
//            {
//                pivotGridControl1.RestoreLayoutFromXml(Filepath);
//            }
//            catch
//            {
//                return;
//            }
//        }

//        private void pivotGridControl1_CustomSummary(object sender, DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs e) {
//            decimal firstn = 0;
//            decimal sumn = 0;
//            PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
//            if (e.DataField == pivotGridField13) { //冲压报废率
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField9]);//冲压投入
//                    sumn += Convert.ToDecimal(row[fieldPNGQtyInK1]);//冲压报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//            if (e.DataField == pivotGridField14) { //电镀报废率
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField10]);//投入
//                    sumn += Convert.ToDecimal(row[fieldENGQtyInK1]);//报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//            if (e.DataField == pivotGridField15) { //切断报废率pivotGridField19
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField11]);//投入
//                    sumn += Convert.ToDecimal(row[fieldCNGQtyInK1]);//报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//            if (e.DataField == pivotGridField23) {//其他报废率
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField12]);//投入
//                    sumn += Convert.ToDecimal(row[pivotGridField22]);//报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//            if (e.DataField == pivotGridField19) { //冲压报废率（当天）
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField16]);//投入
//                    sumn += Convert.ToDecimal(row[pivotGridField6]);//报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//            if (e.DataField == pivotGridField20) { //电镀报废率（当天）
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField17]);//投入
//                    sumn += Convert.ToDecimal(row[pivotGridField7]);//报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//            if (e.DataField == pivotGridField21) { //切断报废率(当天)pivotGridField19
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField18]);//投入
//                    sumn += Convert.ToDecimal(row[pivotGridField8]);//报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//            if (e.DataField == pivotGridField26) { //切断报废率(当天)pivotGridField19
//                for (int i = 0; i < ds.RowCount; i++) {
//                    PivotDrillDownDataRow row = ds[i];
//                    firstn += Convert.ToDecimal(row[pivotGridField25]);//投入
//                    sumn += Convert.ToDecimal(row[pivotGridField24]);//报废
//                    if (firstn != 0)
//                        e.CustomValue = sumn / firstn;

//                }
//            }
//        }
//    }
//}