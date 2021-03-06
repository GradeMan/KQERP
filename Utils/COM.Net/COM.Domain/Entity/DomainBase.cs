﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;

namespace COM.Domain
{
    /// <summary>
    /// 领域层基类=>封装实体状态输出和验证方法
    /// </summary>
    public class DomainBase : ICloneable
    {
       /// <summary>
       /// 初始化领域层基类
       /// </summary>
       protected DomainBase()
       {
           _rules = new List<IValidationRule>();
           _handler = new ValidationHandler();
       }
       /// <summary>
       /// 描述 作用=>实体状态输出
       /// </summary>
       private StringBuilder _description;

       /// <summary>
       /// 验证规则集合=》主要用于添加一些额外的验证规则比如OldProgrammerSalaryRule
       /// </summary>
       private readonly List<IValidationRule> _rules;

       /// <summary>
       /// 验证处理器，验证错误的办法 ValidationHandler
       /// </summary>
       private IValidationHandler _handler;

       /// <summary>
       /// 重写ToString,输出领域对象的状态
       /// </summary>
       /// <returns></returns>
       public override string ToString()
       {
           _description = new StringBuilder();
           AddDescriptions();
           return _description.ToString().TrimEnd().TrimEnd(','); //去掉最后的，
       }

       /// <summary>
       /// 添加描述，用虚方法，继承类重写此方法
       /// </summary>
       protected virtual void AddDescriptions()
       { 
       }

       /// <summary>
       /// 添加描述
       /// </summary>
       /// <param name="description"></param>
       protected void AddDescription(string description)
       {
           if (!string.IsNullOrWhiteSpace(description))
               _description.AppendFormat(description);
       }

       /// <summary>
       /// 添加描述
       /// </summary>
       /// <typeparam name="T">类型</typeparam>
       /// <param name="name">名称</param>
       /// <param name="value">值</param>
       protected void AddDescription<T>(string name, T value)
       {
           if (!string.IsNullOrWhiteSpace(value.ToStr()))
               _description.AppendFormat("{0}:{1}", name, value);
       }

       /// <summary>
       /// 设置验证处理器，默认是用ValidationHandler，已在初始化基类的时候实例化了
       /// </summary>
       /// <param name="handler"></param>
       public void SetValidationHandler(IValidationHandler handler)
       {
           if (handler != null)
               _handler = handler;
       }

       /// <summary>
       /// 添加额外的验证规则
       /// </summary>
       /// <param name="rule"></param>
       public void AddValidationRule(IValidationRule rule)
       {
           if (rule != null)
               _rules.Add(rule);
       }

       /// <summary>
       /// 对实体进行验证
       /// </summary>
       public virtual void Validate()
       {
           //1.0获取验证结果
           var result = GetValiationResult();
           //2.0处理验证结果
           HandlerValidationResult(result);
       }

       /// <summary>
       /// 处理验证结果
       /// </summary>
       /// <param name="result"></param>
       private void HandlerValidationResult(ValidationResultCollection results)
       {
           if (!results.IsValid)
               _handler.Handle(results);
       }
       /// <summary>
       /// 获取验证实体
       /// </summary>
       /// <returns></returns>
       private ValidationResultCollection GetValiationResult()
       {
           //1.0通过验证工厂创建验证实体，然后验证实体
           var result = ValidationFactory.Create().Validate(this);
           Validate(result);
           //2.0验证额外的规则
           foreach (var rule in _rules)
               result.Add(rule.Validate());
           return result;
       }
      
       protected virtual void Validate(ValidationResultCollection result)
       {
       }

       public object Clone()
       {
           object newObject = Activator.CreateInstance(this.GetType());
           System.Reflection.PropertyInfo[] property = newObject.GetType().GetProperties();
           System.Reflection.PropertyInfo[] thisproperty = this.GetType().GetProperties();
           for (int i = 0; i < thisproperty.Length; i++)
           {
               System.Reflection.MethodInfo mi = property[i].GetSetMethod();
               if (mi == null)
                   break;
               object propertyvalue = thisproperty[i].GetValue(this, null);
               if (propertyvalue is ICloneable)
               {
                   property[i].SetValue(newObject, ((ICloneable)propertyvalue).Clone(), null);
               }
               else
               {
                   property[i].SetValue(newObject, propertyvalue, null);
               }
           }
           return newObject;
       }
    }
}
