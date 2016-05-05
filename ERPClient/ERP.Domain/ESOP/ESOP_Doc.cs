using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Domain;

namespace ERP.Domain
{
    public class ESOP_Doc:AggregateRoot
    {
        public  ESOP_Doc(Guid id)
   			: base(id)
		{
			
		}
        public ESOP_Doc()
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }

        [ColumnMap("DocNo", "")]
        public string DocNo { get; set; }

        [ColumnMap("RevNo", "")]
        public string RevNo { get; set; }


        [ColumnMap("DocName", "")]
        public string DocName { get; set; }

        [ColumnMap("Descreption", "")]
        public string Descreption { get; set; }

        [ColumnMap("DocIndexId", "")]
        public Guid DocIndexId { get; set; }

        [ColumnMap("EffectiveDt", "")]
        public DateTime? EffectiveDt { get; set; }

        [ColumnMap("ExpireDt", "")]
        public DateTime? ExpireDt { get; set; }

        [ColumnMap("FilePath", "")]
        public string FilePath { get; set; }

        [ColumnMap("Status", "")]
        public string Status { get; set; }

        [ColumnMap("Fomat", "")]
        public string Fomat { get; set; }

        [ColumnMap("Sizes", "")]
        public decimal Sizes { get; set; }

        [ColumnMap("Owner", "")]
        public string Owner { get; set; }

        [ColumnMap("PageCount", "")]
        public int PageCount { get; set; }

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
