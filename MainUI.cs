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

		}
	}
}
