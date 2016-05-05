using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Reflection.Emit;
using System.Dynamic;
using System.Xml.Linq;
using System.Collections;

namespace COM.Data
{
    public class XElementService
    {
        static private XElementService instance;
        static public XElementService Instance
        {
            get
            {
                return instance ?? (instance = new XElementService());
            }
        }

        private XElement GetListXElement(string entityName, IEnumerable<object> entityList)
        {
            //遍历静态公共属性
            var x = new XElement(string.Format("{0}List", entityName),
                                    from entity in entityList
                                    select this.GetXElement(entityName, entity)
                                );
            return x;
        }

        /// <summary>
        /// 将此对像的属性序列化
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public XElement GetXElement(string entityName, object entity)
        {
            if (entity == null)
                return null;
            Type type = entity.GetType();
            //如果是列表,直接返回 EntityList/Entity 的Xml
            if (typeof(IEnumerable<object>).IsAssignableFrom(type))
            {
                var xmlItemName = entityName.EndsWith("List") ? entityName.Substring(0, entityName.Length - "List".Length) : string.Empty;
                if (string.IsNullOrEmpty(xmlItemName))
                {
                    var itemTypeName = type.GetGenericArguments()[0].Name;
                    xmlItemName = string.IsNullOrEmpty(entityName) ? (itemTypeName.Contains("AnonymousType") ? "EntityXml" : itemTypeName) : entityName;
                }
                return this.GetListXElement(xmlItemName, entity as IEnumerable<object>);
            }

            //如果是列表,直接返回 EntityList/Entity 的Xml
            if (typeof(IQueryable).IsAssignableFrom(type))
                throw new ApplicationException(string.Format("{0}的类型为{1},可能是错误Sql查询!", entityName,type.FullName));

            //如果属性名是_Xml,则把属性值返序列化后,返回把子节点属性值提前
            PropertyInfo[] props = type.GetProperties();
            var xmlProp = from p in props
                          where p.Name.StartsWith("_Xml", StringComparison.OrdinalIgnoreCase)
                          select p;
            var listProp = from p in props.Except(xmlProp)
                           where typeof(IEnumerable<object>).IsAssignableFrom(p.PropertyType)
                           select p;
            var entityProp = props.Except(xmlProp).Except(listProp);
            //var x = new XElement(entityName,
            //                   from p in entityProp
            //                   select new XElement(p.Name, this.GetXmlValue(p.Name, p.PropertyType, p.GetValue(entity, null))),
            //                   from p in xmlProp
            //                   select this.GetXElement(p.Name, p.GetValue(entity, null)).Elements(),
            //                   from p in listProp
            //                   select this.GetXElement(p.Name, p.GetValue(entity, null) as IEnumerable<object>)
            //                   );
            var x = new XElement(entityName,
                                from p in entityProp
                                select new XElement(p.Name, this.GetXmlValue(p.Name, p.PropertyType, p.GetValue(entity, null)))
                // from p in xmlProp
                // select this.GetXElement(p.Name, p.GetValue(entity, null)).Elements()
                //from p in listProp
                //select this.GetXElement(p.Name, p.GetValue(entity, null) as IEnumerable<object>)
                // select this.GetXElement(p.Name, entity)
                                );
            return x;
        }

        private string GetXmlValue(string entityName, Type type, object entity)
        {
            if (entity == null)
                return string.Empty;

            if (type == typeof(DateTime) || type == typeof(DateTime?))
            {
                return ((DateTime)entity).ToString("yyyy/MM/dd HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }

            return entity.ToString();
        }

    }
}