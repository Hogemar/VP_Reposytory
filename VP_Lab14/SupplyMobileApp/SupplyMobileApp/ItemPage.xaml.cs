using System;
using Xamarin.Forms;
namespace SupplyMobileApp
{
	public partial class ItemPage : ContentPage
	{
		public ItemPage()
		{
			InitializeComponent();
		}
		private void SaveItem(object sender, EventArgs e)
		{
			var item = (Item)BindingContext;
			if (!String.IsNullOrEmpty(item.Name))
			{
				App.Database.SaveItem(item);
			}
			Navigation.PopAsync();
		}
		private void DeleteItem(object sender, EventArgs e)
		{
			var item = (Item)BindingContext;
			App.Database.DeleteItem(item.Id);
			Navigation.PopAsync();
		}
		private void Cancel(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}
