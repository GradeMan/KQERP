using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class MES_M003_LotTx:AggregateRoot
	{
   		public  MES_M003_LotTx(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M003_LotTx( )
			: base(Guid.NewGuid())
		{
		
		}
      			

								
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }

        [ColumnMap("JobNo", "")]
        [Required(ErrorMessage = "工单号不能为空")]
        public string JobNo { get; set; }

       [ColumnMap("LotNo", "")]
       [Required(ErrorMessage="批号不能为空")]
        public string LotNo{ get; set; }
								
		[ColumnMap("ProcessCode", "")]
        public string ProcessCode{ get; set; }
								
		[ColumnMap("TxDt", "")]
        [Required(ErrorMessage = "日期不能为空")]
        public DateTime? TxDt{ get; set; }
								
		[ColumnMap("ShiftCode", "")]
        [Required(ErrorMessage = "班次不能为空")]
        public string ShiftCode{ get; set; }
								
		[ColumnMap("MacCode", "")]
        [Required(ErrorMessage = "机台不能为空")]
        public string MacCode{ get; set; }
								
		[ColumnMap("Operator", "")]
        [Required(ErrorMessage = "操作员不能为空")]
        public string Operator{ get; set; }
								
		[ColumnMap("InQty", "")]
       [Range(1,10000,ErrorMessage="投入数要大于0")]
        public decimal InQty{ get; set; }
								
		[ColumnMap("OutQty", "")]
        [Range(1, 10000, ErrorMessage = "产出数要大于0")]
        public decimal OutQty{ get; set; }
								
		[ColumnMap("NGQty", "")]
        public decimal NGQty{ get; set; }
								
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