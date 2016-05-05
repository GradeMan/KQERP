using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_M001_Product:AggregateRoot
	{
   		public  WMS_M001_Product(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_M001_Product( )
			: base(Guid.NewGuid())
		{
		
		}
     
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PartNo", "")]
        public string PartNo{ get; set; }
				
		[ColumnMap("CustCode", "")]
        public string CustCode{ get; set; }
				
		[ColumnMap("PartName", "")]
        public string PartName{ get; set; }
				
		[ColumnMap("MLotNo", "")]
        public string MLotNo{ get; set; }
				
		[ColumnMap("ProdDt", "")]
        public DateTime? ProdDt{ get; set; }
				
		[ColumnMap("CustMatNo", "")]
        public string CustMatNo{ get; set; }
				
		[ColumnMap("CustPartName", "")]
        public string CustPartName{ get; set; }
				
		[ColumnMap("SaftyBoxQty", "")]
        public decimal SaftyBoxQty{ get; set; }
				
		[ColumnMap("SaftyQty", "")]
        public decimal SaftyQty{ get; set; }
				
		[ColumnMap("BoxQty", "")]
        public decimal BoxQty{ get; set; }
				
		[ColumnMap("Qty", "")]
        public decimal Qty{ get; set; }
				
		[ColumnMap("PackBoxQty", "")]
        public decimal PackBoxQty{ get; set; }
				
		[ColumnMap("PackQty", "")]
        public decimal PackQty{ get; set; }
				
		[ColumnMap("InBoxQty", "")]
        public decimal InBoxQty{ get; set; }
				
		[ColumnMap("InQty", "")]
        public decimal InQty{ get; set; }
				
		[ColumnMap("OutBoxQty", "")]
        public decimal OutBoxQty{ get; set; }
				
		[ColumnMap("OutQty", "")]
        public decimal OutQty{ get; set; }
				
		[ColumnMap("AdjBoxQty", "")]
        public decimal AdjBoxQty{ get; set; }
				
		[ColumnMap("AdjQty", "")]
        public decimal AdjQty{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("Modifyuser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("Createuser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
		   
	}
}