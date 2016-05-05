using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class MES_M202_Task_JobLot:AggregateRoot
	{
   		public  MES_M202_Task_JobLot(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M202_Task_JobLot( )
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("JobNo","JobNo")]
        public string JobNo{ get; set; }
				
		[ColumnMap("JobLotNo","JobLotNo")]
        public string JobLotNo{ get; set; }
				
		[ColumnMap("LotQty","LotQty")]
        public int LotQty{ get; set; }
				
		[ColumnMap("CurrentProcess","CurrentProcess")]
        public string CurrentProcess{ get; set; }
				
		[ColumnMap("ProcessQty","ProcessQty")]
        public int ProcessQty{ get; set; }
		   
	}
}