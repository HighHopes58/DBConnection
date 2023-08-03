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
			//string stPathDatabse = null;
			//string stDatabase = null;
			//string stUser = null;
			//string stPassword = null;


			DB_test.DB_path = "1";
			
			

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}



	}
	internal static class DB_test
	{
		internal static string DB_path { get; set; }
	}



}
