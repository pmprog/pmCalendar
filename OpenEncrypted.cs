using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pmCalendar
{
	public partial class OpenEncrypted : Form
	{
		public OpenEncrypted()
		{
			InitializeComponent();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			usePassword.Checked = true;
			useKey.Checked = false;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			usePassword.Checked = false;
			useKey.Checked = true;
		}

		private void okayButton_Click(object sender, EventArgs e)
		{
			if (usePassword.Checked && passwordText.Text == "")
			{
				MessageBox.Show("You need to enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (useKey.Checked && (privateKeyFile.Text == "" || !System.IO.File.Exists(privateKeyFile.Text)))
			{
				MessageBox.Show("You need to select your private key file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void browseKey_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				privateKeyFile.Text = ofd.FileName;
			}
		}
	}
}
