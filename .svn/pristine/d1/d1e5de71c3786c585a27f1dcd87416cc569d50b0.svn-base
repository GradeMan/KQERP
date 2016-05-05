using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M003_Model_Product
	   public class ERP_M003_Model_ProductMap:EntityTypeConfiguration<ERP_M003_Model_Product>
	{
		public ERP_M003_Model_ProductMap ()
		{
			this.ToTable("ERP_M003_Model_Product");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.ModelCode).HasColumnName("ModelCode");
												 			this.Property(t => t.ItemCode).HasColumnName("ItemCode");
												 			this.Property(t => t.Spec).HasColumnName("Spec");
												 			this.Property(t => t.PartColumn).HasColumnName("PartColumn");
												 			this.Property(t => t.PartLine).HasColumnName("PartLine");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}