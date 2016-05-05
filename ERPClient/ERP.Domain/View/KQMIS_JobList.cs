using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class KQMIS_JobList2 
    {
        [ColumnMap("J_JobNo", "")]
        public string J_JobNo { get; set; }

        [ColumnMap("J_MatchJobNo", "")]
        public string J_MatchJobNo { get; set; }

        [ColumnMap("J_IsFinished", "")]
        public bool J_IsFinished { get; set; }

        [ColumnMap("J_PartNo", "")]
        public string J_PartNo { get; set; }

        [ColumnMap("J_SuppLot", "")]
        public string J_SuppLot { get; set; }

        [ColumnMap("J_SuppCode", "")]
        public string J_SuppCode { get; set; }

        [ColumnMap("J_MatCode", "")]
        public string J_MatCode { get; set; }

        [ColumnMap("J_MatWeight", "")]
        public decimal? J_MatWeight { get; set; }

        [ColumnMap("J_CustCode", "")]
        public string J_CustCode { get; set; }

        [ColumnMap("J_CustReq", "")]
        public string J_CustReq { get; set; }

        [ColumnMap("J_Width", "")]
        public string J_Width { get; set; }

        [ColumnMap("J_Distance", "")]
        public string J_Distance { get; set; }

        [ColumnMap("J_MatLotNo", "")]
        public string J_MatLotNo { get; set; }

        [ColumnMap("J_Remarks", "")]
        public string J_Remarks { get; set; }

        [ColumnMap("J_OrderNo", "")]
        public string J_OrderNo { get; set; }

        [ColumnMap("P_PLot", "")]
        public string P_PLot { get; set; }

        [ColumnMap("P_ProdDt", "")]
        public DateTime? P_ProdDt { get; set; }

        [ColumnMap("P_TxDt", "")]
        public DateTime? P_TxDt { get; set; }

        [ColumnMap("P_MacCode", "")]
        public string P_MacCode { get; set; }

        [ColumnMap("P_ModelCode", "")]
        public string P_ModelCode { get; set; }

        [ColumnMap("P_ShiftCode", "")]
        public string P_ShiftCode { get; set; }

        [ColumnMap("P_ScrollCode", "")]
        public string P_ScrollCode { get; set; }

        [ColumnMap("P_SideCode", "")]
        public string P_SideCode { get; set; }

        [ColumnMap("P_InQty", "")]
        public decimal? P_InQty { get; set; }

        [ColumnMap("P_InWeight", "")]
        public decimal? P_InWeight { get; set; }

        [ColumnMap("P_OutQty", "")]
        public decimal? P_OutQty { get; set; }

        [ColumnMap("P_OutWeight", "")]
        public decimal? P_OutWeight { get; set; }

        [ColumnMap("P_Operator", "")]
        public string P_Operator { get; set; }

        [ColumnMap("P_Suppervisor", "")]
        public string P_Suppervisor { get; set; }

        [ColumnMap("P_Remarks", "")]
        public string P_Remarks { get; set; }

        [ColumnMap("P_NGQty", "")]
        public decimal? P_NGQty { get; set; }

        [ColumnMap("P_PartLine", "")]
        public string P_PartLine { get; set; }

        [ColumnMap("P_PartColumn", "")]
        public string P_PartColumn { get; set; }

        [ColumnMap("P_PPartNo", "")]
        public string P_PPartNo { get; set; }

        [ColumnMap("P_CustCode", "")]
        public string P_CustCode { get; set; }

        [ColumnMap("P_CreateDt", "")]
        public DateTime? P_CreateDt { get; set; }

        [ColumnMap("P_CreateUser", "")]
        public int? P_CreateUser { get; set; }

        [ColumnMap("P_ELOT", "")]
        public string P_ELOT { get; set; }

        [ColumnMap("P_JobType", "")]
        public string P_JobType { get; set; }

        [ColumnMap("P_JobYC", "")]
        public string P_JobYC { get; set; }

        [ColumnMap("E_ELot", "")]
        public string E_ELot { get; set; }

        [ColumnMap("E_ProdDt", "")]
        public DateTime? E_ProdDt { get; set; }

        [ColumnMap("E_TxDt", "")]
        public DateTime? E_TxDt { get; set; }

        [ColumnMap("E_MacCode", "")]
        public string E_MacCode { get; set; }

        [ColumnMap("E_MacLineNo", "")]
        public string E_MacLineNo { get; set; }

        [ColumnMap("E_ShiftCode", "")]
        public string E_ShiftCode { get; set; }

        [ColumnMap("E_ScrollCode", "")]
        public string E_ScrollCode { get; set; }

        [ColumnMap("E_PlatType", "")]
        public string E_PlatType { get; set; }

        [ColumnMap("E_Operator", "")]
        public string E_Operator { get; set; }

        [ColumnMap("E_InQty", "")]
        public decimal? E_InQty { get; set; }

        [ColumnMap("E_NGInQty", "")]
        public decimal? E_NGInQty { get; set; }

        [ColumnMap("E_OutQty", "")]
        public decimal? E_OutQty { get; set; }

        [ColumnMap("E_NGOutQty", "")]
        public decimal? E_NGOutQty { get; set; }

        [ColumnMap("E_Suppervisor", "")]
        public string E_Suppervisor { get; set; }

        [ColumnMap("E_Remarks", "")]
        public string E_Remarks { get; set; }

        [ColumnMap("E_CreateDt", "")]
        public DateTime? E_CreateDt { get; set; }

        [ColumnMap("E_CreateUser", "")]
        public int? E_CreateUser { get; set; }

        [ColumnMap("E_EPartNo", "")]
        public string E_EPartNo { get; set; }

        [ColumnMap("E_CustCode", "")]
        public string E_CustCode { get; set; }

        [ColumnMap("E_JobType", "")]
        public string E_JobType { get; set; }

        [ColumnMap("E_JobYC", "")]
        public string E_JobYC { get; set; }

        [ColumnMap("E_PanWeight", "")]
        public decimal? E_PanWeight { get; set; }

        [ColumnMap("C_CLot", "")]
        public string C_CLot { get; set; }

        [ColumnMap("C_ProdDt", "")]
        public DateTime? C_ProdDt { get; set; }

        [ColumnMap("C_TxDt", "")]
        public DateTime? C_TxDt { get; set; }

        [ColumnMap("C_MacCode", "")]
        public string C_MacCode { get; set; }

        [ColumnMap("C_ModelCode", "")]
        public string C_ModelCode { get; set; }

        [ColumnMap("C_ShiftCode", "")]
        public string C_ShiftCode { get; set; }

        [ColumnMap("C_ScrollCode", "")]
        public string C_ScrollCode { get; set; }

        [ColumnMap("C_InQty", "")]
        public decimal? C_InQty { get; set; }

        [ColumnMap("C_OutQty", "")]
        public decimal? C_OutQty { get; set; }

        [ColumnMap("C_UnitofSheet", "")]
        public decimal? C_UnitofSheet { get; set; }

        [ColumnMap("C_Remarks", "")]
        public string C_Remarks { get; set; }

        [ColumnMap("C_Operator", "")]
        public string C_Operator { get; set; }

        [ColumnMap("C_Suppervisor", "")]
        public string C_Suppervisor { get; set; }

        [ColumnMap("C_Width", "")]
        public string C_Width { get; set; }

        [ColumnMap("C_Distance", "")]
        public string C_Distance { get; set; }

        [ColumnMap("C_Deep", "")]
        public string C_Deep { get; set; }

        [ColumnMap("C_CreateDt", "")]
        public DateTime? C_CreateDt { get; set; }

        [ColumnMap("C_CreateUser", "")]
        public int? C_CreateUser { get; set; }

        [ColumnMap("C_CPartNo", "")]
        public string C_CPartNo { get; set; }

        [ColumnMap("C_CCustCode", "")]
        public string C_CCustCode { get; set; }

        [ColumnMap("C_JobType", "")]
        public string C_JobType { get; set; }

        [ColumnMap("C_JobYC", "")]
        public string C_JobYC { get; set; }

        [ColumnMap("D_DLot", "")]
        public string D_DLot { get; set; }

        [ColumnMap("D_ProdDt", "")]
        public DateTime? D_ProdDt { get; set; }

        [ColumnMap("D_TxDt", "")]
        public DateTime? D_TxDt { get; set; }

        [ColumnMap("D_MacCode", "")]
        public string D_MacCode { get; set; }

        [ColumnMap("D_ModelCode", "")]
        public string D_ModelCode { get; set; }

        [ColumnMap("D_ShiftCode", "")]
        public string D_ShiftCode { get; set; }

        [ColumnMap("D_ScrollCode", "")]
        public string D_ScrollCode { get; set; }

        [ColumnMap("D_InQty", "")]
        public decimal? D_InQty { get; set; }

        [ColumnMap("D_OutQty", "")]
        public decimal? D_OutQty { get; set; }

        [ColumnMap("D_UnitofSheet", "")]
        public decimal? D_UnitofSheet { get; set; }

        [ColumnMap("D_Remarks", "")]
        public string D_Remarks { get; set; }

        [ColumnMap("D_Operator", "")]
        public string D_Operator { get; set; }

        [ColumnMap("D_Suppervisor", "")]
        public string D_Suppervisor { get; set; }

        [ColumnMap("D_JobType", "")]
        public string D_JobType { get; set; }

        [ColumnMap("D_JobYC", "")]
        public string D_JobYC { get; set; }

        [ColumnMap("Q_QLot", "")]
        public string Q_QLot { get; set; }

        [ColumnMap("Q_ProdDt", "")]
        public DateTime? Q_ProdDt { get; set; }

        [ColumnMap("Q_TxDt", "")]
        public DateTime? Q_TxDt { get; set; }

        [ColumnMap("Q_BoxLot", "")]
        public string Q_BoxLot { get; set; }

        [ColumnMap("Q_Operator", "")]
        public string Q_Operator { get; set; }

        [ColumnMap("Q_GQty", "")]
        public decimal? Q_GQty { get; set; }

        [ColumnMap("Q_NGQty", "")]
        public decimal? Q_NGQty { get; set; }

        [ColumnMap("Q_Remarks", "")]
        public string Q_Remarks { get; set; }

        [ColumnMap("Q_UnitofSheet", "")]
        public decimal? Q_UnitofSheet { get; set; }

        [ColumnMap("Q_BoxScroll", "")]
        public string Q_BoxScroll { get; set; }

        [ColumnMap("Q_JobQty", "")]
        public decimal? Q_JobQty { get; set; }

        [ColumnMap("Q_InQty", "")]
        public decimal? Q_InQty { get; set; }

        [ColumnMap("Q_InQtyInK", "")]
        public decimal? Q_InQtyInK { get; set; }

        [ColumnMap("Q_GQtyInK", "")]
        public decimal? Q_GQtyInK { get; set; }

        [ColumnMap("Q_NGQtyInk", "")]
        public decimal? Q_NGQtyInk { get; set; }

        [ColumnMap("Q_Create", "")]
        public DateTime? Q_Create { get; set; }

        [ColumnMap("Q_CreateUser", "")]
        public int? Q_CreateUser { get; set; }

        [ColumnMap("Q_QPartNo", "")]
        public string Q_QPartNo { get; set; }

        [ColumnMap("Q_cDescription", "")]
        public string Q_cDescription { get; set; }

        [ColumnMap("Q_QCustCode", "")]
        public string Q_QCustCode { get; set; }

        [ColumnMap("Q_PNGCriteria_MC", "")]
        public decimal? Q_PNGCriteria_MC { get; set; }

        [ColumnMap("Q_PNGCriteria_HDBX", "")]
        public decimal? Q_PNGCriteria_HDBX { get; set; }

        [ColumnMap("Q_PNGCriteria_DY", "")]
        public decimal? Q_PNGCriteria_DY { get; set; }

        [ColumnMap("Q_PNGCriteria_DJBX", "")]
        public decimal? Q_PNGCriteria_DJBX { get; set; }

        [ColumnMap("Q_PNGCriteria_WD", "")]
        public decimal? Q_PNGCriteria_WD { get; set; }

        [ColumnMap("Q_PNGCriteria_BJC", "")]
        public decimal? Q_PNGCriteria_BJC { get; set; }

        [ColumnMap("Q_PNGCriteria_CTD", "")]
        public decimal? Q_PNGCriteria_CTD { get; set; }

        [ColumnMap("Q_PNGCriteria_WJY", "")]
        public decimal? Q_PNGCriteria_WJY { get; set; }

        [ColumnMap("Q_PNGCriteria_SX", "")]
        public decimal? Q_PNGCriteria_SX { get; set; }

        [ColumnMap("Q_PNGCriteria_HS", "")]
        public decimal? Q_PNGCriteria_HS { get; set; }

        [ColumnMap("Q_PNGCriteria_ZH", "")]
        public decimal? Q_PNGCriteria_ZH { get; set; }

        [ColumnMap("Q_PNGCriteria_HW", "")]
        public decimal? Q_PNGCriteria_HW { get; set; }

        [ColumnMap("Q_PNGCriteria_BJD", "")]
        public decimal? Q_PNGCriteria_BJD { get; set; }

        [ColumnMap("Q_PNGCriteria_Other", "")]
        public decimal? Q_PNGCriteria_Other { get; set; }

        [ColumnMap("Q_PNGRemarks", "")]
        public string Q_PNGRemarks { get; set; }

        [ColumnMap("Q_ENGCriteria_MGS", "")]
        public decimal? Q_ENGCriteria_MGS { get; set; }

        [ColumnMap("Q_ENGCriteria_DDYC", "")]
        public decimal? Q_ENGCriteria_DDYC { get; set; }

        [ColumnMap("Q_ENGCriteria_QP", "")]
        public decimal? Q_ENGCriteria_QP { get; set; }

        [ColumnMap("Q_ENGCriteria_SJ", "")]
        public decimal? Q_ENGCriteria_SJ { get; set; }

        [ColumnMap("Q_ENGCriteria_HDBX", "")]
        public decimal? Q_ENGCriteria_HDBX { get; set; }

        [ColumnMap("Q_ENGCriteria_YY", "")]
        public decimal? Q_ENGCriteria_YY { get; set; }

        [ColumnMap("Q_ENGCriteria_WD", "")]
        public decimal? Q_ENGCriteria_WD { get; set; }

        [ColumnMap("Q_ENGCriteria_BX", "")]
        public decimal? Q_ENGCriteria_BX { get; set; }

        [ColumnMap("Q_ENGCriteria_GX", "")]
        public decimal? Q_ENGCriteria_GX { get; set; }

        [ColumnMap("Q_ENGCriteria_KDBX", "")]
        public decimal? Q_ENGCriteria_KDBX { get; set; }

        [ColumnMap("Q_ENGCriteria_OTHER", "")]
        public decimal? Q_ENGCriteria_OTHER { get; set; }

        [ColumnMap("Q_ENGCriteria_TSBL", "")]
        public decimal? Q_ENGCriteria_TSBL { get; set; }

        [ColumnMap("Q_ENGCriteria_ZW", "")]
        public decimal? Q_ENGCriteria_ZW { get; set; }

        [ColumnMap("Q_ENGCriteria_TBL", "")]
        public decimal? Q_ENGCriteria_TBL { get; set; }

        [ColumnMap("Q_ENGCriteria_QIPI", "")]
        public decimal? Q_ENGCriteria_QIPI { get; set; }

        [ColumnMap("Q_ENGCriteria_CCFF", "")]
        public decimal? Q_ENGCriteria_CCFF { get; set; }

        [ColumnMap("Q_ENGCriteria_YYM", "")]
        public decimal? Q_ENGCriteria_YYM { get; set; }

        [ColumnMap("Q_ENGCriteria_ZH", "")]
        public decimal? Q_ENGCriteria_ZH { get; set; }

        [ColumnMap("Q_ENGCriteria_LT", "")]
        public decimal? Q_ENGCriteria_LT { get; set; }

        [ColumnMap("Q_ENGCriteria_HW", "")]
        public decimal? Q_ENGCriteria_HW { get; set; }

        [ColumnMap("Q_ENGCriteria_BJC", "")]
        public decimal? Q_ENGCriteria_BJC { get; set; }

        [ColumnMap("Q_ENGRemarks", "")]
        public string Q_ENGRemarks { get; set; }

        [ColumnMap("Q_CNGCriteria_CDBF", "")]
        public decimal? Q_CNGCriteria_CDBF { get; set; }

        [ColumnMap("Q_CNGCriteria_MGS", "")]
        public decimal? Q_CNGCriteria_MGS { get; set; }

        [ColumnMap("Q_CNGCriteria_DJBX", "")]
        public decimal? Q_CNGCriteria_DJBX { get; set; }

        [ColumnMap("Q_CNGCriteria_LW", "")]
        public decimal? Q_CNGCriteria_LW { get; set; }

        [ColumnMap("Q_CNGCriteria_DY", "")]
        public decimal? Q_CNGCriteria_DY { get; set; }

        [ColumnMap("Q_CNGCriteria_HS", "")]
        public decimal? Q_CNGCriteria_HS { get; set; }

        [ColumnMap("Q_CNGCriteria_ZS", "")]
        public decimal? Q_CNGCriteria_ZS { get; set; }

        [ColumnMap("Q_CNGCriteria_ZJFQ", "")]
        public decimal? Q_CNGCriteria_ZJFQ { get; set; }

        [ColumnMap("Q_CNGCriteria_HW", "")]
        public decimal? Q_CNGCriteria_HW { get; set; }

        [ColumnMap("Q_CNGCriteria_ZW", "")]
        public decimal? Q_CNGCriteria_ZW { get; set; }

        [ColumnMap("Q_CNGCriteria_HMQX", "")]
        public decimal? Q_CNGCriteria_HMQX { get; set; }

        [ColumnMap("Q_CNGCriteria_JDTL", "")]
        public decimal? Q_CNGCriteria_JDTL { get; set; }

        [ColumnMap("Q_CNGCriteria_MC", "")]
        public decimal? Q_CNGCriteria_MC { get; set; }

        [ColumnMap("Q_CNGCriteria_OTHER", "")]
        public decimal? Q_CNGCriteria_OTHER { get; set; }

        [ColumnMap("Q_CNGRemarks", "")]
        public string Q_CNGRemarks { get; set; }

        [ColumnMap("Q_NGCriteria", "")]
        public decimal? Q_NGCriteria { get; set; }

        [ColumnMap("Q_NGRemarks", "")]
        public string Q_NGRemarks { get; set; }

        [ColumnMap("Q_NGRemarks2", "")]
        public string Q_NGRemarks2 { get; set; }

        [ColumnMap("Q_JobType", "")]
        public string Q_JobType { get; set; }

        [ColumnMap("Q_JobYC", "")]
        public string Q_JobYC { get; set; }

        [ColumnMap("B_LotNoList", "")]
        public string B_LotNoList { get; set; }

        [ColumnMap("B_LotNoQtyList", "")]
        public string B_LotNoQtyList { get; set; }

        [ColumnMap("J_bcpintxdt", "")]
        public DateTime? J_bcpintxdt { get; set; }

        [ColumnMap("J_bcppanweight", "")]
        public decimal? J_bcppanweight { get; set; }

        [ColumnMap("J_bcpinqty", "")]
        public decimal? J_bcpinqty { get; set; }

        [ColumnMap("J_bcpouttxdt", "")]
        public DateTime? J_bcpouttxdt { get; set; }

        [ColumnMap("J_bcpoutreceipt", "")]
        public string J_bcpoutreceipt { get; set; }

        [ColumnMap("J_bcpinweight", "")]
        public decimal? J_bcpinweight { get; set; }

        [ColumnMap("J_bcpinfyr", "")]
        public decimal? J_bcpinfyr { get; set; }

        [ColumnMap("J_bcpout", "")]
        public int? J_bcpout { get; set; }

        [ColumnMap("J_BcpRemarks", "")]
        public string J_BcpRemarks { get; set; }

        [ColumnMap("J_zzcin", "")]
        public int? J_zzcin { get; set; }

        [ColumnMap("J_zzcintxdt", "")]
        public DateTime? J_zzcintxdt { get; set; }

        [ColumnMap("J_zzcinweight", "")]
        public decimal? J_zzcinweight { get; set; }

        [ColumnMap("J_zzcpanweight", "")]
        public decimal? J_zzcpanweight { get; set; }

        [ColumnMap("J_zzcinqty", "")]
        public decimal? J_zzcinqty { get; set; }

        [ColumnMap("J_zzcinfyr", "")]
        public decimal? J_zzcinfyr { get; set; }

        [ColumnMap("J_zzcouttxdt", "")]
        public DateTime? J_zzcouttxdt { get; set; }

        [ColumnMap("J_zzcoutreceipt", "")]
        public string J_zzcoutreceipt { get; set; }

        [ColumnMap("J_zzcremarks", "")]
        public string J_zzcremarks { get; set; }

        [ColumnMap("J_IsJobYC", "")]
        public bool? J_IsJobYC { get; set; }

    }
}