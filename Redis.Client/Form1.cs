using DarkUI.Forms;
using StackExchange.Redis;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Redis.Client
{
    public partial class Form1 : Form
    {

        public ConnectionMultiplexer redis;


        public Form1()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
        }

        private void btnStartConnection_Click(object sender, EventArgs e)
        {
            btnStartConnection.Enabled = false;
            btnDisconnect.Enabled = false;

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
            }
            else
            {
                //Verbindung nicht aufgebaut
                btnStartConnection.Enabled = true;
                btnDisconnect.Enabled = false;
            }

        }

        private void AsyncConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                redis = ConnectionMultiplexer.Connect("localhost");
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
    }
}
