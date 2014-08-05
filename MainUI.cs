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
	public partial class MainUI : Form
	{
		private bool _databasechanged = false;
		private String _databasefilename = "";
		private polyLib.Data.Table _database = null;

		private ConfigFile _configfile;
		private bool _startupopen = true;

		public MainUI()
		{
			InitializeComponent();
		}

		private void MainUI_Load(object sender, EventArgs e)
		{
			this.Icon = Properties.Resources.app_icon;

			//newContactToolStripMenuItem.Image = new Icon(Properties.Resources.add_user, 16, 16).ToBitmap();
			//deleteSelectedContactToolStripMenuItem.Image = new Icon(Properties.Resources.delete_something, 16, 16).ToBitmap();
			preferencesToolStripMenuItem.Image = new Icon(Properties.Resources.prefs, 16, 16).ToBitmap();
			//syncToolStripMenuItem.Image = new Icon(Properties.Resources.sync, 16, 16).ToBitmap();
			generateKeyPairToolStripMenuItem.Image = new Icon(Properties.Resources.lockicon, 16, 16).ToBitmap();
			NewDB();

			_configfile = new ConfigFile();
			externalToolItem_Create();
			if (_configfile.WindowMaximised)
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void MainUI_Shown(object sender, EventArgs e)
		{
			if (_startupopen)
			{
				switch (_configfile.StartupOption)
				{
					case ConfigFile.StartupMode.OpenLastDB:
						if (_configfile.RecentDB != "" && System.IO.File.Exists(_configfile.RecentDB))
						{
							LoadDB(_configfile.RecentDB);
						}
						break;
					case ConfigFile.StartupMode.OpenSpecificDB:
						if (System.IO.File.Exists(_configfile.StartupDB))
						{
							LoadDB(_configfile.StartupDB);
						}
						else
						{
							MessageBox.Show("Database '" + _configfile.StartupDB + "' could not be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						break;
				}
				_startupopen = false;
			}
		}

		private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !CloseDB();

			if (!e.Cancel)
			{
				if (this.WindowState == FormWindowState.Maximized && !_configfile.WindowMaximised)
				{
					_configfile.WindowMaximised = true;
					_configfile.Save();
				}
				if (this.WindowState == FormWindowState.Normal && _configfile.WindowMaximised)
				{
					_configfile.WindowMaximised = false;
					_configfile.Save();
				}
			}
		}

		#region File Menu

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (CloseDB())
			{
				NewDB();
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (CloseDB())
				{
					LoadDB(ofd.FileName);
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveDB();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_databasechanged = true;
			_databasefilename = "";
			SaveDB();
		}

		private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region View Menu

		private void monthToolStripMenuItem_Click(object sender, EventArgs e)
		{
			monthToolStripMenuItem.Checked = true;
			yearToolStripMenuItem.Checked = false;
		}

		private void yearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			monthToolStripMenuItem.Checked = false;
			yearToolStripMenuItem.Checked = true;
		}

		#endregion

		#region Tools Menu

		private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void generateKeyPairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			polyLib.UI.KeyPairGenerator kpg = new polyLib.UI.KeyPairGenerator();
			kpg.ShowDialog(this);
		}

		private void externalToolItem_Create()
		{
			int toolnum = 0;

			for (int idx = toolsToolStripMenuItem.DropDownItems.Count - 1; idx >= 0; idx--)
			{
				ToolStripItem i = toolsToolStripMenuItem.DropDownItems[idx];
				if (i.Name.StartsWith("externTool"))
				{
					i.Click -= externalToolItem_Click;
					toolsToolStripMenuItem.DropDownItems.Remove(i);
				}
			}

			foreach (DataRow row in _configfile.GetTools().Rows)
			{
				ToolStripItem i = toolsToolStripMenuItem.DropDownItems.Add(row.Field<string>("Name"));
				i.Name = "externTool" + toolnum.ToString();
				i.Tag = new KeyValuePair<string, string>(row.Field<string>("Command"), row.Field<string>("Parameters"));
				i.Click += externalToolItem_Click;
				toolnum++;
			}
		}

		private void externalToolItem_Click(object sender, EventArgs e)
		{
			KeyValuePair<string, string> toolinfo = ((KeyValuePair<string, string>)((ToolStripItem)sender).Tag);

			try
			{
				System.Diagnostics.Process p = System.Diagnostics.Process.Start(toolinfo.Key, toolinfo.Value);
			}
			catch (Exception)
			{
				MessageBox.Show("Invalid Program: " + toolinfo.Key);
			}
		}

		#endregion

		#region Help Menu

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.ShowDialog(this);
			ab.Dispose();
		}

		#endregion

		private void NewDB()
		{
			_databasefilename = "";
			_database = new polyLib.Data.Table();
			_database.TableName = "Calendar";
			_databasechanged = false;
			PrepareUI();
		}

		private bool CloseDB()
		{
			if (_databasechanged)
			{
				switch (_configfile.SaveOption)
				{
					case ConfigFile.SavingMode.AlwaysAsk:
						switch (MessageBox.Show("You have not saved your changes. Save them now?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
						{
							case DialogResult.Yes:
								SaveDB();
								break;
							case DialogResult.No:
								break;
							case DialogResult.Cancel:
								return false;
						}
						break;
					case ConfigFile.SavingMode.AlwaysSave:
						SaveDB();
						break;
				}
			}
			return true;
		}

		private void LoadDB(String Filename)
		{
			_databasefilename = Filename;
			try
			{
				_database.Load(_databasefilename);
				_configfile.RecentDB = _databasefilename;
				_configfile.Save();
			}
			catch (polyLib.Data.InvalidFormatException)
			{
				DialogResult r = DialogResult.OK;
				while (r != DialogResult.Cancel)
				{
					OpenEncrypted oe = new OpenEncrypted();
					try
					{
						r = oe.ShowDialog();
						if (r == DialogResult.OK)
						{
							if (oe.usePassword.Checked)
							{
								this.Cursor = Cursors.WaitCursor;
								Application.DoEvents();
								_database.Load(_databasefilename, oe.passwordText.Text);
								_configfile.RecentDB = _databasefilename;
								_configfile.Save();
								this.Cursor = Cursors.Default;
								break;
							}

							if (oe.useKey.Checked)
							{
								this.Cursor = Cursors.WaitCursor;
								Application.DoEvents();
								polyLib.Crypto.CryptoKey k = polyLib.Crypto.CryptoKey.LoadFromFile(oe.privateKeyFile.Text);
								_database.Load(_databasefilename, k);
								_configfile.RecentDB = _databasefilename;
								_configfile.Save();
								this.Cursor = Cursors.Default;
								break;
							}
						}
					}
					catch (polyLib.Data.InvalidFormatException)
					{
						MessageBox.Show("You have entered an incorrect password, or selected an invalid private key");
					}
					catch (Exception)
					{
						MessageBox.Show("An known problem has occured reading your file.");
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Unable to load database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			_databasechanged = false;
			PrepareUI();
		}

		private void PrepareUI()
		{
			// TODO: Prepare UI
		}

		private void SaveDB()
		{
			if (_databasefilename == "")
			{
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					_databasefilename = sfd.FileName;
					if (MessageBox.Show("Would you like to set your security settings before saving?", "Encrypt Database?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						propertiesToolStripMenuItem_Click(this, null);
					}
				}
				else
				{
					return;
				}
			}
			if (_database.Metadata.ContainsKey("Encrypt.Password") && _database.Metadata["Encrypt.Password"] != "")
			{
				_database.Save(_databasefilename, _database.Metadata["Encrypt.Password"]);
				_configfile.RecentDB = _databasefilename;
				_configfile.Save();
			}
			else if (_database.Metadata.ContainsKey("Encrypt.PublicKey") && _database.Metadata["Encrypt.PublicKey"] != "")
			{
				polyLib.Crypto.CryptoKey pubkey = new polyLib.Crypto.CryptoKey(UTF8Encoding.UTF8.GetString(Convert.FromBase64String(_database.Metadata["Encrypt.PublicKey"])));
				_database.Save(_databasefilename, pubkey);
				_configfile.RecentDB = _databasefilename;
				_configfile.Save();
			}
			else
			{
				_database.Save(_databasefilename);
				_configfile.RecentDB = _databasefilename;
				_configfile.Save();
			}
			_databasechanged = false;
			PrepareUI();
		}

	}
}
