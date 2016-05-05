using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C103_Shelf
	   public class WMS_C103_ShelfMap:EntityTypeConfiguration<WMS_C103_Shelf>
	{
		public WMS_C103_ShelfMap ()
		{
			this.ToTable("WMS_C103_Shelf");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.SFCode).HasColumnName("SFCode");
												 			this.Property(t => t.SFName).HasColumnName("SFName");
												 			this.Property(t => t.SeqNo).HasColumnName("SeqNo");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}