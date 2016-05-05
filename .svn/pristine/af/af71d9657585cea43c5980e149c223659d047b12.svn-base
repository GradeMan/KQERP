using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace ShareClient.FileService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“FileService”。
    public class FileService : IFileService
    {

        public Serviceresult UploadFile(FileUploadMessage fileMsg)
        {
            try
            {
                string uploadFolder = @"C:\kkk\";
                string savaPath = fileMsg.SavePath;
                var sourceSream = fileMsg.FileData;
                string fileName = fileMsg.FileName;
                if (!sourceSream.CanRead)
                {
                    throw new Exception("数据流不可读!");
                }
                if (savaPath == null) savaPath = @"Photo\";
                if (!savaPath.EndsWith("\\")) savaPath += "\\";
                uploadFolder = uploadFolder + savaPath;
                //如果文件夹不存在则创建
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                string filePath = Path.Combine(uploadFolder, fileName);
                //如果文件存在则先删除
                if (File.Exists(filePath))
                    File.Delete(filePath);

                var targetSream = new FileStream(filePath,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None);
                var buffer = new byte[4096];
                var count = 0;
                while ((count = sourceSream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    targetSream.Write(buffer, 0, count);
                }
                targetSream.Close();
                sourceSream.Close();
            }
            catch (Exception)
            {
                return new Serviceresult { returnresult = false };
            }
            return new Serviceresult { returnresult = true }; 
        }
    }
}
