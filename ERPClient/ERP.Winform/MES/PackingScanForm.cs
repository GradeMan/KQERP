using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using ERP.Domain;
using ERP.Service;
using ERP.Winform.Hepler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Util;
namespace ERP.Winform.MES
{
    public partial class PackingScanForm : EditForm
    {
        private string IniFilePath = "D:\\MIS\\Project\\KQERP\\KQERP.INI";
        private IMES_M801_Label_SService labelSService = Unity.Instance.GetService<IMES_M801_Label_SService>();
        private IMES_M802_Packing_HdService packingHdService = Unity.Instance.GetService<IMES_M802_Packing_HdService>();
        private IERP_M001_Product_PackInfoService productPackInfoService = Unity.Instance.GetService<IERP_M001_Product_PackInfoService>();
        private IMES_M501_JobTxService jobTxService = Unity.Instance.GetService<IMES_M501_JobTxService>();
        public PackingScanForm()
        {
            InitializeComponent();
        }
        protected override void InitData()
        {
            OnOpenSerialPort();
            base.InitData();

        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.OnBtnCommand(sender, e);
        }
        /// <summary>
        /// 处理扫描的二维码
        /// </summary>
        /// <param name="barCode"></param>
        private void OnHandelBarCode(string barCode)
        {
            //判断格式是否是生产批号
            string regrule = @"\d{2}[a-zA-Z]{3}\d{6}";
            Match m = Regex.Match(barCode, regrule);
            if (!m.Success) //如果不是生产批号
                OnHandelShipLot(barCode);
            else
            {
                string jobNo = barCode;
                
                //1.1查出产品包装信息
                var productPackInfo = this.eRPM001ProductPackInfoBindingSource.DataSource as ERP_M001_Product_PackInfo;
                if (productPackInfo == null)
                {
                    lbTips.Text = "提示：产品包装资料不存在，请先扫描内标签。。。";
                    return;
                }
                //1.2查出全检信息
                var jobTx = jobTxService.GetJobTxQuery().Where(a => a.JobNo == jobNo).FirstOrDefault();
                if (jobTx == null)
                {
                    lbTips.Text = "提示：全检资料不存在，请检查。。。";
                    return;
                }
                this.mESM501JobTxBindingSource.DataSource = jobTx;
                //1.3判断标签是否扫描过
                var packingCount = packingHdService.GetPackingHdQuery().Where(a => a.JobNo == jobNo).Count();
                if (packingCount > 0)
                {
                    lbTips.Text = "提示：该生产批号已存在，请检查。。。";
                    return;
                }
                //1.4 获得这张现品票的总包数 = 总片数/（片/包） 
                int baoCount = 0;//Conv.ToInt(Math.Ceiling((jobTx.OutQty??0) / productPackInfo.PackBaoPian));
                //int heCount = baoCount/productPackInfo.PackHeBao
                //1.5 未扫描过的小标签
                var labelSList = this.mESM801LabelSBindingSource.DataSource as List<MES_M801_Label_S>;
                //1.6 从未扫描过的小标签里拿出这张仙品票所需要的标签数量 即 baoCount，一包等于一张小标签
                var labelPreList = labelSList.Take(baoCount).ToList();
                //1.7对拿出来的baoCount张小标签根据单据号进行分组计数
                var packingDtlList = labelPreList.GroupBy(a => a.MLotNo).
                    Select(g => new MES_M802_Packing_Dtl() { JobNo = jobNo,ShipLot = g.Key, ShipLotQty = g.Count() * productPackInfo.PackPianZhi * productPackInfo.PackBaoPian, ShipLotPackage = g.Count() }).ToList();
                this.mESM802PackingDtlBindingSource.DataSource = packingDtlList;
                this.gridView1.BestFitColumns();

                var packingHd = new MES_M802_Packing_Hd()
                {
                    //ProdDt = jobTx.ProdDt,
                    Qty = packingDtlList.Sum(a=>a.ShipLotQty),
                    Package = baoCount,
                    CustCode = productPackInfo.CustCode,
                    JobNo = jobTx.JobNo,
                    PartNo = productPackInfo.PartNo,
                    PartType = productPackInfo.PartType,
                };
                this.mESM802PackingHdBindingSource.DataSource = packingHd;
                //1.8对计算过胡小标签进行标记
                labelPreList.ForEach(a => a.IsPack = true);
                lbTips.Text = "";
                
            }
            
        }
        /// <summary>
        /// 处理内标签条码
        /// </summary>
        /// <param name="barCode">内标签编号</param>
        private void OnHandelShipLot(string barCode)
        {
            //1.如果是二维码,需要提取其中的单据号再查找数据库
            var labelS =  labelSService.GetLabelSQuery().Where(a => a.LotNo == barCode).FirstOrDefault();
            if (labelS == null)
            {
                lbTips.Text = "提示：该内标签资料不存在，请检查内标签条码。。。";
                return;
            }
           //1.1判断标签是否扫描过
            var packingCount = packingHdService.GetPackingHdQuery().Where(a => a.SubShipLot1st == labelS.LotNo).Count();
            if (packingCount > 0)
            {
                lbTips.Text = "提示：该内标签已扫描过，请检查。。。";
                return;
            }
           //1.2查出产品包装信息
            var productPackInfo = productPackInfoService.GetPackInfoQuery().Where(a => a.CustCode == labelS.CustCode && a.PartNo == labelS.PartNo).FirstOrDefault();
            if (productPackInfo == null)
            {
                lbTips.Text = "提示：产品包装信息不存在。。。";
                txtBarCode.Focus();
                txtBarCode.SelectAll();
                return;
            }
            this.eRPM001ProductPackInfoBindingSource.DataSource = productPackInfo;
            //1.3查出所有未使用小标签数据 CustCode->客户,PartNo->产品，LotNo->内标签编号大于等于这次扫描的
            var labelSList = labelSService.GetListBySql(string.Format(" select * from MES_M801_Label_S where CustCode = '{0}' and PartNo = '{1}' and LotNo >= '{2}' order by MLotNo,PackSeqNo", labelS.CustCode, labelS.PartNo, labelS.LotNo));//labelSService.GetLabelSQuery().Where(a => a.CustCode == labelS.CustCode && a.PartNo == labelS.PartNo && a.IsPack == false).OrderBy(a => new { a.MLotNo,a.PackSeqNo}).ToList();
            this.mESM801LabelSBindingSource.DataSource = labelSList;
            this.gridView2.BestFitColumns();
            lbTips.Text = "";
            
            //2.如果是一维码
        }
        #region 设置COM端口扫描用
        /// <summary>
        /// 设置COM串口
        /// </summary>
        void OnOpenSerialPort()
        {
            if (File.Exists(IniFilePath))
            {
                INIFile inifile = new INIFile(IniFilePath);
                string portName = inifile.IniReadValue("SerialPort", "PortName");
                int baudRate = 9600;
                Int32.TryParse(inifile.IniReadValue("SerialPort", "BaudRate"), out baudRate);
                var serialHepler = new SerialPortHelper();
                serialHepler.OnRecieveSerialMsg += serialHepler_OnRecieveSerialMsg;
                serialHepler.OpenSerialPort(portName, baudRate);
            }
            else
            {
                XtraMessageBox.Show("串口配置文件不存在，请检查");
            }
        }


        private delegate void BarCodeChangedHander(string percentage);
        /// <summary>
        /// 获取COM口穿回来的值
        /// </summary>
        /// <param name="strRecieve"></param>
        void serialHepler_OnRecieveSerialMsg(string strRecieve)
        {
            if (this.txtBarCode.InvokeRequired)
            {
                //非UI线程，再次封送该方法到UI线程
                try
                {
                    this.txtBarCode.Invoke(new BarCodeChangedHander(serialHepler_OnRecieveSerialMsg), new object[] { strRecieve });
                }
                catch (Exception ef)
                {
                    MessageBox.Show(ef.Message);
                }
            }
            else
            {
                //UI线程，进度更新 赋值
                this.txtBarCode.Text = strRecieve;

            }
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Down)
            {
                if (txtBarCode.IsEditorActive)
                    OnHandelBarCode(txtBarCode.Text.Trim());
                else
                    SendKeys.SendWait("{Tab}");
                return true;
            }
            if (keyData == Keys.Up)
            {
                SendKeys.SendWait("+{TAB}");
                return true;
            } return base.ProcessCmdKey(ref msg, keyData);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var packingHd = this.mESM802PackingHdBindingSource.DataSource as MES_M802_Packing_Hd;
            var packingDtlLst = this.mESM802PackingDtlBindingSource.DataSource as List<MES_M802_Packing_Dtl>;
            packingHdService.Save(packingHd, packingDtlLst);
        }
    }
}
