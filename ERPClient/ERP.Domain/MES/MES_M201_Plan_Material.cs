using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M201_Plan_Material:AggregateRoot
	{
   		public  MES_M201_Plan_Material(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M201_Plan_Material( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PlanDetailId","PlanDetailId")]
        public Guid PlanDetailId{ get; set; }
				
		[ColumnMap("PLNo","PLNo")]
        public string PLNo{ get; set; }
				
		[ColumnMap("PartNo","PartNo")]
        public string PartNo{ get; set; }
				
		[ColumnMap("MatCode","MatCode")]
        public string MatCode{ get; set; }

        public string MatName { get; set; }

        public string MatSpec { get; set; }
				
		[ColumnMap("SuppCode","SuppCode")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("Unit","Unit")]
        public string Unit{ get; set; }

        [ColumnMap("UnitPrice", "UnitPrice")]
        public string UnitPrice { get; set; }

        public decimal UnitConsume { get; set; }
				
		[ColumnMap("Qty","Qty")]
        public decimal Qty{ get; set; }
				
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
		   
	}
}