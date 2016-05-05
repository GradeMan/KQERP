using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C102_InStoreDetail:AggregateRoot
	{
   		public  WMS_C102_InStoreDetail(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_C102_InStoreDetail( )
			: base(Guid.NewGuid())
		{
		
		}
	
		[ColumnMap("InStoreId", "")]
        public Guid InStoreId{ get; set; }
				
		[ColumnMap("InStoreNo", "")]
        public string InStoreNo{ get; set; }
				
		[ColumnMap("ARCode", "")]
        public string ARCode{ get; set; }
				
		[ColumnMap("PartSpec", "")]
        public string PartSpec{ get; set; }

        [ColumnMap("MatClass2", "")]
        public string MatClass2 { get; set; }
				
		[ColumnMap("Amount", "")]
        public decimal Amount{ get; set; }
				
		[ColumnMap("SuppLot", "")]
        public string SuppLot{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }

        public string MatCode { get; set; }

        public string Unit { get; set; }

        public decimal UnitPrice { get; set; }

        public string Remarks { get; set; }

        public decimal SumPrice { get; set; } 
	}
}