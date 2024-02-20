using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rhombus : Parallelogramm
    {
        public Rhombus(string name = "", string color = "", double sideLenght = 1, double angle = 90)
            : base(name, color, sideLenght, sideLenght, angle)
        {}
    }
}
