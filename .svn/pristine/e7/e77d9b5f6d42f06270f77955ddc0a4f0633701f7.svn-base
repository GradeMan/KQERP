using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M003_Model
	   public class ERP_M003_ModelMap:EntityTypeConfiguration<ERP_M003_Model>
	{
		public ERP_M003_ModelMap ()
		{
			this.ToTable("ERP_M003_Model");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
												 			this.Property(t => t.ModelCode).HasColumnName("ModelCode");
												 			this.Property(t => t.ModelName).HasColumnName("ModelName");
												 			this.Property(t => t.ModelSuppCode).HasColumnName("ModelSuppCode");
												 			this.Property(t => t.StartDt).HasColumnName("StartDt");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}