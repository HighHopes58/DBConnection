namespace DBconnection
{
	partial class fNewConnection
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.labelPath = new System.Windows.Forms.Label();
			this.labelDB = new System.Windows.Forms.Label();
			this.tbDB = new System.Windows.Forms.TextBox();
			this.labelUser = new System.Windows.Forms.Label();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.cbShowPW = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(251, 229);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnect.Location = new System.Drawing.Point(158, 229);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// tbPath
			// 
			this.tbPath.Location = new System.Drawing.Point(87, 20);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(219, 23);
			this.tbPath.TabIndex = 2;
			// 
			// labelPath
			// 
			this.labelPath.AutoSize = true;
			this.labelPath.Location = new System.Drawing.Point(12, 23);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(34, 15);
			this.labelPath.TabIndex = 3;
			this.labelPath.Text = "Path:";
			// 
			// labelDB
			// 
			this.labelDB.AutoSize = true;
			this.labelDB.Location = new System.Drawing.Point(12, 66);
			this.labelDB.Name = "labelDB";
			this.labelDB.Size = new System.Drawing.Size(58, 15);
			this.labelDB.TabIndex = 4;
			this.labelDB.Text = "Database:";
			// 
			// tbDB
			// 
			this.tbDB.Location = new System.Drawing.Point(87, 63);
			this.tbDB.Name = "tbDB";
			this.tbDB.Size = new System.Drawing.Size(219, 23);
			this.tbDB.TabIndex = 5;
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Location = new System.Drawing.Point(12, 106);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(33, 15);
			this.labelUser.TabIndex = 6;
			this.labelUser.Text = "User:";
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(87, 103);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(219, 23);
			this.tbUser.TabIndex = 7;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(12, 147);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(60, 15);
			this.labelPassword.TabIndex = 8;
			this.labelPassword.Text = "Password:";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(87, 144);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(219, 23);
			this.tbPassword.TabIndex = 9;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// cbShowPW
			// 
			this.cbShowPW.AutoSize = true;
			this.cbShowPW.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbShowPW.Location = new System.Drawing.Point(198, 186);
			this.cbShowPW.Name = "cbShowPW";
			this.cbShowPW.Size = new System.Drawing.Size(108, 19);
			this.cbShowPW.TabIndex = 10;
			this.cbShowPW.Text = "Show Password";
			this.cbShowPW.UseVisualStyleBackColor = true;
			this.cbShowPW.CheckedChanged += new System.EventHandler(this.cbShowPW_CheckedChanged);
			// 
			// fNewConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 273);
			this.ControlBox = false;
			this.Controls.Add(this.cbShowPW);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.labelUser);
			this.Controls.Add(this.tbDB);
			this.Controls.Add(this.labelDB);
			this.Controls.Add(this.labelPath);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnCancel);
			this.Name = "fNewConnection";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Connection";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Label labelPath;
		private System.Windows.Forms.Label labelDB;
		private System.Windows.Forms.TextBox tbDB;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.CheckBox cbShowPW;
	}
}