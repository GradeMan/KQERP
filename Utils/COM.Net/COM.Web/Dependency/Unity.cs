﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using COM.Service;

namespace COM.Web
{
    public class Unity : COM.Data.IUnity
    {
        private static Unity instance;
        public static Unity Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Unity();
                    instance.Initial();
                }
                return instance;
            }
        }

        public Unity()
        {
            FileLogService.Instance.LogUnity("Unity Created");
        }

        private UnityDependencyResolver Resolver { get; set; }
        private UnityContainer UnityContainer { get; set; }
        protected void Initial()
        {
            this.UnityContainer = new UnityContainer();
            this.Resolver = new UnityDependencyResolver(this.UnityContainer);
            this.UnityContainer.RegisterInstance<COM.Data.IUnity>(this); //把自己也注入进去
        }

        public I GetService<I>() where I:class
        {
            return this.Resolver.GetService<I>();
        }

        public COM.Data.IUnity Register<I, T>() where T : I
        {
             this.UnityContainer.RegisterType<I, T>(new HttpContextLifetimeManager<T>());
             return this;
        }

        /// <summary>
        /// 注意,注册的单例服务,要避免依赖会话服务
        /// 尽量不要注册单例服务,除非有大量IO操作或反射操作
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="container"></param>
        /// <returns></returns>
        public Unity RegisterSingleton<I, T>() where T : I
        {
            this.UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
            return this;
        }


        public COM.Data.IUnity RegisterSingletonService<I, T>() where T : I
        {
            return this.RegisterSingleton<I, T>();
        }
    }

}