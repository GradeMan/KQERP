using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace COM.Data
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        void PreUpdatePartial(T entity);
        void SetValues(T entityUpdate, T entityExists);
        void Delete(T entity);
        T GetByID<TKey>(TKey entityID);
        T TryGetByID<TKey>(TKey entityID);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        DbEntityEntry<T> DbEntityEntry(T entity);
        DbContext GetDbContext();
    }
}
