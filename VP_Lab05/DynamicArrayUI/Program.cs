using DinamicArrayNS;

DinamicArray<int> dinamicArray = [5,7];

dinamicArray.Add(42);
dinamicArray.Add([0, 12]);
dinamicArray.Insert(-6, 3);
dinamicArray.RemoveAt(4);


Console.WriteLine("Массив:");
foreach (var item in dinamicArray)
{
    Console.Write($"{item.ToString()} ");
}
Console.WriteLine($"\n\nСреднее по массиву: {dinamicArray.Average()}\n");

Console.WriteLine($"Ёмкость массива ДО: {dinamicArray.Capacity}");
dinamicArray.IncreaseCapacity(5);
Console.WriteLine($"Ёмкость массива ПОСЛЕ: {dinamicArray.Capacity}");