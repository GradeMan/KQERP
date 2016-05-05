using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using COM.Service;
using ERP.Service;
using COM.Domain;
using ERP.Domain;
using Util;
using DevExpress.XtraEditors;
using System.Diagnostics;
namespace ERP.Winform.MES
{
    /// <summary>
    /// 标签特性说明：
    /// 1.M.ProdDt = this.txtProdDate.DateTime.Date.ToString(dateTimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);
    /// 日期格式：  yy-MM-dd  MMM为英文
    /// 2.接头数在生成标签后要手动填写
    /// </summary>
    public partial class LabelPrintForm : ListForm
    {
        private IMES_M801_Label_LService labelService = Unity.Instance.GetService<IMES_M801_Label_LService>();
        private IProductService productServer = Unity.Instance.GetService<IProductService>();
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private ICustomerService customerServer = Unity.Instance.GetService<ICustomerService>();
        private IERP_M001_Product_PackInfoService packInfoServer = Unity.Instance.GetService<IERP_M001_Product_PackInfoService>();
        private string INIFilePath = "D:\\MIS\\Project\\KQERP\\KQERP.INI";
        public LabelPrintForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            //this.DataSource = labelService.GetList();
            this.mESM801LabelLBindingSource.DataSource = labelService.GetList();
            txtProdDate.DateTime = DateTime.Now.Date;
        }
        public override void OnAttachEvent()
        {
            var customerData = customerServer.GetCustomerInputData();
            //customerData.ForEach(a => a.InputCode2 = PinYin.GetCodstring(a.DisPlayName));
            SetGridLookUpEdit(txtCustomer, customerData, 3);
            //SetGridLookUpEdit(txtSerCustomer, customerData, 2);
            //var productData = productServer.GetProductInputData();
            //productData.ForEach(a => a.InputCode2 = PinYin.GetCodstring(a.DisPlayName));
            SetGridLookUpEdit(txtProduct, null, 4);
            //SetGridLookUpEdit(txtSerProduct, productData, 2);
            //SetGridView(this.gridControl1, true, false, false, true);
            //SetGridView(this.gridControl2, true, false, false);
            //SetGridView(this.gridControl3, true, false, false);
            //SetGridView(this.gridControl4, true, false, false);
            //InitItem(null, null, null, txtCustomer);
            //this.gridView2.FocusedRowChanged += gridView2_FocusedRowChanged;
            //this.txtProdDt.EditValueChanged += txtProdDt_EditValueChanged;
            //this.txtCustomer.EditValueChanged += txtCustomer_EditValueChanged;
            //this.txtSerCustomer.EditValueChanged += txtSerCustomer_EditValueChanged;
            //this.txtProduct.EditValueChanged += txtProduct_EditValueChanged;
        }
        /// <summary>
        /// 生成标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCustomer.Text))
                throw new ApplicationException("请输入客户信息");

            if (string.IsNullOrWhiteSpace(txtProduct.Text))
                throw new ApplicationException("请输入产品信息");
            //if (string.IsNullOrWhiteSpace(txtOrderNo.Text))
            //    throw new ApplicationException("请输入订单信息");
            if (string.IsNullOrWhiteSpace(txtShipLotNo.Text))
                throw new ApplicationException("请输入出箱批号信息");

            if (this.txtLNo2.Value < this.txtLNo1.Value || txtLNo2.Value == 0)
                throw new ApplicationException("箱号录入出错，请检查");

            if (this.txtSNO2.Value < this.txtSNO1.Value)
                throw new ApplicationException("包号录入出错，请检查");
            OnCreateLabel();
        }
        /// <summary>
        /// 生成标签信息
        /// </summary>
        private void OnCreateLabel()
        {
            this.mESM801LabelLBindingSource1.DataSource = new List<MES_M801_Label_L>();
            this.mESM801LabelMBindingSource.DataSource = new List<MES_M801_Label_M>();
            this.mESM801LabelSBindingSource.DataSource = new List<MES_M801_Label_S>();
            string custCode = txtCustomer.EditValue.ToString();
            string partNo = txtProduct.EditValue.ToString();
            //ERP_M001_Product product = productServer.GetByPartNo(partNo);
            //if (product == null)
            //    throw new ApplicationException("产品不存在，请检查");
            var packInfo = packInfoServer.GetPackInfo(custCode, partNo);
            if (packInfo == null)
                throw new ApplicationException("产品包装资料不存在，请检查");
            //ERP_M001_Material material = ykdbContext.Set<ERP_M001_Material>().Where(a => a.MatCode == product.MatCode).FirstOrDefault();
            //string matcode = material == null ? "" : material.MatType;
            string dateTimeFormat = string.IsNullOrWhiteSpace(packInfo.DateTimeFormat) == false ? packInfo.DateTimeFormat : "yyyy-MM-dd";
            string qtyFormat = "0.###";
            string qtyFormat2 = "0.###";
            // 大标签单位除数
            int unitDivsor = packInfo.UnitDivsor <= 0 ? 1 : packInfo.UnitDivsor;
            //小标签单位除数
            int unitDivsor2 = packInfo.UnitDivSor2 <= 0 ? 1 : packInfo.UnitDivSor2;
            //如果包装里有关数量类型描述，则用包装里的参数
            //if (!string.IsNullOrWhiteSpace(pack.LabelQtyType))
            //{
            //    var codeData = ykdbContext.Set<ERP_C001_Code>().Where(a => a.Code == pack.LabelQtyType && a.CodeID == "LabelQtyType").FirstOrDefault();
            //    if (codeData != null)
            //    {
            //        QtyTypeName = codeData.Description;
            //        QtyType = Convert.ToDecimal(codeData.Code);
            //        if (QtyTypeName == "K")
            //            qtyFormat = "0.000";
            //    }
            //}
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            for (int i = Conv.ToInt( this.txtLNo1.Value); i <= txtLNo2.Value; i++)
            {
                //一箱的片数
                decimal pianCountOfXiang = packInfo.PackXiangHe * packInfo.PackHeBao * packInfo.PackBaoPian;// *packInfo.PackPianZhi;
                //一箱的包数
                decimal baoCoutOfXiang = packInfo.PackXiangHe * packInfo.PackHeBao;
                //一箱的盒数
                decimal heCountOfXiang = packInfo.PackXiangHe;
                //一盒的包数
                decimal baoCountOfHe = packInfo.PackHeBao;

                //如果包不够则重新计算最后一箱的包数，盒数跟片数
                if (this.txtSNO2.Value != 0 && i == txtLNo2.Value)
                {
                    baoCoutOfXiang = txtSNO2.Value - txtSNO1.Value + 1;//包数
                    pianCountOfXiang = baoCoutOfXiang * packInfo.PackBaoPian;//总片数= 包数*片/包
                    heCountOfXiang = (baoCoutOfXiang / packInfo.PackHeBao);//盒数= 总包数/包/盒
                }
                //大标签信息
                MES_M801_Label_L L = new MES_M801_Label_L();
                L.CompCode = tempUser.CompCode;
                L.LotNo = OnCreateLotNo("L", (packInfo.PreLotNo??"").Trim(), txtShipLotNo.Text.Trim(), (packInfo.LotNoSeperater??"").Trim(), (packInfo.PostLotNo??"").Trim(),i.ToString());
                L.MLotNo = OnCreateLotNo("", (packInfo.PreLotNo ?? "").Trim(), txtShipLotNo.Text.Trim(), "", (packInfo.PostLotNo ?? "").Trim(), "");
                //L.MLotNo = txtShipLotNo.Text;
                L.BoxNo = i.ToString().PadLeft(2, '0');
                L.TotBox = (heCountOfXiang * (txtLNo2.Value - txtLNo1.Value + 1)).ToString("0");
                L.TotPack = baoCoutOfXiang.ToString("0");
                L.PartNo = packInfo.PartNo;
                L.PartName = packInfo.PartName;
                L.PartType = packInfo.PartType;
                L.PartSpec = packInfo.PartSpec;
                L.CustCode = packInfo.CustCode;
                L.CustPartNo = packInfo.CustPartNo;
                L.CustPartName = packInfo.CustPartName;
                L.CustPartType = packInfo.CustPartType;
                L.CustPartSpec = packInfo.CustPartSpec;
                L.CustDrawingNo = packInfo.CustDrawingNo;
                L.CustPONo = packInfo.CustPONo;
                L.CustLotNo = packInfo.CustLotNo;
                L.MatCode = packInfo.MatCode;
                L.MatType = packInfo.MatType;
                L.MatSuppCode = packInfo.MatSuppCode;
                L.MatLotNo = packInfo.MatLotNo;
                L.LabelType = packInfo.LabelType.Trim();
                L.ProdDt = this.txtProdDate.DateTime.Date.ToString(dateTimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);
                L.ExpiredDt = this.txtProdDate.DateTime.Date.AddYears(packInfo.ExpiredPeriod).AddDays(-1).ToString(dateTimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);//失效日期
                L.ExpiredPeriod = packInfo.ExpiredPeriod;
                L.PProdDt = this.txtProdDate.DateTime.Date;
                L.PExpiredDt = this.txtProdDate.DateTime.Date.AddYears(packInfo.ExpiredPeriod).AddDays(-1);
                L.Unit = "只/" + pianCountOfXiang.ToString("0")+"条";
                L.LBPartNo = packInfo.LBPartNo;
                L.LBPartName = packInfo.LBPartName;
                //2015-09-21新增
                L.LBSpec1 = packInfo.LBSpec1;
                L.LBSpec2 = packInfo.LBSpec2;
                //质量 = 总片数*只数/1000 
                L.Qty = (pianCountOfXiang * (packInfo.PackPianZhi / packInfo.UnitDivsor)).ToString(qtyFormat);
                L.PQty = (pianCountOfXiang * (packInfo.PackPianZhi / packInfo.UnitDivsor));
                L.PKIn = false;//是否入库
                L.PKOut = false;//是否出库
                L.CPIn = false;//是否入库
                L.CPOut = false;
                string ls_Supplier = "Ningbo Kangqiang Electronics Co.,LTD.";
                switch (packInfo.LabelType.Trim())
                {
                    case "201-TS2D": 
                        //汇总二维码信息 例如：LF DIP016  DIP016  110*140(C)-3P  LFCD0161114C-3P  Ningbo Kangqiang Electronics Co.,LTD.    01.02.02.03.08  32400  6  150917101(P075)  2015-09-17  2016-09-16
                        //L.Code2D = L.CustPartName + "\n" + L.CustPartType + "\n" + L.CustPartSpec + "\n" + L.CustDrawingNo + "\n" + ls_Supplier + "\n" + L.CustPONo + "\n" + L.CustPartNo + "\n" + L.Qty + "\n" + L.TotPack + "\n" + L.LotNo + "\n" + L.ProdDt + "\n" + L.ExpiredDt;
                        L.Code2D = L.CustPartName + "\n" + L.CustPartType + "\n" + L.CustPartSpec + "\n" + L.CustDrawingNo + "\n" + ls_Supplier + "\n" + L.CustPONo + "\n" + L.CustPartNo + "\n" + (pianCountOfXiang * (packInfo.PackPianZhi /1000)).ToString(qtyFormat)+ "\n" + L.TotPack + "\n" + L.LotNo + "\n" + L.ProdDt + "\n" + L.ExpiredDt;
                        break;
                    case "217-TS2D":
                        //汇总二维码信息 例如：LF SSOP028  SSOP028  153*200(C)  LFCP0281520C  Ningbo Kangqiang Electronics Co.,LTD.    01.02.15.04.05  86400  12  150904101(P111)  2015-09-04  2016-09-03
                        L.Code2D = L.CustPartName + "\n" + L.CustPartType + "\n" + L.CustPartSpec + "\n" + L.CustDrawingNo + "\n" + ls_Supplier + "\n" + L.CustPONo + "\n" + L.CustPartNo + "\n" + L.Qty + "\n" + L.TotPack + "\n" + L.LotNo + "\n" + L.ProdDt + "\n" + L.ExpiredDt;
                        break;
                    case "204-CF": 
                        //例如 ： OFMTL-580290A;I0;P11-01008-007;Q54;VNM07;M20150912;L1509121(A071);S22
                        L.Code2D = "O" + L.CustPONo + ";" + "I0" + ";" + "P" + L.MatCode + ";" + "Q" + L.Qty + ";" + "VNM07" + ";" + L.ProdDt + ";" + L.LotNo + ";" + "S" + L.BoxNo;
                        break;
                    case "203-AS": L.Qty = "Q" + L.Qty;
                        //SOP-14L-A5  SOIC 14LD C9-SSM 80*80  2004022832  150917101(B054)  45008080030101  20150917  20160916  Q126000  Ningbo Kangqiang Electronics Co.,LTD.
                        L.Code2D = L.PartNo + "\n" + L.CustPartNo + "\n" + L.MatCode + "\n" + L.LotNo + "\n" + L.CustPONo + "\n" + L.ProdDt + "\n" + L.ExpiredDt + "\n" + L.Qty + "\n" + ls_Supplier;
                        break;
                    case "205-FS": L.CustLotNo = L.CustLotNo.Substring(0, L.CustLotNo.Length - 3) + (Convert.ToInt32(L.CustLotNo.Substring(L.CustLotNo.Length - 3, 3)) + i - 1).ToString().PadLeft(3, '0');
                        break;
                    case "212-AOI": L.CustLotNo = string.Format("{0}{1}{2}{3}{4}", "A", txtShipLotNo.Text.Substring(0, 6), L.CustLotNo, "-", L.BoxNo);
                        break;
                    case "211-NXP": L.Unit = "KP/" + baoCoutOfXiang.ToString("0") + "reels";
                        break;
                    case "215-XAHT":
                        //TSSOP8-B5-3  TSSOP008(126X87)(E)  2KDY0007  150729101(P052)  CG40924025  2015-07-29  2016-07-28  160  Ningbo Kangqiang Electronics Co.,LTD.
                        L.Code2D = L.PartNo + "\n" + L.CustPartNo + "\n" + L.MatCode + "\n" + L.LotNo + "\n" + L.CustPONo + "\n" + L.ProdDt + "\n" + L.ExpiredDt + "\n" + L.Qty + "\n" + ls_Supplier;
                        break;
                    case "208-FST":
                        //HSOP-28L (A)  HSOP28A(189*201)(A)  150914101(A215)  20150914  20160913  30  Ningbo Kangqiang Electronics Co.,LTD.
                        L.Code2D = L.PartNo + "\n" + L.CustPartNo + "\n" + L.LotNo + "\n" + L.ProdDt + "\n" + L.ExpiredDt + "\n" + L.Qty + "\n" + ls_Supplier;
                        L.LotNo = txtShipLotNo.Text.Trim();
                        break;
                    case "209-JF":
                        //SOP-16L-A5  11-2016-9132  150916102(C055)  20150916  20160915  126  Ningbo Kangqiang Electronics Co.,LTD.
                        L.Code2D = L.PartNo + "\n" + L.MatCode + "\n" + L.LotNo + "\n" + L.ProdDt + "\n" + L.ExpiredDt + "\n" + L.Qty + "\n" + ls_Supplier;
                        break;
                    case"210-KJ":
                        //TO-220FA-3(B)  LEAD FRAME TO220(236*205)BARE  500232  KQ150624113  20150624  20160623  10  Ningbo Kangqiang Electronics Co.,LTD.
                        L.Code2D = L.PartNo + "\n" + L.CustPartNo + "\n" + L.MatCode + "\n" + L.LotNo + "\n" + L.ProdDt + "\n" + L.ExpiredDt + "\n" + L.Qty + "\n" + ls_Supplier;
                        break;
                    case "202-KH":
                        L.Code2D = L.CustPartNo + "," + L.MLotNo + "," +L.Qty + ","+ L.ProdDt + "," + L.ExpiredDt + ","  + L.BoxNo;
                        break;
                    case "202R-KH":
                        L.Code2D = L.CustPartNo + "," + L.MLotNo + "," + L.Qty + "," + L.ProdDt + "," + L.ExpiredDt + "," + L.BoxNo;
                        break;
                    default: L.Code2D = L.LotNo;
                        break;
                }
                this.mESM801LabelLBindingSource1.Add(L);
                //中标签信息
                for (int k = 1; k <= heCountOfXiang; k++)
                {
                    MES_M801_Label_M M = new MES_M801_Label_M();
                    M.CompCode = tempUser.CompCode;
                    M.LotNo = OnCreateLotNo("M", (packInfo.PreLotNo ?? "").Trim(), txtShipLotNo.Text.Trim(), (packInfo.LotNoSeperater ?? "").Trim(), (packInfo.PostLotNo ?? "").Trim(), k.ToString());
                    M.MLotNo = L.LotNo;
                    M.LMlotNo = L.MLotNo;
                    M.LBoxNo = L.BoxNo;
                    M.BoxNo = k.ToString().PadLeft(2, '0');
                    M.TotBox = (heCountOfXiang * (txtLNo2.Value - txtLNo1.Value + 1)).ToString("0");
                    M.TotPack = baoCoutOfXiang.ToString("0");
                    M.PartNo = packInfo.PartNo;
                    M.PartName = packInfo.PartName;
                    M.PartType = packInfo.PartType;
                    M.PartSpec = packInfo.PartSpec;
                    M.CustCode = packInfo.CustCode;
                    M.CustPartNo = packInfo.CustPartNo;
                    M.CustPartName = packInfo.CustPartName;
                    M.CustPartType = packInfo.CustPartType;
                    M.CustPartSpec = packInfo.CustPartSpec;
                    M.CustDrawingNo = packInfo.CustDrawingNo;
                    M.CustPONo = packInfo.CustPONo;
                    M.CustLotNo = packInfo.CustLotNo;
                    M.MatCode = packInfo.MatCode;
                    M.MatType = packInfo.MatType;
                    M.MatSuppCode = packInfo.MatSuppCode;
                    M.MatLotNo = packInfo.MatLotNo;
                    M.LabelType = packInfo.LabelType;
                    M.ProdDt = this.txtProdDate.DateTime.Date.ToString(dateTimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    M.ExpiredDt = this.txtProdDate.DateTime.Date.AddYears(packInfo.ExpiredPeriod).AddDays(-1).ToString(dateTimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);//失效日期
                    M.ExpiredPeriod = packInfo.ExpiredPeriod;
                    M.PProdDt = this.txtProdDate.DateTime.Date;
                    M.PExpiredDt = this.txtProdDate.DateTime.Date.AddYears(packInfo.ExpiredPeriod).AddDays(-1);
                    M.LBPartNo = packInfo.LBPartNo;
                    M.LBPartName = packInfo.LBPartName;
                    
                    //2015-09-21新增
                    M.LBSpec1 = packInfo.LBSpec1;
                    M.LBSpec2 = packInfo.LBSpec2;
                    //一盒总片数
                    decimal pianCountOfHe = packInfo.PackBaoPian * packInfo.PackHeBao;
                    //if (heCountOfXiang > k && heCountOfXiang < k + 1)
                    //    pianCountOfHe = pianCountOfCass % sheetCountOfBox; //求余数 一箱的片数/一盒的片数
                    //M.Qty = (sheetCountOfBox * Convert.ToDecimal(product.UnitOfSheet) / QtyType).ToString(qtyFormat) + QtyTypeName + "(" + sheetCountOfBox.ToString("0") + "条)";
                    //M.BoxQtyInK = sheetCountOfBox * Convert.ToDecimal(product.UnitOfSheet) / 1000;
                    //M.Qty2 = sheetCountOfBox * Convert.ToDecimal(product.UnitOfSheet) / QtyType;
                    //质量 = 一盒总片数*只数/1000 
                    M.Qty = (pianCountOfHe * (packInfo.PackPianZhi / packInfo.UnitDivsor)).ToString(qtyFormat);
                    M.PQty = (pianCountOfHe * (packInfo.PackPianZhi / packInfo.UnitDivsor));
                    switch (packInfo.LabelType.Trim())
                    {
                        case "201-TS2D":
                            M.Code2D = M.CustPartName + "\n" + M.CustPartType + "\n" + M.CustPartSpec + "\n" + M.CustDrawingNo + "\n" + ls_Supplier + "\n" + M.CustPONo + "\n" + M.CustPartNo + "\n" + M.Qty + "\n" + M.BoxNo + "\n" + M.LotNo + "\n" + M.ProdDt + "\n" + M.ExpiredDt;
                            break;
                        case "202-KH":
                            M.Code2D = M.CustPartNo + "," + M.MLotNo + "," + M.Qty + "," + M.ProdDt + "," + M.ExpiredDt + "," + M.BoxNo;
                            break;
                        case "202R-KH":
                            M.Code2D = M.CustPartNo + "," + M.MLotNo + "," + M.Qty + "," + M.ProdDt + "," + M.ExpiredDt + "," + M.BoxNo;
                            break;
                        default: M.Code2D = M.LotNo;
                            break;
                    }
                    M.Unit = "只/" + pianCountOfHe.ToString("0") + "条";
                    this.mESM801LabelMBindingSource.Add(M);
                }
                //小标签信息
                for (int j = 1; j <= baoCoutOfXiang; j++)
                {
                    MES_M801_Label_S S = new MES_M801_Label_S();
                    S.CompCode = tempUser.CompCode;
                    S.PackSeqNo = ((i - 1) * baoCoutOfXiang + j).ToString("0").PadLeft(2, '0');
                    //if (packInfo.IsLabelSeq == true)
                    //    S.PackSeqNo = ((i - 1) * baoCoutOfXiang + j).ToString("0").PadLeft(2, '0');
                    //else
                    //    S.PackSeqNo = j.ToString().PadLeft(2, '0');
                    //L.BoxNo = i.ToString().PadLeft(2, '0');
                    S.LotNo = OnCreateLotNo("S", (packInfo.PreLotNo ?? "").Trim(), txtShipLotNo.Text.Trim(), (packInfo.LotNoSeperater ?? "").Trim(), (packInfo.PostLotNo ?? "").Trim(), i.ToString(), j.ToString());
                    S.MLotNo = L.LotNo;
                    S.LMlotNo = L.MLotNo;
                    S.BoxNo = L.BoxNo;
                    S.PackNo = j.ToString().PadLeft(2, '0');
                    S.PartNo = packInfo.PartNo;
                    S.PartName = packInfo.PartName;
                    S.PartType = packInfo.PartType;
                    S.PartSpec = packInfo.PartSpec;
                    S.CustCode = packInfo.CustCode;
                    S.CustPartNo = packInfo.CustPartNo;
                    S.CustPartName = packInfo.CustPartName;
                    S.CustPartType = packInfo.CustPartType;
                    S.CustPartSpec = packInfo.CustPartSpec;
                    S.CustDrawingNo = packInfo.CustDrawingNo;
                    S.CustPONo = packInfo.CustPONo;
                    S.CustLotNo = packInfo.CustLotNo;
                    S.MatCode = packInfo.MatCode;
                    S.MatType = packInfo.MatType;
                    S.ProdDt = this.txtProdDate.DateTime.Date.ToString(dateTimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    S.ExpiredDt = this.txtProdDate.DateTime.Date.AddYears(packInfo.ExpiredPeriod).AddDays(-1).ToString(dateTimeFormat, System.Globalization.DateTimeFormatInfo.InvariantInfo);//失效日期
                    S.Qty = (packInfo.PackBaoPian * packInfo.PackPianZhi/unitDivsor2).ToString(qtyFormat2);
                    S.PQty = packInfo.PackBaoPian * packInfo.PackPianZhi/unitDivsor2;
                    S.Unit = "只/" + packInfo.PackBaoPian.ToString("0") + "条";
                    //S.Code2D = L.Code2D;
                    S.LBPartNo = packInfo.LBPartNo;
                    S.LBPartName = packInfo.LBPartName;
                    //2015-09-21新增
                    S.LBSpec1 = packInfo.LBSpec1;
                    S.LBSpec2 = packInfo.LBSpec2;
                    switch (packInfo.LabelType.Trim())
                    {
                        case "201-TS2D":
                            S.Code2D = S.CustPartName + "\n" + S.CustPartType + "\n" + S.CustPartSpec + "\n" + S.CustDrawingNo + "\n" + ls_Supplier + "\n" + S.CustPONo + "\n" + S.CustPartNo + "\n" + (packInfo.PackBaoPian * packInfo.PackPianZhi /1000).ToString(qtyFormat2) + "\n" + S.PackSeqNo + "\n" + S.LotNo + "\n" + S.ProdDt + "\n" + S.ExpiredDt;
                            break;
                        case "217-TS2D":
                            S.Code2D = S.CustPartName + "\n" + S.CustPartType + "\n" + S.CustPartSpec + "\n" + S.CustDrawingNo + "\n" + ls_Supplier + "\n" + S.CustPONo + "\n" + S.CustPartNo + "\n" + (packInfo.PackBaoPian * packInfo.PackPianZhi /1000).ToString(qtyFormat2) + "\n" + S.PackSeqNo + "\n" + S.LotNo + "\n" + S.ProdDt + "\n" + S.ExpiredDt;
                            break;
                        case "203-AS":
                            S.Code2D = S.PartNo + "\n" + S.CustPartNo + "\n" + S.MatCode + "\n" + S.LotNo + "\n" + S.CustPONo + "\n" + S.ProdDt + "\n" + S.ExpiredDt + "\n" + S.Qty + "\n" + ls_Supplier;
                            break;
                        case "215-XAHT":
                            S.Code2D = S.PartNo + "\n" + S.CustPartNo + "\n" + S.MatCode + "\n" + S.LotNo + "\n" + S.CustPONo + "\n" + S.ProdDt + "\n" + S.ExpiredDt + "\n" + S.Qty + "\n" + ls_Supplier;
                            break;
                        case "204-CF": //S.Qty = (packInfo.PackBaoPian * packInfo.PackPianZhi / 1000).ToString(qtyFormat2);
                            S.CustLotNo = S.CustPartNo + " " + L.LotNo + " " + S.ProdDt;
                            S.MLotNo = L.MLotNo;
                            S.PackSeqNo = i.ToString().PadLeft(2, '0') + j.ToString().PadLeft(2, '0');
                            S.Code2D = "O" + S.CustPONo + ";" + "I0" + ";" + S.MatCode.Replace("N", "") + ";" + S.Qty + ";" + ls_Supplier + ";" + S.ProdDt + ";" + S.LotNo + ";" + "S" + S.PackSeqNo;
                            break;
                        case "208-FST":
                            S.PackSeqNo = i.ToString().PadLeft(2, '0') + j.ToString().PadLeft(2, '0');
                            S.LotNo = txtShipLotNo.Text.Trim();
                            S.Code2D = S.PartNo + "\n" + S.CustPartNo + "\n" + S.LotNo + "\n" + S.ProdDt + "\n" + S.ExpiredDt + "\n" + S.Qty + "\n" + ls_Supplier;
                            break;
                        case "209-JF":
                            S.Code2D = S.PartNo + "\n" + S.MatCode + "\n" + S.LotNo + "\n" + S.ProdDt + "\n" + S.ExpiredDt + "\n" + S.Qty + "\n" + ls_Supplier;
                            break;
                        case "210-KJ":
                            S.Code2D = S.PartNo + "\n" + S.CustPartNo + "\n" + S.MatCode + "\n" + S.LotNo + "\n" + S.ProdDt + "\n" + S.ExpiredDt + "\n" + S.Qty + "\n" + ls_Supplier;
                            break;
                        case "202-KH":
                            S.Code2D = S.CustPartNo + "," + S.MLotNo + "," + S.Qty + "," + S.ProdDt + "," + S.ExpiredDt + "," + S.PackSeqNo;
                            S.PackSeqNo = L.BoxNo + S.PackSeqNo;
                            break;
                        case "202R-KH":
                            S.Code2D = S.CustPartNo + "," + S.MLotNo + "," + S.Qty + "," + S.ProdDt + "," + S.ExpiredDt + "," + S.PackSeqNo;
                            S.PackSeqNo = L.BoxNo + S.PackSeqNo;
                            break;
                        case "212-AOI":
                            S.CustLotNo = string.Format("{0}{1}{2}{3}{4}{5}{6}", "A", txtShipLotNo.Text.Substring(0, 6), S.CustLotNo, "-", i, "-", j);
                                break;
                        default:
                                S.Code2D = S.LotNo;
                                break;
                       
                    }
                    this.mESM801LabelSBindingSource.Add(S);
                }

                this.gridHe.BestFitColumns();
                this.gridBao.BestFitColumns();
                this.gridXiang.BestFitColumns();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="boxNo"></param>
        /// <param name="packNo"></param>
        /// <param name="size"></param>
        /// <param name="preLotNo"></param>
        /// <param name="LotNo"></param>
        /// <param name="LotNoSeperator"></param>
        /// <param name="postLotNo"></param>
        /// <returns></returns>
        private string OnCreateLotNo(string size,string preLotNo, string LotNo, string LotNoSeperator,string postLotNo,string boxNo="", string packNo="")
        {
            string ls_return = "";
            if (boxNo == null) boxNo = "";
            if (packNo == null) packNo = "";
            if (boxNo != "") boxNo = boxNo.PadLeft(2, '0');
            if (packNo != "") packNo = packNo.PadLeft(2, '0');
            if (string.IsNullOrWhiteSpace(size))
            {
                ls_return = string.Format("{0}{1}{2}", preLotNo, LotNo, postLotNo);
            }
            if (size == "L")
            {
                ls_return = string.Format("{0}{1}{2}{3}{4}", preLotNo, LotNo, LotNoSeperator, boxNo, postLotNo);
            }
            if (size == "M")
            {
                ls_return = string.Format("{0}{1}{2}{3}{4}", preLotNo, LotNo, LotNoSeperator, boxNo, postLotNo);
            }
            if (size == "S")
            {
                ls_return = string.Format("{0}{1}{2}{3}{4}{5}{6}", preLotNo, LotNo, LotNoSeperator, boxNo, LotNoSeperator, packNo, postLotNo);
            }
            return ls_return;
        }
        /// <summary>
        /// 客户改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                this.txtProduct.Properties.DataSource = null;
            }
            else
            {
                string custCode = txtCustomer.EditValue.ToString();
                txtProduct.Properties.DataSource = packInfoServer.GetProductInputDataByCustCode(custCode);
            }
        }

        private void txtProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCustomer.Text) && !string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                string custCode = txtCustomer.EditValue.ToString();
                string lbpartNo = txtProduct.EditValue.ToString();
                var model = packInfoServer.GetPackInfo(custCode, lbpartNo);
                if (model != null)
                {
                    txtLabelTemp.Text = model.LabelType;
                    this.eRPM001ProductPackInfoBindingSource.DataSource = model;
                }
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<MES_M801_Label_L> L = this.mESM801LabelLBindingSource1.DataSource as List<MES_M801_Label_L>;
            List<MES_M801_Label_M> M = this.mESM801LabelMBindingSource.DataSource as List<MES_M801_Label_M>;
            List<MES_M801_Label_S> S = this.mESM801LabelSBindingSource.DataSource as List<MES_M801_Label_S>;
            labelService.Save(L, M, S);
            XtraMessageBox.Show("保存成功");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="labelParm">L-,M-,S-</param>
        private void PrintLabel(string labelKey)
        {

            INIFile inifile = new INIFile(INIFilePath);
            //string input = inifile.IniReadValue("PrintLabelSet", value);
            string barPath = inifile.IniReadValue("PrintLabelSet", "BarPath");//bartend的地址
            string labelPath = inifile.IniReadValue("PrintLabelSet", "LabelPath");//模版地址
            string labelParameter = inifile.IniReadValue("PrintLabelSet", labelKey);//打印机参数
            string labelDefultName = inifile.IniReadValue("PrintLabelSet", "DefaultName");//默认模版名称
            if (string.IsNullOrWhiteSpace(this.txtLabelTemp.Text))
                labelPath = labelPath + "\\" + labelKey + labelDefultName;
            else
                labelPath = labelPath + "\\" + labelKey + this.txtLabelTemp.Text;
            //if (!string.IsNullOrWhiteSpace(labelName) && !string.IsNullOrWhiteSpace(labelPath))
            //labelPath = labelPath.Substring(0, labelPath.LastIndexOf('\\')) + "\\"+labelName;
            string input = "bartend.exe" + "  " + labelPath + "  " + labelParameter;
            if (input == "")
            {
                XtraMessageBox.Show("模版设置为空，请检查");
                return;
            }
            XtraMessageBox.Show(input);
            //return;
            //string exe_path_in = barPath;
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.WorkingDirectory = barPath;
            cmd.StartInfo.CreateNoWindow = false;
            try
            {
                cmd.Start();

                cmd.StandardInput.WriteLine(input);
                cmd.StandardInput.WriteLine("exit");
            }
            catch (Exception ef)
            {
                XtraMessageBox.Show(ef.Message);
            }
        }
        /// <summary>
        /// 打印大标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintCass_Click(object sender, EventArgs e)
        {
            PrintLabel("L");
        }
        /// <summary>
        /// 打印中标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintBox_Click(object sender, EventArgs e)
        {
            PrintLabel("M");
        }
        /// <summary>
        /// 打印小标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintPackge_Click(object sender, EventArgs e)
        {
            PrintLabel("S");
        }

    }
}
