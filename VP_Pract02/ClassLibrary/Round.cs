using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Round : Figure
    {
        public double Radius { get; private set; }

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
