using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Data;
using COM.Service;
using ERP.Data;

namespace ERP.Service
{
    public interface IRuntimeService
    {
        //IAppLogService AppLog { get; }
        IUnitOfWork UnitOfWork { get; }
        //IPermissionService Permission { get; }
    }
}
