using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ERP.Domain;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace ERP.Data
{
    public class KQLotDbContext:DbContext
    {
        public KQLotDbContext()
            : base("name=KQLotDatabase")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<System.Data.Entity.Infrastructure.IncludeMetadataConvention>();
            this.RegistEntityMap(modelBuilder.Configurations);

        }

        private void RegistEntityMap(System.Data.Entity.ModelConfiguration.Configuration.ConfigurationRegistrar configurationRegistrar)
        {
            this.RegistEntityMapProduct(configurationRegistrar);
        }
        #region 1.0 产品模块
        private void RegistEntityMapProduct(ConfigurationRegistrar configuration)
        {
        }
        #endregion
    }
}
