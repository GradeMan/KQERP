﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M801_Label_L_PrintData:AggregateRoot
	{
   		public  MES_M801_Label_L_PrintData(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M801_Label_L_PrintData( )
			: base(Guid.NewGuid())
		{
		
		}
      			
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("LotNo", "")]
        public string LotNo{ get; set; }
				
		[ColumnMap("MLotNo", "")]
        public string MLotNo{ get; set; }
				
		[ColumnMap("BoxNo", "")]
        public string BoxNo{ get; set; }
				
		[ColumnMap("TotBox", "")]
        public string TotBox{ get; set; }
				
		[ColumnMap("TotPack", "")]
        public string TotPack{ get; set; }
				
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
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatType", "")]
        public string MatType{ get; set; }
				
		[ColumnMap("MatSuppCode", "")]
        public string MatSuppCode{ get; set; }
				
		[ColumnMap("MatLotNo", "")]
        public string MatLotNo{ get; set; }
				
		[ColumnMap("LabelType", "")]
        public string LabelType{ get; set; }
				
		[ColumnMap("ProdDt", "")]
        public string ProdDt{ get; set; }
				
		[ColumnMap("ExpiredDt", "")]
        public string ExpiredDt{ get; set; }
				
		[ColumnMap("ExpiredPeriod", "")]
        public decimal ExpiredPeriod{ get; set; }
				
		[ColumnMap("Qty", "")]
        public string Qty{ get; set; }
				
		[ColumnMap("Unit", "")]
        public string Unit{ get; set; }
				
		[ColumnMap("Code2D", "")]
        public string Code2D{ get; set; }

        public string LBPartNo { get; set; }

        public string LBPartName { get; set; }
        public string LBSpec1 { get; set; }
        public string LBSpec2 { get; set; }

        public int? JointNumber { get; set; }

        public string CompName { get; set; }

    }
}