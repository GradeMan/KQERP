using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M802_Packing_Dtl:AggregateRoot
	{
   		public  MES_M802_Packing_Dtl(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M802_Packing_Dtl( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("DocNo", "")]
        public string DocNo{ get; set; }
				
		[ColumnMap("JobNo", "")]
        public string JobNo{ get; set; }
				
		[ColumnMap("ShipLot", "")]
        public string ShipLot{ get; set; }
				
		[ColumnMap("ShipLotPackage", "")]
        public decimal ShipLotPackage{ get; set; }
				
		[ColumnMap("ShipLotQty", "")]
        public decimal ShipLotQty{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
		   
	}
}