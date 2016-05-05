using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M001_Product:AggregateRoot
	{
   		public  ERP_M001_Product(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Product( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		[ColumnMap("CompCode", "")]
        [Display(Name = "公司编号")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PartNo", "")]
        [Display(Name = "产品编号")]
        public string PartNo{ get; set; }

        [ColumnMap("Category", "")]
        [Display(Name = "系列")]
        public string Category { get; set; }

		[ColumnMap("PartName", "")]
        [Display(Name = "产品名称")]
        public string PartName{ get; set; }
				
		[ColumnMap("PartType", "")]
        [Display(Name = "产品类别")]
        public string PartType{ get; set; }
				
		[ColumnMap("PartSpec", "")]
        [Display(Name = "产品规格")]
        public string PartSpec{ get; set; }
				
		[ColumnMap("PartDescription", "")]
        [Display(Name = "产品描述")]
        public string PartDescription{ get; set; }
				
		[ColumnMap("DrawingNo", "")]
        [Display(Name = "图号")]
        public string DrawingNo{ get; set; }
				
		[ColumnMap("DrawingNoRev", "")]
        [Display(Name = "版本号")]
        public string DrawingNoRev{ get; set; }
				
		[ColumnMap("ProcessFlow", "")]
        [Display(Name = "工艺流程")]
        [Required(ErrorMessage = "工艺流程不能为空")]
        public string ProcessFlow{ get; set; }
				
		[ColumnMap("EffectiveDt", "")]
        public string EffectiveDt{ get; set; }
				
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


	}
}