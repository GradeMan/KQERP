using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_MatConsume_ActMat:AggregateRoot
	{
   		public  WMS_MatConsume_ActMat(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_MatConsume_ActMat( )
			: base(Guid.NewGuid())
		{
		
		}

				
		[ColumnMap("StampingNo", "")]
        public string StampingNo{ get; set; }
				
		[ColumnMap("TxDt", "")]
        public DateTime? TxDt{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("Owner", "")]
        public string Owner{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("CreatDt", "")]
        public DateTime? CreatDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
		   
	}
}