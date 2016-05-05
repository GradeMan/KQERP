using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_MatConsume_ActMatDetail:AggregateRoot
	{
   		public  WMS_MatConsume_ActMatDetail(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_MatConsume_ActMatDetail( )
			: base(Guid.NewGuid())
		{
		
		}
      			

				
		[ColumnMap("StampingNo", "")]
        public string StampingNo{ get; set; }
				
		[ColumnMap("MatSpecCode", "")]
        public string MatSpecCode{ get; set; }
				
		[ColumnMap("MatSpec", "")]
        public string MatSpec{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatName", "")]
        public string MatName{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("ShortName", "")]
        public string ShortName{ get; set; }
				
		[ColumnMap("ReqQty", "")]
        public decimal ReqQty{ get; set; }
				
		[ColumnMap("RetQty", "")]
        public decimal RetQty{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
		   
	}
}