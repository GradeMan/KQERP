using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_M101_StockTx_Data:AggregateRoot
	{
   		public  WMS_M101_StockTx_Data(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_M101_StockTx_Data( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("StockID", "")]
        public string StockID{ get; set; }
				
		[ColumnMap("OPType", "")]
        public string OPType{ get; set; }
				
		[ColumnMap("DocNo", "")]
        public string DocNo{ get; set; }
				
		[ColumnMap("TxDt", "")]
        public DateTime? TxDt{ get; set; }
				
		[ColumnMap("LotNo", "")]
        public string LotNo{ get; set; }
				
		[ColumnMap("CustCode", "")]
        public string CustCode{ get; set; }
				
		[ColumnMap("PartNo", "")]
        public string PartNo{ get; set; }
				
		[ColumnMap("Weight", "")]
        public decimal? Weight{ get; set; }
				
		[ColumnMap("Qty", "")]
        public decimal? Qty{ get; set; }
				
		[ColumnMap("Operator", "")]
        public string Operator{ get; set; }
				
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

        public string ARCode { get; set; }

        public Boolean? IsProcessed { get; set; }

        public bool Check { get; set; }
	}
}