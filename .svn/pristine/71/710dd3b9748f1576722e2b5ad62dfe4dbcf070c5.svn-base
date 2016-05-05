using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M002_Job_Lot
	   public class MES_M002_Job_LotMap:EntityTypeConfiguration<MES_M002_Job_Lot>
	{
           public MES_M002_Job_LotMap()
           {
               this.ToTable("MES_M002_Job_Lot");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.LotNo).HasColumnName("LotNo");
               this.Property(t => t.LotQty).HasColumnName("LotQty");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Ignore(i => i.CheckBox);
           }
	}
}