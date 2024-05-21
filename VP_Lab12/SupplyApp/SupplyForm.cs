using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyApp
{

	public partial class SupplyForm : Form
	{

		public SupplyForm()
		{
			InitializeComponent();
		}

		// Загрузка таблиц
		private void SetItemGrid()
		{
			if (itemGrid.ColumnCount < 4)
			{
				itemGrid.Columns.Add("colId", "Артикул");
				itemGrid.Columns.Add("colName", "Наименование");
				itemGrid.Columns.Add("colManufacturer", "Производитель");
				itemGrid.Columns.Add("colPrice", "Цена");
			}

			itemGrid.Rows.Clear();

			using (var db = new SupplyModel())
				foreach (var item in db.Item.ToList())
					itemGrid.Rows.Add(item.Id, item.Name, item.Manufacturer, ((double)item.Price));
		}
		private void SetSupplierGrid()
		{
			if (supplierGrid.ColumnCount < 4)
			{
				supplierGrid.Columns.Add("colId", "Ид. номер");
				supplierGrid.Columns.Add("colName", "Имя");
				supplierGrid.Columns.Add("colAddress", "Адрес");
				supplierGrid.Columns.Add("colPrice", "Телефон");
			}

			supplierGrid.Rows.Clear();

			using (var db = new SupplyModel())
				foreach (var supplier in db.Supplier.ToList())
					supplierGrid.Rows.Add(supplier.Id, supplier.Name, supplier.Address, supplier.Phone);
		}
		private void SetSupplyGrid()
		{
			if (supplyGrid.ColumnCount < 6)
			{
				supplyGrid.Columns.Add("colDate", "Дата поставки");
				supplyGrid.Columns.Add("colSupplier", "Поставщик");
				supplyGrid.Columns.Add("colItem", "Артикул товара");
				supplyGrid.Columns.Add("colName", "Наим. товара");
				supplyGrid.Columns.Add("colVolume", "Объём");
				supplyGrid.Columns.Add("colOverall", "Общая стоимость");
			}

			supplyGrid.Rows.Clear();

			using (var db = new SupplyModel())
				foreach (var supply in
					db.Supply.Select(supply => new
					{
						supply.Date,
						SupplierName = supply.Supplier1.Name,
						SupplierId = supply.Supplier,
						ItemId = supply.Item1.Id,
						ItemName = supply.Item1.Name,
						supply.Volume,
						Overall = supply.Volume * supply.Item1.Price
					}).ToList()
					)
					supplyGrid.Rows.Add(supply.Date.ToShortDateString(), new KeyValuePair<int, string>(supply.SupplierId, supply.SupplierName), supply.ItemId, supply.ItemName, supply.Volume, supply.Overall);
		}
		
		// Supply Form
		private void SupplyForm_Load(object sender, EventArgs e)
		{
			SetItemGrid();
			SetSupplierGrid();
			SetSupplyGrid();
		}

		// Item context menu
		private void refreshItem_Click(object sender, EventArgs e)
		{
			SetItemGrid();
		}
		private void addItem_Click(object sender, EventArgs e)
		{
			AddItemForm add = new AddItemForm();
			if (add.ShowDialog(this) == DialogResult.OK)
			{
				SetItemGrid();
			}
		}
		private void removeItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент ? ",
									"Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				if (itemGrid.SelectedCells.Count > 0)
				{
					var i = itemGrid.SelectedCells[0].OwningRow.Index;
					int itemId = (int)itemGrid[0, i].Value;
					using (var db = new SupplyModel())
					{
						Item item = db.Item.Where(x => x.Id == itemId).First();
						db.Item.Remove(item);
						db.SaveChanges();
					}
				}
			}
			SetItemGrid();
		}
		private void updateItem_Click(object sender, EventArgs e)
		{
			var i = itemGrid.SelectedCells[0].OwningRow.Index;
			int itemId = (int)itemGrid[0, i].Value;

			using (var db = new SupplyModel())
			{
				Item item = db.Item.Where(x => x.Id == itemId).First();

				AddItemForm update = new AddItemForm(item);

				if (update.ShowDialog(this) == DialogResult.OK)
				{
					SetItemGrid();
				}
			}
		}

		// Supplier context menu
		private void refreshSupplier_Click(object sender, EventArgs e)
		{
			SetSupplierGrid();
		}
		private void addSupplier_Click(object sender, EventArgs e)
		{
			AddSupplierForm add = new AddSupplierForm();
			if (add.ShowDialog(this) == DialogResult.OK)
			{
				SetSupplierGrid();
			}
		}
		private void removeSupplier_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент ? ",
									"Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				if (supplierGrid.SelectedCells.Count > 0)
				{
					var i = supplierGrid.SelectedCells[0].OwningRow.Index;
					int supplierId = (int)supplierGrid[0, i].Value;
					using (var db = new SupplyModel())
					{
						Supplier supplier = db.Supplier.Where(x => x.Id == supplierId).First();
						db.Supplier.Remove(supplier);
						db.SaveChanges();
					}
				}
			}
			SetSupplierGrid();
		}
		private void updateSupplier_Click(object sender, EventArgs e)
		{
			var i = supplierGrid.SelectedCells[0].OwningRow.Index;
			int supplierId = (int)supplierGrid[0, i].Value;

			using (var db = new SupplyModel())
			{
				Supplier supplier = db.Supplier.Where(x => x.Id == supplierId).First();

				AddSupplierForm update = new AddSupplierForm(supplier);

				if (update.ShowDialog(this) == DialogResult.OK)
				{
					SetSupplierGrid();
				}
			}
		}

		// Supply context menu
		private void refreshSupply_Click(object sender, EventArgs e)
		{
			SetSupplyGrid();
		}
		private void addSupply_Click(object sender, EventArgs e)
		{
			AddSupplyForm add = new AddSupplyForm();
			if (add.ShowDialog(this) == DialogResult.OK)
			{
				SetSupplyGrid();
			}
		}
		private void removeSupply_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент ? ",
									"Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				if (supplyGrid.SelectedCells.Count > 0)
				{
					var i = supplyGrid.SelectedCells[0].OwningRow.Index;
					int supplierId = ((KeyValuePair<int, string>)supplyGrid[1, i].Value).Key;
					int itemId = (int)supplyGrid[2, i].Value;
					DateTime date = Convert.ToDateTime(supplyGrid[0, i].Value);

					using (var db = new SupplyModel())
					{
						Supply supply = db.Supply.Where(x => x.Supplier == supplierId
														&& x.Item == itemId
														&& x.Date == date).First();
						db.Supply.Remove(supply);
						db.SaveChanges();
					}
				}
			}
			SetSupplyGrid();
		}
		private void updateSupply_Click(object sender, EventArgs e)
		{
			var i = supplyGrid.SelectedCells[0].OwningRow.Index;
			int supplierId = ((KeyValuePair<int, string>)supplyGrid[1, i].Value).Key;
			int itemId = (int)supplyGrid[2, i].Value;
			DateTime date = Convert.ToDateTime(supplyGrid[0, i].Value);

			using (var db = new SupplyModel())
			{
				Supply supply = db.Supply.Where(x => x.Supplier == supplierId
												&& x.Item == itemId
												&& x.Date == date).First();

				AddSupplyForm update = new AddSupplyForm(supply);

				if (update.ShowDialog(this) == DialogResult.OK)
				{
					SetSupplyGrid();
				}
			}

		}
	}

}
