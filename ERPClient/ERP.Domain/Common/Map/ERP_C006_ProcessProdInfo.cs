using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C006_ProcessProdInfo
	   public class ERP_C006_ProcessProdInfoMap:EntityTypeConfiguration<ERP_C006_ProcessProdInfo>
	{
		public ERP_C006_ProcessProdInfoMap ()
		{
			this.ToTable("ERP_C006_ProcessProdInfo");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.CompCode).HasColumnName("CompCode");
												 			this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
												 			this.Property(t => t.TechCode).HasColumnName("TechCode");
												 			this.Property(t => t.TechSeqNo).HasColumnName("TechSeqNo");
												 			this.Property(t => t.TechContent).HasColumnName("TechContent");
												 			this.Property(t => t.TechType).HasColumnName("TechType");
												 			this.Property(t => t.IsVisible).HasColumnName("IsVisible");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
						   		}
	}
}