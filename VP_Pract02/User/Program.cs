using ClassLibrary;

Ring ring = new Ring("Кольцо", "Красный", 3.14);
Console.WriteLine(ring.ToString());

Rectangle rectangle = new Rectangle("Прямоугольник", "Синий", 4, 3);
Console.WriteLine(rectangle.ToString());


Rhombus rhombus = new Rhombus("Ромб", "Зелёный", 7.51, 17);
Console.WriteLine(rhombus.ToString());

Quadrant quadrant = new Quadrant("Квадрат","Салатовый", 4.443);
Console.WriteLine(quadrant.ToString());

Triangle triangle = new Triangle("Треугольник", "Малиновый", 13.32);
Console.WriteLine(triangle.ToString());
