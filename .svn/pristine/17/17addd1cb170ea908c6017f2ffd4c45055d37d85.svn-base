using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M004_QHProduct:AggregateRoot
	{
   		public  ERP_M004_QHProduct(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M004_QHProduct( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("QHItemCode", "")]
        [Required(ErrorMessage = "企划产品代号不能为空")]
        public string QHItemCode{ get; set; }
				
		[ColumnMap("QHItemName", "")]
        [Required(ErrorMessage = "企划产品名称不能为空")]
        public string QHItemName{ get; set; }
				
		[ColumnMap("ItemCode", "")]
        public string ItemCode{ get; set; }
				
		[ColumnMap("StockQty", "")]
        public decimal StockQty{ get; set; }
				
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