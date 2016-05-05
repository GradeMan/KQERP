using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_M105_MatSotre
	   public class WMS_M105_MatSotreMap:EntityTypeConfiguration<WMS_M105_MatSotre>
	{
		public WMS_M105_MatSotreMap ()
		{
			this.ToTable("WMS_M105_MatSotre");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.MatSpecCode).HasColumnName("MatSpecCode");
												 			this.Property(t => t.MatSpec).HasColumnName("MatSpec");
												 			this.Property(t => t.MatType).HasColumnName("MatType");
												 			this.Property(t => t.Suppode).HasColumnName("Suppode");
												 			this.Property(t => t.StoreAmount).HasColumnName("StoreAmount");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}