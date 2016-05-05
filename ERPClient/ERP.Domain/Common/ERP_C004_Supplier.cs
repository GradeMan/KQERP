using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_C004_Supplier:AggregateRoot
	{
   		public  ERP_C004_Supplier(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C004_Supplier( )
			: base(Guid.NewGuid())
		{
		
		}
      			
	
				
		[ColumnMap("CompCode", "")]
        [Required(ErrorMessage = "公司代号不能为空")]
        public string CompCode{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        [Required(ErrorMessage = "供应商代号不能为空")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("SuppName", "")]
        [Required(ErrorMessage = "供应商名称不能为空")]
        public string SuppName{ get; set; }
				
		[ColumnMap("Alias", "")]
        public string Alias{ get; set; }
				
		[ColumnMap("Add1", "")]
        public string Add1{ get; set; }
				
		[ColumnMap("Add2", "")]
        public string Add2{ get; set; }
				
		[ColumnMap("Add3", "")]
        public string Add3{ get; set; }
				
		[ColumnMap("Country", "")]
        public string Country{ get; set; }
				
		[ColumnMap("Phone", "")]
        public string Phone{ get; set; }
				
		[ColumnMap("Fax", "")]
        public string Fax{ get; set; }
				
		[ColumnMap("CPerson1", "")]
        public string CPerson1{ get; set; }
				
		[ColumnMap("CPerson2", "")]
        public string CPerson2{ get; set; }
				
		[ColumnMap("CPerson3", "")]
        public string CPerson3{ get; set; }
				
		[ColumnMap("CEMail1", "")]
        public string CEMail1{ get; set; }
				
		[ColumnMap("CEMail2", "")]
        public string CEMail2{ get; set; }
				
		[ColumnMap("CEMail3", "")]
        public string CEMail3{ get; set; }
				
		[ColumnMap("CPhone1", "")]
        public string CPhone1{ get; set; }
				
		[ColumnMap("CPhone2", "")]
        public string CPhone2{ get; set; }
				
		[ColumnMap("CPhone3", "")]
        public string CPhone3{ get; set; }
				
		[ColumnMap("CFax1", "")]
        public string CFax1{ get; set; }
				
		[ColumnMap("CFax2", "")]
        public string CFax2{ get; set; }
				
		[ColumnMap("CFax3", "")]
        public string CFax3{ get; set; }
				
		[ColumnMap("DNAdd1", "")]
        public string DNAdd1{ get; set; }
				
		[ColumnMap("DNAdd2", "")]
        public string DNAdd2{ get; set; }
				
		[ColumnMap("DNAdd3", "")]
        public string DNAdd3{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
		[ColumnMap("Salesman", "")]
        public string Salesman{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }
		   
	}
}