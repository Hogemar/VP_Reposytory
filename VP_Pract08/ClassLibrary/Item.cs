namespace ClassLibrary
{
	public class Item
	{

		public int Id { get; private set; }

		public string Name { get; private set; }
        
		public string Color { get; private set; }
        
		public double Price { get; private set; }
        
		public string Provider { get; private set; }

        public DateOnly ProductionDate { get; private set; }

        public Item(int id, string name, string color, double price, string provider, DateOnly productionDate)
		{
			this.Id = id;
			this.Name = name;
			this.Color = color;
			this.Price = price;
			this.Provider = provider;
			this.ProductionDate = productionDate;
		}
		public override string ToString()
		{
			return $" Артикул {Id}. Наименование {Name}. Цвет {Color}. Стоимость {Price}. Поставщик {Provider}. Дата производства {ProductionDate}\n";
		}
	}
}




/*
namespace ClassLibrary
{
	public class Item
	{

		private int _id;

		private string _name;

		private string _color;

		private double _price;

		private string _provider;

		private DateOnly _productionDate;

		public int Id
		{
			get
			{
				return _id;
			}
			private set { }
		}

		public string Name
		{
			get
			{
				return _name;
			}
			private set { }
		}
		public string Color
		{
			get
			{
				return _color;
			}
			private set { }
		}
		public double Price
		{
			get
			{
				return _price;
			}
			private set { }
		}
		public string Provider { 
			get    
			{
				return _provider;
			  }
			private set { } 
		}

		public DateOnly ProductionDate
		{
			get
			{
				return _productionDate;
			}
			private set { }
		}

	

		public Item(int id, string name, string color, double price, string provider, DateOnly productionDate)
		{
			this._id = id;
			this._name = name;
			this._color = color;
			this._price = price;
			this._provider = provider;
			this._productionDate = productionDate;
		}
		public override string ToString()
		{
			return $"\tАртикул {_id}. Наименование {_name}. Цвет {_color}. Стоимость {_price}. Поставщик {_provider}. Дата производства {_productionDate}\n";
		}
	}
}
*/