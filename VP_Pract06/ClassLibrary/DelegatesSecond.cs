using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DelegatesSecond
    {
        public static void DoSecond(Func<Action<int,int>, bool> func, Action<int,int> action)
        {
            Console.WriteLine("Func is activating...");
            if(func(action))
                Console.WriteLine("Func said True!");
            else
                Console.WriteLine("Func said False!");
            Console.WriteLine("Func is over\n");
        }


        //public static void add(int a, int b)
        //{
        //    Console.WriteLine($"Сумма: {a + b}");
        //}

        //public static bool PositiveOrNot(Action<int, int> sum, bool log)
        //{
        //    Console.WriteLine("Введите первое число:");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите второе число:");
        //    int y = int.Parse(Console.ReadLine());

        //    sum(x, y); 

        //    if ((x + y) > 0)
        //    {
        //        if (log)
        //        {
        //            Console.WriteLine("Положительное число");
        //        }
        //        return true;
        //    }
        //    else
        //    {
        //        if (log)
        //        {
        //            Console.WriteLine("Отрицательное число или ноль");
        //        }
        //        return false;
        //    }
        //}
    }
}
