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
    public class Program
    {
        static int port = 2000;
        static IPAddress ip = IPAddress.Parse("127.0.0.1");
        static TcpListener server = new TcpListener(ip, port);
        static List<Thread> processes = new List<Thread>();
        static List<Client> Users;
        static int i = 1;
        public static string name { get; set; }

        static void Main(string[] args)
        {
            //start the TCPListener at ip="127.0.0.1" port=2000
            server.Start();
            Users = new List<Client>();
            Console.WriteLine("Server Listening...");
            while (true)
            {
                //Keep accepting new clients
                Client c = new Client(server.AcceptTcpClient());
                c.userName = name;
                Console.WriteLine(DateTime.Now + "\t Client Connected");
                //add clients to users
                Users.Add(c);
                //start a thread for each Client/user to read and write messages on network stream
                Thread th = new Thread(()=>ReadWriteMessages(c));
                th.Name = i.ToString();
                i++;
                processes.Add(th);
                th.Start();
            }
        }
        static void ReadWriteMessages(Client c)
        {
            bool run = true;
            while(run)
            {
                //read messages sent by the clients
                byte[] receivedBuffer = new byte[1024];
                NetworkStream ns = c.tcp.GetStream();
                ns.Read(receivedBuffer, 0, receivedBuffer.Length);
                string msg = DateTime.Now + "\t" + Encoding.ASCII.GetString(receivedBuffer, 0, receivedBuffer.Length);
                
                if(msg!=null)
                {
                    //if the message is about ending the connection, complete the thread execution by leaving the endless while loop and write a message about user disconnected.
                    if (msg.Contains("EndClientConnection"))
                    {
                        run = false;
                        msg = msg.Remove(msg.IndexOf(" EndClientConnection"));
                        Console.WriteLine($"{msg} disconnected");
                        msg = msg + " has left the chat";
                    }
                    //forward all the received messages to all users(broadcast all messages)
                    forwardMessage(msg);
                    
                }
            }
        }
        static void forwardMessage(string str)
        {
            //Broadcast messahes to all users/TcpClients.
            Byte[] data = new Byte[256];
            str ="\n"+ str;
            data = Encoding.ASCII.GetBytes(str);

            for (int i = 0; i < Users.Count; i++)
            {
                try
                {
                    NetworkStream fs = Users[i].tcp.GetStream();
                    fs.Write(data, 0, data.Length);
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
