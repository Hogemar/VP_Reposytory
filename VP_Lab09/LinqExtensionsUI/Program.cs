using ClassLibrary;
using LinqExtensionsLogic;

/// Пример на int
var listOfInt = new List<int>([3, -5, 12, 3, -7, 5]);

Console.WriteLine("\t Коллекция чисел");
foreach (var item in listOfInt)
	Console.Write(" " + item);

Console.WriteLine("\n\nВсе числа больше 0 ?\n > " + listOfInt.MyAll(x => x > 0));

listOfInt = listOfInt.MyDoThing(Math.Abs).ToList();

Console.WriteLine("\n Взятие модулей");
foreach (var item in listOfInt)
	Console.Write(" " + item);

Console.WriteLine("\n\n Исключение повторов");
listOfInt = listOfInt.MyDistinct(x => x).ToList();
foreach (var item in listOfInt)
	Console.Write(" " + item);

Console.WriteLine("\n\n Пересечение с [-5, 0, 5]");
listOfInt = listOfInt.MyIntersect([-5, 0, 5], x => x).ToList();
foreach (var item in listOfInt)
	Console.Write(" " + item);

/// Пример на Item
var listOfItem = new List<Item>();

listOfItem.Add(new Item(1, "Футболка", "Синий", 15000.99, "Модный магазин", new DateOnly(2023, 5, 10)));
listOfItem.Add(new Item(2, "Джинсы", "Черный", 29.99, "Джинсовый мир", new DateOnly(2022, 4, 22)));
listOfItem.Add(new Item(4, "Рубашка", "Красный", 24.99, "Модный магазин", new DateOnly(2023, 6, 5)));

Console.WriteLine("\n\n\t Коллекция товаров\n");
foreach (var item in listOfItem)
	Console.WriteLine(item);

Console.WriteLine("\t Перекраска всего в чёрный (осенняя коллекция)\n");
listOfItem = listOfItem.MyDoThing(item => new Item(item.Id, item.Name, "Чёрный", item.Price*1.5, item.Provider, item.ProductionDate)).ToList();
foreach (var item in listOfItem)
	Console.WriteLine(item);

Console.WriteLine("Все товары не раньше 2022 года производства?\n > " + listOfItem.MyAll(item => item.ProductionDate.Year >= 2022));

