using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C006_ProcessFlow_Process
	   public class ERP_C006_ProcessFlow_ProcessMap:EntityTypeConfiguration<ERP_C006_ProcessFlow_Process>
	{
           public ERP_C006_ProcessFlow_ProcessMap()
           {
               this.ToTable("ERP_C006_ProcessFlow_Process");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PFCode).HasColumnName("PFCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.ProcessSeqNo).HasColumnName("ProcessSeqNo");
               this.Property(t => t.ProcessKey).HasColumnName("ProcessKey");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.ProcessType).HasColumnName("ProcessType");
           }
	}
}