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
	public partial class SupplierTablePage : ContentPage
	{
		public SupplierTablePage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			supplierList.ItemsSource = App.Database.GetSuppliers();
			base.OnAppearing();
		}

		private async void OnSupplierSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Supplier selectedSupplier = (Supplier)e.SelectedItem;
			SupplierPage itemPage = new SupplierPage();
			itemPage.BindingContext = selectedSupplier;
			await Navigation.PushAsync(itemPage);
		}

		private async void CreateSupplier(object sender, EventArgs e)
		{
			Supplier item = new Supplier();
			SupplierPage itemPage = new SupplierPage();
			itemPage.BindingContext = item;
			await Navigation.PushAsync(itemPage);
		}
	}
}