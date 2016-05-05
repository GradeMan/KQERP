using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using COM.Service;
using COM.Data;


namespace COM.Web
{
    public interface IWebAppPathService : IAppPathService
    {
        string UploadFilePath { get; }
    }

    public class WebAppPathService : IWebAppPathService, IAppPathService
    {

        public string AppDataPath
        {
            get
            {
                var path = new System.IO.DirectoryInfo(HttpRuntime.BinDirectory);
                return System.IO.Path.Combine(path.Parent.FullName, "App_Data");
            }
        }

        public string UploadFilePath
        {
            get
            {
                var path = System.IO.Path.Combine(this.AppDataPath, "UploadFile");
                if (!System.IO.Directory.Exists(path))
                    System.IO.Directory.CreateDirectory(path);
                return path;
            }
        }


        public string AppRunPath
        {
            get
            {
                return HttpRuntime.BinDirectory;
            }
        }
    }
}
