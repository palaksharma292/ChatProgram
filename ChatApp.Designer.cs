
namespace ChatProgram
{
    partial class ChatApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJoinServer = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.TextIP = new System.Windows.Forms.TextBox();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJoinServer
            // 
            this.btnJoinServer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJoinServer.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJoinServer.Location = new System.Drawing.Point(280, 418);
            this.btnJoinServer.Name = "btnJoinServer";
            this.btnJoinServer.Size = new System.Drawing.Size(304, 70);
            this.btnJoinServer.TabIndex = 1;
            this.btnJoinServer.Text = "Join Chat Server";
            this.btnJoinServer.UseVisualStyleBackColor = false;
            this.btnJoinServer.Click += new System.EventHandler(this.btnJoinServer_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(272, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(306, 45);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Server Information";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(262, 303);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(70, 38);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.Location = new System.Drawing.Point(176, 220);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(156, 38);
            this.lblIp.TabIndex = 4;
            this.lblIp.Text = "IP Address";
            // 
            // TextIP
            // 
            this.TextIP.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIP.Location = new System.Drawing.Point(360, 221);
            this.TextIP.Name = "TextIP";
            this.TextIP.Size = new System.Drawing.Size(310, 39);
            this.TextIP.TabIndex = 5;
            // 
            // TextPort
            // 
            this.TextPort.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPort.Location = new System.Drawing.Point(360, 304);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(310, 39);
            this.TextPort.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(73, 524);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 27);
            this.lblMessage.TabIndex = 7;
            // 
            // TextUsername
            // 
            this.TextUsername.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsername.Location = new System.Drawing.Point(360, 142);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(310, 39);
            this.TextUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(176, 141);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(146, 38);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 591);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.TextIP);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnJoinServer);
            this.Name = "ChatApp";
            this.Text = "Chatting Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnJoinServer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox TextIP;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.Label lblUsername;
    }
}

