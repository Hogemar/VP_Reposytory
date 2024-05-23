using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VP_Pract13
{
	public partial class SplashPage : ContentPage
	{
		public SplashPage()
		{
			InitializeComponent();
			NavigateToMainPage();
		}

		private async void NavigateToMainPage()
		{
			await Task.Delay(6000);
			Application.Current.MainPage = new MainPage();
		}
	}
}
