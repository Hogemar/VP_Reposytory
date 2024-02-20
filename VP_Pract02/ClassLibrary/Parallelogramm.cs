using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Parallelogramm : Figure
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Angle { get; private set; }

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
