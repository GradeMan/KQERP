using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C006_ProcessFlow_Process:AggregateRoot
	{
   		public  ERP_C006_ProcessFlow_Process(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C006_ProcessFlow_Process( )
			: base(Guid.NewGuid())
		{
		
		}
      			
	
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }

        [ColumnMap("PFCode", "")]
        public string PFCode { get; set; }

        [ColumnMap("ProcessCode", "")]
        public string ProcessCode { get; set; }

        [ColumnMap("ProcessSeqNo", "")]
        public string ProcessSeqNo { get; set; }

        public int ProcessKey { get; set; }

        public string Remarks { get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }

        public string ProcessType { get; set; }
	}
}