namespace SharpSocket.TalkFree.Server
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_HostIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_HostPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_LocalHostIP = new System.Windows.Forms.ListBox();
            this.btnRndHostPort = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listClient = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxEventLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNetIP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_HostIP
            // 
            this.textBox_HostIP.Location = new System.Drawing.Point(56, 155);
            this.textBox_HostIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_HostIP.Name = "textBox_HostIP";
            this.textBox_HostIP.ReadOnly = true;
            this.textBox_HostIP.Size = new System.Drawing.Size(152, 26);
            this.textBox_HostIP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口";
            // 
            // textBox_HostPort
            // 
            this.textBox_HostPort.Location = new System.Drawing.Point(72, 202);
            this.textBox_HostPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_HostPort.Name = "textBox_HostPort";
            this.textBox_HostPort.ReadOnly = true;
            this.textBox_HostPort.Size = new System.Drawing.Size(73, 26);
            this.textBox_HostPort.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNetIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox_LocalHostIP);
            this.groupBox1.Controls.Add(this.btnStopServer);
            this.groupBox1.Controls.Add(this.btnStartServer);
            this.groupBox1.Controls.Add(this.btnRndHostPort);
            this.groupBox1.Controls.Add(this.textBox_HostIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_HostPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主机配置";
            // 
            // listBox_LocalHostIP
            // 
            this.listBox_LocalHostIP.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox_LocalHostIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_LocalHostIP.FormattingEnabled = true;
            this.listBox_LocalHostIP.ItemHeight = 16;
            this.listBox_LocalHostIP.Location = new System.Drawing.Point(24, 51);
            this.listBox_LocalHostIP.Name = "listBox_LocalHostIP";
            this.listBox_LocalHostIP.Size = new System.Drawing.Size(255, 82);
            this.listBox_LocalHostIP.TabIndex = 0;
            this.listBox_LocalHostIP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_LocalHostIP_MouseDoubleClick);
            // 
            // btnRndHostPort
            // 
            this.btnRndHostPort.Location = new System.Drawing.Point(180, 205);
            this.btnRndHostPort.Name = "btnRndHostPort";
            this.btnRndHostPort.Size = new System.Drawing.Size(99, 26);
            this.btnRndHostPort.TabIndex = 4;
            this.btnRndHostPort.Text = "随机端口号";
            this.btnRndHostPort.UseVisualStyleBackColor = true;
            this.btnRndHostPort.Click += new System.EventHandler(this.btnRndHostPort_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(28, 258);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(117, 31);
            this.btnStartServer.TabIndex = 5;
            this.btnStartServer.Text = "启动服务器";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(164, 258);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(117, 31);
            this.btnStopServer.TabIndex = 6;
            this.btnStopServer.Text = "关闭服务器";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listClient);
            this.groupBox2.Location = new System.Drawing.Point(326, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 304);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户端列表";
            // 
            // listClient
            // 
            this.listClient.BackColor = System.Drawing.Color.Azure;
            this.listClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listClient.Location = new System.Drawing.Point(7, 26);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(278, 263);
            this.listClient.TabIndex = 0;
            this.listClient.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxEventLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 250);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "事件日志";
            // 
            // richTextBoxEventLog
            // 
            this.richTextBoxEventLog.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxEventLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxEventLog.Location = new System.Drawing.Point(18, 25);
            this.richTextBoxEventLog.Name = "richTextBoxEventLog";
            this.richTextBoxEventLog.Size = new System.Drawing.Size(581, 213);
            this.richTextBoxEventLog.TabIndex = 0;
            this.richTextBoxEventLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "局域网IP(可能包含虚拟网卡)";
            // 
            // btnNetIP
            // 
            this.btnNetIP.Location = new System.Drawing.Point(226, 155);
            this.btnNetIP.Name = "btnNetIP";
            this.btnNetIP.Size = new System.Drawing.Size(55, 26);
            this.btnNetIP.TabIndex = 9;
            this.btnNetIP.Text = "外网";
            this.btnNetIP.UseVisualStyleBackColor = true;
            this.btnNetIP.Click += new System.EventHandler(this.btnNetIP_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 584);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "TalkFree(LF)聊天服务器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_HostIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_HostPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRndHostPort;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxEventLog;
        private System.Windows.Forms.ListBox listBox_LocalHostIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNetIP;
    }
}

