namespace ClassLibrary
{
    public abstract class Figure
    {
        public  string Name { get; private set; }
        public  string Color { get; private set; }
        protected double _p
        {
            get => Perimeter();
            set { }
        }

        protected double _s
        {
            get => Square();
            set { }
        }
        public virtual double Perimeter()
        { return _p; }
        public virtual double Square() 
        { return _s; 
        }

        public override string ToString()
        {
            string str = $"Фигура -> {Name}." +
                    $"Цвет -> {Color}." +
                     $"Периметр -> {_p}." +
                      $"Площадь -> {_s}.\n";
            return str;
        }
       public Figure(string name="", string color="")
        {
            this.Name = name;
           this.Color = color;
           
        }
    }
}
