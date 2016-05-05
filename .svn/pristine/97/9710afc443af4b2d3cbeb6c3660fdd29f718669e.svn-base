using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//DEV_D001_Device
	   public class DEV_D001_DeviceMap:EntityTypeConfiguration<DEV_D001_Device>
	{
           public DEV_D001_DeviceMap()
           {
               this.ToTable("DEV_D001_Device");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.DevNo).HasColumnName("DevNo");
               this.Property(t => t.DevName).HasColumnName("DevName");
               this.Property(t => t.DevVersion).HasColumnName("DevVersion");
               this.Property(t => t.DepartNo).HasColumnName("DepartNo");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.DevFunction).HasColumnName("DevFunction");
               this.Property(t => t.DevSpec).HasColumnName("DevSpec");
               this.Property(t => t.DevExFacDt).HasColumnName("DevExFacDt");
               this.Property(t => t.DevCompanyNo).HasColumnName("DevCompanyNo");
               this.Property(t => t.DevType).HasColumnName("DevType");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.StorageAddress).HasColumnName("StorageAddress");
               this.Property(t => t.DevInProdDt).HasColumnName("DevInProdDt");
               this.Property(t => t.DevManager).HasColumnName("DevManager");
               this.Property(t => t.FirstMaintain).HasColumnName("FirstMaintain");
               this.Property(t => t.AgreementNo).HasColumnName("AgreementNo");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}