using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M002_Job_Lot_Process:AggregateRoot
	{
   		public  MES_M002_Job_Lot_Process(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M002_Job_Lot_Process( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("JobNo", "")]
        public string JobNo{ get; set; }
				
		[ColumnMap("LotNo", "")]
        public string LotNo{ get; set; }
				
		[ColumnMap("ProcessCode", "")]
        public string ProcessCode{ get; set; }

        [ColumnMap("ProcessName", "")]
        public string ProcessName { get; set; }
				
		[ColumnMap("SeqNo", "")]
        public string SeqNo{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
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
		   
	}
}