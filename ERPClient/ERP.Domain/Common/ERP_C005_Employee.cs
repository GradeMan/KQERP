using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_C005_Employee:AggregateRoot
	{
   		public  ERP_C005_Employee(Guid id)
   			: base(id)
		{
			
		}
        public ERP_C005_Employee()
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode", "")]
       [Required(ErrorMessage="公司名称不能为空")]
        public string CompCode{ get; set; }
				
		[ColumnMap("EmpNo", "")]
       [Required(ErrorMessage="工号不能为空")]
        public string EmpNo{ get; set; }

        [ColumnMap("Name", "")]
        [Required(ErrorMessage = "名字不能为空")]
        public string Name { get; set; }

		[ColumnMap("BirthDate", "")]
        public DateTime? BirthDate{ get; set; }
				
		[ColumnMap("City", "")]
        public string City{ get; set; }
				
		[ColumnMap("Add1", "")]
        public string Add1{ get; set; }
				
		[ColumnMap("Add2", "")]
        public string Add2{ get; set; }
				
		[ColumnMap("ZIPCode", "")]
        public string ZIPCode{ get; set; }
				
		[ColumnMap("TelPhone", "")]
        public string TelPhone{ get; set; }
				
		[ColumnMap("Phone", "")]
        public string Phone{ get; set; }
				
		[ColumnMap("Email", "")]
        public string Email{ get; set; }
				
		[ColumnMap("DeptCode", "")]
        public string DeptCode{ get; set; }
				
		[ColumnMap("JobCode", "")]
        public string JobCode{ get; set; }
				
		[ColumnMap("WrokDt", "")]
        public DateTime? WrokDt{ get; set; }
				
		[ColumnMap("Photo", "")]
        public byte[] Photo{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
				
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
		   
	}
}