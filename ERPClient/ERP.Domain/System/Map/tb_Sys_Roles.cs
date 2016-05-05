using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//tb_Sys_Roles
	   public class tb_Sys_RolesMap:EntityTypeConfiguration<tb_Sys_Roles>
	{
		public tb_Sys_RolesMap ()
		{
			this.ToTable("tb_Sys_Roles");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.Roles_Name).HasColumnName("Roles_Name");
						this.Property(t => t.Roles_Remark).HasColumnName("Roles_Remark");
						this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
						this.Property(t => t.CreateTime).HasColumnName("CreateTime");
						this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
						this.Property(t => t.CreateUser).HasColumnName("CreateUser");
						this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
			   		}
	}
}