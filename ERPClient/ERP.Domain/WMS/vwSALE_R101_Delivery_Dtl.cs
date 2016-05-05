using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Domain;

namespace ERP.Domain
{
    public class vwSALE_R101_Delivery_Dtl
    {
        [ColumnMap("DocNo", "")]
        public string DocNo { get; set; }

        [ColumnMap("TxDt", "")]
        public DateTime? TxDt { get; set; }

        [ColumnMap("CustCode", "")]
        public string CustCode { get; set; }

        [ColumnMap("CustName", "")]
        public string CustName { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("PartName", "")]
        public string PartName { get; set; }

        [ColumnMap("PartType", "")]
        public string PartType { get; set; }

        [ColumnMap("PartSpec", "")]
        public string PartSpec { get; set; }

        [ColumnMap("CustPartNo", "")]
        public string CustPartNo { get; set; }

        [ColumnMap("CustPartName", "")]
        public string CustPartName { get; set; }

        [ColumnMap("CustPartType", "")]
        public string CustPartType { get; set; }

        [ColumnMap("CustPartSpec", "")]
        public string CustPartSpec { get; set; }

        [ColumnMap("CustPONo", "")]
        public string CustPONo { get; set; }

        [ColumnMap("Supplier", "")]
        public string Supplier { get; set; }

        [ColumnMap("MLotNo", "")]
        public string MLotNo { get; set; }

        [ColumnMap("LotNo", "")]
        public string LotNo { get; set; }

        [ColumnMap("ProdDt", "")]
        public string ProdDt { get; set; }

        [ColumnMap("ExpDt", "")]
        public string ExpDt { get; set; }

        [ColumnMap("BoxQty", "")]
        public int? BoxQty { get; set; }

        [ColumnMap("PerQty", "")]
        public decimal? PerQty { get; set; }

        public decimal? SumAmount { get; set; }

        public string CustDrawingNo { get; set; }

    }
}
