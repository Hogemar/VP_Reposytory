using System;
using System.IO;
using Xamarin.Forms;
namespace SupplyMobileApp
{
	public partial class App : Application
	{
		public const string DATABASE_NAME = "supply.db";


		private static DBService _database;
		public static DBService Database
		{
			get
			{
				if (_database == null)
				{
				   _database = new DBService(
					   Path.Combine(
						   Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
						   DATABASE_NAME));
				}
				return _database;
			}
		}

		public App()
		{
			InitializeComponent();
			MainPage = new MainPage();
		}


		protected override void OnStart()
		{
		}
		protected override void OnSleep()
		{
		}
		protected override void OnResume()
		{
		}
	}
}
