using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class DEV_D001_Device_Appurten:AggregateRoot
	{
   		public  DEV_D001_Device_Appurten(Guid id)
   			: base(id)
		{
			
		}
		public  DEV_D001_Device_Appurten( )
			: base(Guid.NewGuid())
		{
		
		}
      			
	
				
		[ColumnMap("DevId", "")]
        public Guid DevId{ get; set; }
				
		[ColumnMap("AppCode", "")]
        public string AppCode{ get; set; }
				
		[ColumnMap("AppName", "")]
        public string AppName{ get; set; }
				
		[ColumnMap("AppSpec", "")]
        public string AppSpec{ get; set; }
				
		[ColumnMap("AppCompanyNo", "")]
        public string AppCompanyNo{ get; set; }
				
		[ColumnMap("AppFunction", "")]
        public string AppFunction{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
		   
	}
}