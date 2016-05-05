using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product_ProcessFlow
	   public class ERP_M001_Product_ProcessFlowMap:EntityTypeConfiguration<ERP_M001_Product_ProcessFlow>
	{
           public ERP_M001_Product_ProcessFlowMap()
           {
               this.ToTable("ERP_M001_Product_Process");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.PFCode).HasColumnName("PFCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.ProcessKey).HasColumnName("ProcessKey");
               this.Property(t => t.ProcessSeqNo).HasColumnName("ProcessSeqNo");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Ignore(t => t.ProcessName);
               this.Property(t => t.ProcessType).HasColumnName("ProcessType");
           }
	}
}