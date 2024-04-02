using TreesLogic;
using ItemLogic;

Tree<int> treeOfInt = new();

treeOfInt.Insert(5);
treeOfInt.Insert(-2);
treeOfInt.Insert(0);
treeOfInt.Insert(7);
treeOfInt.Insert(2);


Console.WriteLine("\t Tree of int:");
foreach (var item in treeOfInt)
    Console.WriteLine(item);

Console.WriteLine("\n Is there '5' in tree?");
Console.WriteLine(" > " + treeOfInt.Find(5));

treeOfInt.Remove(5);

Console.WriteLine("\n I have removed '5' from tree.");
Console.WriteLine(" Is there '5' in tree?");
Console.WriteLine(" > " + treeOfInt.Find(5));

Console.WriteLine("\n\t Tree of int:");
foreach (var item in treeOfInt)
    Console.WriteLine(item);

Tree<Item> treeOfItem = new();

treeOfItem.Insert(new Item(2, "Кирпич", "Красный", 100.76));
treeOfItem.Insert(new Item(1, "Молоко", "Белое", 70.32));
treeOfItem.Insert(new Item(4, "Стерка", "Синяя", 24.13));
treeOfItem.Insert(new Item(3, "Карандаш", "Черный", 50.11));

Console.WriteLine("\n\t Tree of Item:\n");
foreach (var item in treeOfItem)
    Console.WriteLine(item);
