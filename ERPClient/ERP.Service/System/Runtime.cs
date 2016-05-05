using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using COM.Service;
using Util;
using ERP.Data;

namespace ERP.Service
{
    public class RuntimeService : IRuntimeService
    {
        private IUnity unity;
        public RuntimeService(IUnity unity)
        {
            this.unity = unity;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return this.unity.GetService<IUnitOfWork>();
            }
        }

    }
}
