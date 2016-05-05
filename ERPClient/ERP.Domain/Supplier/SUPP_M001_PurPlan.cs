using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class SUPP_M001_PurPlan:AggregateRoot
	{
   		public  SUPP_M001_PurPlan(Guid id)
   			: base(id)
		{
			
		}
		public  SUPP_M001_PurPlan( )
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PurPlNo", "")]
       [Required(ErrorMessage="采购单号不能为空")]
        public string PurPlNo{ get; set; }
				
		[ColumnMap("TxDt", "")]
        public DateTime? TxDt{ get; set; }
				
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

        public string Status { get; set; }
		   
	}
}