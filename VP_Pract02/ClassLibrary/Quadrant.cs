using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Quadrant : RegularnPolygon
    {
        public Quadrant(string name = "", string color = "", double sideLenght = 1)
            : base(name, color, sideLenght, 4)
        {}
    }
}
