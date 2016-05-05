using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_C006_ProcessFlow:AggregateRoot
	{
   		public  ERP_C006_ProcessFlow(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C006_ProcessFlow( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("CompCode", "")]
        [Required(ErrorMessage = "公司代号不能为空")]
        public string CompCode{ get; set; }

        [ColumnMap("PFCode", "")]
        [Required(ErrorMessage = "流程代号不能为空")]
        public string PFCode { get; set; }

        [ColumnMap("PFName", "")]
        [Required(ErrorMessage = "流程名称不能为空")]
        public string PFName { get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
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
        public byte[] Version { get; set; }
		   
	}
}