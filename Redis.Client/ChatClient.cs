using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Redis.Client
{
    public partial class ChatClient : Form
    {
        public ChatClient()
        {
            InitializeComponent();

            txtNickname.Text = Environment.UserName;
        }

        private void txtChatInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendChatMessage();
                //prevent new line from Enter
                e.Handled = true;
            }
        }


        private void btnConnectToChat_Click(object sender, EventArgs e)
        {
            Start.redis.GetSubscriber().Subscribe("chat_" + txtChannelName.Text, ChatMessageHandler);
            btnConnectToChat.Enabled = false;
            SendChatMessage("hat den Chat betreten");
        }

        private void ChatMessageHandler(RedisChannel arg1, RedisValue arg2)
        {
            ChatMessage chatMessageControl;
            Classes.ChatMessage currentChatMessage = JsonConvert.DeserializeObject<Classes.ChatMessage>(arg2);

            //check if last message is from this sender
            if (ChatMessageContainer.Controls.Count != 0)
            {
                chatMessageControl = (ChatMessage)ChatMessageContainer.Controls[ChatMessageContainer.Controls.Count - 1];

                if (chatMessageControl.Nickname == currentChatMessage.Nickname)
                {
                    //message came from the same person
                    chatMessageControl.BeginInvoke((MethodInvoker)delegate ()
                    {
                        chatMessageControl.Message += Environment.NewLine + "[" + DateTime.Now.ToLongTimeString() + "] " + currentChatMessage.Message;
                    });
                }
                else
                {
                    chatMessageControl = new ChatMessage();
                    chatMessageControl.Nickname = currentChatMessage.Nickname;
                    chatMessageControl.Message = "[" + DateTime.Now.ToLongTimeString() + "] " + currentChatMessage.Message;
                }

            }
            else
            {
                chatMessageControl = new ChatMessage();
                chatMessageControl.Nickname = currentChatMessage.Nickname;
                chatMessageControl.Message = "[" + DateTime.Now.ToLongTimeString() + "] " + currentChatMessage.Message;
            }


            chatMessageControl.Width = ChatMessageContainer.Width - 30;

            ChatMessageContainer.BeginInvoke((MethodInvoker)delegate ()
            {
                ChatMessageContainer.Controls.Add(chatMessageControl);
                ChatMessageContainer.AutoScrollPosition = new Point(
                    chatMessageControl.Right - ChatMessageContainer.AutoScrollPosition.X,
                    chatMessageControl.Bottom - ChatMessageContainer.AutoScrollPosition.Y);
                chatMessageControl.Invalidate(true);
            });

            ChatMessageContainer.Invalidate();

        }

        private void btnSendToChat_Click(object sender, EventArgs e)
        {
            SendChatMessage();
        }

        private void SendChatMessage()
        {
            SendChatMessage(txtChatInput.Text);
            txtChatInput.Clear();
        }

        private void SendChatMessage(string message)
        {
            Classes.ChatMessage chatMessage = new Classes.ChatMessage(message, txtNickname.Text);
            Start.redis.GetSubscriber().Publish("chat_" + txtChannelName.Text, JsonConvert.SerializeObject(chatMessage));
        }

    }
}
