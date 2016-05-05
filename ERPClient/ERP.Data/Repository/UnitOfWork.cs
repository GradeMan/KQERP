using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using COM.Data;

namespace ERP.Data
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
    }

    public class UnitOfWork : COM.Data.UnitOfWorkBase<ErpDbContext>, IUnitOfWork
    {
        public UnitOfWork(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
