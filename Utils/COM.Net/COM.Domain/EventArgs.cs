using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Domain
{
    public class EventArgs<T> : EventArgs where T : class
    {
        public EventArgs(T arg)
        {
            Value = arg;
        }

        public T Value
        {
            get;
            set;
        }

    }


}
