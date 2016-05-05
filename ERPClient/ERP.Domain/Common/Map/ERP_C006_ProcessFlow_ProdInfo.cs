using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C006_ProcessFlow_ProdInfo
	   public class ERP_C006_ProcessFlow_ProdInfoMap:EntityTypeConfiguration<ERP_C006_ProcessFlow_ProdInfo>
	{
           public ERP_C006_ProcessFlow_ProdInfoMap()
           {
               this.ToTable("ERP_C006_ProcessFlow_ProdInfo");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PFCode).HasColumnName("PFCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.TechCode).HasColumnName("TechCode");
               this.Property(t => t.TechType).HasColumnName("TechType");
               this.Property(t => t.IsVisible).HasColumnName("IsVisible");
               this.Property(t => t.TechSeqNo).HasColumnName("TechSeqNo");
               this.Property(t => t.TechContent).HasColumnName("TechContent");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.Status).HasColumnName("Status");
           }
	}
}