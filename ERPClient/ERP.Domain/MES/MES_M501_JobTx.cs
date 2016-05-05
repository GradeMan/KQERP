using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M501_JobTx:AggregateRoot
	{
   		public  MES_M501_JobTx(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M501_JobTx( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "CompCode")]
        public string CompCode { get; set; }

        [ColumnMap("PLNo", "PLNo")]
        public string PLNo { get; set; }

        [ColumnMap("JobNo", "JobNo")]
        public string JobNo { get; set; }

        [ColumnMap("JobType", "JobType")]
        public string JobType { get; set; }

        [ColumnMap("ProcessCode", "ProcessCode")]
        public string ProcessCode { get; set; }

        [ColumnMap("CustCode", "CustCode")]
        public string CustCode { get; set; }

        [ColumnMap("TaskNo", "TaskNo")]
        public string TaskNo { get; set; }

        [ColumnMap("SONo", "SONo")]
        public string SONo { get; set; }

        [ColumnMap("SOQty", "SOQty")]
        public decimal? SOQty { get; set; }

        [ColumnMap("PartNo", "PartNo")]
        public string PartNo { get; set; }

        [ColumnMap("PartType", "PartType")]
        public string PartType { get; set; }

        [ColumnMap("PartSpec", "PartSpec")]
        public string PartSpec { get; set; }

        [ColumnMap("PFCode", "PFCode")]
        public string PFCode { get; set; }

        [ColumnMap("ProdDt", "ProdDt")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("OutDt", "OutDt")]
        public DateTime? OutDt { get; set; }

        [ColumnMap("MacCode", "MacCode")]
        public string MacCode { get; set; }

        [ColumnMap("ModelCode", "ModelCode")]
        public string ModelCode { get; set; }

        [ColumnMap("OutSpeed", "OutSpeed")]
        public decimal? OutSpeed { get; set; }

        [ColumnMap("MatLotNo", "MatLotNo")]
        public string MatLotNo { get; set; }

        [ColumnMap("MatSpoolNo", "MatSpoolNo")]
        public string MatSpoolNo { get; set; }

        [ColumnMap("Weight", "Weight")]
        public decimal? Weight { get; set; }

        [ColumnMap("InLotNo", "InLotNo")]
        public string InLotNo { get; set; }

        [ColumnMap("InPartNo", "InPartNo")]
        public string InPartNo { get; set; }

        [ColumnMap("InPartSpec", "InPartSpec")]
        public string InPartSpec { get; set; }

        [ColumnMap("InLength", "InLength")]
        public decimal? InLength { get; set; }

        [ColumnMap("InWeight", "InWeight")]
        public decimal? InWeight { get; set; }

        [ColumnMap("PlatRate", "PlatRate")]
        public decimal? PlatRate { get; set; }

        [ColumnMap("Speed", "Speed")]
        public decimal? Speed { get; set; }

        [ColumnMap("Temp", "Temp")]
        public decimal? Temp { get; set; }

        [ColumnMap("ModifyDt", "ModifyDt")]
        public DateTime? ModifyDt { get; set; }

        [ColumnMap("ModifyUser", "ModifyUser")]
        public string ModifyUser { get; set; }

        [ColumnMap("CreateDt", "CreateDt")]
        public DateTime? CreateDt { get; set; }

        [ColumnMap("CreateUser", "CreateUser")]
        public string CreateUser { get; set; }

		   
	}
}