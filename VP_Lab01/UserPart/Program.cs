using LP = LogicPart;

Console.Write(" Введите строку латинских букв\n > ");
Console.WriteLine($" Процент гласных = {LP.Logic.strAnalise(Console.ReadLine())}%");

//for (int i = 0; i < 5000; i++)
//{
//    Console.SetWindowSize(Random.Shared.Next()%60+1, Random.Shared.Next()%40+1);
//}