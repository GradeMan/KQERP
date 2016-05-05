using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_M104_Packing_Detail
	   public class WMS_M104_Packing_DetailMap:EntityTypeConfiguration<WMS_M104_Packing_Detail>
	{
           public WMS_M104_Packing_DetailMap()
           {
               this.ToTable("WMS_M104_Packing_Detail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.PackingHdId).HasColumnName("PackingHdId");
               this.Property(t => t.SeqNo).HasColumnName("SeqNo");
               this.Property(t => t.SuppPartNo).HasColumnName("SuppPartNo");
               this.Property(t => t.MFGLotNo).HasColumnName("MFGLotNo");
               this.Property(t => t.MFGDate).HasColumnName("MFGDate");
               this.Property(t => t.ExpiredDate).HasColumnName("ExpiredDate");
               this.Property(t => t.Qty).HasColumnName("Qty");
           }
	}
}