namespace Redis.Client
{
    partial class TestTool
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
            this.lblHeader = new DarkUI.Controls.DarkLabel();
            this.chatMessages = new DarkUI.Controls.DarkListView();
            this.btnPing = new DarkUI.Controls.DarkButton();
            this.btnTestExpire = new DarkUI.Controls.DarkButton();
            this.btnSendChat = new DarkUI.Controls.DarkButton();
            this.btnTestLoad = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblHeader.Location = new System.Drawing.Point(15, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 32);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Redis Test-Tool";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chatMessages
            // 
            this.chatMessages.Location = new System.Drawing.Point(381, 75);
            this.chatMessages.Name = "chatMessages";
            this.chatMessages.Size = new System.Drawing.Size(319, 263);
            this.chatMessages.TabIndex = 6;
            this.chatMessages.Text = "darkListView1";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(23, 90);
            this.btnPing.Name = "btnPing";
            this.btnPing.Padding = new System.Windows.Forms.Padding(5);
            this.btnPing.Size = new System.Drawing.Size(228, 30);
            this.btnPing.TabIndex = 7;
            this.btnPing.Text = "PING";
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnTestExpire
            // 
            this.btnTestExpire.Location = new System.Drawing.Point(23, 126);
            this.btnTestExpire.Name = "btnTestExpire";
            this.btnTestExpire.Padding = new System.Windows.Forms.Padding(5);
            this.btnTestExpire.Size = new System.Drawing.Size(228, 30);
            this.btnTestExpire.TabIndex = 8;
            this.btnTestExpire.Text = "Test Exprie";
            this.btnTestExpire.Click += new System.EventHandler(this.btnTestExpire_Click);
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(23, 162);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Padding = new System.Windows.Forms.Padding(5);
            this.btnSendChat.Size = new System.Drawing.Size(228, 30);
            this.btnSendChat.TabIndex = 9;
            this.btnSendChat.Text = "Send Chat";
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnTestLoad
            // 
            this.btnTestLoad.Location = new System.Drawing.Point(23, 198);
            this.btnTestLoad.Name = "btnTestLoad";
            this.btnTestLoad.Padding = new System.Windows.Forms.Padding(5);
            this.btnTestLoad.Size = new System.Drawing.Size(228, 30);
            this.btnTestLoad.TabIndex = 10;
            this.btnTestLoad.Text = "Send 10000 PINGs";
            this.btnTestLoad.Click += new System.EventHandler(this.btnTestLoad_Click);
            // 
            // TestTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(712, 350);
            this.Controls.Add(this.btnTestLoad);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.btnTestExpire);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.chatMessages);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "TestTool";
            this.Text = "TestTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel lblHeader;
        private DarkUI.Controls.DarkListView chatMessages;
        private DarkUI.Controls.DarkButton btnPing;
        private DarkUI.Controls.DarkButton btnTestExpire;
        private DarkUI.Controls.DarkButton btnSendChat;
        private DarkUI.Controls.DarkButton btnTestLoad;
    }
}