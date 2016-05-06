using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class MES_M202_Task_Detail:AggregateRoot
	{
   		public  MES_M202_Task_Detail(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M202_Task_Detail( )
			: base(Guid.NewGuid())
		{
		
		}
      			

				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("TaskNo", "")]
        public string TaskNo{ get; set; }
				
		[ColumnMap("PLNo", "")]
        public string PLNo{ get; set; }

        [ColumnMap("SONo", "")]
        public string SONo { get; set; }
				
		[ColumnMap("JobNo", "")]
        public string JobNo{ get; set; }
				
		[ColumnMap("JobType", "")]
        public string JobType{ get; set; }
				
		[ColumnMap("SeqNo", "")]
        public string SeqNo{ get; set; }
				
		[ColumnMap("CustCode", "")]
        [Required(ErrorMessage = "客户不能为空")]
        public string CustCode{ get; set; }

        [ColumnMap("PartNo", "")]
        [Required(ErrorMessage = "产品不能为空")]
        public string PartNo{ get; set; }
				
		[ColumnMap("MacCode", "")]
        public string MacCode{ get; set; }

        [ColumnMap("ShiftCode", "")]
        public string ShiftCode { get; set; }
				
		[ColumnMap("JobQty", "")]
        [Required(ErrorMessage = "工单数量不能为空")]
        public int? JobQty{ get; set; }
				
		[ColumnMap("FQty", "")]
        public int? FQty{ get; set; }
				
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

        public string PlanDetailId { get; set; }

        [ColumnMap("PlanFQty", "计划完成数量")]
        public decimal? PlanFQty { get; set; }

        [ColumnMap("PlanSumQty", "计划总数量")]
        public decimal? PlanSumQty { get; set; }

        public string MacName { get; set; }

        public string ShiftName { get; set; }

        [ColumnMap("TaskDt", "")]
        public DateTime? TaskDt { get; set; }

        public string CustName { get; set; }

        public decimal? SOQty { get; set; }

        public string PartSpec { get; set; }

        public string PartType { get; set; }

       [Required(ErrorMessage = "工艺流程不能为空")]
        public string ProcessFlow { get; set; }

       [ColumnMap("SOLotNo", "订单批次号")]//2016/03/30日Jade要求添加
        public string SOLotNo { get; set; }

       //紧急，正常
       public string TLevel { get; set; }
       //是否插单
       public string Status { get; set; }

       //2016-04-14新增三个字段
       public int? LotCount { get; set; }//Lot数

       public int? ShipQty { get; set; }//板数

       public string PartName { get; set; }

       public string Auditor { get; set; }

       public DateTime? AuditingDt { get; set; }



	}
}