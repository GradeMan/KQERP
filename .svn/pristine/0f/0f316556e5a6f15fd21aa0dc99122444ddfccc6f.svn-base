using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using COM.Data;
using System.Linq.Expressions;
namespace ERP.Data
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class
    {
    }

    public class AnyRepositoryBase<T> : AnyRepositoryBase<T, ErpDbContext>, IRepository<T> where T : class
    {
        public AnyRepositoryBase(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public abstract class RepositoryBase<T> : RepositoryBase<T, ErpDbContext>, IRepository<T> where T : class
    {
        public RepositoryBase(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
