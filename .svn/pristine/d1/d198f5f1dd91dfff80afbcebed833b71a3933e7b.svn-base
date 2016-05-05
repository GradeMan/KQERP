using ESOP.Core;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOP.Server
{
    public class ESOPServer : AppServer<ESOPSession>
    {
        public ESOPServer()
            : base(new CommandLineReceiveFilterFactory(Encoding.UTF8, new BasicRequestInfoParser(":", ",")))
        {
        }

        protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
        {
            return base.Setup(rootConfig, config);
        }

        protected override void OnStarted()
        {
            base.OnStarted();
        }

        protected override void OnStopped()
        {
            var clients = this.GetSessions(a=>true).ToList();
            foreach (var client in clients)
            {
                DataProtocol protocol = new DataProtocol(2, "服务器断开");
                string pro = protocol.ToString();
                //ProtocolHelper helper = new ProtocolHelper(pro);

                //DataProtocol protocol2 = helper.GetProtocol();
                client.Send(pro);
            }
            base.OnStopped();
        }
    }
}
