namespace ClassLibrary
{
    public class DelegatesFirst
    {
        public static void DoFirst(Action<Func<int>, char, char> action, Func<int> func, char c1, char str2)
        {
            Console.WriteLine("Here goes action!");
            action(func, c1, str2);
            Console.WriteLine("\nAction is over\n");
        }
      
        //public static int Mul(int a)
        //{
        //    return a * a;
        //}

        //public static void Sum(Func<int>a,char c1, char c2)
        //{
        //    Console.WriteLine(Convert.ToString(a()) + " " + Convert.ToString(c1) + " " + Convert.ToString(c2));
        //}

    }

}
