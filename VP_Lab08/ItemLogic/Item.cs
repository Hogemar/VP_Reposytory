namespace ItemLogic
{
    public class Item : IComparable
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Color { get; private set; }
        public double Price { get; private set; }

        public Item(int id, string name, string color, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Color = color;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Артикул {Id}. Наименование {Name}. Цвет {Color}. Стоимость {Price}.\n";
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) throw new Exception("Cannot compare Item to null!");

            return Id.CompareTo((obj as Item).Id);
        }

    }
}
