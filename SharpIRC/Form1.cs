using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatSharp;

namespace SharpIRC
{
    public partial class SharpIRC : Form
    {

        public delegate void SetTextCallback(string text);
        public string msgUsername;
        public string msgText;
        public string msgSend;
        public bool sendReady;
        public string clientNick;

        public SharpIRC()
        {
            InitializeComponent();
        }

        private void SharpIRC_Load(object sender, EventArgs e)
        {

        }

        private void loginSubmit_Click(object sender, EventArgs q)
        {
            loginChannel.Hide();
            loginChannelLabel.Hide();
            loginNickname.Hide();
            loginNicknameLabel.Hide();
            loginServer.Hide();
            loginServerLabel.Hide();
            loginSubmit.Hide();
            loginUsername.Hide();
            loginUsernameLabel.Hide();

            ircChat.Show();
            ircMsg.Show();
            sendMsg.Show();

            this.backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            e.Result = ircClient(bw);
        }

        private void backgroundWorker1_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Operation was somehow cancelled.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // Operation was somehow completed.
                string msg = String.Format("Result = {0}", e.Result);
                MessageBox.Show(msg);
            }
        }

        public object ircClient(
            BackgroundWorker bw)
        {
            string connectServer = loginServer.Text;

            string connectChannel = "#" + loginChannel.Text;
            if (loginChannel.Text.StartsWith("#"))
                connectChannel = loginChannel.Text; // If input already contains a "#", set connectChannel back to input

            string connectNick = loginNickname.Text;

            string connectUser = loginUsername.Text;

            var client = new IrcClient(connectServer, new IrcUser(connectNick, connectUser));

            client.ConnectionComplete += (s, e) => client.JoinChannel(connectChannel);

            client.ChannelMessageRecieved += (s, e) =>
            {
                var channel = client.Channels[e.PrivateMessage.Source];

                msgUsername = e.PrivateMessage.User.Nick;
                msgText = e.PrivateMessage.Message;

                var msgUpdateThread =
                    new Thread(new ThreadStart(this.ircMsgUpdate));

                msgUpdateThread.Start();
            };

            client.ConnectAsync();

            while (true)
            {
                if (sendReady == true)
                {
                    sendReady = false;
                    client.Channels.FirstOrDefault().SendMessage(msgSend);

                    clientNick = loginNickname.Text;

                    var msgSentUpdaterThread =
                        new Thread(new ThreadStart(this.ircMsgSentUpdate));

                    msgSentUpdaterThread.Start();
                }
            }
        }

        private void ircMsgUpdate()
        {
            this.SetText(ircChat.Text + "<" + msgUsername + "> " + msgText + "\r\n");
        }

        private void ircMsgSentUpdate()
        {
            this.SetText(ircChat.Text + "<" + clientNick + "> " + msgSend + "\r\n");
        }

        private void SetText(string text)
        {
            if (this.ircChat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.ircChat.Text = text;
            }
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            msgSend = this.ircMsg.Text;
            this.ircMsg.Clear();
            sendReady = true;
        }
    }
}
