using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Domain
{
    /// <summary>
    /// 实体接口
    /// </summary>
    public interface IEntity
    {
    }

    /// <summary>
    /// 实体接口
    /// </summary>
    /// <typeparam name="TKey">标示</typeparam>
    public interface IEntity<out TKey> : IEntity
    {
        TKey Id { get; }
    }
}
