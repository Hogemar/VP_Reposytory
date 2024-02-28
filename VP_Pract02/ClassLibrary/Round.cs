using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Round : Figure
    {
        private double _radius;
        public double Radius 
        {
            get
            {
                return _radius;
            }
            private set
            {
                if (value <= 0) throw new Exception("Raduis must be positive number!");
                else _radius = value;
            }
        }

        public Round(string name = "", string color = "", double radius = 1) : base(name, color)
        {
            this.Radius = radius;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override double Square
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }
}
