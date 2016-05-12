using System;
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M201_Plan_Daily:AggregateRoot
	{
   		public  MES_M201_Plan_Daily(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M201_Plan_Daily( )
			: base(Guid.NewGuid())
		{
		
		}
      		
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }

        public string PLNo { get; set; }

        [ColumnMap("PlanDetailId","PlanDetailId")]
        public Guid? PlanDetailId{ get; set; }
				
		[ColumnMap("TxDt","TxDt")]
        public DateTime TxDt{ get; set; }
				
		[ColumnMap("Qty","Qty")]
        public decimal Qty{ get; set; }

        public string Remarks { get; set; }


    }
}