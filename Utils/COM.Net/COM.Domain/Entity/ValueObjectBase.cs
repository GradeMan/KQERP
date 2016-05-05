using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Domain
{
    /// <summary>
    /// 值对象
    /// </summary>
    public abstract class ValueObjectBase<TValueObject>:DomainBase, IEquatable<TValueObject> where TValueObject
        : ValueObjectBase<TValueObject>
    {
        public override bool Equals(object obj)
        {
            return Equals(obj as TValueObject);
        }

        /// <summary>
        /// 值类型相等性比较 判断每一个属性值都相等，则相等
        /// </summary>
        /// <param name="valueObjec1"></param>
        /// <param name="valueObject2"></param>
        /// <returns></returns>
        public static bool operator ==(ValueObjectBase<TValueObject> valueObjec1, ValueObjectBase<TValueObject> valueObject2)
        {
            if ((object)valueObjec1 == null && (object)valueObject2 == null)
                return true;
            if ((object)valueObjec1 == null || (object)valueObject2 == null)
                return false;
            if (valueObjec1.GetType() != valueObject2.GetType())
                return false;
            var properties = valueObjec1.GetType().GetProperties();
            return properties.All(property => property.GetValue(valueObjec1,null) == property.GetValue(valueObject2,null));
        }

        /// <summary>
        /// 不相等性比较
        /// </summary>
        /// <param name="valueObjec1"></param>
        /// <param name="valueObject2"></param>
        /// <returns></returns>
        public static bool operator !=(ValueObjectBase<TValueObject> valueObjec1, ValueObjectBase<TValueObject> valueObject2)
        {
            return !(valueObjec1 == valueObject2);
        }
        
        /// <summary>
        /// 获取哈希
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            var properties = GetType().GetProperties();
            return properties.Select(property => property.GetValue(this, null))
                .Where(value => value != null)
                .Aggregate(0, (current, value) => current ^ value.GetHashCode());
        }

        /// <summary>
        /// 克隆副本
        /// </summary>
        /// <returns></returns>
        public virtual TValueObject Clone()
        {
            return (TValueObject)MemberwiseClone();
        }

        public bool Equals(TValueObject other)
        {
            return this == other;
        }
    }
}
