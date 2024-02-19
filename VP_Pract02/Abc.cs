using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Round:Figure
    {
        public Round(string roundName = "", string roundColor = "") : base(roundName, roundColor) { }
    }

    public class Parallelogramm : Figure
    {
        public Parallelogramm(string parallelogrammName = "", string parallelogrammColor = "") : base(parallelogrammName, parallelogrammColor) { }
    }

    public class RegularnNgon:Figure
    {
        public RegularnNgon(string regularnNgonName = "", string regularnNgonColor = "") : base(regularnNgonName, regularnNgonColor) { }
    }


}
