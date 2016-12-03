namespace SharpIRC
{
    partial class SharpIRC
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
            this.ircChat = new System.Windows.Forms.TextBox();
            this.ircMsg = new System.Windows.Forms.TextBox();
            this.sendMsg = new System.Windows.Forms.Button();
            this.loginServerLabel = new System.Windows.Forms.Label();
            this.loginChannelLabel = new System.Windows.Forms.Label();
            this.loginNicknameLabel = new System.Windows.Forms.Label();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginServer = new System.Windows.Forms.TextBox();
            this.loginChannel = new System.Windows.Forms.TextBox();
            this.loginNickname = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginSubmit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ircChat
            // 
            this.ircChat.Location = new System.Drawing.Point(12, 12);
            this.ircChat.MaxLength = 10000000;
            this.ircChat.Multiline = true;
            this.ircChat.Name = "ircChat";
            this.ircChat.ReadOnly = true;
            this.ircChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ircChat.Size = new System.Drawing.Size(757, 292);
            this.ircChat.TabIndex = 0;
            this.ircChat.Visible = false;
            // 
            // ircMsg
            // 
            this.ircMsg.Location = new System.Drawing.Point(12, 310);
            this.ircMsg.Name = "ircMsg";
            this.ircMsg.Size = new System.Drawing.Size(689, 20);
            this.ircMsg.TabIndex = 1;
            this.ircMsg.Visible = false;
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(707, 310);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(62, 20);
            this.sendMsg.TabIndex = 2;
            this.sendMsg.Text = "Send";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Visible = false;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // loginServerLabel
            // 
            this.loginServerLabel.AutoSize = true;
            this.loginServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginServerLabel.Location = new System.Drawing.Point(292, 53);
            this.loginServerLabel.Name = "loginServerLabel";
            this.loginServerLabel.Size = new System.Drawing.Size(54, 17);
            this.loginServerLabel.TabIndex = 3;
            this.loginServerLabel.Text = "Server:";
            // 
            // loginChannelLabel
            // 
            this.loginChannelLabel.AutoSize = true;
            this.loginChannelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginChannelLabel.Location = new System.Drawing.Point(282, 80);
            this.loginChannelLabel.Name = "loginChannelLabel";
            this.loginChannelLabel.Size = new System.Drawing.Size(64, 17);
            this.loginChannelLabel.TabIndex = 4;
            this.loginChannelLabel.Text = "Channel:";
            // 
            // loginNicknameLabel
            // 
            this.loginNicknameLabel.AutoSize = true;
            this.loginNicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNicknameLabel.Location = new System.Drawing.Point(272, 107);
            this.loginNicknameLabel.Name = "loginNicknameLabel";
            this.loginNicknameLabel.Size = new System.Drawing.Size(74, 17);
            this.loginNicknameLabel.TabIndex = 5;
            this.loginNicknameLabel.Text = "Nickname:";
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsernameLabel.Location = new System.Drawing.Point(269, 134);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.loginUsernameLabel.TabIndex = 6;
            this.loginUsernameLabel.Text = "Username:";
            // 
            // loginServer
            // 
            this.loginServer.Location = new System.Drawing.Point(352, 53);
            this.loginServer.Name = "loginServer";
            this.loginServer.Size = new System.Drawing.Size(100, 20);
            this.loginServer.TabIndex = 7;
            this.loginServer.Text = "irc.freenode.net";
            // 
            // loginChannel
            // 
            this.loginChannel.Location = new System.Drawing.Point(352, 80);
            this.loginChannel.Name = "loginChannel";
            this.loginChannel.Size = new System.Drawing.Size(100, 20);
            this.loginChannel.TabIndex = 8;
            this.loginChannel.Text = "#freenode";
            // 
            // loginNickname
            // 
            this.loginNickname.Location = new System.Drawing.Point(352, 107);
            this.loginNickname.Name = "loginNickname";
            this.loginNickname.Size = new System.Drawing.Size(100, 20);
            this.loginNickname.TabIndex = 9;
            this.loginNickname.Text = "SharpIRC";
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(352, 134);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(100, 20);
            this.loginUsername.TabIndex = 10;
            this.loginUsername.Text = "SharpIRC";
            // 
            // loginSubmit
            // 
            this.loginSubmit.Location = new System.Drawing.Point(317, 169);
            this.loginSubmit.Name = "loginSubmit";
            this.loginSubmit.Size = new System.Drawing.Size(101, 23);
            this.loginSubmit.TabIndex = 11;
            this.loginSubmit.Text = "Connect";
            this.loginSubmit.UseVisualStyleBackColor = true;
            this.loginSubmit.Click += new System.EventHandler(this.loginSubmit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // SharpIRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(781, 342);
            this.Controls.Add(this.loginSubmit);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.loginNickname);
            this.Controls.Add(this.loginChannel);
            this.Controls.Add(this.loginServer);
            this.Controls.Add(this.loginUsernameLabel);
            this.Controls.Add(this.loginNicknameLabel);
            this.Controls.Add(this.loginChannelLabel);
            this.Controls.Add(this.loginServerLabel);
            this.Controls.Add(this.sendMsg);
            this.Controls.Add(this.ircMsg);
            this.Controls.Add(this.ircChat);
            this.MaximizeBox = false;
            this.Name = "SharpIRC";
            this.Text = "SharpIRC";
            this.Load += new System.EventHandler(this.SharpIRC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ircChat;
        private System.Windows.Forms.TextBox ircMsg;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.Label loginServerLabel;
        private System.Windows.Forms.Label loginChannelLabel;
        private System.Windows.Forms.Label loginNicknameLabel;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.TextBox loginServer;
        private System.Windows.Forms.TextBox loginChannel;
        private System.Windows.Forms.TextBox loginNickname;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Button loginSubmit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

