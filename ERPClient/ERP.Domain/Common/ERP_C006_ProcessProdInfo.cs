using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C006_ProcessProdInfo:AggregateRoot
	{
   		public  ERP_C006_ProcessProdInfo(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C006_ProcessProdInfo( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ProcessCode","ProcessCode")]
        public string ProcessCode{ get; set; }
				
		[ColumnMap("TechCode","TechCode")]
        public string TechCode{ get; set; }
				
		[ColumnMap("TechSeqNo","TechSeqNo")]
        public string TechSeqNo{ get; set; }
				
		[ColumnMap("TechContent","TechContent")]
        public string TechContent{ get; set; }
				
		[ColumnMap("TechType","TechType")]
        public string TechType{ get; set; }
				
		[ColumnMap("IsVisible","IsVisible")]
        public bool IsVisible{ get; set; }
				
		[ColumnMap("Remarks","Remarks")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt","ModifyDt")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser","ModifyUser")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt","CreateDt")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser","CreateUser")]
        public string CreateUser{ get; set; }
		   
	}
}