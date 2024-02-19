using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ring : Round
    {
        private double Radius { get; }
        private double _ringPerimeter;
        private double _ringSquare;
    
        public Ring(string ringName = "", string ringColor = "", double radius=0.0) : base(ringName, ringColor) {
          
            this.Radius = radius;
        
        }

        public override double Perimeter()
        {
            _ringPerimeter =  2 * Math.PI * Radius;
            return _ringPerimeter;
        }

        public override double Square()
        {
            _ringSquare = Math.PI * Radius * Radius;
            return _ringSquare;
        }

       
    }

    public class Rectangle : Parallelogramm
    {
        public double Width { get;  }
        public double Height { get;  }

        private double _rectanglePerimeter;
        private double _rectangleSquare;

        public Rectangle(string rectangleName = "", string rectangleColor = "", double width=0.0, double height=0.0) : base(rectangleName, rectangleColor)
        {
            this.Width = width;
            this.Height = height;
           
        }

        public override double Perimeter()  
        {
            _rectanglePerimeter=Width*2+Height*2;
            return _rectanglePerimeter;
        }
        public override double Square()
        {
            _rectangleSquare = Width * Height;
            return _rectangleSquare;
        }
    

    }

    public class Rhombus : Parallelogramm
    { 
        public double Side {  get; }
        public double Height { get; }

        private double _rhombusPerimeter;
        private double _rhombusSquare;

        public Rhombus (string rhombusName="", string rhombusColor="", double side = 0.0, double height = 0.0 ):base(rhombusName, rhombusColor)

        {
            this.Side = side;
            this.Height = height;
            
        }

        public override double Perimeter() 
        {
            _rhombusPerimeter = Side * 4;
            return _rhombusPerimeter;
        }
        public override double Square()
        {
            _rhombusSquare = Side * Height;
           return _rhombusSquare;
        }

    
    }

    public class Quadrant : RegularnNgon
    { 
        public double Side { get; }

        private double _quadrantPerimeter;
        private double _quadrantSquare;

        public Quadrant(string quadrantName = "", string quadrantColor="", double side = 0.0):base(quadrantName,quadrantColor)
        { 
            this.Side = side;
            

        }


        public override double Perimeter()
        {
            _quadrantPerimeter = Side * 4;
            return _quadrantPerimeter;
        }

        public override double Square()
        {
            _quadrantSquare = Side * Side;
            return _quadrantSquare;
        }


    }

    public class Triangle: RegularnNgon
    {
        public double Basis { get; }

        public double Side1 {  get; }

        public double Side2 {  get; }
       

        private double _trianglePerimeter;
        private double _triangleSquare;

        public Triangle(string triangleName = "", string triangleColor = "", double basis = 0.0,double side1=0.0,double side2=0.0, double height = 0.0):base(triangleName, triangleColor) 
        {
            this.Basis = basis;
            this.Side1 = side1;
            this.Side2 = side2;
        
        }


        public override double Perimeter()
        {
            _trianglePerimeter = Basis+Side1+Side2;
            return _trianglePerimeter;
        }

        public override double Square()
        {
            double p = Perimeter() / 2;
            _triangleSquare = Math.Sqrt(p * (p - Basis) * (p - Side1) * (p - Side2));
            return _triangleSquare;
        }


    }

}
