using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product_File
	   public class ERP_M001_Product_FileMap:EntityTypeConfiguration<ERP_M001_Product_File>
	{
           public ERP_M001_Product_FileMap()
           {
               this.ToTable("ERP_M001_Product_File");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.ItemCode).HasColumnName("ItemCode");
               this.Property(t => t.DocNo).HasColumnName("DocNo");
               this.Property(t => t.DocType).HasColumnName("DocType");
               this.Property(t => t.DocName).HasColumnName("DocName");
               this.Property(t => t.Content).HasColumnName("Content");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.EffDt).HasColumnName("EffDt");
               this.Property(t => t.TermDt).HasColumnName("TermDt");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
           }
	}
}