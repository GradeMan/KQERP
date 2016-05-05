using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Domain
{
    /// <summary>
    /// 聚合根
    /// </summary>
    public interface IAggregateRoot:IEntity
    {
        //[ColumnMap("Version", "")]
        //byte[] Version { get; set; }
    }
    /// <summary>
    /// 聚合根
    /// </summary>
    /// <typeparam name="TKey">标示类型</typeparam>
    public interface IAggregateRoot<out TKey> : IEntity<TKey>, IAggregateRoot
    {
    }
}
