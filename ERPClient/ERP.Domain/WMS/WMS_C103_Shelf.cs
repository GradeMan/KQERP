using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C103_Shelf:AggregateRoot
	{
   		public  WMS_C103_Shelf(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_C103_Shelf( )
			: base(Guid.NewGuid())
		{
		
		}
      			
	
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("SFCode", "")]
        public string SFCode{ get; set; }
				
		[ColumnMap("SFName", "")]
        public string SFName{ get; set; }
				
		[ColumnMap("SeqNo", "")]
        public string SeqNo{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
		   
	}
}