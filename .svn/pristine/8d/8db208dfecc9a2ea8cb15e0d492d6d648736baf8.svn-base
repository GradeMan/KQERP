using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.Domain;

namespace ERP.Data
{

    public interface IESOP_ProductRepository : IRepository<ESOP_Product>
    {
    }
    public class ESOP_ProductRepository : AnyRepositoryBase<ESOP_Product>, IESOP_ProductRepository
    {
        public ESOP_ProductRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
