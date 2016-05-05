using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//DEV_D001_Device_Appurten
	   public class DEV_D001_Device_AppurtenMap:EntityTypeConfiguration<DEV_D001_Device_Appurten>
	{
		public DEV_D001_Device_AppurtenMap ()
		{
			this.ToTable("DEV_D001_Device_Appurten");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.DevId).HasColumnName("DevId");
												 			this.Property(t => t.AppCode).HasColumnName("AppCode");
												 			this.Property(t => t.AppName).HasColumnName("AppName");
												 			this.Property(t => t.AppSpec).HasColumnName("AppSpec");
												 			this.Property(t => t.AppCompanyNo).HasColumnName("AppCompanyNo");
												 			this.Property(t => t.AppFunction).HasColumnName("AppFunction");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}