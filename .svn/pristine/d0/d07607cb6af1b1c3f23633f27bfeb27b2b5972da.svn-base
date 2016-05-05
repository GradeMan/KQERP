using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util.Logs;
using System.Collections;

namespace Util
{
    /// <summary>
    /// 应用程序异常
    /// </summary>
    public class AppException:ApplicationException
    {

        public AppException(string message)
            : this(message, "")
        {
        }

        public AppException(string message, string code)
            : this(message,code,LogLevel.Warning)
        {
        }

        public AppException(string message, string code, LogLevel logLevel)
            :this(message,code,logLevel,null)
        {
           
        }

        public AppException(Exception exception)
            : this("", "", LogLevel.Warning, exception)
        {
        }

        public AppException(string message, string code, Exception exception)
            : this(message, code, LogLevel.Warning, exception)
        {
        }

        public AppException(string message, string code, LogLevel logLevel, Exception exception)
            : base(message ?? "",exception)
        {
            Code = code;
            Level = logLevel;
            _message = GetMessage();
        }

        private string GetMessage()
        {
            var result = new StringBuilder();
            AppendSelfMessage(result);
            AppendInnerMessage(result, InnerException);
            return result.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        /// <summary>
        /// 添加本身消息
        /// </summary>
        /// <param name="result"></param>
        private void AppendSelfMessage(StringBuilder result)
        {
            if (string.IsNullOrWhiteSpace(base.Message))
                return;
            result.AppendLine(base.Message);
        }
        /// <summary>
        /// 添加内部异常消息
        /// </summary>
        /// <param name="result"></param>
        /// <param name="InnerException"></param>
        private void AppendInnerMessage(StringBuilder result, Exception exception)
        {
            if (exception == null)
                return;
            if (exception is AppException)
            {
                result.AppendLine(exception.Message);
                return;
            }
            result.AppendLine(exception.Message);
            result.Append(GetData(exception));
            AppendInnerMessage(result, exception.InnerException);
        }
        /// <summary>
        /// 获取添加的额外数据
        /// </summary>
        /// <param name="InnerException"></param>
        /// <returns></returns>
        private string GetData(Exception ex)
        {
            var result = new StringBuilder();
            foreach (DictionaryEntry data in ex.Data)
                result.AppendFormat("{0}:{1}{2}", data.Key, data.Value, Environment.NewLine);
            return result.ToString();
        }
        /// <summary>
        /// 错误消息
        /// </summary>
        private readonly string _message;

        public override string Message
        {
            get
            {
                if (Data.Count == 0)
                    return _message;
                return _message + Environment.NewLine + GetData(this);
            }
        }
        /// <summary>
        /// 错误码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 日志级别
        /// </summary>
        public LogLevel Level { get; set; }

        public override string StackTrace
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(base.StackTrace))
                    return base.StackTrace;
                if (base.InnerException == null)
                    return string.Empty;
                return base.InnerException.StackTrace;
            }
        }

    }
}
