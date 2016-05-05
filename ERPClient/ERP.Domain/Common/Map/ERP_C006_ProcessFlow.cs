using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C006_ProcessFlowMap:EntityTypeConfiguration<ERP_C006_ProcessFlow>
	{
		public ERP_C006_ProcessFlowMap ()
		{
			this.ToTable("ERP_C006_ProcessFlow");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.CompCode).HasColumnName("CompCode");
                        this.Property(t => t.PFCode).HasColumnName("PFCode");
                        this.Property(t => t.PFName).HasColumnName("PFName");
						this.Property(t => t.Status).HasColumnName("Status");
						this.Property(t => t.Remarks).HasColumnName("Remarks");
						this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
						this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
						this.Property(t => t.CreateDt).HasColumnName("CreateDt");
						this.Property(t => t.CreateUser).HasColumnName("CreateUser");
						this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
			   		}
	}
}