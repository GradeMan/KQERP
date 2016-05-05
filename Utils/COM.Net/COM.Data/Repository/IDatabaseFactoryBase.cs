using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace COM.Data
{
    public interface IDatabaseFactoryBase<TDbContext> :IDisposable where TDbContext : DbContext
    {
        TDbContext Get();
       // TDbContext Instance();
    }
}
