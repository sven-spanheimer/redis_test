namespace Redis.Client
{
    partial class Start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartConnection = new DarkUI.Controls.DarkButton();
            this.lblHeader = new DarkUI.Controls.DarkLabel();
            this.CommandContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDisconnect = new DarkUI.Controls.DarkButton();
            this.btnServerStatus = new DarkUI.Controls.DarkButton();
            this.btnTestTool = new DarkUI.Controls.DarkButton();
            this.btnOpenChat = new DarkUI.Controls.DarkButton();
            this.btnEnd = new DarkUI.Controls.DarkButton();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.txtConnectionEndpoint = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CommandContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartConnection
            // 
            this.btnStartConnection.Location = new System.Drawing.Point(3, 3);
            this.btnStartConnection.Name = "btnStartConnection";
            this.btnStartConnection.Padding = new System.Windows.Forms.Padding(5);
            this.btnStartConnection.Size = new System.Drawing.Size(228, 30);
            this.btnStartConnection.TabIndex = 0;
            this.btnStartConnection.Text = "Verbindung herstellen";
            this.btnStartConnection.Click += new System.EventHandler(this.btnStartConnection_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblHeader.Location = new System.Drawing.Point(15, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(173, 32);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Redis Test-App";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommandContainer
            // 
            this.CommandContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommandContainer.AutoScroll = true;
            this.CommandContainer.Controls.Add(this.btnStartConnection);
            this.CommandContainer.Controls.Add(this.btnDisconnect);
            this.CommandContainer.Controls.Add(this.btnServerStatus);
            this.CommandContainer.Controls.Add(this.btnTestTool);
            this.CommandContainer.Controls.Add(this.btnOpenChat);
            this.CommandContainer.Controls.Add(this.btnEnd);
            this.CommandContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CommandContainer.Location = new System.Drawing.Point(21, 106);
            this.CommandContainer.Name = "CommandContainer";
            this.CommandContainer.Size = new System.Drawing.Size(262, 187);
            this.CommandContainer.TabIndex = 5;
            this.CommandContainer.WrapContents = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(3, 39);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Padding = new System.Windows.Forms.Padding(5);
            this.btnDisconnect.Size = new System.Drawing.Size(228, 30);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Verbindung trennen";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnServerStatus
            // 
            this.btnServerStatus.Location = new System.Drawing.Point(3, 75);
            this.btnServerStatus.Name = "btnServerStatus";
            this.btnServerStatus.Padding = new System.Windows.Forms.Padding(5);
            this.btnServerStatus.Size = new System.Drawing.Size(228, 30);
            this.btnServerStatus.TabIndex = 3;
            this.btnServerStatus.Text = "Server Status";
            this.btnServerStatus.Click += new System.EventHandler(this.btnServerStatus_Click);
            // 
            // btnTestTool
            // 
            this.btnTestTool.Location = new System.Drawing.Point(3, 111);
            this.btnTestTool.Name = "btnTestTool";
            this.btnTestTool.Padding = new System.Windows.Forms.Padding(5);
            this.btnTestTool.Size = new System.Drawing.Size(228, 30);
            this.btnTestTool.TabIndex = 4;
            this.btnTestTool.Text = "Test-Tool öffnen";
            this.btnTestTool.Click += new System.EventHandler(this.btnTestTool_Click);
            // 
            // btnOpenChat
            // 
            this.btnOpenChat.Location = new System.Drawing.Point(3, 147);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Padding = new System.Windows.Forms.Padding(5);
            this.btnOpenChat.Size = new System.Drawing.Size(228, 30);
            this.btnOpenChat.TabIndex = 5;
            this.btnOpenChat.Text = "Chat öffnen";
            this.btnOpenChat.Click += new System.EventHandler(this.btnOpenChat_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(3, 183);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Padding = new System.Windows.Forms.Padding(5);
            this.btnEnd.Size = new System.Drawing.Size(228, 30);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Beenden";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // darkLabel3
            // 
            this.darkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(21, 295);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(161, 13);
            this.darkLabel3.TabIndex = 7;
            this.darkLabel3.Text = "StackExchange.Redis Test-App";
            this.darkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConnectionEndpoint
            // 
            this.txtConnectionEndpoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtConnectionEndpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConnectionEndpoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtConnectionEndpoint.Location = new System.Drawing.Point(113, 68);
            this.txtConnectionEndpoint.Name = "txtConnectionEndpoint";
            this.txtConnectionEndpoint.Size = new System.Drawing.Size(139, 23);
            this.txtConnectionEndpoint.TabIndex = 8;
            this.txtConnectionEndpoint.Text = "192.168.234.136,192.168.234.138";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(21, 71);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(89, 15);
            this.darkLabel1.TabIndex = 9;
            this.darkLabel1.Text = "Redis Endpoint:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::Redis.Client.Properties.Resources.redis;
            this.pictureBox1.Location = new System.Drawing.Point(289, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(609, 317);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.txtConnectionEndpoint);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.CommandContainer);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redis Test-App";
            this.CommandContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton btnStartConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkLabel lblHeader;
        private System.Windows.Forms.FlowLayoutPanel CommandContainer;
        private DarkUI.Controls.DarkButton btnEnd;
        private DarkUI.Controls.DarkButton btnDisconnect;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkButton btnServerStatus;
        private DarkUI.Controls.DarkTextBox txtConnectionEndpoint;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkButton btnTestTool;
        private DarkUI.Controls.DarkButton btnOpenChat;
    }
}

