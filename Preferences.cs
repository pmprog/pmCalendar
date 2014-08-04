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
	public partial class Preferences : Form
	{

		private ConfigFile _configfile;

		public Preferences()
		{
			InitializeComponent();
		}

		private void Preferences_Load(object sender, EventArgs e)
		{
			this.Icon = Properties.Resources.prefs;
			
			_configfile = new ConfigFile();
			switch (_configfile.StartupOption)
			{
				case ConfigFile.StartupMode.OpenLastDB:
					startLastDB.Checked = true;
					startSpecific.Checked = false;
					startNew.Checked = false;
					break;
				case ConfigFile.StartupMode.OpenSpecificDB:
					startLastDB.Checked = false;
					startSpecific.Checked = true;
					startNew.Checked = false;
					break;
				case ConfigFile.StartupMode.NewDB:
					startLastDB.Checked = false;
					startSpecific.Checked = false;
					startNew.Checked = true;
					break;
			}
			specificDB.Text = _configfile.StartupDB;

			switch (_configfile.SaveOption)
			{
				case ConfigFile.SavingMode.AlwaysAsk:
					saveAsk.Checked = true;
					saveAlways.Checked = false;
					saveNever.Checked = false;
					break;
				case ConfigFile.SavingMode.AlwaysSave:
					saveAsk.Checked = false;
					saveAlways.Checked = true;
					saveNever.Checked = false;
					break;
				case ConfigFile.SavingMode.NeverSave:
					saveAsk.Checked = false;
					saveAlways.Checked = false;
					saveNever.Checked = true;
					break;
			}

			toolsList.DataSource = _configfile.GetTools();

		}

		private void okayButton_Click(object sender, EventArgs e)
		{
			if (startLastDB.Checked) _configfile.StartupOption = ConfigFile.StartupMode.OpenLastDB;
			if (startSpecific.Checked) _configfile.StartupOption = ConfigFile.StartupMode.OpenSpecificDB;
			if (startNew.Checked) _configfile.StartupOption = ConfigFile.StartupMode.NewDB;
			_configfile.StartupDB = specificDB.Text;
			if (saveAsk.Checked) _configfile.SaveOption = ConfigFile.SavingMode.AlwaysAsk;
			if (saveAlways.Checked) _configfile.SaveOption = ConfigFile.SavingMode.AlwaysSave;
			if (saveNever.Checked) _configfile.SaveOption = ConfigFile.SavingMode.NeverSave;

			_configfile.Save();

			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ofd.FileName = specificDB.Text;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				specificDB.Text = ofd.FileName;
			}
		}
	}
}
