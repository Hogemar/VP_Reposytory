using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace SupplyMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SupplyTablePage : ContentPage
	{
		public SupplyTablePage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			LoadSupplies();
		}

		private void LoadSupplies()
		{
			var supplies = App.Database.GetSupplies();
			var suppliers = App.Database.GetSuppliers().ToDictionary(s => s.Id, s => s.Name);
			var items = App.Database.GetItems().ToDictionary(i => i.Id, i => i.Name);

			var supplyDisplayModels = supplies.Select(supply => new SupplyDisplayModel
			{
				SupplierName = suppliers.ContainsKey(supply.Supplier) ? suppliers[supply.Supplier] : "Unknown",
				ItemName = items.ContainsKey(supply.Item) ? items[supply.Item] : "Unknown",
				Date = supply.Date,
				Volume = supply.Volume,
				SupplierId = supply.Supplier,
				ItemId = supply.Item
			}).ToList();

			supplyList.ItemsSource = supplyDisplayModels;
		}

		private async void OnSupplySelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var selectedSupplyDisplayModel = e.SelectedItem as SupplyDisplayModel;

			var selectedSupply = App.Database.GetSupplies().FirstOrDefault(s =>
				s.Supplier == selectedSupplyDisplayModel.SupplierId &&
				s.Item == selectedSupplyDisplayModel.ItemId &&
				s.Date == selectedSupplyDisplayModel.Date);

			if (selectedSupply != null)
			{
				SupplyPage supplyPage = new SupplyPage(selectedSupply);
				await Navigation.PushAsync(supplyPage);
			}

			((ListView)sender).SelectedItem = null;
		}

		private async void CreateSupply(object sender, EventArgs e)
		{
			Supply supply = new Supply();
			SupplyPage supplyPage = new SupplyPage(supply);
			await Navigation.PushAsync(supplyPage);
		}
	}

	public class SupplyDisplayModel
	{
		public string SupplierName { get; set; }
		public string ItemName { get; set; }
		public DateTime Date { get; set; }
		public int Volume { get; set; }
		public int SupplierId { get; set; }
		public int ItemId { get; set; }
	}
}
