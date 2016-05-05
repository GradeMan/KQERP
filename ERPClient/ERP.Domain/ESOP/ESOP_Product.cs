using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Domain;
using System.ComponentModel.DataAnnotations;

namespace ERP.Domain
{
    public class ESOP_Product : AggregateRoot
    {
        public ESOP_Product(Guid id)
            : base(id)
        {

        }
        public ESOP_Product()
            : base(Guid.NewGuid())
        {

        }
        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }

        //[ColumnMap("DevId", "")]
        //public Guid DevId { get; set; }

        [ColumnMap("PartNo", "")]
        [Required(ErrorMessage = "产品代号不能为空")]
        public string PartNo { get; set; }

        [ColumnMap("ParName", "")]
        public string ParName { get; set; }

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
