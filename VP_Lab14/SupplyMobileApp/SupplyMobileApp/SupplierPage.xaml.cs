using System;
using Xamarin.Forms;
namespace SupplyMobileApp
{
	public partial class SupplierPage : ContentPage
	{
		public SupplierPage()
		{
			InitializeComponent();
		}

		private void SaveSupplier(object sender, EventArgs e)
		{
			var supplier = (Supplier)BindingContext;
			if (!String.IsNullOrEmpty(supplier.Name))
			{
				App.Database.SaveSupplier(supplier);
			}
			Navigation.PopAsync();
		}

		private void DeleteSupplier(object sender, EventArgs e)
		{
			var supplier = (Supplier)BindingContext;
			App.Database.DeleteSupplier(supplier.Id);
			Navigation.PopAsync();
		}

		private void Cancel(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}
