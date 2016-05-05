using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M501_JobTxDetail:AggregateRoot
	{
   		public  MES_M501_JobTxDetail(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M501_JobTxDetail( )
			: base(Guid.NewGuid())
		{
		
		}
        [ColumnMap("CompCode", "CompCode")]
        public string CompCode { get; set; }

        [ColumnMap("JobNo", "JobNo")]
        public string JobNo { get; set; }

       [ColumnMap("ProcessCode", "ProcessCode")]
        public string ProcessCode { get; set; }

        [ColumnMap("InDt", "InDt")]
        public DateTime? InDt { get; set; }

        [ColumnMap("InSpool", "InSpool")]
        public string InSpool { get; set; }

        [ColumnMap("OutDt", "OutDt")]
        public DateTime? OutDt { get; set; }

        [ColumnMap("MacCode", "MacCode")]
        public string MacCode { get; set; }

        [ColumnMap("Dia", "Dia")]
        public decimal? Dia { get; set; }

        [ColumnMap("NetWeight", "NetWeight")]
        public decimal? NetWeight { get; set; }

        [ColumnMap("Length", "Length")]
        public decimal? Length { get; set; }

        [ColumnMap("OutSpool", "OutSpool")]
        public string OutSpool { get; set; }

        [ColumnMap("Operator", "Operator")]
        public string Operator { get; set; }

        [ColumnMap("QCOperator", "QCOperator")]
        public string QCOperator { get; set; }

        [ColumnMap("ActDia", "ActDia")]
        public decimal? ActDia { get; set; }

        [ColumnMap("Quanlity", "Quanlity")]
        public string Quanlity { get; set; }

        [ColumnMap("ExtendRate", "ExtendRate")]
        public decimal? ExtendRate { get; set; }

        [ColumnMap("Fracture", "Fracture")]
        public decimal? Fracture { get; set; }

        [ColumnMap("Temp", "Temp")]
        public decimal? Temp { get; set; }

        [ColumnMap("Speed", "Speed")]
        public decimal? Speed { get; set; }

        [ColumnMap("OPPram", "OPPram")]
        public string OPPram { get; set; }

        [ColumnMap("CaseNo", "CaseNo")]
        public string CaseNo { get; set; }

        [ColumnMap("SeqNo", "SeqNo")]
        public string SeqNo { get; set; }

        [ColumnMap("SpoolCnt", "SpoolCnt")]
        public decimal? SpoolCnt { get; set; }

        [ColumnMap("OKSpoolCnt", "OKSpoolCnt")]
        public decimal? OKSpoolCnt { get; set; }

        [ColumnMap("PackSpec", "PackSpec")]
        public string PackSpec { get; set; }

        [ColumnMap("SpoolColor", "SpoolColor")]
        public string SpoolColor { get; set; }

        [ColumnMap("PackReq", "PackReq")]
        public string PackReq { get; set; }

        [ColumnMap("PackSpoolCnt", "PackSpoolCnt")]
        public decimal? PackSpoolCnt { get; set; }

        [ColumnMap("Remarks", "Remarks")]
        public string Remarks { get; set; }
		   
	}
}