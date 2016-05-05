using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product_ProdInfo
	   public class ERP_M001_Product_ProdInfoMap:EntityTypeConfiguration<ERP_M001_Product_ProdInfo>
	{
           public ERP_M001_Product_ProdInfoMap()
           {
               this.ToTable("ERP_M001_Product_ProdInfo");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.PFCode).HasColumnName("PFCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.TechCode).HasColumnName("TechCode");
               this.Property(t => t.TechType).HasColumnName("TechType");
               this.Property(t => t.IsVisible).HasColumnName("IsVisible");
               this.Property(t => t.TechSeqNo).HasColumnName("TechSeqNo");
               this.Property(t => t.TechContent).HasColumnName("TechContent");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Ignore(t => t.TechName);
           }
	}
}