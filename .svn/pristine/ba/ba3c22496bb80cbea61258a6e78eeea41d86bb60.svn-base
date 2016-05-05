using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class DEV_D001_Device_File:AggregateRoot
	{
   		public  DEV_D001_Device_File(Guid id)
   			: base(id)
		{
			
		}
		public  DEV_D001_Device_File( )
			: base(Guid.NewGuid())
		{
		
		}
      			

				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("DevId", "")]
        public Guid DevId{ get; set; }
				
		[ColumnMap("DocName", "")]
        public string DocName{ get; set; }
				
		[ColumnMap("Contents", "")]
        public byte[] Contents{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
		   
	}
}