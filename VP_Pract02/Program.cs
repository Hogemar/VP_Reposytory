using ClassLibrary;

Ring ring = new Ring("Кольцо", "Красный", 3.14);
double perimeterRing = ring.Perimeter();
double squareRing = ring.Square();
Console.WriteLine(ring.ToString());

Rectangle rectangle = new Rectangle("Прямоугольник", "Синий", 4, 3);
double perimeterRectangle=rectangle.Perimeter();
double squareRectangle=rectangle.Square();
Console.WriteLine(rectangle.ToString());


Rhombus rhombus = new Rhombus("Ромб", "Зелёный", 7.51, 2.23);
double perimeterRhombus = rhombus.Perimeter();
double squareRhombus =rhombus.Square();
Console.WriteLine(rhombus.ToString());

Quadrant quadrant = new Quadrant("Квадрат","Салатовый", 4.443);
double perimeterQuadrant = quadrant.Perimeter();
double squareQuadrant = quadrant.Square();
Console.WriteLine(quadrant.ToString());

Triangle triangle = new Triangle("Треугольник", "Малиновый", 13.32, 15.1, 18.75);
double perimeterTriangle = triangle.Perimeter();
double squareTriangle = triangle.Square();
Console.WriteLine(triangle.ToString());
