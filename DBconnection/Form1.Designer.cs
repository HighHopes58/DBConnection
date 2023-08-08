namespace DBconnection
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mmNewConnection = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mmExit = new System.Windows.Forms.ToolStripMenuItem();
			this.labelPath = new System.Windows.Forms.Label();
			this.temp_groupBox1 = new System.Windows.Forms.GroupBox();
			this.label_Pass = new System.Windows.Forms.Label();
			this.label_User = new System.Windows.Forms.Label();
			this.label_DBname = new System.Windows.Forms.Label();
			this.label_Path = new System.Windows.Forms.Label();
			this.labelPass = new System.Windows.Forms.Label();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelDB_name = new System.Windows.Forms.Label();
			this.MainMenu.SuspendLayout();
			this.temp_groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(800, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "MainMenu";
			// 
			// mmFile
			// 
			this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmNewConnection,
            this.toolStripSeparator1,
            this.mmExit});
			this.mmFile.Name = "mmFile";
			this.mmFile.Size = new System.Drawing.Size(37, 20);
			this.mmFile.Text = "File";
			// 
			// mmNewConnection
			// 
			this.mmNewConnection.Name = "mmNewConnection";
			this.mmNewConnection.Size = new System.Drawing.Size(163, 22);
			this.mmNewConnection.Text = "New Connection";
			this.mmNewConnection.Click += new System.EventHandler(this.mmNewConnection_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
			// 
			// mmExit
			// 
			this.mmExit.Name = "mmExit";
			this.mmExit.Size = new System.Drawing.Size(163, 22);
			this.mmExit.Text = "Exit";
			this.mmExit.Click += new System.EventHandler(this.mmExit_Click);
			// 
			// labelPath
			// 
			this.labelPath.AutoSize = true;
			this.labelPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelPath.Location = new System.Drawing.Point(101, 28);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(14, 15);
			this.labelPath.TabIndex = 1;
			this.labelPath.Text = "1";
			// 
			// temp_groupBox1
			// 
			this.temp_groupBox1.Controls.Add(this.label_Pass);
			this.temp_groupBox1.Controls.Add(this.label_User);
			this.temp_groupBox1.Controls.Add(this.label_DBname);
			this.temp_groupBox1.Controls.Add(this.label_Path);
			this.temp_groupBox1.Controls.Add(this.labelPass);
			this.temp_groupBox1.Controls.Add(this.labelUser);
			this.temp_groupBox1.Controls.Add(this.labelDB_name);
			this.temp_groupBox1.Controls.Add(this.labelPath);
			this.temp_groupBox1.Location = new System.Drawing.Point(539, 290);
			this.temp_groupBox1.Name = "temp_groupBox1";
			this.temp_groupBox1.Size = new System.Drawing.Size(249, 148);
			this.temp_groupBox1.TabIndex = 2;
			this.temp_groupBox1.TabStop = false;
			this.temp_groupBox1.Text = "Connection Variables";
			// 
			// label_Pass
			// 
			this.label_Pass.AutoSize = true;
			this.label_Pass.Location = new System.Drawing.Point(8, 107);
			this.label_Pass.Name = "label_Pass";
			this.label_Pass.Size = new System.Drawing.Size(60, 15);
			this.label_Pass.TabIndex = 5;
			this.label_Pass.Text = "Password:";
			// 
			// label_User
			// 
			this.label_User.AutoSize = true;
			this.label_User.Location = new System.Drawing.Point(32, 81);
			this.label_User.Name = "label_User";
			this.label_User.Size = new System.Drawing.Size(33, 15);
			this.label_User.TabIndex = 4;
			this.label_User.Text = "User:";
			// 
			// label_DBname
			// 
			this.label_DBname.AutoSize = true;
			this.label_DBname.Location = new System.Drawing.Point(8, 54);
			this.label_DBname.Name = "label_DBname";
			this.label_DBname.Size = new System.Drawing.Size(58, 15);
			this.label_DBname.TabIndex = 3;
			this.label_DBname.Text = "Database:";
			// 
			// label_Path
			// 
			this.label_Path.AutoSize = true;
			this.label_Path.Location = new System.Drawing.Point(32, 28);
			this.label_Path.Name = "label_Path";
			this.label_Path.Size = new System.Drawing.Size(34, 15);
			this.label_Path.TabIndex = 2;
			this.label_Path.Text = "Path:";
			// 
			// labelPass
			// 
			this.labelPass.AutoSize = true;
			this.labelPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelPass.Location = new System.Drawing.Point(101, 107);
			this.labelPass.Name = "labelPass";
			this.labelPass.Size = new System.Drawing.Size(14, 15);
			this.labelPass.TabIndex = 1;
			this.labelPass.Text = "4";
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelUser.Location = new System.Drawing.Point(101, 81);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(14, 15);
			this.labelUser.TabIndex = 1;
			this.labelUser.Text = "3";
			// 
			// labelDB_name
			// 
			this.labelDB_name.AutoSize = true;
			this.labelDB_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelDB_name.Location = new System.Drawing.Point(101, 54);
			this.labelDB_name.Name = "labelDB_name";
			this.labelDB_name.Size = new System.Drawing.Size(14, 15);
			this.labelDB_name.TabIndex = 1;
			this.labelDB_name.Text = "2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.temp_groupBox1);
			this.Controls.Add(this.MainMenu);
			this.HelpButton = true;
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DB Connection for php site";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.temp_groupBox1.ResumeLayout(false);
			this.temp_groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem mmFile;
		private System.Windows.Forms.ToolStripMenuItem mmNewConnection;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mmExit;
		internal System.Windows.Forms.Label labelPath;
		private System.Windows.Forms.Label label_DBname;
		private System.Windows.Forms.Label label_Path;
		internal System.Windows.Forms.GroupBox temp_groupBox1;
		private System.Windows.Forms.Label label_Pass;
		private System.Windows.Forms.Label label_User;
		internal System.Windows.Forms.Label labelDB_name;
		internal System.Windows.Forms.Label labelUser;
		internal System.Windows.Forms.Label labelPass;
	}
}
