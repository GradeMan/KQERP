using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//tb_Sys_UserRole
	   public class tb_Sys_UserRoleMap:EntityTypeConfiguration<tb_Sys_UserRole>
	{
		public tb_Sys_UserRoleMap ()
		{
			this.ToTable("tb_Sys_UserRole");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.UserId).HasColumnName("UserId");
						this.Property(t => t.RoleId).HasColumnName("RoleId");
						this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
                        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
			   		}
	}
}