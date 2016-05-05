using System.Xml;
using System.IO;
using System;

namespace Util
{
    /// <summary>
    /// ���ڻ�ȡ������Web.config/*.exe.config�нڵ����ݵĸ�����
    /// </summary>
    public sealed class AppConfig
    {
        private string filePath;

        private static AppConfig instance;
        public static AppConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppConfig();
                }
                return instance;
            }
        }
        /// <summary>
        /// �ӵ�ǰĿ¼�а�˳�����Web.Config��*.App.Config�ļ���
        /// ����ҵ�һ������ʹ������Ϊ�����ļ���������׳�һ��ArgumentNullException�쳣��
        /// </summary>
        public AppConfig()
        {
            string webconfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Web.Config");
            string appConfig = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile.Replace(".vshost", "");

            if (File.Exists(webconfig))
            {
                filePath = webconfig;
            }
            else if (File.Exists(appConfig))
            {
                filePath = appConfig;
            }
            else
            {
                throw new ArgumentNullException("û���ҵ�Web.Config�ļ�����Ӧ�ó��������ļ�, ��ָ�������ļ�");
            }
        }

        /// <summary>
        /// �û�ָ������������ļ�·��
        /// </summary>
        /// <param name="configFilePath">�����ļ�·��������·����</param>
        public AppConfig(string configFilePath)
        {
            filePath = configFilePath;
        }

        /// <summary>
        /// ���ó����config�ļ�
        /// </summary>
        /// <param name="keyName">����</param>
        /// <param name="keyValue">��ֵ</param>
        public void AppConfigSet(string keyName, string keyValue)
        {
            //���ڴ��ڶ��Add��ֵ��ʹ�÷���appSetting�Ĳ������ɹ�����ע��������䣬�����µķ�ʽ
            /* 
            string xpath = "//add[@key='" + keyName + "']";
            XmlDocument document = new XmlDocument();
            document.Load(filePath);

            XmlNode node = document.SelectSingleNode(xpath);
            node.Attributes["value"].Value = keyValue;
            document.Save(filePath); 
             */

            XmlDocument document = new XmlDocument();
            document.Load(filePath);

            XmlNodeList nodes = document.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //��ý���ǰԪ�ص�key����
                XmlAttribute attribute = nodes[i].Attributes["key"];
                //����Ԫ�صĵ�һ���������жϵ�ǰ��Ԫ���ǲ���Ŀ��Ԫ��
                if (attribute != null && (attribute.Value == keyName))
                {
                    attribute = nodes[i].Attributes["value"];
                    //��Ŀ��Ԫ���еĵڶ������Ը�ֵ
                    if (attribute != null)
                    {
                        attribute.Value = keyValue;
                        break;
                    }
                }
            }
            document.Save(filePath);
        }

        /// <summary>
        /// ��ȡ�����config�ļ��ļ�ֵ��
        /// ������������ڣ����ؿ�
        /// </summary>
        /// <param name="keyName">����</param>
        /// <returns></returns>
        public string AppConfigGet(string keyName)
        {
            string strReturn = string.Empty;
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(filePath);

                XmlNodeList nodes = document.GetElementsByTagName("add");
                for (int i = 0; i < nodes.Count; i++)
                {
                    //��ý���ǰԪ�ص�key����
                    XmlAttribute attribute = nodes[i].Attributes["key"];
                    //����Ԫ�صĵ�һ���������жϵ�ǰ��Ԫ���ǲ���Ŀ��Ԫ��
                    if (attribute != null && (attribute.Value == keyName))
                    {
                        attribute = nodes[i].Attributes["value"];
                        if (attribute != null)
                        {
                            strReturn = attribute.Value;
                            break;
                        }
                    }
                }
            }
            catch
            {
                ;
            }

            return strReturn;
        }

        /// <summary>
        /// ��ȡָ�������е������ֵ
        /// </summary>
        /// <param name="keyName">����</param>
        /// <param name="subKeyName">�Էֺ�(;)Ϊ�ָ�������������</param>
        /// <returns>��Ӧ�������Ƶ�ֵ������=�ź����ֵ��</returns>
        public string GetSubValue(string keyName, string subKeyName)
        {
            string connectionString = AppConfigGet(keyName).ToLower();
            string[] item = connectionString.Split(new char[] { ';' });

            for (int i = 0; i < item.Length; i++)
            {
                string itemValue = item[i].ToLower();
                if (itemValue.IndexOf(subKeyName.ToLower()) >= 0) //�������ָ���Ĺؼ���
                {
                    int startIndex = item[i].IndexOf("="); //�Ⱥſ�ʼ��λ��
                    return item[i].Substring(startIndex + 1); //��ȡ�Ⱥź����ֵ��ΪValue
                }
            }
            return string.Empty;
        }

        #region һЩ���õ�����������

        /// <summary>
        /// �������ļ���ȡȨ��ϵͳ���ӣ�������HWSecurity��ֵ��
        /// </summary>
        public string HWSecurity
        {
            get
            {
                return AppConfigGet("HWSecurity");
            }
        }

        /// <summary>
        /// ϵͳ�ı�ʶID��������System_ID��ֵ��
        /// </summary>
        public string System_ID
        {
            get
            {
                return AppConfigGet("System_ID");
            }
        }

        /// <summary>
        /// Ӧ�ó������ƣ�������ApplicationName��ֵ��
        /// </summary>
        public string AppName
        {
            get
            {
                return AppConfigGet("ApplicationName");
            }
        }

        /// <summary>
        /// ����������ƣ�������Manufacturer��ֵ��
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return AppConfigGet("Manufacturer");
            }
        }

        /// <summary>
        /// ���ó����config�ļ���Enterprise Library�����ݿ����ӵ�ַ
        /// </summary>
        /// <param name="filePath">Web.config����*.exe.config�ļ��ľ���·��</param>
        /// <param name="keyName">����</param>
        /// <param name="keyValue">��ֵ</param>
        public void SetConnectionString(string keyName, string keyValue)
        {
            XmlDocument document = new XmlDocument();
            document.Load(filePath);

            XmlNodeList nodes = document.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //��ý���ǰԪ�ص�name����
                XmlAttribute att = nodes[i].Attributes["name"];
                //����Ԫ�صĵ�һ���������жϵ�ǰ��Ԫ���ǲ���Ŀ��Ԫ��
                if (att != null && (att.Value == keyName))
                {
                    att = nodes[i].Attributes["connectionString"];
                    if (att != null)
                    {
                        att.Value = keyValue;
                        break;
                    }
                }
            }
            document.Save(filePath);
        }

        /// <summary>
        /// ��ȡ�����config�ļ�Enterprise Library�����ݿ����ӵ�ַ
        /// </summary>
        /// <param name="filePath">Web.config����*.exe.config�ļ��ľ���·��</param>
        /// <param name="keyName">����</param>
        /// <returns></returns>
        public string GetConnectionString(string keyName)
        {
            string strReturn = string.Empty;
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(filePath);

                XmlNodeList nodes = document.GetElementsByTagName("add");
                for (int i = 0; i < nodes.Count; i++)
                {
                    //��ý���ǰԪ�ص�key����
                    XmlAttribute att = nodes[i].Attributes["name"];
                    //����Ԫ�صĵ�һ���������жϵ�ǰ��Ԫ���ǲ���Ŀ��Ԫ��
                    if (att != null && (att.Value == keyName))
                    {
                        att = nodes[i].Attributes["connectionString"];
                        if (att != null)
                        {
                            strReturn = att.Value;
                            break;
                        }
                    }
                }
            }
            catch
            { ; }

            return strReturn;
        }

        /// <summary>
        /// ��ȡ���ݿ�������Ϣ
        /// </summary>
        /// <param name="keyName">�ڵ�����</param>
        /// <returns></returns>
        public DatabaseInfo GetDatabaseInfo(string keyName)
        {
            string connectionString = GetConnectionString(keyName);
            return new DatabaseInfo(connectionString);
        }

        /// <summary>
        /// �������ݿ�������Ϣ
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="databaseInfo"></param>
        public void SetDatabaseInfo(string keyName, DatabaseInfo databaseInfo)
        {
            SetConnectionString(keyName, databaseInfo.ConnectionString);
        }

        #endregion
    }

}