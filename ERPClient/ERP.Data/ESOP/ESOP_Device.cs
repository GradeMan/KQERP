using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.Domain;

namespace ERP.Data
{
    public interface IESOP_DeviceRepository : IRepository<ESOP_Device>
    {
    }
    public class ESOP_DeviceRepository : AnyRepositoryBase<ESOP_Device>, IESOP_DeviceRepository
    {
        public ESOP_DeviceRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
