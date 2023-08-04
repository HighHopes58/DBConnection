using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBconnection
{
	public partial class fNewConnection : Form
	{

		MainForm mainForm; 
		public fNewConnection(MainForm owner)
		{
			mainForm = owner;
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{

			DB_test.DB_path = tbPath.Text;
			mainForm.label1.Text = tbPath.Text;
			Close();
		}

		private void cbShowPW_CheckedChanged(object sender, EventArgs e)
		{
			if (cbShowPW.Checked)
			{
				tbPassword.UseSystemPasswordChar = false;
			}
			else
			{
				tbPassword.UseSystemPasswordChar = true;
			}


		}
	}
}
