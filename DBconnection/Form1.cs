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
			label1.Text = DB_test.DB_path;
		}

		private void mmExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mmNewConnection_Click(object sender, EventArgs e)
		{
			fNewConnection formNewConnection = new fNewConnection();
			formNewConnection.ShowDialog();
		}
	}
}
