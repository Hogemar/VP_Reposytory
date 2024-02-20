using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RegularnPolygon : Figure
    {
        public double SideLenght { get; private set; }
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
                return SideCount/4 * SideLenght * SideLenght * Math.Tan(Math.PI/SideCount);
            }
        }
    }


}
