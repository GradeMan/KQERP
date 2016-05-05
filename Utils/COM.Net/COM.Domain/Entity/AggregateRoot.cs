using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Util;

namespace COM.Domain
{

    public abstract class AggregateRoot : AggregateRoot<Guid>
    {
        /// <summary>
        /// 初始化聚合根
        /// </summary>
        /// <param name="id"></param>
        protected AggregateRoot(Guid id)
            : base(id)
        {
        }
      
        /// <summary>
        /// 添加验证
        /// </summary>
        /// <param name="results"></param>
        protected override void Validate(ValidationResultCollection results)
        {
            if (Id == Guid.Empty)
                results.Add(new ValidationResult("Id不能为空"));
        }
       
    }
    /// <summary>
    /// 聚合根
    /// </summary>
    public abstract class AggregateRoot<TKey>: EntityBase<TKey>,IAggregateRoot<TKey>
    {
        protected AggregateRoot(TKey id)
            : base(id)
        {
        }

       
        //[ColumnMap("Version", "")]
        //public byte[] Version { get; set; }

        
    }
}
