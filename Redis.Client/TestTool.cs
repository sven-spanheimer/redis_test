using DarkUI.Forms;
using StackExchange.Redis;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Redis.Client
{
    public partial class TestTool : Form
    {
        public TestTool()
        {
            InitializeComponent();

            //please dont judge
            CheckForIllegalCrossThreadCalls = false;

            Start.redis.GetSubscriber().Subscribe("chat", ChatMessageHandler);

        }

        private void ChatMessageHandler(RedisChannel channel, RedisValue message)
        {
            chatMessages.Items.Add(new DarkUI.Controls.DarkListItem("[" + DateTime.Now.ToLongTimeString() + "] " + (string)message));

        }

        private void btnPing_Click(object sender, System.EventArgs e)
        {
            DarkMessageBox.ShowInformation("elapsed time: " + Start.redis.GetDatabase().Ping().ToString(), "PING");
        }

        private void btnTestExpire_Click(object sender, System.EventArgs e)
        {
            var db = Start.redis.GetDatabase();

            db.StringSet("KEY", "VALUE");
            db.KeyExpire("KEY", TimeSpan.FromSeconds(5));

            DarkMessageBox.ShowInformation(db.StringGet("KEY"), "Expire");
            DarkMessageBox.ShowInformation(db.KeyTimeToLive("KEY").ToString(), "TTL");
            DarkMessageBox.ShowInformation(db.StringGet("KEY"), "Expire");
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            Start.redis.GetSubscriber().Publish("chat", "test");
        }

        private void btnTestLoad_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            for (int i = 1; i < 10000; i++)
            {
                Start.redis.GetDatabase().Ping();
            }

            time.Stop();
            DarkMessageBox.ShowInformation(time.ElapsedMilliseconds.ToString() + "ms", "Result");
        }
    }
}
