//#define Фигуры

using ClassLibrary;

#if Фигуры

Ring ring = new Ring("Кольцо", "Красный", 3.14, 5);

Rectangle rectangle = new Rectangle("Прямоугольник", "Синий", 4, 3);

Rhombus rhombus = new Rhombus("Ромб", "Зелёный", 7.51, 17);

Quadrant quadrant = new Quadrant("Квадрат", "Салатовый", 4.443);

Triangle triangle = new Triangle("Треугольник", "Малиновый", 13.32);

var figures = new GenericList<Figure>();
figures.Add(rectangle);
figures.Add(quadrant);
figures.Add(triangle);
figures.Add(ring);
figures.Add(rhombus);
Console.WriteLine("\tПеред сортировкой:");
Console.WriteLine(figures.ToString());

figures.BubbleSort();
Console.WriteLine("\tПосле сортировки:");
Console.WriteLine(figures.ToString());

#else
/*Строки*/
var strings = new GenericList<string>();
strings.Add("На поле берёзка стояла");
strings.Add("Видит: машина стоит");
strings.Add("А она ему как раз");
strings.Add("Кольца кальмара у синагоги не покупайте");

Console.WriteLine("\tПеред сортировкой:");
Console.WriteLine(strings.ToString());

strings.BubbleSort();
Console.WriteLine("\tПосле сортировки:");
Console.WriteLine(strings.ToString());

#endif