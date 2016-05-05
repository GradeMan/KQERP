using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ESOP_RoleDevice
	   public class ESOP_RoleDeviceMap:EntityTypeConfiguration<ESOP_RoleDevice>
	{
           public ESOP_RoleDeviceMap()
           {
               this.ToTable("ESOP_RoleDevice");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.RoleId).HasColumnName("RoleId");
               this.Property(t => t.DevId).HasColumnName("DevId");
           }
	}
}