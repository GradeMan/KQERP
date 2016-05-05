using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Domain;
using System.ComponentModel.DataAnnotations;

namespace ERP.Domain
{
    public class ESOP_Device:AggregateRoot
    {
        public  ESOP_Device(Guid id)
   			: base(id)
		{
			
		}
		public  ESOP_Device( )
			: base(Guid.NewGuid())
		{
		
		}
        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }	

        //[ColumnMap("DevId", "")]
        //public Guid DevId { get; set; }

        [ColumnMap("DevName", "")]
        [Required(ErrorMessage = "设备名称不能为空")]
        public string DevName { get; set; }

        [ColumnMap("Alias", "")]
        public string Alias { get; set; }

        [ColumnMap("State", "")]
        public string State { get; set; }

        [ColumnMap("Remarks", "")]
        public string Remarks { get; set; }

        [ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt { get; set; }

        [ColumnMap("ModifyUser", "")]
        public string ModifyUser { get; set; }

        [ColumnMap("CreateDt", "")]
        public DateTime? CreateDt { get; set; }

        [ColumnMap("CreateUser", "")]
        public string CreateUser { get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }
    }
}
