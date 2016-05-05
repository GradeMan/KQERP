using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_M105_MatGetDetail:AggregateRoot
	{
   		public  WMS_M105_MatGetDetail(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_M105_MatGetDetail( )
			: base(Guid.NewGuid())
		{
		
		}
      			
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("RequestNo","RequestNo")]
        public string RequestNo{ get; set; }
				
		[ColumnMap("MatSpecCode","MatSpecCode")]
        public string MatSpecCode{ get; set; }
				
		[ColumnMap("MatSpec","MatSpec")]
        public string MatSpec{ get; set; }
				
		[ColumnMap("MatType","MatType")]
        public string MatType{ get; set; }
				
		[ColumnMap("Suppode","Suppode")]
        public string Suppode{ get; set; }
				
		[ColumnMap("ReqQty","ReqQty")]
        public decimal ReqQty{ get; set; }
				
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
				
		[ColumnMap("Version","Version")]
        public byte[] Version{ get; set; }
		   
	}
}