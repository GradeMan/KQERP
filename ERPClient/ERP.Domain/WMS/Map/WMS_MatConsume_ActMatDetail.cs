using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_MatConsume_ActMatDetail
	   public class WMS_MatConsume_ActMatDetailMap:EntityTypeConfiguration<WMS_MatConsume_ActMatDetail>
	{
           public WMS_MatConsume_ActMatDetailMap()
           {
               this.ToTable("WMS_MatConsume_ActMatDetail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.StampingNo).HasColumnName("StampingNo");
               this.Property(t => t.MatSpecCode).HasColumnName("MatSpecCode");
               this.Property(t => t.MatSpec).HasColumnName("MatSpec");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.MatName).HasColumnName("MatName");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.ShortName).HasColumnName("ShortName");
               this.Property(t => t.ReqQty).HasColumnName("ReqQty");
               this.Property(t => t.RetQty).HasColumnName("RetQty");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
           }
	}
}