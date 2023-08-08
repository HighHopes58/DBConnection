using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBconnection
{


	internal static class Program
	{

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			


			//DB_variables.DB_path = "Path";
			//DB_variables.DB_name = "DB Name";
			//DB_variables.DB_user = "User";
			//DB_variables.DB_pass = "Password";
			

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}



	}
	//class for connection variables
	internal static class DB_variables
	{
		//in New Connection Form - tbPath
		internal static string DB_path { get; set; } = "Path";
		//in New Connection Form - tbDB_name
		internal static string DB_name { get; set; } = "DB Name";
		//in New Connection Form - tbUser		
		internal static string DB_user { get; set; } = "User";
		//in New Connection Form - tbPassword		
		internal static string DB_pass { get; set; } = "Password";

	}



}
