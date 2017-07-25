using DarkUI.Forms;
using StackExchange.Redis;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Redis.Client
{
    public partial class Start : Form
    {

        public static ConnectionMultiplexer redis;


        public Start()
        {
            InitializeComponent();


            btnDisconnect.Enabled = false;
            btnServerStatus.Enabled = false;
            btnTestTool.Enabled = false;
        }

        private void btnStartConnection_Click(object sender, EventArgs e)
        {
            btnStartConnection.Enabled = false;
            btnDisconnect.Enabled = false;
            btnServerStatus.Enabled = false;
            btnTestTool.Enabled = false;

            BackgroundWorker asyncConnect = new BackgroundWorker();
            asyncConnect.DoWork += AsyncConnect_DoWork;
            asyncConnect.RunWorkerCompleted += AsyncConnect_RunWorkerCompleted;
            asyncConnect.RunWorkerAsync();
        }

        private void AsyncConnect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Neues Verbinden erlauben, wenn die Verbindung nicht hergestellt wurde

            if (redis != null && redis.IsConnected)
            {
                //Verbindung aufgebaut
                btnStartConnection.Enabled = false;
                btnDisconnect.Enabled = true;
                btnServerStatus.Enabled = true;
                btnTestTool.Enabled = true;

                //DarkMessageBox.ShowInformation("Verbindung wurde erfolgreich hergestellt.", Text, DarkDialogButton.Ok);
                btnServerStatus.Focus();
            }
            else
            {
                //Verbindung nicht aufgebaut
                btnStartConnection.Enabled = true;
                btnDisconnect.Enabled = false;
                btnServerStatus.Enabled = false;
                btnTestTool.Enabled = false;
            }

        }

        private void AsyncConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                redis = ConnectionMultiplexer.Connect(txtConnectionEndpoint.Text);
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError(ex.Message, "Fehler");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (redis == null || !redis.IsConnected) { throw new Exception("Verbindung ist nicht aufgebaut und kann daher nicht beendet werden!"); }
                redis.Close();
                btnStartConnection.Enabled = true;
                btnDisconnect.Enabled = false;
                btnServerStatus.Enabled = false;
                btnTestTool.Enabled = false;

                btnStartConnection.Focus();
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError(ex.Message, "Fehler");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnServerStatus_Click(object sender, EventArgs e)
        {
            DarkMessageBox.ShowInformation(redis.GetStatus(), Text, DarkDialogButton.Ok);
        }

        private void btnTestTool_Click(object sender, EventArgs e)
        {
            TestTool testTool = new TestTool();
            testTool.Show();
        }

        private void btnOpenChat_Click(object sender, EventArgs e)
        {
            ChatClient chatClient = new ChatClient();
            chatClient.Show();
        }
    }
}
