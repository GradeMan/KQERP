using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M801_Label_S_PrintData:AggregateRoot
	{
   		public  MES_M801_Label_S_PrintData(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M801_Label_S_PrintData( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("LotNo", "")]
        public string LotNo{ get; set; }
				
		[ColumnMap("MLotNo", "")]
        public string MLotNo{ get; set; }
				
		[ColumnMap("PackSeqNo", "")]
        public string PackSeqNo{ get; set; }
				
		[ColumnMap("PartNo", "")]
        public string PartNo{ get; set; }
				
		[ColumnMap("PartName", "")]
        public string PartName{ get; set; }
				
		[ColumnMap("PartType", "")]
        public string PartType{ get; set; }
				
		[ColumnMap("PartSpec", "")]
        public string PartSpec{ get; set; }
				
		[ColumnMap("CustCode", "")]
        public string CustCode{ get; set; }
				
		[ColumnMap("CustPartNo", "")]
        public string CustPartNo{ get; set; }
				
		[ColumnMap("CustPartName", "")]
        public string CustPartName{ get; set; }
				
		[ColumnMap("CustPartType", "")]
        public string CustPartType{ get; set; }
				
		[ColumnMap("CustPartSpec", "")]
        public string CustPartSpec{ get; set; }
				
		[ColumnMap("CustDrawingNo", "")]
        public string CustDrawingNo{ get; set; }
				
		[ColumnMap("CustPONo", "")]
        public string CustPONo{ get; set; }
				
		[ColumnMap("CustLotNo", "")]
        public string CustLotNo{ get; set; }
				
		[ColumnMap("ProdDt", "")]
        public string ProdDt{ get; set; }
				
		[ColumnMap("ExpiredDt", "")]
        public string ExpiredDt{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatType", "")]
        public string MatType{ get; set; }
				
		[ColumnMap("Qty", "")]
        public string Qty{ get; set; }
				
		[ColumnMap("Code2D", "")]
        public string Code2D{ get; set; }
				
		[ColumnMap("Unit", "")]
        public string Unit{ get; set; }

        public string LBPartNo { get; set; }

        public string LBPartName { get; set; }
        public string LBSpec1 { get; set; }
        public string LBSpec2 { get; set; }

        public int? JointNumber { get; set; }

        //2016-04-28新增
        public string LMlotNo { get; set; }

        public string BoxNo { get; set; }

        public string PackNo { get; set; }
	}
}