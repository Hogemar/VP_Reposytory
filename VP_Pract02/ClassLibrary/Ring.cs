using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ring : Round
    {
        public Ring(string name = "", string color = "", double radius = 1) : base(name, color, radius)
        { }
    }
}
