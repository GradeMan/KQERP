using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//tb_Sys_RolesBtn
	   public class tb_Sys_RolesBtnMap:EntityTypeConfiguration<tb_Sys_RolesBtn>
	{
		public tb_Sys_RolesBtnMap ()
		{
			this.ToTable("tb_Sys_RolesBtn");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.Roles_Id).HasColumnName("Roles_Id");
                        this.Property(t => t.Menu_Id).HasColumnName("Menu_Id");
						this.Property(t => t.Btn_Id).HasColumnName("Btn_Id");
                        this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
                        this.Property(t => t.CreateTime).HasColumnName("CreateTime");
			   		}
	}
}