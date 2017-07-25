namespace Redis.Client
{
    partial class ChatClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatClient));
            this.lblHeader = new DarkUI.Controls.DarkLabel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.txtNickname = new DarkUI.Controls.DarkTextBox();
            this.txtChatInput = new DarkUI.Controls.DarkTextBox();
            this.btnSendToChat = new DarkUI.Controls.DarkButton();
            this.settingsSelectionPanel = new DarkUI.Controls.DarkSectionPanel();
            this.btnConnectToChat = new DarkUI.Controls.DarkButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.txtChannelName = new DarkUI.Controls.DarkTextBox();
            this.chatWindow = new DarkUI.Controls.DarkSectionPanel();
            this.ChatMessageContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsSelectionPanel.SuspendLayout();
            this.chatWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblHeader.Location = new System.Drawing.Point(15, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(199, 32);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Redis Chat-Client";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(8, 39);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(64, 15);
            this.darkLabel1.TabIndex = 7;
            this.darkLabel1.Text = "Nickname:";
            // 
            // txtNickname
            // 
            this.txtNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNickname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtNickname.Location = new System.Drawing.Point(80, 37);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(179, 23);
            this.txtNickname.TabIndex = 8;
            // 
            // txtChatInput
            // 
            this.txtChatInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChatInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtChatInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChatInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtChatInput.Location = new System.Drawing.Point(21, 412);
            this.txtChatInput.Multiline = true;
            this.txtChatInput.Name = "txtChatInput";
            this.txtChatInput.Size = new System.Drawing.Size(531, 37);
            this.txtChatInput.TabIndex = 10;
            this.txtChatInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChatInput_KeyPress);
            // 
            // btnSendToChat
            // 
            this.btnSendToChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToChat.Location = new System.Drawing.Point(558, 412);
            this.btnSendToChat.Name = "btnSendToChat";
            this.btnSendToChat.Padding = new System.Windows.Forms.Padding(5);
            this.btnSendToChat.Size = new System.Drawing.Size(114, 37);
            this.btnSendToChat.TabIndex = 11;
            this.btnSendToChat.Text = "Senden";
            this.btnSendToChat.Click += new System.EventHandler(this.btnSendToChat_Click);
            // 
            // settingsSelectionPanel
            // 
            this.settingsSelectionPanel.Controls.Add(this.btnConnectToChat);
            this.settingsSelectionPanel.Controls.Add(this.darkLabel2);
            this.settingsSelectionPanel.Controls.Add(this.txtChannelName);
            this.settingsSelectionPanel.Controls.Add(this.darkLabel1);
            this.settingsSelectionPanel.Controls.Add(this.txtNickname);
            this.settingsSelectionPanel.Location = new System.Drawing.Point(21, 53);
            this.settingsSelectionPanel.Name = "settingsSelectionPanel";
            this.settingsSelectionPanel.SectionHeader = "Verbindungseinstellungen";
            this.settingsSelectionPanel.Size = new System.Drawing.Size(473, 103);
            this.settingsSelectionPanel.TabIndex = 12;
            // 
            // btnConnectToChat
            // 
            this.btnConnectToChat.Location = new System.Drawing.Point(11, 69);
            this.btnConnectToChat.Name = "btnConnectToChat";
            this.btnConnectToChat.Padding = new System.Windows.Forms.Padding(5);
            this.btnConnectToChat.Size = new System.Drawing.Size(118, 23);
            this.btnConnectToChat.TabIndex = 14;
            this.btnConnectToChat.Text = "Verbinden";
            this.btnConnectToChat.Click += new System.EventHandler(this.btnConnectToChat_Click);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(269, 39);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(91, 15);
            this.darkLabel2.TabIndex = 9;
            this.darkLabel2.Text = "Channel-Name:";
            // 
            // txtChannelName
            // 
            this.txtChannelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtChannelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannelName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtChannelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtChannelName.Location = new System.Drawing.Point(366, 37);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(94, 23);
            this.txtChannelName.TabIndex = 10;
            this.txtChannelName.Text = "ch1";
            // 
            // chatWindow
            // 
            this.chatWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatWindow.Controls.Add(this.ChatMessageContainer);
            this.chatWindow.Location = new System.Drawing.Point(21, 169);
            this.chatWindow.Name = "chatWindow";
            this.chatWindow.SectionHeader = "Chat";
            this.chatWindow.Size = new System.Drawing.Size(651, 233);
            this.chatWindow.TabIndex = 13;
            // 
            // ChatMessageContainer
            // 
            this.ChatMessageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatMessageContainer.AutoScroll = true;
            this.ChatMessageContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChatMessageContainer.Location = new System.Drawing.Point(4, 28);
            this.ChatMessageContainer.Name = "ChatMessageContainer";
            this.ChatMessageContainer.Size = new System.Drawing.Size(643, 201);
            this.ChatMessageContainer.TabIndex = 0;
            this.ChatMessageContainer.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Redis.Client.Properties.Resources.redis;
            this.pictureBox1.Location = new System.Drawing.Point(500, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.chatWindow);
            this.Controls.Add(this.settingsSelectionPanel);
            this.Controls.Add(this.btnSendToChat);
            this.Controls.Add(this.txtChatInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ChatClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redis Chat-Client";
            this.settingsSelectionPanel.ResumeLayout(false);
            this.settingsSelectionPanel.PerformLayout();
            this.chatWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel lblHeader;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox txtNickname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkTextBox txtChatInput;
        private DarkUI.Controls.DarkButton btnSendToChat;
        private DarkUI.Controls.DarkSectionPanel settingsSelectionPanel;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkTextBox txtChannelName;
        private DarkUI.Controls.DarkSectionPanel chatWindow;
        private DarkUI.Controls.DarkButton btnConnectToChat;
        private System.Windows.Forms.FlowLayoutPanel ChatMessageContainer;
    }
}