using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_M001_Product_Material:AggregateRoot
	{
   		public  ERP_M001_Product_Material(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Product_Material( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ProductCode", "")]
        public string ProductCode{ get; set; }
				
		[ColumnMap("ProcessCode", "")]
        public string ProcessCode{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("BaseQty", "")]
        public decimal BaseQty{ get; set; }
				
		[ColumnMap("Unit", "")]
        public string Unit{ get; set; }
				
		[ColumnMap("UnitConsume", "")]
        public decimal UnitConsume{ get; set; }
				
		[ColumnMap("UnitConsume1", "")]
        public decimal UnitConsume1{ get; set; }
				
		[ColumnMap("UnitConsume2", "")]
        public decimal UnitConsume2{ get; set; }
				
		[ColumnMap("NGFactor", "")]
        public decimal NGFactor{ get; set; }
				
		[ColumnMap("EffectiveDt", "")]
        public DateTime? EffectiveDt{ get; set; }
				
		[ColumnMap("IsActive", "")]
        public bool IsActive{ get; set; }
				
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
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
		   
	}
}