using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public interface IUnity
    {
        I GetService<I>() where I : class;
        IUnity Register<I, T>() where T : I;
    }
}
