using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShareClient.FileService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IFileService”。
    [ServiceContract]
    public interface IFileService
    {
        [OperationContract(Action = "UploadFile", IsOneWay = true)]
        Serviceresult UploadFile(FileUploadMessage fileMsg);
    }

    [MessageContract]
    public class FileUploadMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public string SavePath;

        [MessageHeader(MustUnderstand = true)]
        public string FileName;

        [MessageBodyMember(Order = 1)]
        public Stream FileData;

    }

    /// <summary>
    /// 返回结果
    /// </summary>
    [MessageContract]
    public class Serviceresult
    {
        [MessageBodyMember]
        public bool returnresult;
    }
}
