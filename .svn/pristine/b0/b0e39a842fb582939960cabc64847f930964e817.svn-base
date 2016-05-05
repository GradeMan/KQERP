using System;
using Util.Logs;
using Util;

namespace COM.Data {
    /// <summary>
    /// 并发异常
    /// </summary>
    public class ConcurrencyException : AppException
    {
        /// <summary>
        /// 初始化并发异常
        /// </summary>
        /// <param name="exception">异常</param>
        public ConcurrencyException( Exception exception )
            : this( "", exception ) {
        }

        /// <summary>
        /// 初始化并发异常
        /// </summary>
        /// <param name="message">错误消息</param>
        /// <param name="exception">异常</param>
        public ConcurrencyException( string message, Exception exception )
            : this( message, exception,"" ) {
        }

        /// <summary>
        /// 初始化并发异常
        /// </summary>
        /// <param name="message">错误消息</param>
        /// <param name="exception">异常</param>
        /// <param name="code">错误码</param>
        public ConcurrencyException( string message, Exception exception ,string code)
            : this( message,exception, code, LogLevel.Error ) {
        }

        /// <summary>
        /// 初始化并发异常
        /// </summary>
        /// <param name="message">错误消息</param>
        /// <param name="exception">异常</param>
        /// <param name="code">错误码</param>
        /// <param name="level">日志级别</param>
        public ConcurrencyException( string message, Exception exception,string code, LogLevel level )
            : base( message, code,level, exception ) {
        }
    }
}
