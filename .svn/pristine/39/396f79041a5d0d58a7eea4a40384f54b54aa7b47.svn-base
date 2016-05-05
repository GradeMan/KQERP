using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using COM.Data;
using System.Runtime.Remoting.Messaging;

namespace COM.Data
{
    public class DatabaseFactoryBase<T> : Disposable, IDatabaseFactoryBase<T> where T:DbContext,new()
    {
        ////[ThreadStatic]
        private  T dataContext;
        ////public static MyDataContext Instance()
        ////{
        ////    if (context == null)
        ////        instance = new MyDataContext();
        ////    return instance;
        ////} 
        public T Get()
        {
            //dataContext = CallContext.GetData(typeof(DatabaseFactoryBase<T>).Name) as T;
            //if (dataContext == null)
            //{
            //    dataContext = new T();
            //    CallContext.SetData(typeof(DatabaseFactoryBase<T>).Name, dataContext);
            //}
           // return dataContext;
            return dataContext ?? (dataContext = new T());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }

        //[ThreadStatic]
        //private static T instance;

        //public  T Instance()
        //{
        //    if (instance == null)
        //        instance = new T();
        //    return instance;
        //}
    }

}
