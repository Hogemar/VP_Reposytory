using ClassLibrary;
using System.Text;

/*String №1*/
//string str1 = "привет пока-пока привет";
//string str2 = "пока";
//Console.WriteLine(str1.RemoveAll(str2));


/*String№2*/
//string str = "Условие: Дана строка-предложение, содержащая      избыточные    пробелы.   Преобразовать ее    так, чтобы    между  словами был   ровно один пробел";
//Console.WriteLine(str.NormalizeSpaces());


/*String №3*/
//string str = "КОТ - РЫЖИЙ  ОБОРМОТ     ПОСТРОИЛ ДОМ НА ДЕРЕВЕ   И ЛЕНИВО      ЛОВИТ  МЫШЕЙ, БЕГАЮЩИХ  ПО ПОЛУ.";
//Console.WriteLine(str.SortString());

///*StringBuilder №1*/
//string orig = "Привет 11";
//char c = '1';
//string str = "пока";
//Console.WriteLine(orig.AppString(c, str));

/*StringBuilder №2*/

//string str1 = "ПРИВЕТ";
//string str2 = "ПРИВЕЕЕТ";
//StringBuilderTasks.EqualizeLength(ref str1, ref str2);
//Console.WriteLine($"{str1}+\n{str2}+");

/*StringBuilder №3*/
string numstr = "11";
Console.WriteLine(numstr.DecToBin());
