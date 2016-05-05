using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Reflection.Emit;
using System.Dynamic;

namespace COM.Data
{
    public class EntityReflectService
    {
        static private EntityReflectService instance;
        static public EntityReflectService Instance
        {
            get
            {
                return instance ?? (instance = new EntityReflectService());
            }
        }

        /// <summary>
        /// 复制属性,如果原始对象与目标对象的属性名一致,则复制
        /// </summary>
        /// <param name="from">原始对象</param>
        /// <param name="to">目标对象</param>
        public void CopyEntityProperty(object from, object to)
        {
            PropertyInfo[] propertyInfoFrom = this.GetTypePropertyInfo(from.GetType());
            PropertyInfo[] propertyInfoTo = this.GetTypePropertyInfo(to.GetType());
            var dictFrom = propertyInfoFrom.ToDictionary(p => p.Name, p => p);
            foreach (var property in propertyInfoTo)
            {
                if (property.PropertyType.IsSealed && property.PropertyType.IsSerializable && dictFrom.ContainsKey(property.Name))
                {
                    Object propertyValue = dictFrom[property.Name].GetValue(from, null);
                    if (property.GetSetMethod() != null)
                        property.SetValue(to, propertyValue, null);
                }
            }
        }

        static private object syncObj = new object();

        private Dictionary<Type, PropertyInfo[]> propertyInfoCache = new Dictionary<Type, PropertyInfo[]>();
        public PropertyInfo[] GetTypePropertyInfo(Type type)
        {
            if (!propertyInfoCache.ContainsKey(type))
                lock(syncObj)
                    if (!propertyInfoCache.ContainsKey(type))
                        propertyInfoCache.Add(type, type.GetProperties());
            return propertyInfoCache[type];
        }

        /// <summary>
        /// 从对象to复制所有属性到对象from,属性名可能不同
        /// </summary>
        /// <param name="from">原始对象</param>
        /// <param name="to">目标对象</param>
        /// <param name="propertyCopy">列名到属性名的映射表</param>
        public void CopyEntityProperty(object from, object to, Dictionary<string, string> propertyMap)
        {
            PropertyInfo[] propertyInfoTo = this.GetTypePropertyInfo(to.GetType());
            PropertyInfo[] propertyInfoFrom = this.GetTypePropertyInfo(from.GetType());
            var dictFrom = propertyInfoFrom.ToDictionary(p => p.Name, p => p);
            var dictTo = propertyInfoTo.ToDictionary(p => p.Name, p => p);
            foreach (var copy in propertyMap)
            {
                Object propertyValue = dictFrom[copy.Key].GetValue(from, null);
                var property = dictTo[copy.Value];
                if (property.GetSetMethod() != null)
                    property.SetValue(to, propertyValue, null);
            }
        }

        private List<string> complexEntityList = null;
        private List<string> ComplexEntityList
        {
            get
            {
                if (complexEntityList == null)
                    complexEntityList = typeof(EnumComplexEntity).GetMembers(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Select(m => m.Name).ToList();
                return complexEntityList;
            }
        }

        /// <summary>
        /// 返回一个entity的副本clr对象，类型与entity一致
        /// </summary>
        public T CloneEntityCopy<T>(T entity) where T : class
        {
            var type = entity.GetType();
            var copy = this.CreateEntity<T>(type.Name);
            System.Reflection.PropertyInfo[] propertyInfo = type.GetProperties();
            foreach (var property in propertyInfo)
            {
                if (property.PropertyType.IsSealed && property.PropertyType.IsSerializable)
                {
                    Object propertyValue = property.GetValue(entity, null);
                    if (property.GetSetMethod() != null)
                        property.SetValue(copy, propertyValue, null);
                }
                else if (this.ComplexEntityList.Contains(property.ReflectedType.Name)) //复杂类型
                {
                    Object propertyValue = property.GetValue(entity, null);
                    if (property.GetSetMethod() != null)
                        property.SetValue(copy, this.CloneEntityCopy(propertyValue), null);
                }
            }
            return copy as T;
        }


        /// <summary>
        /// 动态创建InstanceType类型的实例,返回类型T,InstanceType继承于T类型
        /// </summary>
        /// <typeparam name="T">返回的父类型</typeparam>
        /// <param name="instanceType">实例类型</param>
        /// <returns>CLR实例</returns>
        public T CreateEntity<T>(string instanceType)
        {
            //Todo:临时类型
            Type type = typeof(T);
            Type t = Assembly.GetExecutingAssembly().GetType(string.Format("{0}.{1}", type.Namespace, instanceType));
            ConstructorInfo creator = t.GetConstructor(System.Type.EmptyTypes);
            var entity = (T)creator.Invoke(null);
            return entity;
        }

        public void ClearEventHandler(object eventObject, object targetObject)
        {
            var eventObjectType = eventObject.GetType();
            var eventList = eventObjectType.GetEvents().ToList();
            eventList.ForEach(eventInfo =>
            {
                var f = this.GetEventFiled(eventObjectType, eventInfo.Name);
                var hlist = f.GetValue(eventObject) as EventHandler;
                if (hlist != null)
                    foreach (var h in hlist.GetInvocationList())
                    {
                        if (h.Target == null)
                        {
                            if (h.Method.DeclaringType.Name == targetObject.GetType().Name)
                                eventInfo.RemoveEventHandler(eventObject, h);
                        }
                        else
                        {
                            if (h.Target == targetObject)
                                eventInfo.RemoveEventHandler(eventObject, h);
                        }
                    }
            });
        }

        public bool IsRegistEventHandler(object eventObject, string eventName, object targetObject)
        {
            var eventObjectType = eventObject.GetType();
            var eventList = eventObjectType.GetEvents().ToList();
            var eventInfo = eventList.Where(e => e.Name == eventName).SingleOrDefault();
            if (eventInfo == null)
                throw new ApplicationException(string.Format("事件{0}.{1}不存在", eventObjectType.Name, eventName));
            var f = this.GetEventFiled(eventObjectType, eventInfo.Name);
            var hlist = f.GetValue(eventObject) as EventHandler;
            if (hlist == null)
                return false;
            foreach (var h in hlist.GetInvocationList())
            {
                if (h.Target == null)
                {
                    if (h.Method.DeclaringType.Name == targetObject.GetType().Name)
                        return true;
                }
                else
                {
                    if (h.Target == targetObject)
                        return true;
                }
            }
            return false;
        }

        public bool IsRegistEventHandler<T>(object eventObject, string eventName)
        {
            var eventObjectType = eventObject.GetType();
            var eventList = eventObjectType.GetEvents().ToList();
            var eventInfo = eventList.Where(e => e.Name == eventName).SingleOrDefault();
            if (eventInfo == null)
                throw new ApplicationException(string.Format("事件{0}.{1}不存在", eventObjectType.Name, eventName));
            var f = this.GetEventFiled(eventObjectType, eventInfo.Name);
            var hlist = f.GetValue(eventObject) as EventHandler;
            if (hlist == null)
                return false;
            foreach (var h in hlist.GetInvocationList())
            {
                if (h.Method.DeclaringType.Name == typeof(T).Name)
                    return true;
            }
            return false;

        }

        private FieldInfo GetEventFiled(Type type, string eventName)
        {
            BindingFlags all = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            FieldInfo fieldInfo = type.GetFields(all).Where(f => f.Name == eventName).SingleOrDefault();
            if (fieldInfo != null)
                return fieldInfo;
            return this.GetEventFiled(type.BaseType, eventName);
        }


        /// <summary>
        /// 把代理的实体去代理化,用于序列化
        /// </summary>
        /// <param name="proxyEntity">代理的</param>
        /// <returns>非代理的原始类</returns>
        public object GetEntityFromProxy(object proxyEntity)
        {
            var typeProxy = proxyEntity.GetType();
            if (!typeProxy.Namespace.EndsWith("DynamicProxies"))
                throw new ApplicationException("参数应传入代理对象!");
            var typeBase = typeProxy.BaseType;
            var entity = Activator.CreateInstance(typeBase);
            this.CopyEntityProperty(proxyEntity, entity);
            //复制集合属性
            var propList = this.GetTypePropertyInfo(typeBase);
            var q = from info in propList
                    where info.PropertyType.IsGenericType && info.PropertyType.GetGenericTypeDefinition().Name.StartsWith("ICollection")
                    select info;

            var proxyPropList = this.GetTypePropertyInfo(typeProxy);
            foreach (var item in q)
            {
                var hashSetProxy = proxyPropList.Where(p => p.Name == item.Name).Single();
                var listFromSet = hashSetProxy.GetValue(proxyEntity, null);
                if (listFromSet == null)
                    item.SetValue(entity, null, null);
                else
                {
                    //生成HashSet泛型类
                    Type type = typeof(HashSet<>).MakeGenericType(hashSetProxy.PropertyType.GetGenericArguments());
                    var toSet = Activator.CreateInstance(type);
                    dynamic listFromSetDynamic = listFromSet;
                    dynamic toSetDynamic = toSet;
                    foreach (var entityItem in listFromSetDynamic)
                    {
                        toSetDynamic.Add(this.GetEntityFromProxy(entityItem));
                    }
                    item.SetValue(entity, toSet, null);
                }
            }
            return entity;
        }
    }


    class EnumComplexEntity
    {
        public static readonly string ContractCustomer = "ContractCustomer";
        public static readonly string ContractPay = "ContractPay";
        public static readonly string ContractExpress = "ContractExpress";
    }

    /// <summary>
    /// A 10 minute wrapper to access private members, havn't tested in detail.
    /// </summary>
    public class AccessPrivateWrapper : DynamicObject
    {

        /// <summary>
        /// The object we are going to wrap
        /// </summary>
        object _wrapped;

        /// <summary>
        /// Specify the flags for accessing members
        /// </summary>
        static BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance| BindingFlags.Static | BindingFlags.Public;

        /// <summary>
        /// Create a simple private wrapper
        /// </summary>
        public AccessPrivateWrapper(object o)
        {
            _wrapped = o;
        }

        /// <summary>
        /// Create an instance via the constructor matching the args 
        /// </summary>
        public static dynamic FromType(Assembly asm, string type, params object[] args)
        {

            var allt = asm.GetTypes();
            var t = allt.First(item => item.Name == type);


            var types = from a in args
                        select a.GetType();

            //Gets the constructor matching the specified set of args
            var ctor = t.GetConstructor(flags, null, types.ToArray(), null);

            if (ctor != null)
            {
                var instance = ctor.Invoke(args);
                return new AccessPrivateWrapper(instance);
            }

            return null;
        }

        /// <summary>
        /// Try invoking a method
        /// </summary>
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var types = from a in args
                        select a.GetType();

            var method = _wrapped.GetType().GetMethod(binder.Name, flags, null, types.ToArray(), null);

            if (method == null)
                return base.TryInvokeMember(binder, args, out result);
            else
            {
                result = method.Invoke(_wrapped, args);
                return true;
            }
        }

        /// <summary>
        /// Tries to get a property or field with the given name
        /// </summary>
        public override bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result)
        {
            //Try getting a property of that name
            var prop = _wrapped.GetType().GetProperty(binder.Name, flags);

            if (prop == null)
            {
                //Try getting a field of that name
                var fld = _wrapped.GetType().GetField(binder.Name, flags);
                if (fld != null)
                {
                    result = fld.GetValue(_wrapped);
                    return true;
                }
                else
                    return base.TryGetMember(binder, out result);
            }
            else
            {
                result = prop.GetValue(_wrapped, null);
                return true;
            }
        }

        /// <summary>
        /// Tries to set a property or field with the given name
        /// </summary>
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            var prop = _wrapped.GetType().GetProperty(binder.Name, flags);
            if (prop == null)
            {
                var fld = _wrapped.GetType().GetField(binder.Name, flags);
                if (fld != null)
                {
                    fld.SetValue(_wrapped, value);
                    return true;
                }
                else
                    return base.TrySetMember(binder, value);
            }
            else
            {
                prop.SetValue(_wrapped, value, null);
                return true;
            }
        }




    }
}