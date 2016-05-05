using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_C002_Company:AggregateRoot
	{
   		public  ERP_C002_Company(Guid id)
   			: base(id)
		{
			
		}
        public ERP_C002_Company()
            :base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "")]
        [Required(ErrorMessage = "公司代号不能为空")]
        public string CompCode { get; set; }

        [ColumnMap("CompName", "")]
       [Required(ErrorMessage="公司名称不能为空")]
        public string CompName { get; set; }
				
		[ColumnMap("Alias", "")]
        public string Alias{ get; set; }
				
		[ColumnMap("Add1", "")]
        public string Add1{ get; set; }
				
		[ColumnMap("Add2", "")]
        public string Add2{ get; set; }
				
		[ColumnMap("Add3", "")]
        public string Add3{ get; set; }
				
		[ColumnMap("Tel", "")]
        public string Tel{ get; set; }
				
		[ColumnMap("Fax", "")]
        public string Fax{ get; set; }
				
		[ColumnMap("Email", "")]
        public string Email{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }

        [ColumnMap("SysName", "")]
        public string SysName { get; set; }
	}
}