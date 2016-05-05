using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.Domain;

namespace ERP.Data
{
    public interface IESOP_DocRepository : IRepository<ESOP_Doc>
    {
    }
    public class ESOP_DocRepository : AnyRepositoryBase<ESOP_Doc>, IESOP_DocRepository
    {
        public ESOP_DocRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
