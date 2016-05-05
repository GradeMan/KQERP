using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//tb_Sys_Button
	   public class tb_Sys_ButtonMap:EntityTypeConfiguration<tb_Sys_Button>
	{
		public tb_Sys_ButtonMap ()
		{
			this.ToTable("tb_Sys_Button");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.Btn_Name).HasColumnName("Btn_Name");
						this.Property(t => t.Btn_Icon).HasColumnName("Btn_Icon");
						this.Property(t => t.Btn_SeqNo).HasColumnName("Btn_SeqNo");
						this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
						this.Property(t => t.CreateTime).HasColumnName("CreateTime");
						this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
						this.Property(t => t.CreateUser).HasColumnName("CreateUser");
						this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
			   		}
	}
}