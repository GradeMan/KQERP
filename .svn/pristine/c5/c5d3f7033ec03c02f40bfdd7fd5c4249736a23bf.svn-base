using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//DEV_D001_Device_File
	   public class DEV_D001_Device_FileMap:EntityTypeConfiguration<DEV_D001_Device_File>
	{
		public DEV_D001_Device_FileMap ()
		{
			this.ToTable("DEV_D001_Device_File");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.DevId).HasColumnName("DevId");
												 			this.Property(t => t.DocName).HasColumnName("DocName");
												 			this.Property(t => t.Contents).HasColumnName("Contents");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}