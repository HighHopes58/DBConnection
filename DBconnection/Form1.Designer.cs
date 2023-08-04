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
			this.label1 = new System.Windows.Forms.Label();
			this.MainMenu.SuspendLayout();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(291, 198);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "asdfasdf";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MainMenu);
			this.HelpButton = true;
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DB Connection for php site";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem mmFile;
		private System.Windows.Forms.ToolStripMenuItem mmNewConnection;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mmExit;
		internal System.Windows.Forms.Label label1;
	}
}
