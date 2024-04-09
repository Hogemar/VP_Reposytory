#define SYNTAX_1
#define SYNTAX_2

using ClassLibrary;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;

#region Инициализация
List<Item> items = new List<Item>();

// Добавление товаров в список
items.Add(new Item(1, "Футболка", "Синий", 15000.99, "Модный магазин", new DateOnly(2023, 5, 10)));
items.Add(new Item(2, "Джинсы", "Черный", 29.99, "Джинсовый мир", new DateOnly(2023, 4, 22)));
items.Add(new Item(3, "Кроссовки", "Белый", 49.99, "Спортивный магазин", new DateOnly(2023, 3, 15)));
items.Add(new Item(4, "Рубашка", "Красный", 24.99, "Модный магазин", new DateOnly(2023, 6, 5)));
items.Add(new Item(5, "Шорты", "Зеленый", 59000.99, "Летний стиль", new DateOnly(2023, 7, 10)));
items.Add(new Item(6, "Платье", "Розовый", 59000.99, "Модный магазин", new DateOnly(2023, 8, 20)));
items.Add(new Item(7, "Джинсы", "Серый", 59000.99, "Мужской стиль", new DateOnly(2024, 9, 3)));

Console.WriteLine("\tСписок товаров:\n");
foreach (Item item in items)
    Console.WriteLine(item);
#endregion

Console.WriteLine("===================================\n");

///*Запрос 1. Отсортировать товары по поставщику, а затем по наименованию*/

#if SYNTAX_1
//Синтаксис 1
var even1_1 =
            from item in items
orderby item.Provider, item.Name
select item;

Console.WriteLine("\tСортировка по поставщику и наименованию:\n");
foreach (var item in even1_1)
Console.WriteLine(item);

//Console.WriteLine("------------------------------\n");

//Console.WriteLine("\tСортировка по наименованию:\n");
//foreach (var item in even1_2)
//    Console.WriteLine(item);
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<Item> even1_3 = items
    .OrderBy(i => i.Provider)
    .ThenBy(i => i.Name);


//IEnumerable<Item> even1_4 = items
//	.OrderBy(i => i.Name);

Console.WriteLine("\tСортировка по поставщику и наименованию (синтаксис 2):\n");
foreach (var item in even1_3)
Console.WriteLine(item);

//Console.WriteLine("------------------------------\n");

//Console.WriteLine("\tСортировка по наименованию (синтаксис 2):\n");
//foreach (var item in even1_4)
//	Console.WriteLine(item);
#endif

Console.WriteLine("===================================\n");

/*Запрос 2.  Вывести информацию о товарах конкретного поставщика*/

string providerName = "Модный магазин";

#if SYNTAX_1
//Синтаксис 1
var even2_1 =
            from item in items
where item.Provider == providerName
select item;

Console.WriteLine($"\t Информация о товарах от поставщика '{providerName}':\n");
foreach (var item in even2_1)
Console.WriteLine(item);
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<Item> even2_2 = items
    .Where(i => i.Provider == providerName);

Console.WriteLine($"\t Информация о товарах от поставщика '{providerName}':\n");
foreach (var item in even2_2)
Console.WriteLine(item);
#endif

Console.WriteLine("===================================\n");

/*Запрос 3. Вывести три самых дорогих товара*/

#if SYNTAX_1
//Синтаксис 1
var even3_1 =
            (from item in items
orderby item.Price descending
select item).Take(3);

Console.WriteLine("\tТри самых дорогих товара (синтаксис 1):\n");
foreach (var item in even3_1)
{
Console.WriteLine(item);
}
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<Item> even3_2 = items.OrderByDescending(i => i.Price)
                                 .Take(3);

Console.WriteLine("\tТри самых дорогих товара (синтаксис 2):\n");
foreach (var item in even3_2)
Console.WriteLine(item);
#endif

Console.WriteLine("===================================\n");

/*Запрос 4. Вывести информацию о товарах, произведенных в текущем году.*/

#if SYNTAX_1
//Синтаксис 1
var even4_1 =
            from item in items
where item.ProductionDate.Year == DateTime.Now.Year
select item;

Console.WriteLine("\tИнформация о товарах, произведенных в текущем году (синтаксис 1):\n");
foreach (var item in even4_1)
{
Console.WriteLine(item);
}
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<Item> even4_2 = items.Where(i => i.ProductionDate.Year == DateTime.Now.Year);

Console.WriteLine("\tИнформация о товарах, произведенных в текущем году (синтаксис 2):\n");
foreach (var item in even4_2)
Console.WriteLine(item);
#endif

Console.WriteLine("===================================\n");

/*Запрос 5. Вывести информацию о последнем произведенном товаре*/

#if SYNTAX_1
//Синтаксис 1
var even5_1 =
            (from item in items
orderby item.ProductionDate descending
select item).First();

Console.WriteLine("\tИнформация о последнем произведенном товаре (синтаксис 1):\n");
Console.WriteLine(even5_1);
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<Item> even5_2 = items.OrderByDescending(i => i.ProductionDate)
                                 .Take(1);

Console.WriteLine("\tИнформация о последнем произведенном товаре (синтаксис 2):\n");
foreach (var item in even5_2)
Console.WriteLine(item);
#endif

Console.WriteLine("===================================\n");

/*Запрос 6.  Посчитать количество поставщиков товара с заданным наименованием*/

string itemName = "Джинсы";

#if SYNTAX_1
//Синтаксис 1

var even6_1 =
        (from item in items
where item.Name == itemName
select item.Provider).Distinct().Count();

Console.WriteLine($"\tКоличество поставщиков товара '{itemName}' (синтаксис 1): {even6_1}\n");
#endif

#if SYNTAX_2
//Синтаксис 2

int even6_2 = items
    .Where(i => i.Name == itemName)
    .Select(i => i.Provider)
    .Distinct()
    .Count();

Console.WriteLine($"\tКоличество поставщиков товара '{itemName}' (синтаксис 2): {even6_2}\n");
#endif

Console.WriteLine("===================================\n");

/*Запрос 7. Вывести поставщиков, которые поставляют товары только дороже 10000*/

#if SYNTAX_1
//Синтаксис 1
//var even7_1 = //all
//        (from item in items
//         where item.Price > 10000
//         select item.Provider).Distinct();

var even7_1 =
            from item in items
group item by item.Provider into providerGroup
where providerGroup.All(item => item.Price>10000)
select providerGroup.Key;


Console.WriteLine("\tПоставщики, которые поставляют товары только дороже 10000 (синтаксис 1):\n");
foreach (var provider in even7_1)
Console.WriteLine(" " + provider);
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<string> even7_2 = items
                    .GroupBy(i => i.Provider)
                    .Where(group => group.All(item => item.Price > 10000))
                    .Select(group => group.Key);
Console.WriteLine("\n\tПоставщики, которые поставляют товары только дороже 10000 (синтаксис 2):\n");
foreach (var provider in even7_2)
Console.WriteLine(" " + provider);
#endif

Console.WriteLine("\n===================================\n");

/*Запрос 8.Вывести товары, которые либо не поставлялись в текущем году, либо их цена ниже средней цены всех товаров */

#if SYNTAX_1
//Синтаксис 1
//одним запросом
var even8_1 =
            from item in items
let averagePrice = items.Select(x => x.Price).Average()
where item.ProductionDate.Year != DateTime.Now.Year || item.Price < averagePrice
select item;
Console.WriteLine("\tТовары, которые либо не поставлялись в текущем году, либо их цена ниже средней цены всех товаров:\n");
foreach (var item in even8_1)
Console.WriteLine(item);
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<Item> even8_2 = items
    .Where(i => i.ProductionDate.Year != DateTime.Now.Year || i.Price < items.Select(x => x.Price).Average());

Console.WriteLine("\tТовары, которые либо не поставлялись в текущем году, либо их цена ниже средней цены всех товаров:\n");
foreach (var item in even8_2)
Console.WriteLine(item);
#endif

Console.WriteLine("===================================\n");

/*Запрос 9. Вывести полные наименования товаров в виде {Артикул} {Наименование} {Цвет}*/

#if SYNTAX_1
//Синтаксис 1
var even9_1 = from item in items
select $"{item.Id} {item.Name} {item.Color}";

Console.WriteLine("\tВывести полные наименования товаров в виде {Артикул} {Наименование} {Цвет} (синтаксис 1):\n");
foreach (var item in even9_1)
Console.WriteLine(" " + item.ToString());
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<string> even9_2 = items
    .Select(i => $"{i.Id} {i.Name} {i.Color}");

Console.WriteLine("\n\tВывести полные наименования товаров в виде {Артикул} {Наименование} {Цвет} (синтаксис 2):\n");
foreach (var item in even9_2)
Console.WriteLine(" " + item.ToString());
#endif

Console.WriteLine("\n===================================\n");

/*Запрос 10. Вывести минимальную цену товара для каждого поставщика */

#if SYNTAX_1
//Синтаксис 1
var even10_1 = from item in items
group item by item.Provider into providerGroup
select new
{
Provider = providerGroup.Key,
MinPrice = providerGroup.Min(item => item.Price)
};

Console.WriteLine("\tМинимальная цена для каждого поставщика (синтаксис 1):\n");
foreach (var item in even10_1)
Console.WriteLine($" Поставщик: {item.Provider}\t|\tМинимальная цена: {item.MinPrice}");
#endif

#if SYNTAX_2
//Синтаксис 2

IEnumerable<dynamic> even10_2 = items
    .GroupBy(i => i.Provider)
    .Select(group => new { Provider = group.Key, MinPrice = group.Min(item => item.Price) });

Console.WriteLine("\n\tМинимальная цена для каждого поставщика (синтаксис 2):\n");
foreach (var item in even10_2)
Console.WriteLine($" Поставщик: {item.Provider}\t|\tМинимальная цена: {item.MinPrice}");
#endif

Console.WriteLine("\n===================================\n");

/*Дополнительно. Вывести поставщиков, поставляющих самые дорогие товары*/

#if SYNTAX_1
var even11_1 =
    from item in items
    group item by item.Provider into providerGroup
    let maxPrice = providerGroup.Max(item => item.Price)
    where maxPrice == items.Max(item => item.Price)
    select new { Provider = providerGroup.Key, MaxPrice = maxPrice };

Console.WriteLine("\tПоставщики самых дорогих товаров (синтаксис 1):\n");
foreach (var supplier in even11_1)
    Console.WriteLine($" Поставщик: {supplier.Provider}\t|\tМаксимальная цена: {supplier.MaxPrice}");
#endif

#if SYNTAX_2
IEnumerable<dynamic> even11_2 =
    items.GroupBy(i => i.Provider)
         .Select(group => new { Provider = group.Key, MaxPrice = group.Max(item => item.Price) })
         .Where(item => item.MaxPrice == items.Max(i => i.Price));

Console.WriteLine("\n\tПоставщики самых дорогих товаров (синтаксис 2):\n");
foreach (var supplier in even11_2)
    Console.WriteLine($" Поставщик: {supplier.Provider}\t|\tМаксимальная цена: {supplier.MaxPrice}");
#endif
