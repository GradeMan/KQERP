using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C101_InStore
	   public class WMS_C101_InStoreMap:EntityTypeConfiguration<WMS_C101_InStore>
	{
           public WMS_C101_InStoreMap()
           {
               this.ToTable("WMS_M102_InStore");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.InStoreNo).HasColumnName("DocNo");
               this.Property(t => t.DriverName).HasColumnName("DriverName");
               this.Property(t => t.DriverTel).HasColumnName("DriverTel");
               this.Property(t => t.DriverBusNumber).HasColumnName("DriverBusNumber");
               this.Property(t => t.DriverDt).HasColumnName("DeliveryDt");
               this.Property(t => t.EmpInfo).HasColumnName("EmpInfo");
               this.Property(t => t.EmpTel).HasColumnName("EmpTel");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.ActualAmount).HasColumnName("ActualQty");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.StoreInDate).HasColumnName("TxDt");
               this.Property(t => t.StockArea).HasColumnName("StockID");
               this.Property(t => t.DeliveryNo).HasColumnName("DeliveryNo");
           }
	}
}