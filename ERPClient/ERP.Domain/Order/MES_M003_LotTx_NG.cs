using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M003_LotTx_NG:AggregateRoot
	{
   		public  MES_M003_LotTx_NG(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M003_LotTx_NG( )
			: base(Guid.NewGuid())
		{
		
		}
      			

								
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
								
		[ColumnMap("LotNo", "")]
        public string LotNo{ get; set; }
								
		[ColumnMap("ProcessCode", "")]
        public string ProcessCode{ get; set; }
								
		[ColumnMap("CriteriaCode", "")]
        public string CriteriaCode{ get; set; }
								
		[ColumnMap("Qty", "")]
        public decimal Qty{ get; set; }
								
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