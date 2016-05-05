using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M001_Order_Detail:AggregateRoot
	{
   		public  MES_M001_Order_Detail(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M001_Order_Detail( )
			: base(Guid.NewGuid())
		{
		
		}
      			
								
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }

        [ColumnMap("OrdNo", "")]
        public string OrdNo { get; set; }
								
		[ColumnMap("ItemCode", "")]
        public string ItemCode{ get; set; }
								
		[ColumnMap("Qty", "")]
        public decimal Qty{ get; set; }
								
		[ColumnMap("Unit", "")]
        public string Unit{ get; set; }
								
		[ColumnMap("DeliveryDt", "")]
        public DateTime? DeliveryDt{ get; set; }
								
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
								
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
								
		[ColumnMap("ProdQty", "")]
        public decimal ProdQty{ get; set; }
								
		[ColumnMap("StockQty", "")]
        public decimal StockQty{ get; set; }
								
		[ColumnMap("ShipQty", "")]
        public decimal ShipQty{ get; set; }
								
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
				   		
	}
}