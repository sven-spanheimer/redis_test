using System.Windows.Forms;

namespace Redis.Client
{
    public partial class ChatMessage : UserControl
    {
        public ChatMessage()
        {
            InitializeComponent();
        }


        public string Nickname
        {
            get { return lblNickname.Text; }
            set { lblNickname.Text = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }


    }
}
