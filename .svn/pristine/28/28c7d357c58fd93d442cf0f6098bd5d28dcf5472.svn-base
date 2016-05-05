using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M003_Model:AggregateRoot
	{
   		public  ERP_M003_Model(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M003_Model( )
			: base(Guid.NewGuid())
		{
		
		}
      			
	
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ProcessCode", "")]
        public string ProcessCode{ get; set; }
				
		[ColumnMap("ModelCode", "")]
        [Required(ErrorMessage = "模具代号不能为空")]
        public string ModelCode{ get; set; }
				
		[ColumnMap("ModelName", "")]
        [Required(ErrorMessage = "模具名称不能为空")]
        public string ModelName{ get; set; }
				
		[ColumnMap("ModelSuppCode", "")]
        public string ModelSuppCode{ get; set; }
				
		[ColumnMap("StartDt", "")]
        public DateTime? StartDt{ get; set; }
				
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