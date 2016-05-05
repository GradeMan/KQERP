using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_M104_Packing_Detail:AggregateRoot
	{
   		public  WMS_M104_Packing_Detail(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_M104_Packing_Detail( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("PackingHdId", "PackingHdId")]
        public Guid PackingHdId { get; set; }

        [ColumnMap("SeqNo", "SeqNo")]
        public int? SeqNo { get; set; }

        [ColumnMap("SuppPartNo", "SuppPartNo")]
        public string SuppPartNo { get; set; }

        [ColumnMap("MFGLotNo", "MFGLotNo")]
        public string MFGLotNo { get; set; }

        [ColumnMap("MFGDate", "MFGDate")]
        public DateTime? MFGDate { get; set; }

        [ColumnMap("ExpiredDate", "ExpiredDate")]
        public DateTime? ExpiredDate { get; set; }

        [ColumnMap("Qty", "Qty")]
        public decimal? Qty { get; set; }
		   
	}
}