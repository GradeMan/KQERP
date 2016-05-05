using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M802_Packing_Dtl
	   public class MES_M802_Packing_DtlMap:EntityTypeConfiguration<MES_M802_Packing_Dtl>
	{
           public MES_M802_Packing_DtlMap()
           {
               this.ToTable("MES_M802_Packing_Dtl");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.DocNo).HasColumnName("DocNo");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.ShipLot).HasColumnName("ShipLot");
               this.Property(t => t.ShipLotPackage).HasColumnName("ShipLotPackage");
               this.Property(t => t.ShipLotQty).HasColumnName("ShipLotQty");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
           }
	}
}