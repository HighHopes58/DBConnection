using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBconnection
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			//variables visualisation temporary
			labelPath.Text = DB_variables.DB_path;
			labelDB_name.Text = DB_variables.DB_name;
			labelUser.Text = DB_variables.DB_user;
			labelPass.Text = DB_variables.DB_pass;

		}

		private void mmExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mmNewConnection_Click(object sender, EventArgs e)
		{
			fNewConnection formNewConnection = new fNewConnection(this);
			formNewConnection.Show();
		}

		
	}
}
