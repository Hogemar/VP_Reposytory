using DynamicArrayNS;

DynamicArray<int> dynamicArray = [5,7];

dynamicArray.Add(42);
dynamicArray.Add([0, 12]);
dynamicArray.Insert(-6, 3);
dynamicArray.RemoveAt(4);

Console.WriteLine("Массив:");
foreach (var item in dynamicArray)
{
    Console.Write($"{item.ToString()} ");
}

Console.WriteLine("\nPos of 42: " + dynamicArray.IndexOf(42, 0, dynamicArray.Count));

Console.WriteLine($"\n\nСреднее по массиву: {dynamicArray.Average()}\n");

Console.WriteLine($"Ёмкость массива ДО: {dynamicArray.Capacity}");
dynamicArray.IncreaseCapacity(5);
Console.WriteLine($"Ёмкость массива ПОСЛЕ: {dynamicArray.Capacity}");