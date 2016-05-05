using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M802_Packing_Hd:AggregateRoot
	{
   		public  MES_M802_Packing_Hd(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M802_Packing_Hd( )
			: base(Guid.NewGuid())
		{
		
		}
      			
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("DocNo", "")]
        public string DocNo{ get; set; }
				
		[ColumnMap("ProdDt", "")]
        public DateTime? ProdDt{ get; set; }
				
		[ColumnMap("Qty", "")]
        public decimal Qty{ get; set; }
				
		[ColumnMap("Package", "")]
        public decimal Package{ get; set; }
				
		[ColumnMap("CustCode", "")]
        public string CustCode{ get; set; }
				
		[ColumnMap("JobNo", "")]
        public string JobNo{ get; set; }
				
		[ColumnMap("PartNo", "")]
        public string PartNo{ get; set; }
				
		[ColumnMap("PartType", "")]
        public string PartType{ get; set; }
				
		[ColumnMap("SubShipLot1st", "")]
        public string SubShipLot1st{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("LotNoList", "")]
        public string LotNoList{ get; set; }
				
		[ColumnMap("LotNoPackList", "")]
        public string LotNoPackList{ get; set; }
				
		[ColumnMap("LotNoPackQtyList", "")]
        public string LotNoPackQtyList{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
		   
	}
}