using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public partial class ESOP_Publish:AggregateRoot
    {
        public  ESOP_Publish(Guid id)
   			: base(id)
		{
			
		}
        public ESOP_Publish()
			: base(Guid.NewGuid())
		{
		
		}
        public Guid DevId { get; set; }
        public string CompCode { get; set; }
        public Guid DocId { get; set; }
        public Guid DocIndexId { get; set; }
        public Nullable<System.DateTime> EffectiveDt { get; set; }
        public Nullable<System.DateTime> ExpireDt { get; set; }
        public string State { get; set; }
        public string PartNo { get; set; }

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
