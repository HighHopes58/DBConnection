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
			//variables visualisation temporary 
			mainForm.labelPath.Text = tbPath.Text;
			mainForm.labelDB_name.Text = tbDB_name.Text;
			mainForm.labelUser.Text = tbUser.Text;
			mainForm.labelPass.Text = tbPassword.Text;
			Close();
		}
		//hide-show password
		private void cbShowPW_CheckedChanged(object sender, EventArgs e)
		{
			tbPassword.UseSystemPasswordChar = cbShowPW.Checked ? false : true;
		}
	}
}
