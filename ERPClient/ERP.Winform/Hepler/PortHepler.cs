using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Winform.Hepler
{
    public class PortHepler
    {
        private static PortHepler instance;
        public static PortHepler Instance
        {
            get
            {
                return instance ?? (instance = new PortHepler());
            }
        }


    }
}
