using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_M001_Product_SemiProduct:AggregateRoot
	{
   		public  ERP_M001_Product_SemiProduct(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Product_SemiProduct( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PartNo", "")]
        public string PartNo{ get; set; }
				
		[ColumnMap("SemiPartNo", "")]
        public string SemiPartNo{ get; set; }
				
		[ColumnMap("SemiPartName", "")]
        public string SemiPartName{ get; set; }
				
		[ColumnMap("SemiPartSpec", "")]
        public string SemiPartSpec{ get; set; }
				
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