using StackExchange.Redis;
using System;
using System.Windows.Forms;

namespace Redis.Client
{
    public partial class ChatClient : Form
    {
        public ChatClient()
        {
            InitializeComponent();

            txtNickname.Text = Environment.UserName;
            settingsSelectionPanel.SectionHeader = "Verbindungseinstellungen";
            chatWindow.SectionHeader = "Chat";
        }

        private void txtChatInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendChatMessage();
                txtChatInput.Clear();
                //prevent new line from Enter
                e.Handled = true;
            }
        }


        private void btnConnectToChat_Click(object sender, EventArgs e)
        {
            Start.redis.GetSubscriber().Subscribe("chat_" + txtChannelName.Text, ChatMessageHandler);
        }

        private void ChatMessageHandler(RedisChannel arg1, RedisValue arg2)
        {
            ChatMessage chatMessageControl = new ChatMessage();
            chatMessageControl.Nickname = "Test";
            chatMessageControl.Message = arg2;
            chatMessageControl.Width = ChatMessageContainer.Width - 30;
            //chatMessageControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            ChatMessageContainer.BeginInvoke((MethodInvoker)delegate ()
            {
                ChatMessageContainer.Controls.Add(chatMessageControl);
                ChatMessageContainer.ScrollControlIntoView(chatMessageControl);
            });

        }

        private void btnSendToChat_Click(object sender, EventArgs e)
        {
            SendChatMessage();
        }

        private void SendChatMessage()
        {
            Start.redis.GetSubscriber().Publish("chat_" + txtChannelName.Text, txtChatInput.Text);
        }
    }
}
