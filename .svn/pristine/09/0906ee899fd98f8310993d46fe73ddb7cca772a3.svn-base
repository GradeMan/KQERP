using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Reflection.Emit;
using System.Dynamic;
using System.Linq.Expressions;

namespace COM.Domain
{
    public class PropertyLambda
    {
        public static object Get<T,TPorp>(object obj, Expression<Func<T, string>> propExpression)
        {
            var propName = For(propExpression);
            var type = typeof(T);
            var propList = type.GetProperties();
            var p = propList.Where(i => i.Name == propName).SingleOrDefault();
            if (p == null)
                throw new ApplicationException(string.Format("对象{0}没有属性{1}",type.FullName,propName));
            return p.GetValue(obj, null);
        }

        public static string For<T, TPorperty>(Expression<Func<T, TPorperty>> expression)
        {
            var body = expression.Body;
            return GetMemberName(body);
        }

        //public static string For(Expression<Func<string>> expression)
        //{
        //    var body = expression.Body;
        //    return GetMemberName(body);
        //}

        private static string GetMemberName(Expression expression)
        {
            if (expression is MemberExpression)
            {
                var memberExpression = (MemberExpression)expression;
                if (memberExpression.Expression.NodeType ==  ExpressionType.MemberAccess)
                    return GetMemberName(memberExpression.Expression) + "." + memberExpression.Member.Name;
                return memberExpression.Member.Name;
            }
            if (expression is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)expression;
                if (unaryExpression.NodeType != ExpressionType.Convert)
                    throw new Exception(string.Format
                      ("Cannot interpret member from {0}", expression));
                return GetMemberName(unaryExpression.Operand);
            }
            throw new Exception
              (string.Format("Could not determine member from {0}", expression));
        }
    }

}