﻿namespace SocketSenderServer
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "NightMode: Off",
            "100600"}, -1);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "NightMode: On",
            "100601"}, -1);
			this.OpenSocketButton = new System.Windows.Forms.Button();
			this.CloseSocketButton = new System.Windows.Forms.Button();
			this.ServerIpBox = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.PortNoBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.OutputLog = new System.Windows.Forms.ListBox();
			this.SendMsgButton = new System.Windows.Forms.Button();
			this.MsgBox = new System.Windows.Forms.TextBox();
			this.MessageList = new System.Windows.Forms.ListView();
			this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// OpenSocketButton
			// 
			this.OpenSocketButton.Location = new System.Drawing.Point(175, 6);
			this.OpenSocketButton.Name = "OpenSocketButton";
			this.OpenSocketButton.Size = new System.Drawing.Size(75, 46);
			this.OpenSocketButton.TabIndex = 0;
			this.OpenSocketButton.Text = "Start Server";
			this.OpenSocketButton.UseVisualStyleBackColor = true;
			this.OpenSocketButton.Click += new System.EventHandler(this.OpenSocketButton_Click);
			// 
			// CloseSocketButton
			// 
			this.CloseSocketButton.Enabled = false;
			this.CloseSocketButton.Location = new System.Drawing.Point(256, 6);
			this.CloseSocketButton.Name = "CloseSocketButton";
			this.CloseSocketButton.Size = new System.Drawing.Size(75, 46);
			this.CloseSocketButton.TabIndex = 1;
			this.CloseSocketButton.Text = "Stop Server";
			this.CloseSocketButton.UseVisualStyleBackColor = true;
			this.CloseSocketButton.Click += new System.EventHandler(this.CloseSocketButton_Click);
			// 
			// ServerIpBox
			// 
			this.ServerIpBox.Enabled = false;
			this.ServerIpBox.Location = new System.Drawing.Point(69, 6);
			this.ServerIpBox.Name = "ServerIpBox";
			this.ServerIpBox.Size = new System.Drawing.Size(100, 20);
			this.ServerIpBox.TabIndex = 2;
			this.ServerIpBox.TextChanged += new System.EventHandler(this.ServerIpBox_TextChanged);
			this.ServerIpBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerIpBox_KeyPress);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// PortNoBox
			// 
			this.PortNoBox.ContextMenuStrip = this.contextMenuStrip1;
			this.PortNoBox.Location = new System.Drawing.Point(69, 32);
			this.PortNoBox.Name = "PortNoBox";
			this.PortNoBox.Size = new System.Drawing.Size(100, 20);
			this.PortNoBox.TabIndex = 3;
			this.PortNoBox.TextChanged += new System.EventHandler(this.PortNoBox_TextChanged);
			this.PortNoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortNoBox_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Server IP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Port No.";
			// 
			// OutputLog
			// 
			this.OutputLog.FormattingEnabled = true;
			this.OutputLog.HorizontalScrollbar = true;
			this.OutputLog.Location = new System.Drawing.Point(12, 58);
			this.OutputLog.Name = "OutputLog";
			this.OutputLog.Size = new System.Drawing.Size(319, 212);
			this.OutputLog.TabIndex = 6;
			// 
			// SendMsgButton
			// 
			this.SendMsgButton.Enabled = false;
			this.SendMsgButton.Location = new System.Drawing.Point(12, 276);
			this.SendMsgButton.Name = "SendMsgButton";
			this.SendMsgButton.Size = new System.Drawing.Size(60, 23);
			this.SendMsgButton.TabIndex = 7;
			this.SendMsgButton.Text = "Send";
			this.SendMsgButton.UseVisualStyleBackColor = true;
			this.SendMsgButton.Click += new System.EventHandler(this.SendMsgButton_Click);
			// 
			// MsgBox
			// 
			this.MsgBox.ContextMenuStrip = this.contextMenuStrip1;
			this.MsgBox.Enabled = false;
			this.MsgBox.Location = new System.Drawing.Point(78, 278);
			this.MsgBox.Name = "MsgBox";
			this.MsgBox.Size = new System.Drawing.Size(253, 20);
			this.MsgBox.TabIndex = 8;
			this.MsgBox.TextChanged += new System.EventHandler(this.MsgBox_TextChanged);
			this.MsgBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MsgBox_KeyPress);
			// 
			// MessageList
			// 
			this.MessageList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.MessageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Data});
			this.MessageList.Enabled = false;
			this.MessageList.FullRowSelect = true;
			this.MessageList.GridLines = true;
			this.MessageList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			listViewItem3.Tag = "";
			listViewItem4.Tag = "";
			this.MessageList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
			this.MessageList.Location = new System.Drawing.Point(337, 6);
			this.MessageList.MultiSelect = false;
			this.MessageList.Name = "MessageList";
			this.MessageList.ShowGroups = false;
			this.MessageList.Size = new System.Drawing.Size(213, 292);
			this.MessageList.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.MessageList.TabIndex = 9;
			this.MessageList.UseCompatibleStateImageBehavior = false;
			this.MessageList.View = System.Windows.Forms.View.Details;
			this.MessageList.ItemActivate += new System.EventHandler(this.MessageList_ItemActivate);
			// 
			// Description
			// 
			this.Description.Text = "Description";
			this.Description.Width = 82;
			// 
			// Data
			// 
			this.Data.Text = "Data";
			this.Data.Width = 127;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 314);
			this.Controls.Add(this.MessageList);
			this.Controls.Add(this.MsgBox);
			this.Controls.Add(this.SendMsgButton);
			this.Controls.Add(this.OutputLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PortNoBox);
			this.Controls.Add(this.ServerIpBox);
			this.Controls.Add(this.CloseSocketButton);
			this.Controls.Add(this.OpenSocketButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Socket Sender - Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OpenSocketButton;
		private System.Windows.Forms.Button CloseSocketButton;
		private System.Windows.Forms.TextBox ServerIpBox;
		private System.Windows.Forms.TextBox PortNoBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox OutputLog;
		private System.Windows.Forms.Button SendMsgButton;
		private System.Windows.Forms.TextBox MsgBox;
		private System.Windows.Forms.ListView MessageList;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader Description;
		private System.Windows.Forms.ColumnHeader Data;
	}
}

