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
			this.File_Mainmenu = new System.Windows.Forms.ToolStripMenuItem();
			this.NewConnection_File_MainMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Exit_File_MainMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Mainmenu});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(800, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "MainMenu";
			// 
			// File_Mainmenu
			// 
			this.File_Mainmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewConnection_File_MainMenu,
            this.toolStripSeparator1,
            this.Exit_File_MainMenu});
			this.File_Mainmenu.Name = "File_Mainmenu";
			this.File_Mainmenu.Size = new System.Drawing.Size(37, 20);
			this.File_Mainmenu.Text = "File";
			// 
			// NewConnection_File_MainMenu
			// 
			this.NewConnection_File_MainMenu.Name = "NewConnection_File_MainMenu";
			this.NewConnection_File_MainMenu.Size = new System.Drawing.Size(180, 22);
			this.NewConnection_File_MainMenu.Text = "New Connection";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// Exit_File_MainMenu
			// 
			this.Exit_File_MainMenu.Name = "Exit_File_MainMenu";
			this.Exit_File_MainMenu.Size = new System.Drawing.Size(180, 22);
			this.Exit_File_MainMenu.Text = "Exit";
			this.Exit_File_MainMenu.Click += new System.EventHandler(this.Exit_File_MainMenu_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MainMenu);
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.Text = "DB Connection for php site";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem File_Mainmenu;
		private System.Windows.Forms.ToolStripMenuItem NewConnection_File_MainMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem Exit_File_MainMenu;
	}
}
