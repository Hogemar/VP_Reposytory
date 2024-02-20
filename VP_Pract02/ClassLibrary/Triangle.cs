using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   
    public class Triangle: RegularnPolygon
    {
        public Triangle(string name = "", string color = "", double sideLenght = 1)
            : base(name, color, sideLenght, 3) 
        {}
    }

}
