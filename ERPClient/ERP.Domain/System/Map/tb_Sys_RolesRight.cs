using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//tb_Sys_RolesRight
	   public class tb_Sys_RolesRightMap:EntityTypeConfiguration<tb_Sys_RolesRight>
	{
		public tb_Sys_RolesRightMap ()
		{
			this.ToTable("tb_Sys_RolesRight");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.Roles_Id).HasColumnName("Roles_Id");
						this.Property(t => t.Menu_Id).HasColumnName("Menu_Id");
						this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
						this.Property(t => t.CreateTime).HasColumnName("CreateTime");
						this.Property(t => t.CreateUser).HasColumnName("CreateUser");
			   		}
	}
}