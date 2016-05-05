using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Web
{
    public interface IScheduleTask
    {
        /// <summary>
        /// 返回true,执行Executed,通常是异步打开url后,立即返回
        /// </summary>
        /// <returns></returns>
        DateTime? ExecuteTask();

        /// <summary>
        /// 下次调用时间,是从任务执行完后间隔多少时间后调用
        ///此任务如果是异步的,则相当于触发任务后,即确定下次调用时间
        /// </summary>
        DateTime? NextTaskDateTime { get; }
    }
}