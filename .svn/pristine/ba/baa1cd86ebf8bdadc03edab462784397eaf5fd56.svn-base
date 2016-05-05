using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//FTP_F002_File
	   public class FTP_F002_FileMap:EntityTypeConfiguration<FTP_F002_File>
	{
           public FTP_F002_FileMap()
           {
               this.ToTable("FTP_F002_File");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.FileName).HasColumnName("FileName");
               this.Property(t => t.Path).HasColumnName("Path");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.Sizes).HasColumnName("Sizes");
               this.Property(t => t.Pwd).HasColumnName("Pwd");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Ignore(i => i.Image);
               this.Property(t => t.Extension).HasColumnName("Extension");
               this.Property(t => t.ServiceName).HasColumnName("ServiceName");
           }
	}
}