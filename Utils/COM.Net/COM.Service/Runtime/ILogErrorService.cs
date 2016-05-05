using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;

namespace COM.Service
{
    public interface ILogErrorService
    {
        void LogWebAppError(string info);
        void LogMvcError(string info);
        void LogWcfError(string info);
        void LogScheduleError(string info);
        void LogWorkflowError(string info);
    }

}


