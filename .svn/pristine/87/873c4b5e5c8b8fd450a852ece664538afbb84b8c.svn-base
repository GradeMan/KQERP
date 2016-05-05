using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
namespace Util
{
    /// <summary>
    /// 验证操作
    /// </summary>
    public class Validation :IValidation
    {
        public Validation()
        {
            _results = new ValidationResultCollection();
        }
        /// <summary>
        /// 验证目标
        /// </summary>
        private object _target;
        /// <summary>
        /// 验证结果
        /// </summary>
        private readonly ValidationResultCollection _results;

        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="target">验证目标</param>
        /// <returns></returns>
        public ValidationResultCollection Validate(object target)
        {
            _target = target;
            Type type = target.GetType();
            var properties = type.GetProperties();
            foreach (var property in properties) //遍历每个属性上的ValidationAttribute特性
                ValidateProperty(property);
            return _results;
        }
        
        /// <summary>
        /// 验证属性
        /// </summary>
        /// <param name="property">属性</param>
        private void ValidateProperty(PropertyInfo property)
        {
            //获取验证特性
            var attributes = property.GetCustomAttributes(typeof(ValidationAttribute), true);
            foreach (var attribute in attributes)
            {
                var validationAttribute = attribute as ValidationAttribute;
                if (validationAttribute != null)
                {
                    ValidateAttribute(property, validationAttribute);
                }
            }

        }

        /// <summary>
        /// 验证特性
        /// </summary>
        /// <param name="property"></param>
        /// <param name="attribute"></param>
        private void ValidateAttribute(PropertyInfo property, ValidationAttribute attribute)
        {
            bool isValid = attribute.IsValid(property.GetValue(_target, null));
            if (!isValid)
                _results.Add(new ValidationResult(GetErrorMessage(attribute)));
        }

        /// <summary>
        /// 获取错误信息
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        private string GetErrorMessage(ValidationAttribute attribute)
        {
            if (!string.IsNullOrEmpty(attribute.ErrorMessage))
                return attribute.ErrorMessage;
            return "错误";
            //return Resource.GetString(attribute.ErrorMessageResourceType.FullName, attribute.ErrorMessageResourceName, attribute.ErrorMessageResourceType.Assembly);
        }
    }
}
