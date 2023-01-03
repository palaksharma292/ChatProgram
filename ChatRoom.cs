using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ChatServer;

namespace ChatProgram
{
    public partial class ChatRoom : Form
    {
        Client c;
        Thread th;
        public ChatRoom(Client client)
        {
            //the client is initialized and a message about client joining the chat is sent to server for broadcast
            InitializeComponent();
            c = client;
            c.tcp = client.tcp;
            this.lblUser.Text = c.userName = client.userName;
            c.ns = c.tcp.GetStream();
            //a new thread is created and started to continuously monitor the network stream for any incoming messages from the server
            th = new Thread(ReadMessages);
            th.Start();
            string msg = c.userName + " has joined the chat";
            Byte[] data = Encoding.ASCII.GetBytes(msg);
            c.ns.Write(data, 0, data.Length);
        }

        private void ReadMessages()
        {
            Byte[] data = new Byte[256];
            String responseData = String.Empty;
            while (true)
            {
                int i;
                while((i=c.ns.Read(data,0,data.Length))!=0)
                {
                    //messages from the server are converted to string and added to message box
                    responseData = Encoding.ASCII.GetString(data, 0, i);
                    updateText(responseData);
                }
            }
        }
        public void updateText(string text)
        {
            //displaying message to message box
            if (Messages.InvokeRequired)
            {
                Action safeWrite = delegate { updateText($"{text} (th)"); };
                Messages.Invoke(safeWrite);
            }
            else
                Messages.Text += text;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //Sending message from message input box to the server
            if (TextSend.Text != "")
            {
                string msg = c.userName + ":  " + TextSend.Text;
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
                c.ns.Write(data, 0, data.Length);
            }
            TextSend.Text = "";
        }

        private void ChatRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when for is closed, appropriate message is sent to the server to close the connection.
            string msg = lblUser.Text + " " + "EndClientConnection";
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
            //the threads to read messages are closed
            th.Abort();
            c.ns = c.tcp.GetStream();
            c.ns.Write(data, 0, data.Length);
            c.ns.Close();
        }

        private void TextSend_KeyDown(object sender, KeyEventArgs e)
        {
            //Same and btnSend_Click is done when a user presses enter instead of clicking the send button.
            if(Keys.Enter==e.KeyCode)
            {
                if(TextSend.Text!="")
                {
                    string msg = c.userName + ":  " + TextSend.Text;
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
                    c.ns.Write(data, 0, data.Length);
                }
                TextSend.Text = "";
            }
        }
        
    }
}
