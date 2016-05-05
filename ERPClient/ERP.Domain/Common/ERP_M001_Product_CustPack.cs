using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M001_Product_CustPack:AggregateRoot
	{
   		public  ERP_M001_Product_CustPack(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Product_CustPack( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ItemCode", "")]
        [Required(ErrorMessage = "产品代号不能为空")]
        public string ItemCode{ get; set; }
				
		[ColumnMap("CustCode", "")]
        [Required(ErrorMessage = "客户代号不能为空")]
        public string CustCode{ get; set; }
				
		[ColumnMap("CustMatNo", "")]
        public string CustMatNo{ get; set; }
				
		[ColumnMap("CustPartName", "")]
        public string CustPartName{ get; set; }
				
		[ColumnMap("CustPONo", "")]
        public string CustPONo{ get; set; }
				
		[ColumnMap("CustLotNo", "")]
        public string CustLotNo{ get; set; }
				
		[ColumnMap("CustDrawingNo", "")]
        public string CustDrawingNo{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatType", "")]
        public string MatType{ get; set; }
				
		[ColumnMap("MatSupplier", "")]
        public string MatSupplier{ get; set; }
				
		[ColumnMap("PianZhi", "")]
        public decimal PianZhi{ get; set; }
				
		[ColumnMap("BaoPian", "")]
        public decimal BaoPian{ get; set; }
				
		[ColumnMap("HeBao", "")]
        public decimal HeBao{ get; set; }
				
		[ColumnMap("XiangHe", "")]
        public decimal XiangHe{ get; set; }
				
		[ColumnMap("PreLotNo", "")]
        public string PreLotNo{ get; set; }
				
		[ColumnMap("PostLotNo", "")]
        public string PostLotNo{ get; set; }
				
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