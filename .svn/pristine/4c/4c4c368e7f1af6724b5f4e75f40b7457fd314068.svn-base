using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace COM.Data
{
    public class UnitOfWorkBase<T> : IUnitOfWorkBase where T:DbContext
    {
        private readonly IDatabaseFactoryBase<T> databaseFactory;
        private T dataContext;

        public UnitOfWorkBase(IDatabaseFactoryBase<T> databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        private DbContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            try
            {
                this.DataContext.SaveChanges();
                //this.DataContext.Dispose();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new ConcurrencyException(ex);
            }
            catch(DbEntityValidationException ex)
            {
                throw new EfValidationException(ex);
            }
        }
    }
}
