using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RegularnPolygon : Figure
    {
        private double _sideLenght;
        public double SideLenght
        {
            get
            {
                return _sideLenght;
            }
            private set
            {
                if (value <= 0) throw new Exception("Side lenght must be positive number!");
                else _sideLenght = value;
            }
        }

        public uint SideCount { get; private set; }

        public RegularnPolygon(string name = "", string color = "", double sideLenght = 1, uint sideCount = 3) : base(name, color)
        {
            SideLenght = sideLenght;
            SideCount = sideCount;
        }

        public override double Perimeter
        {
            get
            {
                return SideCount * SideLenght;
            }
        }

        public override double Square
        {
            get
            {
                return SideCount / 4.0 * SideLenght * SideLenght * Math.Tan(Math.PI / SideCount);
            }
        }
    }
}
