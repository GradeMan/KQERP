using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M501_JobTx_NG:AggregateRoot
	{
   		public  MES_M501_JobTx_NG(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M501_JobTx_NG( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ProcessCode","ProcessCode")]
        public string ProcessCode{ get; set; }
				
		[ColumnMap("CurrProcessCode","CurrProcessCode")]
        public string CurrProcessCode{ get; set; }
				
		[ColumnMap("NGCode","NGCode")]
        public string NGCode{ get; set; }
				
		[ColumnMap("NGQty","NGQty")]
        public decimal NGQty{ get; set; }
				
		[ColumnMap("Remarks","Remarks")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt","ModifyDt")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser","ModifyUser")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt","CreateDt")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser","CreateUser")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version","Version")]
        public byte[] Version{ get; set; }

        public string JobNo { get; set; }


       
		   
	}
}