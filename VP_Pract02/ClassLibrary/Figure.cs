namespace ClassLibrary
{
    public abstract class Figure
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public abstract double Perimeter { get; }
        public abstract double Square { get; }

        public override string ToString()
        {
            return $"Фигура {Name}. Цвет {Color}. Периметр {Perimeter}. Площадь {Square}.\n";
        }

       public Figure(string name = "", string color = "")
        {
           this.Name = name;
           this.Color = color;           
        }
    }
}
