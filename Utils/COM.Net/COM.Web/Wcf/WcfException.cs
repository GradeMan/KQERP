using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel;
using System.Web.Mvc;
using COM.Service;

namespace COM.Web
{

    public class ErrorHandlerServiceBehavior :IServiceBehavior
    {
        public class ErrorHandler : IErrorHandler
        {
            public bool HandleError(Exception error)
            {
                string format = "Wcf.Exception {0}.Message:{1}\r\nInnerException:{2}\r\nStack:{3}";
                string errorInfo = string.Format(format, error.GetType().Name, error.Message, error.InnerException == null ? string.Empty : error.InnerException.ToString(), error.StackTrace);
                var logErrorService = Unity.Instance.GetService<ILogErrorService>();
                logErrorService.LogWcfError(errorInfo);
                return true; //已处理异常,继承提供WCF服务
            }

            public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
            {
                //you can throw exception in WCF method and get the exception here.
                FaultCode faultCode = FaultCode.CreateSenderFaultCode(error.GetType().Name, "http://tempuri.org/net/exceptions");
                fault = Message.CreateMessage(version, faultCode, error.Message, null);
            }
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcher chanDisp in serviceHostBase.ChannelDispatchers)
            {
                chanDisp.ErrorHandlers.Add(new ErrorHandler());
            }

        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

    }

    public class ErrorHandlerBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(ErrorHandlerServiceBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new ErrorHandlerServiceBehavior();
        }
    }


    /*
    public class FaultingWebHttpBehavior : WebHttpBehavior
    {
        protected override void AddServerErrorHandlers(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            endpointDispatcher.ChannelDispatcher.ErrorHandlers.Clear();
            endpointDispatcher.ChannelDispatcher.ErrorHandlers.Add(new ErrorHandler());
        }

        public class ErrorHandler : IErrorHandler
        {
            private IRuntimeService runtimeService = DependencyService.Resolver.GetService<IRuntimeService>();
            #region IErrorHandler Members
            public bool HandleError(Exception error)
            {
                string errorString = string.Format("异常:({0}){1}\r\n深层异常:{2}\r\n堆栈:{3}", error.GetType().Name, error.Message, error.InnerException == null ? string.Empty : error.InnerException.ToString(), error.StackTrace);
                throw new ApplicationException(errorString);
                return true;
            }

            public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
            {
                //you can throw exception in WCF method and get the exception here.
                FaultCode faultCode = FaultCode.CreateSenderFaultCode(error.GetType().Name, "http://tempuri.org/net/exceptions");
                fault = Message.CreateMessage(version, faultCode, error.Message, null);
            }
            #endregion
        }

    }

    public class FaultingWebHttpBehaviorElement : BehaviorExtensionElement
    {
        /// <summary>
        /// Gets the type of behavior.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Type"/>.</returns>
        public override Type BehaviorType
        {
            get { return typeof(FaultingWebHttpBehavior); }
        }

        /// <summary>
        /// Creates a behavior extension based on the current  configuration settings.
        /// </summary>
        /// <returns>The behavior extension.</returns>
        protected override object CreateBehavior()
        {
            return new FaultingWebHttpBehavior();
        }
    }
    */



}


