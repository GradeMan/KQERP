using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M002_Material
	   public class ERP_M002_MaterialMap:EntityTypeConfiguration<ERP_M002_Material>
	{
		public ERP_M002_MaterialMap ()
		{
			this.ToTable("ERP_M002_Material");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.MatCode).HasColumnName("MatCode");
												 			this.Property(t => t.MatCategory).HasColumnName("MatCategory");
												 			this.Property(t => t.MatType).HasColumnName("MatType");
												 			this.Property(t => t.MatName).HasColumnName("MatName");
												 			this.Property(t => t.MatSpec).HasColumnName("MatSpec");
												 			this.Property(t => t.SuppCode).HasColumnName("SuppCode");
												 			this.Property(t => t.Location).HasColumnName("Location");
												 			this.Property(t => t.Unit).HasColumnName("Unit");
												 			this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
												 			this.Property(t => t.Qty).HasColumnName("Qty");
												 			this.Property(t => t.SaftyQty).HasColumnName("SaftyQty");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}