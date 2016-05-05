using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace COM.Domain
{
    /// <summary>
    /// 领域实体基类
    /// </summary>
    public abstract class EntityBase: EntityBase<Guid>
    {
        protected EntityBase(Guid id)
            : base(id)
        {
        }
      
    }
    /// <summary>
    /// 领域实体
    /// </summary>
    public abstract class EntityBase<TKey> : DomainBase,IEntity<TKey>
    {

        
        /// <summary>
        /// 初始化领域实体
        /// </summary>
        /// <param name="id"></param>
        protected EntityBase(TKey id)
        {
            Id = id;
            //MarkKey = "Add";
        }

        /// <summary>
        /// 标示
        /// </summary>
        [Required(ErrorMessage="主键不能为空")]
        [ColumnMap("Id", "")]
        public TKey Id { get;  set; }

        
        /// <summary>
        /// 重写相等运算
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public override bool Equals(object entity)
        {
            if (entity == null)
                return false;
            if (!(entity is EntityBase<TKey>))
                return false;
            return this == (EntityBase<TKey>)entity;
        }

        /// <summary>
        /// 相等比较
        /// </summary>
        /// <param name="entity1"></param>
        /// <param name="entity2"></param>
        /// <returns></returns>
        public static bool operator ==(EntityBase<TKey> entity1, EntityBase<TKey> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
                return true;
            if ((object)entity1 == null || (object)entity2 == null)
                return false;
            if (entity1.Id == null)
                return false;
            if (entity1.Id.Equals(default(TKey))) //判断Id是否为默认的值，比如，一个实体的标识为int类型，这个实体在刚创建的时候，Id默认为0，另外创建一个该类的实例，Id也为0
                return false;
            return entity1.Id.Equals(entity2.Id);
        }

        /// <summary>
        /// 不相等比较
        /// </summary>
        /// <param name="entity1"></param>
        /// <param name="entity2"></param>
        /// <returns></returns>
        public static bool operator !=(EntityBase<TKey> entity1, EntityBase<TKey> entity2)
        {
            return !(entity1 == entity2);
        }

        /// <summary>
        /// 重写获取哈希值
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //#region 实现已放到DomainBase中
        ///// <summary>
        ///// 描述
        ///// </summary>
        //private StringBuilder _description;

        //public override string ToString()
        //{
        //    _description = new StringBuilder();
        //    AddDescriptions();
        //    return _description.ToString().TrimEnd().TrimEnd(',');
        //}

        ///// <summary>
        ///// 添加描述
        ///// </summary>
        //protected virtual void AddDescriptions()
        //{
        //}

        ///// <summary>
        ///// 添加单个描述
        ///// </summary>
        ///// <param name="description"></param>
        //protected void AddDescription(string description)
        //{
        //    if (string.IsNullOrWhiteSpace(description))
        //        return;
        //    _description.Append(description);
        //}

        ///// <summary>
        ///// 添加描述
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="name"></param>
        ///// <param name="value"></param>
        //protected void AddDescription<T>(string name, T value)
        //{
        //    if (string.IsNullOrWhiteSpace(value.ToStr()))
        //        return;
        //    _description.AppendFormat("{0}:{1}", name, value);
        //}

        ///// <summary>
        ///// 验证规则集合
        ///// </summary>
        //private readonly List<IValidationRule> _rules;

        ///// <summary>
        ///// 添加验证规则
        ///// </summary>
        ///// <param name="rule"></param>
        //public void AddValidationRule(IValidationRule rule)
        //{
        //    if (rule == null)
        //        return;
        //    _rules.Add(rule);
        //}
        ///// <summary>
        ///// 验证
        ///// </summary>
        //public virtual void Validate()
        //{
        //    var result = GetValidationResult();
        //    HandleValidationResult(result);
        //}
        ///// <summary>
        ///// 处理验证结果
        ///// </summary>
        ///// <param name="results"></param>
        //private void HandleValidationResult(ValidationResultCollection results)
        //{
        //    if (results.IsValid)
        //        return;
        //    _handler.Handle(results);
        //}
        ///// <summary>
        ///// 获取验证结果
        ///// </summary>
        ///// <returns></returns>
        //private ValidationResultCollection GetValidationResult()
        //{
        //    var result = ValidationFactory.Create().Validate(this);
        //    Validate(result);
        //    foreach (var rule in _rules)
        //        result.Add(rule.Validate());
        //    return result;
        //}

        ///// <summary>
        ///// 验证并添加到验证结果集合
        ///// </summary>
        ///// <param name="results">验证结果集合</param>
        //protected virtual void Validate(ValidationResultCollection results)
        //{
        //}
        ///// <summary>
        ///// 验证处理器
        ///// </summary>
        //private IValidationHandler _handler;
        ///// <summary>
        ///// 设置验证处理器
        ///// </summary>
        ///// <param name="handler"></param>
        //public void SetValidationHandler(IValidationHandler handler)
        //{
        //    if (handler == null)
        //        return;
        //    _handler = handler;
        //} 
        //#endregion
    }
}
