using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C005_Employee
    public class ERP_C005_EmployeeMap : EntityTypeConfiguration<ERP_C005_Employee>
	{
           public ERP_C005_EmployeeMap()
		{
            this.ToTable("ERP_C005_Employee");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.CompCode).HasColumnName("CompCode");
						this.Property(t => t.EmpNo).HasColumnName("EmpNo");
                        this.Property(t => t.Name).HasColumnName("Name");
						this.Property(t => t.BirthDate).HasColumnName("BirthDate");
						this.Property(t => t.City).HasColumnName("City");
						this.Property(t => t.Add1).HasColumnName("Add1");
						this.Property(t => t.Add2).HasColumnName("Add2");
						this.Property(t => t.ZIPCode).HasColumnName("ZIPCode");
						this.Property(t => t.TelPhone).HasColumnName("TelPhone");
						this.Property(t => t.Phone).HasColumnName("Phone");
						this.Property(t => t.Email).HasColumnName("Email");
						this.Property(t => t.DeptCode).HasColumnName("DeptCode");
						this.Property(t => t.JobCode).HasColumnName("JobCode");
						this.Property(t => t.WrokDt).HasColumnName("WrokDt");
						this.Property(t => t.Photo).HasColumnName("Photo");
						this.Property(t => t.Status).HasColumnName("Status");
						this.Property(t => t.Remarks).HasColumnName("Remarks");
						this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
						this.Property(t => t.CreateDt).HasColumnName("CreateDt");
						this.Property(t => t.CreateUser).HasColumnName("CreateUser");
						this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
						this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
			   		}
	}
}