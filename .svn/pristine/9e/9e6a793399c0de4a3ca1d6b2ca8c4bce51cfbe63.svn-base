using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_M002_Job : AggregateRoot
    {
        public MES_M002_Job(Guid id)
            : base(id)
        {

        }
        public MES_M002_Job()
            : base(Guid.NewGuid())
        {

        }


        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }

        [ColumnMap("JobNo", "")]
        public string JobNo { get; set; }

        [ColumnMap("JobDt", "")]
        public DateTime? JobDt { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("FItemCode", "")]
        public string FItemCode { get; set; }

        [ColumnMap("ItemCode", "")]
        public string ItemCode { get; set; }

        [ColumnMap("OrderNo", "")]
        public string OrderNo { get; set; }

        public decimal OrdQty { get; set; }

        [ColumnMap("CustCode", "")]
        public string CustCode { get; set; }

        [ColumnMap("ProcessFlow", "")]
        public string ProcessFlow { get; set; }

        [ColumnMap("Status", "")]
        public string Status { get; set; }

        [ColumnMap("ProdTargetDt", "")]
        public DateTime? ProdTargetDt { get; set; }

        [ColumnMap("IssueTargetDt", "")]
        public DateTime? IssueTargetDt { get; set; }

        [ColumnMap("ApprovalDt", "")]
        public DateTime? ApprovalDt { get; set; }

        [ColumnMap("ApprovalBy", "")]
        public string ApprovalBy { get; set; }

        [ColumnMap("Remarks", "")]
        public string Remarks { get; set; }

        [ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt { get; set; }

        [ColumnMap("ModifyUser", "")]
        public string ModifyUser { get; set; }

        [ColumnMap("CreateDt", "")]
        public DateTime? CreateDt { get; set; }

        [ColumnMap("CreateUser", "")]
        public string CreateUser { get; set; }

        [ColumnMap("JobQty", "工单数量")]
        public decimal JobQty { get; set; }

        [ColumnMap("PQty", "")]
        public decimal PQty { get; set; }

        [ColumnMap("BCPQty", "")]
        public decimal BCPQty { get; set; }

        [ColumnMap("EQty", "")]
        public decimal EQty { get; set; }

        [ColumnMap("ZZCQty", "")]
        public decimal ZZCQty { get; set; }

        [ColumnMap("CQty", "")]
        public decimal CQty { get; set; }

        [ColumnMap("QQty", "")]
        public decimal QQty { get; set; }

        [ColumnMap("CPQty", "")]
        public decimal CPQty { get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }

        [ColumnMap("PanelQty", "板数")]
        public decimal PanelQty { get; set; }

        [ColumnMap("StripPerPanel", "每板数量")]
        public decimal StripPerPanel { get; set; }

        [ColumnMap("LotCount", "总Lot数")]
        public decimal LotCount { get; set; }

        [ColumnMap("IssueQty", "出货数量")]
        public decimal IssueQty { get; set; }
    }
}