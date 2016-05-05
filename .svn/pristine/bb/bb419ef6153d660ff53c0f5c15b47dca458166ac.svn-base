using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_M001_Product
	   public class WMS_M001_ProductMap:EntityTypeConfiguration<WMS_M001_Product>
	{
		public WMS_M001_ProductMap ()
		{
			this.ToTable("WMS_M001_Product");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.PartNo).HasColumnName("PartNo");
												 			this.Property(t => t.CustCode).HasColumnName("CustCode");
												 			this.Property(t => t.PartName).HasColumnName("PartName");
												 			this.Property(t => t.MLotNo).HasColumnName("MLotNo");
												 			this.Property(t => t.ProdDt).HasColumnName("ProdDt");
												 			this.Property(t => t.CustMatNo).HasColumnName("CustMatNo");
												 			this.Property(t => t.CustPartName).HasColumnName("CustPartName");
												 			this.Property(t => t.SaftyBoxQty).HasColumnName("SaftyBoxQty");
												 			this.Property(t => t.SaftyQty).HasColumnName("SaftyQty");
												 			this.Property(t => t.BoxQty).HasColumnName("BoxQty");
												 			this.Property(t => t.Qty).HasColumnName("Qty");
												 			this.Property(t => t.PackBoxQty).HasColumnName("PackBoxQty");
												 			this.Property(t => t.PackQty).HasColumnName("PackQty");
												 			this.Property(t => t.InBoxQty).HasColumnName("InBoxQty");
												 			this.Property(t => t.InQty).HasColumnName("InQty");
												 			this.Property(t => t.OutBoxQty).HasColumnName("OutBoxQty");
												 			this.Property(t => t.OutQty).HasColumnName("OutQty");
												 			this.Property(t => t.AdjBoxQty).HasColumnName("AdjBoxQty");
												 			this.Property(t => t.AdjQty).HasColumnName("AdjQty");
												 			this.Property(t => t.Status).HasColumnName("Status");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("Modifyuser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("Createuser");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}