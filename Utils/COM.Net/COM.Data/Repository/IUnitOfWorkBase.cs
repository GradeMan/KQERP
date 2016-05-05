using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace COM.Data
{
    public interface IUnitOfWorkBase
    {
        void Commit();
    }
}
