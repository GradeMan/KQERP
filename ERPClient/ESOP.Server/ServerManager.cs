using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSocket.SocketEngine;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using ESOP.Entiy;
using ESOP.Core;
using ESOP.Model;
namespace ESOP.Server
{
    public partial class ServerManager : Form
    {
        List<Entiy.ClientEntity> clients = new List<Entiy.ClientEntity>();
        ESOPServer appServer;// = new ESOPServer();
        //private StringRequestInfo LastRequestInfo;//上一次缓存的记录;

        private Dictionary<string, StringRequestInfo> LastRequestInfo = new Dictionary<string, StringRequestInfo>();
        IBootstrap bootstrap;
        public ServerManager()
        {
            InitializeComponent();
            //this.txtMsg.Items.Add(string.Format("服务器已启动,开始监听本机{0}下的8181端口",IPAddress.Any));
        }

        void server_OnDisconnect(object sender, EventArgs e)
        {
            
            txtMsg.Invoke(new EventHandler(delegate
            {
                //txtMsg.Items.Add(string.Format("{0}断开连接...当前连接数：{1} ",));
                // txtMsg.Text += string.Format("{0}连接进来...当前连接数：{1} //r//n", client.RemoteEndPoint, server.AliveClients.Count);
            }));
        }

        private void ServerManager_Load(object sender, EventArgs e)
        {
            
            //var serverConfig = new ServerConfig
            //{
            //    Port = 2012,//set the listening port
            //    Ip = "192.168.10.159"
            //};
            bootstrap = BootstrapFactory.CreateBootstrap();
            if (!bootstrap.Initialize())
            {
                txtMsg.Items.Add("Failed to initialize!");
                //Console.ReadKey();
                return;
            }

            var result = bootstrap.Start();
            //TelnetServer sss = bootstrap.AppServers.First() as TelnetServer;
            //sss.NewSessionConnected += sss_NewSessionConnected;
            txtMsg.Items.Add(string.Format("Start result: {0}!", result));

            if (result == StartResult.Failed)
            {
                txtMsg.Items.Add("Failed to start!");
               // Console.ReadKey();
                return;
            }
            //if (!appServer.Setup(2012))
            //{
            //    txtMsg.Items.Add("Failed to setup!");
            //    return;
            //}
            appServer = bootstrap.AppServers.First() as ESOPServer;
            appServer.NewSessionConnected += new SessionHandler<ESOPSession>(appServer_NewSessionConnected);
            appServer.NewRequestReceived += new RequestHandler<ESOPSession, StringRequestInfo>(appServer_NewRequestReceived);
            appServer.SessionClosed += appServer_SessionClosed;

            //Try to start the appServer
            //if (!appServer.Start())
            //{
            //    txtMsg.Items.Add("Failed to start!");
            //    return;
            //}

            //txtMsg.Items.Add("The server started successfully");
            
        }

        void appServer_SessionClosed(ESOPSession session, SuperSocket.SocketBase.CloseReason value)
        {
            txtMsg.Invoke(new EventHandler(delegate
            {
                txtMsg.Items.Add(string.Format("用户{0}断开链接...当前连接数：{1} ", session.Name, appServer.SessionCount));
            }));
            var client = clients.Where(a => a.Name == session.Name).FirstOrDefault();
            if (client != null)
                clients.Remove(client);
           // LastRequestInfo.Remove(session.Name);
        }

        private void appServer_NewSessionConnected(ESOPSession session)
        {
           // session.Send("Welcome to SuperSocket Telnet Server");
        }
        private void appServer_NewRequestReceived(ESOPSession session, StringRequestInfo requestInfo)
        {
            switch (requestInfo.Key.ToUpper())
            {
                case ("ECHO"):
                    session.Send(requestInfo.Body);
                    break;
                case ("LOGIN"):
                    if (string.IsNullOrWhiteSpace(session.Name))
                    {
                        session.Name = requestInfo.Body.Trim();
                       // session.Send("OK");
                        DataProtocol protocol = new DataProtocol(0, session.Name+"登录成功");
                        string pro = protocol.ToString();
                        session.Send(pro);
                        ClientEntity client = new ClientEntity() { Name = session.Name, IP = session.RemoteEndPoint.Address.ToString() };
                        clients.Add(client);
                        txtMsg.Invoke(new EventHandler(delegate
                        {
                            txtMsg.Items.Add(string.Format("用户{0}登录...当前连接数：{1} ", session.Name, appServer.SessionCount));
                            dataGridView1.DataSource = clients;
                        }));
                        if (LastRequestInfo.ContainsKey(session.Name))
                        {
                            using (ESOPEntities entity = new ESOPEntities())
                            {
                                var devidData = LastRequestInfo[session.Name].Parameters.ToList();
                                var publishId = devidData[0];
                                var publishData = entity.tb_F_PublishTask.Where(a => a.Id == publishId).FirstOrDefault();
                                if (publishData == null)
                                    throw new ApplicationException(string.Format("任务{0}不存在", publishId));
                                var PartName = entity.tb_M_Product.Where(a => a.PartNo == publishData.PartNo).Select(a => a.ParName).FirstOrDefault() ?? "";
                                //var devidData = LastRequestInfo.Parameters.ToList();
                                var docName = publishData.DocId;
                                
                                var docData = entity.tb_F_Doc.Where(a => a.Id == docName).FirstOrDefault() ?? new tb_F_Doc();
                                var devData = entity.tb_S_Device.Where(a => a.DevId == session.Name).FirstOrDefault() ?? new tb_S_Device();
                                DataProtocol protocol2 = new DataProtocol(1, docName, docData.PageCount ?? 0, devData.State2, docData.DocName+","+PartName);
                                string pro2 = protocol2.ToString();
                                    //ProtocolHelper helper = new ProtocolHelper(pro);

                                    //DataProtocol protocol2 = helper.GetProtocol();
                                session.Send(pro2);
                                
                            }
                        }
                    }
                    break;
                case ("SEND")://从管理平台发送指令到客户端
                    //LastRequestInfo = requestInfo;
                    var devid2 = requestInfo.Parameters.ToList();//第一个参数为要显示的文档名称，后面跟着的参数为对应要发送的机台
                    using (ESOPEntities entity = new ESOPEntities())
                    {
                        var publishId = devid2[0];
                        var publishData = entity.tb_F_PublishTask.Where(a=>a.Id == publishId).FirstOrDefault();
                        if(publishData==null)
                            throw new ApplicationException(string.Format("任务{0}不存在",publishId));

                        //var docid =  devid2[0];
                        var docid = publishData.DocId;
                        var docData = entity.tb_F_Doc.Where(a => a.Id == docid).FirstOrDefault()?? new tb_F_Doc();
                        var PartName = entity.tb_M_Product.Where(a => a.PartNo == publishData.PartNo).Select(a => a.ParName).FirstOrDefault() ?? "";
                        //var PubLishData = entity.tb_F_PublishTask.Where(a=>a.Id==)
                        //var devIdData = entity.tb_S_Device.Where(a=>a.d)
                        for (int i = 1; i < devid2.Count; i++)
                        {
                            string name = devid2[i];
                            var devData = entity.tb_S_Device.Where(a => a.DevId == name).FirstOrDefault()??new tb_S_Device();
                            
                            var clients = appServer.GetSessions(a => a.Name == name).ToList();//.FirstOrDefault();
                            foreach (var client in clients)
                            {
                                if (client != null)
                                {
                                    if (LastRequestInfo.ContainsKey(name))
                                        LastRequestInfo[name] = requestInfo;
                                    else
                                        LastRequestInfo.Add(name, requestInfo);
                                    DataProtocol protocol = new DataProtocol(1, docid, docData.PageCount ?? 0, devData.State2, docData.DocName + "," + PartName);
                                    string pro = protocol.ToString();
                                    //ProtocolHelper helper = new ProtocolHelper(pro);

                                    //DataProtocol protocol2 = helper.GetProtocol();
                                    client.Send(pro);
                                }
                            }
                        }
                    }
                        break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bootstrap.Stop();
            txtMsg.Items.Add("Server Has Stop ");
            //var bootstrap = BootstrapFactory.CreateBootstrap();
            //if (!bootstrap.Initialize())
            //{
            //    txtMsg.Items.Add("Failed to initialize!");
            //    //Console.ReadKey();
            //    return;
            //}
            //bootstrap.Stop()
            var result = bootstrap.Start();
            //TelnetServer sss = bootstrap.AppServers.First() as TelnetServer;
            //sss.NewSessionConnected += sss_NewSessionConnected;
            txtMsg.Items.Add(string.Format("Start result: {0}!", result));

            if (result == StartResult.Failed)
            {
                txtMsg.Items.Add("Failed to start!");
                // Console.ReadKey();
                return;
            }
        }

        private void ServerManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            bootstrap.Stop();
        }
        /// <summary>
        /// 心跳包，每伍秒发送一次过去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeartTimer_Tick(object sender, EventArgs e)
        {

            try
            {
                var clients = this.appServer.GetSessions(a => true).ToList();
                foreach (var client in clients)
                {
                    DataProtocol protocol = new DataProtocol(2, "服务器断开");
                    string pro = protocol.ToString();
                    //ProtocolHelper helper = new ProtocolHelper(pro);

                    //DataProtocol protocol2 = helper.GetProtocol();
                    client.TrySend(pro);

                }
            }
            catch (Exception ef)
            {
                txtMsg.Items.Add(string.Format("错误报告: {0}!", ef.Message));
            }
        }

        //private  void Login(SocketAsync<DataEventExArgs> client, DataEventExArgs e)
        //{
           
        //    using (ESOPEntities entity = new ESOPEntities())
        //    {
        //        // 客户端发来的数据转换为字符串 
        //        // 对客户端而言服务接口是：Entity.Userinfo GetUserInfo(string username);
                
        //        string devId = e.Binary.ToEntity<string>();
        //        var employee = entity.tb_S_Device.Where(a => a.DevId == devId).Select(a => new { a.DevId, a.DevName }).FirstOrDefault();
        //        string Msg = "";
        //        string MsgBack = "";
        //        if (employee == null && devId!="ADMIN")
        //        {
        //            Msg = string.Format("{0}用户验证失败...当前连接数：{1} ", devId,server.AliveClients.Count);
        //            client.HasValidated = false;
        //            MsgBack = "登陆失败,用户验证失败";
        //        }
        //        else
        //        {
        //            if (devId == "ADMIN")
        //            {
        //                Msg = string.Format("用户{0}通过远程客户端{1}连接进来...当前连接数：{2} ", "ADMIN", client.RemoteEndPoint, server.AliveClients.Count);
        //                client.UserID = "ADMIN";
        //                client.UserToken = employee;
        //                client.HasValidated = true;
        //                MsgBack = "登陆成功";
        //            }
        //            else
        //            {
        //                Msg = string.Format("用户{0}通过远程客户端{1}连接进来...当前连接数：{2} ", employee.DevName, client.RemoteEndPoint, server.AliveClients.Count);
        //                client.UserID = employee.DevId;
        //                client.UserToken = employee;
        //                client.HasValidated = true;
        //                MsgBack = "登陆成功";
        //            }
        //        }

        //        txtMsg.Invoke(new EventHandler(delegate
        //        {
        //            txtMsg.Items.Add(Msg);
        //            // txtMsg.Text += string.Format("{0}连接进来...当前连接数：{1} //r//n", client.RemoteEndPoint, server.AliveClients.Count);
        //        }));

        //        byte[] buffer = Encoding.UTF8.GetBytes(MsgBack);
        //        e.Binary = new Binary(buffer);
        //        client.Send(e);
        //    }
        //}

        //private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        //{
          
        //}

    }
}
