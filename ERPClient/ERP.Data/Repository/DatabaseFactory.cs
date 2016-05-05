﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ERP.Data
{
    public interface IDatabaseFactory : COM.Data.IDatabaseFactoryBase<ErpDbContext>
    {
    }

    public class DatabaseFactory : COM.Data.DatabaseFactoryBase<ErpDbContext>, IDatabaseFactory
    {
    }

   
}
