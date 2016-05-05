using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M003_Model_Product:AggregateRoot
	{
   		public  ERP_M003_Model_Product(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M003_Model_Product( )
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ModelCode", "")]
        [Required(ErrorMessage = "模具代号不能为空")]
        public string ModelCode{ get; set; }
				
		[ColumnMap("ItemCode", "")]
        [Required(ErrorMessage = "产品代号不能为空")]
        public string ItemCode{ get; set; }
				
		[ColumnMap("Spec", "")]
        public string Spec{ get; set; }
				
		[ColumnMap("PartColumn", "")]
        public string PartColumn{ get; set; }
				
		[ColumnMap("PartLine", "")]
        public string PartLine{ get; set; }
				
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