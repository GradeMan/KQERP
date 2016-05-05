using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M202_Task:AggregateRoot
	{
   		public  MES_M202_Task(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M202_Task( )
			: base(Guid.NewGuid())
		{
		
		}
      			

		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("TaskNo", "")]
        public string TaskNo{ get; set; }
				
		[ColumnMap("TaskDt", "")]
        public DateTime? TaskDt{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }

        [ColumnMap("Status", "")]
        public string Status { get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
		   
	}
}