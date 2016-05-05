using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;

namespace ERP.Domain.Map
{
	public class tb_Sys_UserMap : EntityTypeConfiguration<tb_Sys_User>
    {
        public tb_Sys_UserMap()
        {
            this.ToTable("tb_Sys_User");
            this.HasKey(t => t.UserCode);
            this.Property(t => t.UserCode).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			this.Property(t => t.UserCode).HasColumnName("UserCode");
			this.Property(t => t.UserName).HasColumnName("UserName");
			this.Property(t => t.UserPassword).HasColumnName("UserPassword");
			this.Property(t => t.CreateTime).HasColumnName("CreateTime");
			this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
			this.Property(t => t.Createuser).HasColumnName("Createuser");
			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
			this.Property(t => t.Version).HasColumnName("Version");
			this.Property(t => t.Id).HasColumnName("Id");
			}
    }
}

