using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C009_Layout
	   public class ERP_C009_LayoutMap:EntityTypeConfiguration<ERP_C009_Layout>
	{
           public ERP_C009_LayoutMap()
           {
               this.ToTable("ERP_C009_Layout");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.UserId).HasColumnName("UserId");
               this.Property(t => t.FrmType).HasColumnName("FrmType");
               this.Property(t => t.LayType).HasColumnName("LayType");
               this.Property(t => t.LayFiles).HasColumnName("LayFiles");
               this.Property(t => t.LayFiles2).HasColumnName("LayFiles2");
               this.Property(t => t.LayFiles3).HasColumnName("LayFiles3");
           }
	}
}