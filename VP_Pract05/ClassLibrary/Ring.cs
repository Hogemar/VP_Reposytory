using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ring : Round
    {
        private double _radiusInternal;

        public double RadiusInternal
        {
            get
            {
                return _radiusInternal;
            }
            private set
            {
                if (value <= 0) throw new Exception("Radius must be positive number!");
                _radiusInternal = value;
            }
        }

        public double RadiusExternal
        {
            get
            {
                return base.Radius;
            }
        }

        public Ring(string name = "", string color = "", double radiusInternal = 1, double radiusExternal = 2) : base(name, color, radiusExternal)
        {
            if (radiusInternal >= radiusExternal) throw new Exception("External radius must be greater than internal radius");
        }

        public override double Perimeter
        {
            get
            {
                return base.Perimeter + (2 * Math.PI * RadiusInternal);
            }
        }

        public override double Square
        {
            get
            {
                return base.Square - (2 * Math.PI * RadiusInternal * RadiusInternal);
            }
        }

    }
}
