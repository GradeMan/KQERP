using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ERP.Domain
{
    public class ProductMaterialViewModel
    {
        public Guid Id { get; set; }

        [ColumnMap("CompCode", "CompCode")]
        public string CompCode { get; set; }

        [ColumnMap("PlanDetailId", "PlanDetailId")]
        public Guid PlanDetailId { get; set; }

        [ColumnMap("PLNo", "PLNo")]
        public string PLNo { get; set; }

        [ColumnMap("PartNo", "PartNo")]
        public string PartNo { get; set; }

        [ColumnMap("MatCode", "MatCode")]
        public string MatCode { get; set; }

        [ColumnMap("SuppCode", "SuppCode")]
        public string SuppCode { get; set; }

        [ColumnMap("Unit", "Unit")]
        public string Unit { get; set; }

        [ColumnMap("UnitPrice", "UnitPrice")]
        public string UnitPrice { get; set; }

        [ColumnMap("Qty", "Qty")]
        public decimal? Qty { get; set; }

        [ColumnMap("Remarks", "Remarks")]
        public string Remarks { get; set; }

        [ColumnMap("ModifyDt", "ModifyDt")]
        public DateTime? ModifyDt { get; set; }

        [ColumnMap("ModifyUser", "ModifyUser")]
        public string ModifyUser { get; set; }

        [ColumnMap("CreateDt", "CreateDt")]
        public DateTime? CreateDt { get; set; }

        [ColumnMap("CreateUser", "CreateUser")]
        public string CreateUser { get; set; }

        public Guid PlanId { get; set; }

        public string CustType { get; set; }
        public string CustCode { get; set; }

        public string PartName { get; set; }

        public string PartSpec { get; set; }

        public string MatName { get; set; }

        public string MatSpec { get; set; }

        public decimal? UnitConsume { get; set; }

        public string CustAlias { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        public decimal? SumQty { get; set; }

        [ColumnMap("PLDt", "PLDt")]
        public DateTime? PLDt { get; set; }

        [ColumnMap("PLType", "月，日，周 单")]
        public string PLType { get; set; }

        [ColumnMap("PLAuditing", "是否审核")]
        public string PLAuditing { get; set; }
        [ColumnMap("PLAuditingDt", "审核时间")]
        public DateTime? PLAuditingDt { get; set; }

        public string SONo { get; set; }

    }

    public class M201PlanProductViewModel
    {
        [ColumnMap("PLNo", "PLNo")]
        public string PLNo { get; set; }

        [ColumnMap("PLDt", "PLDt")]
        public DateTime? PLDt { get; set; }

        [ColumnMap("PLType", "月，日，周 单")]
        public string PLType { get; set; }

        [ColumnMap("PLAuditing", "是否审核")]
        public string PLAuditing { get; set; }
        [ColumnMap("PLAuditingDt", "审核时间")]
        public DateTime? PLAuditingDt { get; set; }

        [ColumnMap("PlanId", "PlanId")]
        public Guid PlanId { get; set; }

        public string PartName { get; set; }

        public string PartSpec { get; set; }

        [ColumnMap("PartNo", "PartNo")]
        public string PartNo { get; set; }

        public string CustCode { get; set; }

        public string CustAlias { get; set; }

        [ColumnMap("Qty", "Qty")]
        public decimal? Qty { get; set; }

        [ColumnMap("FQty", "FQty")]
        public decimal? FQty { get; set; }

        [ColumnMap("AdJustQty", "调整数量")]
        public decimal? AdJustQty { get; set; }

        [ColumnMap("SumQty", "总数量")]
        public decimal? SumQty { get; set; }

        public string SONo { get; set; }
    }
}
