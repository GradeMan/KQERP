using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class vw_JobReport:AggregateRoot
	{
   		public  vw_JobReport(Guid id)
   			: base(id)
		{
			
		}
		public  vw_JobReport( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		[ColumnMap("JobNo", "")]
        public string JobNo{ get; set; }
				
		[ColumnMap("JobDt", "")]
        public DateTime? JobDt{ get; set; }
				
		[ColumnMap("LotNo", "")]
        public string LotNo{ get; set; }
				
		[ColumnMap("LotQty", "")]
        public decimal? LotQty{ get; set; }
				
		[ColumnMap("JobType", "")]
        public string JobType{ get; set; }
				
		[ColumnMap("CustCode", "")]
        public string CustCode{ get; set; }

       [ColumnMap("CustName", "")]
        public string CustName { get; set; }

		[ColumnMap("ItemCode", "")]
        public string ItemCode{ get; set; }
				
		[ColumnMap("ItemName", "")]
        public string ItemName{ get; set; }
				
		[ColumnMap("OrderNo", "")]
        public string OrderNo{ get; set; }
				
		[ColumnMap("CustMatNo", "")]
        public string CustMatNo{ get; set; }
				
		[ColumnMap("CustPartName", "")]
        public string CustPartName{ get; set; }
				
		[ColumnMap("Expr1", "")]
        public string Expr1{ get; set; }
				
		[ColumnMap("CorpDrawingNo", "")]
        public string CorpDrawingNo{ get; set; }
				
		[ColumnMap("CorpDrawingRevNo", "")]
        public string CorpDrawingRevNo{ get; set; }
				
		[ColumnMap("CustDrawingNo", "")]
        public string CustDrawingNo{ get; set; }
				
		[ColumnMap("CustDrawingRevNo", "")]
        public string CustDrawingRevNo{ get; set; }
				
		[ColumnMap("ItemSize", "")]
        public int? ItemSize{ get; set; }
				
		[ColumnMap("SpecUnitofSheet", "")]
        public string SpecUnitofSheet{ get; set; }
				
		[ColumnMap("SpecLeads", "")]
        public string SpecLeads{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatSpec", "")]
        public string MatSpec{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }

        public string SuppName { get; set; }
				
		[ColumnMap("OrdQty", "")]
        public decimal? OrdQty { get; set; }
				
		[ColumnMap("JobQty", "")]
        public decimal? JobQty { get; set; }
				
		[ColumnMap("IssueQty", "")]
        public decimal? IssueQty { get; set; }
				
		[ColumnMap("IssueTargetDt", "")]
        public DateTime? IssueTargetDt{ get; set; }
				
		[ColumnMap("ProdTargetDt", "")]
        public DateTime? ProdTargetDt{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
		   
	}
}