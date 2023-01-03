using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using ChatServer;

namespace ChatProgram
{
    public partial class ChatApp : Form
    {
        List<Client> clients;
        int count = 1;
        public ChatApp()
        {
            InitializeComponent();
            clients = new List<Client>();
            TextIP.Text = "127.0.0.1";
            TextPort.Text = "2000";
        }

        private async void btnJoinServer_Click(object sender, EventArgs e)
        {
            //if the inputs are incorrect, give proper message
            if(TextUsername.Text==""|| TextIP.Text == ""||TextPort.Text == "")
            {
                lblMessage.Text = "Incorrect Input";
            }
            else
            {
                //if the inputs are in correct format,
                //try connecting to the server
                try
                {
                    //if connection is successful, a new chat room is created for the client
                    Client c = new Client(new TcpClient());
                    c.threadName = count.ToString();
                    count++;
                    c.userName = TextUsername.Text;
                    ConnectToServer(c);
                    ChatRoom cr = new ChatRoom(c);
                    cr.Show();
                    TextUsername.Text = "";

                }
                catch (Exception ex)
                {
                    //in case of failed connection, the application is closed.
                    lblMessage.Text = ex.Message+"\tEXITING!";
                    await Task.Delay(2000);
                    Application.Exit();
                }
            }
        }

        private void ConnectToServer(Client client)
        {
            if (!client.tcp.Connected)
            {
                //if the client is not already connected, a connection to the server is made
                client.tcp.Connect(IPAddress.Parse(TextIP.Text), Convert.ToInt32(TextPort.Text));
                clients.Add(client);
            }
        }

    }
}
