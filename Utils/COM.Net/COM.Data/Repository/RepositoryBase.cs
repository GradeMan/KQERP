using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;
using Util;

namespace COM.Data
{
    public abstract class AnyRepositoryBase<T, TDbContext> : IRepositoryBase<T>
        where T : class
        where TDbContext : DbContext
    {
        private TDbContext dataContext;

        protected readonly IDbSet<T> dbset;

        private IDatabaseFactoryBase<TDbContext> databaseFactory { get; set; }
        protected AnyRepositoryBase(IDatabaseFactoryBase<TDbContext> databaseFactory)
        {
            this.databaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected TDbContext DataContext
        {
            get { return dataContext ?? (dataContext = this.databaseFactory.Get()); }
        }

        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }


        protected virtual Expression<Func<T, bool>> ReadExpression()
        {
            return (i => true);
        }

        protected virtual bool TestRead(T entity)
        {
            return this.ReadExpression().Compile().Invoke(entity);
        }

        /// <summary>
        /// 更新数据库中的对象
        /// </summary>
        /// <param name="entityUpdate">新属性值的对象</param>
        /// <param name="entityExists">数据库中原有的对象,被更新</param>
        public virtual void SetValues(T entityUpdate, T entityExists)
        {
            //EntityReflectService.Instance.CopyEntityProperty(entityUpdate, entityExists);
            dataContext.Entry(entityExists).CurrentValues.SetValues(entityUpdate);
           // dataContext.Entry(entityUpdate).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public virtual T GetByID<KType>(KType entityID)
        {
            var entity = dbset.Find(entityID);
            if (entity == null)
                return null;
            return entity;
        }

        public T TryGetByID<TKey>(TKey entityID)
        {
            var entity = dbset.Find(entityID);
            if (entity == null)
                return null;
            if (this.TestRead(entity))
                return entity;

            return null;
        }

        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return this.PreFilter().Where(where);
        }

        public void PreUpdatePartial(T entity)
        {
            if (!(dataContext.Entry(entity).State == EntityState.Modified || dataContext.Entry(entity).State == EntityState.Unchanged))
                throw new AppException("对象部分更新前,应该是从数据库中读取的,应为Modified状态,不应该是{0}状态", dataContext.Entry(entity).State.ToStr());
        }

        protected virtual IQueryable<T> PreFilter()
        {
            return dbset.Where(this.ReadExpression());
        }

        protected virtual bool CheckDataPermission(string enumDataPermission, T entity)
        {
            if (!this.TestRead(entity))
                return false;

            return true;
        }

      

        public System.Data.Entity.Infrastructure.DbEntityEntry<T> DbEntityEntry(T entity)
        {
            return this.dataContext.Entry(entity);
        }


        public DbContext GetDbContext()
        {
            return DataContext;
        }
    }



    public abstract class RepositoryBase<T, TDbContext> : AnyRepositoryBase<T, TDbContext>, IRepositoryBase<T>
        where T : class
        where TDbContext : DbContext
    {
        protected RepositoryBase(IDatabaseFactoryBase<TDbContext> databaseFactory)
            : base(databaseFactory)
        {
            
        }


    

        protected abstract override Expression<Func<T, bool>> ReadExpression();

    }
}
