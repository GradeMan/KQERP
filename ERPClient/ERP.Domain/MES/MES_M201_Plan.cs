using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M201_Plan:AggregateRoot
	{
   		public  MES_M201_Plan(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M201_Plan( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PLNo","PLNo")]
        public string PLNo{ get; set; }
				
		[ColumnMap("PLDt","PLDt")]
        public DateTime? PLDt{ get; set; }
				
		[ColumnMap("PLType","月，日，周 单")]
        public string PLType{ get; set; }

       [ColumnMap("PLAuditing", "是否审核")]
        public string PLAuditing { get; set; }
       [ColumnMap("PLAuditingDt", "审核时间")]
       public DateTime? PLAuditingDt { get; set; }

		[ColumnMap("Remarks","Remarks")]
        public string Remarks{ get; set; }

        public string State { get; set; }
				
		[ColumnMap("ModifyDt","ModifyDt")]
        public DateTime? ModifyDt { get; set; }
				
		[ColumnMap("ModifyUser","ModifyUser")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt","CreateDt")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser","CreateUser")]
        public string CreateUser{ get; set; }
		   
	}
}