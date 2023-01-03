using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{
    public class Client
    {
        public TcpClient tcp { get; set; }
        public string userName { get; set; }
        public NetworkStream ns { get; set; }
        public Thread thread { get; set; }

        public Client(TcpClient t)
        {
            tcp = new TcpClient();
            tcp = t;
        }
    }
}
