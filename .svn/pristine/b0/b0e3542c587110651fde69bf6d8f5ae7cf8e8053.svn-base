using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Domain
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class ColumnMapAttribute : Attribute
    {
        readonly string columnName;
        readonly string columnReamrk;
        public ColumnMapAttribute(string columnName,string columnReamrk)
        {
            this.columnName = columnName;
            this.columnReamrk = columnReamrk;
        }

        public string ColumnName
        {
            get { return columnName; }
        }


        public string ColumnReamrk
        {
            get { return columnReamrk; }
        }
    }
}
