using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Web
{
    /// <summary>
    /// 这是一个单例服务
    /// </summary>
    public class ScheduleService : IDisposable, IScheduleService
    {
        //全局变量,所有引用的对象都必须是方法内临时变量
        private ScheduleTimer scheduleTimer = new ScheduleTimer();

        public void StartTask()
        {
            //仅当第一次打开网页时,才激活网站,才开始计时
            this.scheduleTimer.Start();
            //this.ScheduleTimer.AddSchedulTask(new MinScheduleItem());
            this.scheduleTimer.AddSchedulTask(new Min5ScheduleItem());
            this.scheduleTimer.AddSchedulTask(new HoureScheduleItem());
            this.scheduleTimer.AddSchedulTask(new TestTimeScheduleItem());
        }

        public void Dispose()
        {
            this.Close();
        }

        public void Close()
        {
            this.scheduleTimer.Close();
        }

    }
}