using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.Drawing;
namespace ERP.Domain
{
   public class FTP_F002_File : AggregateRoot
	{
   		public  FTP_F002_File(Guid id)
   			: base(id)
		{
			
		}
		public  FTP_F002_File( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }	
										
		[ColumnMap("FileName", "")]
        public string FileName{ get; set; }
								
		[ColumnMap("Path", "")]
        public string Path{ get; set; }
								
			
		[ColumnMap("Status", "")]
        public bool Status{ get; set; }
								
		[ColumnMap("Sizes", "")]
        public string Sizes{ get; set; }
								
		[ColumnMap("Pwd", "")]
        public string Pwd{ get; set; }
								
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

        public Image Image { get; set; }

       [ColumnMap("Extension", "")]
        public string Extension { get; set; }

       [ColumnMap("ServiceName", "")]
       public string ServiceName { get; set; }
       
				   		
	}
}