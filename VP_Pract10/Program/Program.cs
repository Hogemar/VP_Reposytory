using ClassLibrary;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
/* ПУНКТ 1*/

/*
string filePath = @"C:\test.txt";

FileClass file = FileClass.Open(filePath);

file = null;


FileClass newFile = FileClass.Open(filePath);

string line = newFile.ReadLine();
Console.WriteLine(line);
*/

/*ПУНКТ 3*/

/*
string filePath = @"C:\test.txt";
FileClass file = FileClass.Open(filePath);
file?.Dispose();
FileClass newFile = FileClass.Open(filePath);

string line = newFile.ReadLine();
Console.WriteLine(line);
*/

/*ПУНКТ 5*/

/*
FileClass file = null;
string filePath = @"C:\test2.txt";

try
{
    file = FileClass.Open(filePath);
    file.WriteLine("new string1");
}
finally
{
    file?.Dispose();
}
*/

/*ПУНКТ 6*/
/*
string filePath = @"C:\test.txt";
using (FileClass file1 = FileClass.Open(filePath))
{
    string line = file1.ReadLine();
    Console.WriteLine(line);
}
*/

/*ПУНКТ 7*/


long startMemory = GC.GetTotalMemory(true);

Console.WriteLine("Начальный размер кучи: " + startMemory + " байт");

for (int i = 0; i < 3000; i++)
{
    new object();
}

////Получаем размер кучи после создания объектов
long afterAllocMemory = GC.GetTotalMemory(false);
Console.WriteLine("Размер кучи после выделения памяти для объектов: " + afterAllocMemory + " байт");

////Запускаем сборку мусора
GC.Collect();

////Получаем размер кучи после сборки мусора
long endMemory = GC.GetTotalMemory(true);
Console.WriteLine("Размер кучи после сборки мусора: " + endMemory + " байт");
