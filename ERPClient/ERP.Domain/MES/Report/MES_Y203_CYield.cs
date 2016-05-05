using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Y203_CYield
    {
        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("PlatType", "")]
        public string PlatType { get; set; }

        [ColumnMap("MacCode", "")]
        public string MacCode { get; set; }

        [ColumnMap("ModelCode", "")]
        public string ModelCode { get; set; }

        [ColumnMap("Operator", "")]
        public string Operator { get; set; }

        [ColumnMap("OperatorName", "")]
        public string OperatorName { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("JobNo", "")]
        public string JobNo { get; set; }

        [ColumnMap("UnitofSheet", "")]
        public decimal UnitofSheet { get; set; }

        [ColumnMap("YieldFactor", "")]
        public string YieldFactor { get; set; }

        [ColumnMap("BBScrollCnt", "")]
        public int? BBScrollCnt { get; set; }

        [ColumnMap("YBScrollCnt", "")]
        public int? YBScrollCnt { get; set; }

        [ColumnMap("ScrollCnt", "")]
        public int? ScrollCnt { get; set; }

        [ColumnMap("BBZZCInQty", "")]
        public decimal? BBZZCInQty { get; set; }

        [ColumnMap("YBZZCInQty", "")]
        public Decimal? YBZZCInQty { get; set; }

        [ColumnMap("ALLZZCInQty", "")]
        public Decimal? ALLZZCInQty { get; set; }

        [ColumnMap("BBZZCInQty_Individual", "")]
        public Decimal? BBZZCInQty_Individual { get; set; }

        [ColumnMap("YBZZCInQty_Individual", "")]
        public Decimal? YBZZCInQty_Individual { get; set; }

        [ColumnMap("ALLZZCInQty_Individual", "")]
        public Decimal? ALLZZCInQty_Individual { get; set; }

        [ColumnMap("BBInQty", "")]
        public Decimal? BBInQty { get; set; }

        [ColumnMap("YBInQty", "")]
        public Decimal? YBInQty { get; set; }

        [ColumnMap("ALLInQty", "")]
        public Decimal? ALLInQty { get; set; }

        [ColumnMap("BBInQty_Individual", "")]
        public Decimal? BBInQty_Individual { get; set; }

        [ColumnMap("YBInQty_Individual", "")]
        public Decimal? YBInQty_Individual { get; set; }

        [ColumnMap("ALLInQty_Individual", "")]
        public Decimal? ALLInQty_Individual { get; set; }

        [ColumnMap("BBOutQty", "")]
        public Decimal? BBOutQty { get; set; }

        [ColumnMap("YBOutQty", "")]
        public Decimal? YBOutQty { get; set; }

        [ColumnMap("ALLOutQty", "")]
        public Decimal? ALLOutQty { get; set; }

        [ColumnMap("BBOutQty_Individual", "")]
        public Decimal? BBOutQty_Individual { get; set; }

        [ColumnMap("YBOutQty_Individual", "")]
        public Decimal? YBOutQty_Individual { get; set; }

        [ColumnMap("ALLOutQty_Individual", "")]
        public Decimal? ALLOutQty_Individual { get; set; }

        [ColumnMap("BBOutQtyInK", "")]
        public Decimal? BBOutQtyInK { get; set; }

        [ColumnMap("YBOutQtyInK", "")]
        public Decimal? YBOutQtyInk { get; set; }

        [ColumnMap("AllOutQtyInK", "")]
        public Decimal? AllOutQtyInK { get; set; }

        [ColumnMap("BBOutQtyInK_Individual", "")]
        public Decimal? BBOutQtyInK_Individual { get; set; }

        [ColumnMap("YBOutQtyInK_Individual", "")]
        public Decimal? YBOutQtyInk_Individual { get; set; }

        [ColumnMap("AllOutQtyInK_Individual", "")]
        public Decimal? AllOutQtyInK_Individual { get; set; }
    }
}