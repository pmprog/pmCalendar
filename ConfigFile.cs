using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace pmCalendar
{
	public class ConfigFile
	{
		private String _configfilename = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "pmcontact.cfg");

		public enum StartupMode
		{
			OpenLastDB = 0,
			OpenSpecificDB = 1,
			NewDB = 2
		}

		public enum SavingMode
		{
			AlwaysAsk = 0,
			AlwaysSave = 1,
			NeverSave = 2
		}

		public StartupMode StartupOption { get; set; }
		public String RecentDB { get; set; }
		public String StartupDB { get; set; }

		public SavingMode SaveOption { get; set; }

		public bool WindowMaximised { get; set; }

		private DataTable _toolstable;


		public ConfigFile()
		{
			StartupOption = StartupMode.OpenLastDB;
			RecentDB = "";
			StartupDB = "";
			SaveOption = SavingMode.AlwaysAsk;

			_toolstable = new DataTable();
			_toolstable.Columns.Add("Name");
			_toolstable.Columns.Add("Command");
			_toolstable.Columns.Add("Parameters");

			if (System.IO.File.Exists(_configfilename))
			{
				System.Xml.XmlDocument x = new System.Xml.XmlDocument();
				x.Load(_configfilename);

				StartupOption = (StartupMode)int.Parse(x.SelectSingleNode("/Config/Startup").InnerText);
				RecentDB = x.SelectSingleNode("/Config/RecentDB").InnerText;
				StartupDB = x.SelectSingleNode("/Config/StartupDB").InnerText;
				SaveOption = (SavingMode)int.Parse(x.SelectSingleNode("/Config/Saving").InnerText);

				foreach( System.Xml.XmlElement e in x.SelectNodes("/Config/Tools/Tool"))
				{
					DataRow row = _toolstable.NewRow();
					row["Name"] = e.SelectSingleNode("Name").InnerText;
					row["Command"] = e.SelectSingleNode("Command").InnerText;
					row["Parameters"] = e.SelectSingleNode("Parameters").InnerText;
					_toolstable.Rows.Add(row);
				}

				try
				{
					if (x.SelectSingleNode("/Config/Window").Attributes["maximised"].Value == "Y")
					{
						WindowMaximised = true;
					}
					else
					{
						WindowMaximised = false;
					}
				}
				catch (Exception)
				{
					WindowMaximised = false;
				}
			}
		}

		public void Save()
		{
			StringBuilder b = new StringBuilder();
			b.AppendLine("<Config>");
			b.AppendLine(" <Startup>" + ((int)StartupOption).ToString() + "</Startup>");
			b.AppendLine(" <RecentDB>" + RecentDB + "</RecentDB>");
			b.AppendLine(" <StartupDB>" + StartupDB + "</StartupDB>");
			b.AppendLine(" <Saving>" + ((int)SaveOption).ToString() + "</Saving>");
			b.AppendLine(" <Tools>");
			foreach (DataRow row in _toolstable.Rows)
			{
				b.AppendLine("  <Tool>");
				b.AppendLine("   <Name>" + System.Security.SecurityElement.Escape(row.Field<string>("Name")) + "</Name>");
				b.AppendLine("   <Command>" + System.Security.SecurityElement.Escape(row.Field<string>("Command")) + "</Command>");
				b.AppendLine("   <Parameters>" + System.Security.SecurityElement.Escape(row.Field<string>("Parameters")) + "</Parameters>");
				b.AppendLine("  </Tool>");
			}
			b.AppendLine(" </Tools>");
			b.AppendLine(" <Window maximised=\"" + (WindowMaximised ? "Y" : "N") + "\" />");
			b.AppendLine("</Config>");
			System.IO.File.WriteAllText(_configfilename, b.ToString());
		}

		public DataTable GetTools()
		{
			return _toolstable;
		}

	}
}
