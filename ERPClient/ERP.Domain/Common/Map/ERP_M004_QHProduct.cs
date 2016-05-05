using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M004_QHProduct
	   public class ERP_M004_QHProductMap:EntityTypeConfiguration<ERP_M004_QHProduct>
	{
		public ERP_M004_QHProductMap ()
		{
			this.ToTable("ERP_M004_QHProduct");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.QHItemCode).HasColumnName("QHItemCode");
												 			this.Property(t => t.QHItemName).HasColumnName("QHItemName");
												 			this.Property(t => t.ItemCode).HasColumnName("ItemCode");
												 			this.Property(t => t.StockQty).HasColumnName("StockQty");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}