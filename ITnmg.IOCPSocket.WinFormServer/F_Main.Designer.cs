﻿namespace ITnmg.IOCPSocket.WinFormServer
{
	partial class F_Main
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_MaxConnection = new System.Windows.Forms.TextBox();
			this.bt_Start = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_DomainOrIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Port = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bt_Stop = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cob_FirsIPType = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.bt_Init = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tb_Console = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_MaxConnection
			// 
			this.tb_MaxConnection.Location = new System.Drawing.Point(724, 18);
			this.tb_MaxConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_MaxConnection.Name = "tb_MaxConnection";
			this.tb_MaxConnection.Size = new System.Drawing.Size(56, 27);
			this.tb_MaxConnection.TabIndex = 3;
			this.tb_MaxConnection.Text = "10000";
			// 
			// bt_Start
			// 
			this.bt_Start.Location = new System.Drawing.Point(903, 16);
			this.bt_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bt_Start.Name = "bt_Start";
			this.bt_Start.Size = new System.Drawing.Size(84, 31);
			this.bt_Start.TabIndex = 100;
			this.bt_Start.Text = "Start";
			this.bt_Start.UseVisualStyleBackColor = true;
			this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Domain Or IP:";
			// 
			// tb_DomainOrIP
			// 
			this.tb_DomainOrIP.Location = new System.Drawing.Point(122, 18);
			this.tb_DomainOrIP.Name = "tb_DomainOrIP";
			this.tb_DomainOrIP.Size = new System.Drawing.Size(119, 27);
			this.tb_DomainOrIP.TabIndex = 1;
			this.tb_DomainOrIP.Text = "localhost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(267, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Port:";
			// 
			// tb_Port
			// 
			this.tb_Port.Location = new System.Drawing.Point(314, 18);
			this.tb_Port.Name = "tb_Port";
			this.tb_Port.Size = new System.Drawing.Size(56, 27);
			this.tb_Port.TabIndex = 2;
			this.tb_Port.Text = "9000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(588, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Max Connection:";
			// 
			// bt_Stop
			// 
			this.bt_Stop.Location = new System.Drawing.Point(1007, 16);
			this.bt_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bt_Stop.Name = "bt_Stop";
			this.bt_Stop.Size = new System.Drawing.Size(84, 31);
			this.bt_Stop.TabIndex = 101;
			this.bt_Stop.Text = "Stop";
			this.bt_Stop.UseVisualStyleBackColor = true;
			this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(402, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 20);
			this.label4.TabIndex = 102;
			this.label4.Text = "First IP Type:";
			// 
			// cob_FirsIPType
			// 
			this.cob_FirsIPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_FirsIPType.FormattingEnabled = true;
			this.cob_FirsIPType.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
			this.cob_FirsIPType.Location = new System.Drawing.Point(507, 17);
			this.cob_FirsIPType.Name = "cob_FirsIPType";
			this.cob_FirsIPType.Size = new System.Drawing.Size(56, 28);
			this.cob_FirsIPType.TabIndex = 103;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 27);
			this.textBox1.TabIndex = 104;
			// 
			// bt_Init
			// 
			this.bt_Init.Location = new System.Drawing.Point(799, 16);
			this.bt_Init.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bt_Init.Name = "bt_Init";
			this.bt_Init.Size = new System.Drawing.Size(84, 31);
			this.bt_Init.TabIndex = 105;
			this.bt_Init.Text = "Init";
			this.bt_Init.UseVisualStyleBackColor = true;
			this.bt_Init.Click += new System.EventHandler(this.bt_Init_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tb_DomainOrIP);
			this.panel1.Controls.Add(this.bt_Init);
			this.panel1.Controls.Add(this.tb_MaxConnection);
			this.panel1.Controls.Add(this.bt_Start);
			this.panel1.Controls.Add(this.cob_FirsIPType);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.bt_Stop);
			this.panel1.Controls.Add(this.tb_Port);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1182, 67);
			this.panel1.TabIndex = 106;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(0, 67);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.textBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tb_Console);
			this.splitContainer1.Size = new System.Drawing.Size(1182, 566);
			this.splitContainer1.SplitterDistance = 360;
			this.splitContainer1.TabIndex = 107;
			// 
			// tb_Console
			// 
			this.tb_Console.BackColor = System.Drawing.Color.Black;
			this.tb_Console.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Console.ForeColor = System.Drawing.Color.White;
			this.tb_Console.Location = new System.Drawing.Point(0, 0);
			this.tb_Console.Multiline = true;
			this.tb_Console.Name = "tb_Console";
			this.tb_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_Console.Size = new System.Drawing.Size(1182, 202);
			this.tb_Console.TabIndex = 0;
			// 
			// F_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 633);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "F_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Socket Server";
			this.Load += new System.EventHandler(this.F_Main_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tb_MaxConnection;
		private System.Windows.Forms.Button bt_Start;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_DomainOrIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_Port;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bt_Stop;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cob_FirsIPType;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button bt_Init;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox tb_Console;
	}
}

