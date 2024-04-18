using FileClassLogic;

string filePath = @"C:\VP10.txt";

/*  Создание файла и запись*/
var newFile = FileClass.Create(filePath);

newFile.Write("1234", 3);
Console.WriteLine(newFile.Read(2));
newFile.Write("543", 3);
Console.WriteLine(newFile.ReadLine());

//newFile.WriteLine("Идёт медведь по лесу");      // "Идёт медведь по лесу"
//newFile.Write("Видит – машина горит", 5+3+6);   // "Видит – машина"

newFile.Close();

/* Открытие файла и чтение*/
var file = FileClass.Open(filePath);

file.Read(4+1);             // "Идёт "
string bear = file.Read(7); // "медведь"
file.ReadLine();            // "по лесу\n"
Console.WriteLine(file.ReadLine().Replace("машина", bear)); // "Видит - медведь"

file.Close();

/* Удаление файла */
Console.WriteLine("\n> Пожалуйста, нажмите Enter...");
Console.ReadKey();
File.Delete(filePath);