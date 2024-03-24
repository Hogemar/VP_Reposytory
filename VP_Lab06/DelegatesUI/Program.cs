//using DinamicArrayNS;
//using DAExpansion;

///*  1  */

//DinamicArray<int> numbers = [-7, 5, 0, -6, 3];

//Console.WriteLine("\t Массив до:");
//foreach (var number in numbers)
//    Console.Write($"{number.ToString()} ");
//Console.WriteLine("\n");

//numbers.Filter((x) => x >= 0);

//Console.WriteLine("\t Массив после:");
//foreach (var number in numbers)
//    Console.Write($"{number.ToString()} ");
//Console.WriteLine("\n");

///*  2  */

//DinamicArray<string> strings =
//    [
//    "На поле берёзка стояла",
//    "Видит: машина стоит",
//    "А она ему как раз",
//    "Кольца кальмара у синагоги не покупайте"
//    ];

//Console.WriteLine("\t Строки до:");
//foreach (var str in strings)
//    Console.WriteLine(str);
//Console.WriteLine("\n");

//strings.Sort((str1, str2) => -str1.CompareTo(str2));

//Console.WriteLine("\t Строки после:");
//foreach (var str in strings)
//    Console.WriteLine(str);
//Console.WriteLine("\n");

Action<int> action;

action = delegate (int x)
{
    Console.WriteLine($"Wow! {x}!");
};

action=(x) =>  Console.WriteLine($"Wow! {x}!");