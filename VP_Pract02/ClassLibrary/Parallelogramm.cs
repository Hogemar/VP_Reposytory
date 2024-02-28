using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Parallelogramm : Figure
    {
        private double _side1, _side2, _angle;
        public double Side1 
        { 
            get
            {
                return _side1;
            }
            private set
            {
                if (value <= 0) throw new Exception("Side must be positive number!");
                else _side1 = value;
            }
        }
        public double Side2
        {
            get
            {
                return _side2;
            }
            private set
            {
                if (value <= 0) throw new Exception("Side must be positive number!");
                else _side2 = value;
            }
        }
        public double Angle
        {
            get
            {
                return _angle;
            }
            private set
            {
                if (value <= 0) throw new Exception("Angle must be positive number!");
                else _angle = value;
            }
        }


        public Parallelogramm(string name = "", string color = "", double side1 = 1, double side2 = 1, double angle = 90) : base(name, color)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Angle = angle;
        }

        public override double Perimeter
        {
            get
            {
                return Side1 * 2 + Side2 * 2;
            }
        }
        public override double Square
        {
            get
            {
                return Side1 * Side2 * Math.Sin(Angle * Math.PI / 180);
            }
        }
    }
}
