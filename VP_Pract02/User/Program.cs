using ClassLibrary;

var list = new List<Figure>();

Ring ring = new Ring("Кольцо", "Красный", 3.14, 5);

Rectangle rectangle = new Rectangle("Прямоугольник", "Синий", 4, 3);

Rhombus rhombus = new Rhombus("Ромб", "Зелёный", 7.51, 17);

Quadrant quadrant = new Quadrant("Квадрат","Салатовый", 4.443);

Triangle triangle = new Triangle("Треугольник", "Малиновый", 13.32);

list.Add(ring);
list.Add(rectangle);
list.Add(rhombus);
list.Add(quadrant);
list.Add(triangle);

foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}