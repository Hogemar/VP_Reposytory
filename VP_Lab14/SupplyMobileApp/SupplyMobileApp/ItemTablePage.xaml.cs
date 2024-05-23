using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SupplyMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemTablePage : ContentPage
	{
		public ItemTablePage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			itemList.ItemsSource = App.Database.GetItems();
			base.OnAppearing();
		}

		private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Item selectedItem = (Item)e.SelectedItem;
			ItemPage itemPage = new ItemPage();
			itemPage.BindingContext = selectedItem;
			await Navigation.PushAsync(itemPage);
		}

		private async void CreateItem(object sender, EventArgs e)
		{
			Item item = new Item();
			ItemPage itemPage = new ItemPage();
			itemPage.BindingContext = item;
			await Navigation.PushAsync(itemPage);
		}
	}
}