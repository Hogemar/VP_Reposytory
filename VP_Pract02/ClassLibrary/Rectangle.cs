using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Parallelogramm
    {
        public Rectangle(string name = "", string color = "", double side1 = 1, double side2 = 1)
            : base(name, color, side1, side2, 90)
        {}
    }
}
