using SQLite;
using System;
using System.Collections.Generic;
namespace SupplyMobileApp
{
	public class DBService
	{
		SQLiteConnection _database;
		public DBService(string databasePath)
		{
			_database = new SQLiteConnection(databasePath);
			_database.CreateTable<Item>();
			_database.CreateTable<Supplier>();
			_database.CreateTable<Supply>();
		}

		/// Item
		public IEnumerable<Item> GetItems()
		{
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Хлеб', 'Хлебозавод №1', 40.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Молоко', 'Молочный комбинат', 60.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Сахар', 'Сахарный завод', 50.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Чай', 'Чайная фабрика', 100.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Кофе', 'Кофейная компания', 150.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Макароны', 'Макаронная фабрика', 80.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Мясо', 'Мясокомбинат', 300.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Рыба', 'Рыбозавод', 250.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Яблоки', 'Садоводческое хозяйство', 120.00)");
			//_database.Execute("INSERT INTO Item (Name, Manufacturer, Price) VALUES ('Бананы', 'Фрукты-экспорт', 130.00)");

			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Поставщик продуктов', 'ул. Ленина, 1', '+7-900-123-45-67')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Молочный мир', 'ул. Советская, 23', '+7-900-234-56-78')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Сладкая жизнь', 'ул. Гагарина, 45', '+7-900-345-67-89')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Чайный дом', 'ул. Победы, 67', '+7-900-456-78-90')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Золотое зерно', 'ул. Мира, 89', '+7-900-567-89-01')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Паста и Ко', 'ул. Карла Маркса, 101', '+7-900-678-90-12')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Фермерское мясо', 'ул. Лесная, 121', '+7-900-789-01-23')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Рыбный уголок', 'ул. Морская, 141', '+7-900-890-12-34')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Фруктовый рай', 'ул. Садовая, 161', '+7-900-901-23-45')");
			//_database.Execute("INSERT INTO Supplier (Name, Address, Phone) VALUES ('Тропические фрукты', 'ул. Экзотическая, 181', '+7-900-012-34-56')");

			return _database.Table<Item>().ToList();
		}
		public Item GetItem(int id)
		{
			return _database.Get<Item>(id);
		}
		public int DeleteItem(int id)
		{
			return _database.Delete<Item>(id);
		}
		public int SaveItem(Item item)
		{
			if (item.Id != 0)
			{
				_database.Update(item);
				return item.Id;
			}
			else
			{
				return _database.Insert(item);
			}
		}

		/// Supplier
		public IEnumerable<Supplier> GetSuppliers()
		{
			return _database.Table<Supplier>().ToList();
		}
		public Supplier GetSupplier(int id)
		{
			return _database.Get<Supplier>(id);
		}
		public int DeleteSupplier(int id)
		{
			return _database.Delete<Supplier>(id);
		}
		public int SaveSupplier(Supplier supplier)
		{
			if (supplier.Id != 0)
			{
				_database.Update(supplier);
				return supplier.Id;
			}
			else
			{
				return _database.Insert(supplier);
			}
		}

		/// Supply
		public IEnumerable<Supply> GetSupplies()
		{
			//_database.DeleteAll<Supply>();
			return _database.Table<Supply>().ToList();
		}
		public Supply GetSupply(int supplier, int item, DateTime date)
		{
			return _database.Find<Supply>(supply =>
				supply.Supplier == supplier &&
				supply.Item == item &&
				supply.Date == date);
		}
		public void DeleteSupply(int supplier, int item, DateTime date)
		{
			_database.Execute(
				"DELETE FROM Supply WHERE Supplier = ? AND Item = ? AND Date = ?",
				supplier, item, date);
		}
		public void SaveSupply(Supply supply)
		{
			var existingSupply = GetSupply(supply.Supplier, supply.Item, supply.Date);

			if (existingSupply != null)
			{
				_database.Execute(
					"UPDATE Supply " +
					"SET Volume = ? " +
					"WHERE Supplier = ? AND Item = ? AND Date = ?",
					supply.Volume, supply.Supplier, supply.Item, supply.Date);
			}
			else
			{
				_database.Execute(
					"INSERT INTO Supply (Supplier, Item, Date, Volume) " +
					"VALUES (?, ?, ?, ?)",
					supply.Supplier, supply.Item, supply.Date, supply.Volume);
			}
		}
	}
}
