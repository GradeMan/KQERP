using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_M104_Packing_Hd
	   public class WMS_M104_Packing_HdMap:EntityTypeConfiguration<WMS_M104_Packing_Hd>
	{
           public WMS_M104_Packing_HdMap()
           {
               this.ToTable("WMS_M104_Packing_Hd");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.Date).HasColumnName("Date");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.Code).HasColumnName("Code");
               this.Property(t => t.PoNo).HasColumnName("PoNo");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.InvoiceNo).HasColumnName("InvoiceNo");
               this.Property(t => t.DocNo).HasColumnName("DocNo");
               this.Property(t => t.Model).HasColumnName("Model");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Ignore(t => t.SumQty);
           }
	}
}