using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M001_Product_PackInfo:AggregateRoot
	{
   		public  ERP_M001_Product_PackInfo(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Product_PackInfo( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
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
				
		[ColumnMap("CustLotNo", "")]
        public string CustLotNo{ get; set; }
				
		[ColumnMap("CustPONo", "")]
        public string CustPONo{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatType", "")]
        public string MatType{ get; set; }
				
		[ColumnMap("MatSuppCode", "")]
        public string MatSuppCode{ get; set; }
				
		[ColumnMap("MatLotNo", "")]
        public string MatLotNo{ get; set; }
				
		[ColumnMap("PackPianZhi", "")]
        public decimal PackPianZhi{ get; set; }
				
		[ColumnMap("PackBaoPian", "")]
        public decimal PackBaoPian{ get; set; }
				
		[ColumnMap("PackHeBao", "")]
        public decimal PackHeBao{ get; set; }
				
		[ColumnMap("PackXiangHe", "")]
        public decimal PackXiangHe{ get; set; }
				
		[ColumnMap("ExpiredPeriod", "")]
        public int ExpiredPeriod{ get; set; }
				
		[ColumnMap("LabelType", "")]
        [Required(ErrorMessage = "标签类别不能为空")]
        public string LabelType{ get; set; }
				
		[ColumnMap("IsLabelSeq", "")]
        public bool IsLabelSeq{ get; set; }
				
		[ColumnMap("PreLotNo", "")]
        public string PreLotNo{ get; set; }
				
		[ColumnMap("PostLotNo", "")]
        public string PostLotNo{ get; set; }
				
		[ColumnMap("LotNoSeperater", "")]
        public string LotNoSeperater{ get; set; }
				
		[ColumnMap("DateTimeFormat", "")]
        public string DateTimeFormat{ get; set; }
				
		[ColumnMap("UnitDivsor", "")]
        public int UnitDivsor{ get; set; }
				
		[ColumnMap("UnitDivSor2", "")]
        public int UnitDivSor2{ get; set; }
				
		[ColumnMap("EffectiveDt", "")]
        public DateTime? EffectiveDt{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
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
        
        [Required(ErrorMessage="标签产品代号不能为空")]
        public string LBPartNo { get; set; }
       [Required(ErrorMessage = "标签产品名称不能为空")]
        public string LBPartName { get; set; }

        public string LBSpec1 { get; set; }
        public string LBSpec2 { get; set; }
	}
}