using System;
using System.IO;
using TextNotesApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextNotesApp
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

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
