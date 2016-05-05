using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M002_Material:AggregateRoot
	{
   		public  ERP_M002_Material(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M002_Material( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("MatCode", "")]
        [Required(ErrorMessage = "原材料代号不能为空")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatCategory", "")]
        public string MatCategory{ get; set; }
				
		[ColumnMap("MatType", "")]
        public string MatType{ get; set; }
				
		[ColumnMap("MatName", "")]
        public string MatName{ get; set; }
				
		[ColumnMap("MatSpec", "")]
        public string MatSpec{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("Location", "")]
        public string Location{ get; set; }
				
		[ColumnMap("Unit", "")]
        public string Unit{ get; set; }
				
		[ColumnMap("UnitPrice", "")]
        public decimal UnitPrice{ get; set; }
				
		[ColumnMap("Qty", "")]
        public decimal Qty{ get; set; }
				
		[ColumnMap("SaftyQty", "")]
        public decimal SaftyQty{ get; set; }
				
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