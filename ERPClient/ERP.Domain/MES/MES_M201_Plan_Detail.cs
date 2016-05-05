using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M201_Plan_Detail:AggregateRoot
	{
   		public  MES_M201_Plan_Detail(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M201_Plan_Detail( )
			: base(Guid.NewGuid())
		{
		
		}
      		
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PlanId","PlanId")]
        public Guid PlanId{ get; set; }
				
		[ColumnMap("PLNo","PLNo")]
        public string PLNo{ get; set; }

        public string SONo { get; set; }
				
		[ColumnMap("CustCode","CustCode")]
        public string CustCode{ get; set; }
				
		[ColumnMap("PartNo","PartNo")]
        public string PartNo{ get; set; }
				
		[ColumnMap("PartName","PartName")]
        public string PartName{ get; set; }
				
		[ColumnMap("PartSpec","PartSpec")]
        public string PartSpec{ get; set; }

       [ColumnMap("DetailType", "是否增单")]
        public string DetailType { get; set; }

		[ColumnMap("Unit","Unit")]
        public string Unit{ get; set; }
				
		[ColumnMap("Qty","Qty")]
        public decimal Qty{ get; set; }
				
		[ColumnMap("FQty","FQty")]
        public decimal FQty{ get; set; }

       [ColumnMap("AdJustQty", "调整数量")]
        public decimal AdJustQty { get; set; }

       [ColumnMap("SumQty", "总数量")]
       public decimal SumQty { get; set; }
				
		[ColumnMap("Remarks","Remarks")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt","ModifyDt")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser","ModifyUser")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt","CreateDt")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser","CreateUser")]
        public string CreateUser{ get; set; }

        public decimal? SOQty { get; set; }

        //紧急，正常
        public string PLevel { get; set; }
        //是否插单
        public string Status { get; set; }
		   
	}
}