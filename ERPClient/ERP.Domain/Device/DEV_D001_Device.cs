using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class DEV_D001_Device:AggregateRoot
	{
   		public  DEV_D001_Device(Guid id)
   			: base(id)
		{
			
		}
		public  DEV_D001_Device( )
			: base(Guid.NewGuid())
		{
		
		}
      
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("DevNo", "")]
        public string DevNo{ get; set; }
				
		[ColumnMap("DevName", "")]
        public string DevName{ get; set; }
				
		[ColumnMap("DevVersion", "")]
        public string DevVersion{ get; set; }
				
		[ColumnMap("DepartNo", "")]
        public string DepartNo{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("DevFunction", "")]
        public string DevFunction{ get; set; }
				
		[ColumnMap("DevSpec", "")]
        public string DevSpec{ get; set; }
				
		[ColumnMap("DevExFacDt", "")]
        public DateTime? DevExFacDt{ get; set; }
				
		[ColumnMap("DevCompanyNo", "")]
        public string DevCompanyNo{ get; set; }
				
		[ColumnMap("DevType", "")]
        public string DevType{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
		[ColumnMap("StorageAddress", "")]
        public string StorageAddress{ get; set; }
				
		[ColumnMap("DevInProdDt", "")]
        public DateTime? DevInProdDt{ get; set; }
				
		[ColumnMap("DevManager", "")]
        public string DevManager{ get; set; }
				
		[ColumnMap("FirstMaintain", "")]
        public string FirstMaintain{ get; set; }
				
		[ColumnMap("AgreementNo", "")]
        public string AgreementNo{ get; set; }
				
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