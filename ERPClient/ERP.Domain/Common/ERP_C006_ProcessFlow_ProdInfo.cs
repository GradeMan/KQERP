using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C006_ProcessFlow_ProdInfo:AggregateRoot
	{
   		public  ERP_C006_ProcessFlow_ProdInfo(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C006_ProcessFlow_ProdInfo( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PFCode","PFCode")]
        public string PFCode{ get; set; }
				
		[ColumnMap("ProcessCode","ProcessCode")]
        public string ProcessCode{ get; set; }
				
		[ColumnMap("TechCode","TechCode")]
        public string TechCode{ get; set; }
				
		[ColumnMap("TechType","TechType")]
        public string TechType{ get; set; }
				
		[ColumnMap("IsVisible","IsVisible")]
        public bool IsVisible{ get; set; }
				
		[ColumnMap("TechSeqNo","TechSeqNo")]
        public string TechSeqNo{ get; set; }
				
		[ColumnMap("TechContent","TechContent")]
        public string TechContent{ get; set; }
				
		[ColumnMap("Remarks","Remarks")]
        public string Remarks{ get; set; }
				
		[ColumnMap("Status","Status")]
        public string Status{ get; set; }
		   
	}
}