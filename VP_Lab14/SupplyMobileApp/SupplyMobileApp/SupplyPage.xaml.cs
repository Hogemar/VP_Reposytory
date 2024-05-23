using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SupplyMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SupplyPage : ContentPage
	{
		public Supply supply { get; set; }
		public List<Supplier> Suppliers { get; set; }
		public List<Item> Items { get; set; }

		public SupplyPage(Supply supply = null)
		{
			InitializeComponent();

			if (supply == null)
			{
				supply = new Supply
				{
					Date = DateTime.Now // Устанавливаем текущую дату по умолчанию
				};
			}

			this.supply = supply;

			LoadData();

			// Устанавливаем текущую дату в DatePicker
			if (supply.Date == default(DateTime))
			{
				datePicker.Date = DateTime.Now;
			}
			else
			{
				datePicker.Date = supply.Date;
			}

			BindingContext = this.supply;
		}

		private void LoadData()
		{
			Suppliers = App.Database.GetSuppliers() as List<Supplier>;
			Items = App.Database.GetItems() as List<Item>;

			supplierPicker.ItemsSource = Suppliers;
			itemPicker.ItemsSource = Items;

			supplierPicker.ItemDisplayBinding = new Binding("Name");
			itemPicker.ItemDisplayBinding = new Binding("Name");

			if (supply.Supplier != 0)
			{
				var selectedSupplier = Suppliers.Find(s => s.Id == supply.Supplier);
				if (selectedSupplier != null)
				{
					supplierPicker.SelectedItem = selectedSupplier;
				}
			}

			if (supply.Item != 0)
			{
				var selectedItem = Items.Find(i => i.Id == supply.Item);
				if (selectedItem != null)
				{
					itemPicker.SelectedItem = selectedItem;
				}
			}
		}

		private async void SaveSupply(object sender, EventArgs e)
		{
			if (supplierPicker.SelectedItem == null || itemPicker.SelectedItem == null)
			{
				await DisplayAlert("Ошибка", "Пожалуйста, выберите поставщика и товар", "OK");
				return;
			}

			var bindingInfo = BindingContext as Supply;

			supply.Supplier = ((Supplier)supplierPicker.SelectedItem).Id;
			supply.Item = ((Item)itemPicker.SelectedItem).Id;
			supply.Date = datePicker.Date; // Используем выбранную дату
			supply.Volume = bindingInfo.Volume;

			App.Database.SaveSupply(supply);
			await Navigation.PopAsync();
		}

		private async void DeleteSupply(object sender, EventArgs e)
		{
			App.Database.DeleteSupply(supply.Supplier, supply.Item, supply.Date);
			await Navigation.PopAsync();
		}

		private async void Cancel(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
