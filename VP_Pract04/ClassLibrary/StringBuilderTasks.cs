using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public static class StringBuilderTasks
    {

        public static StringBuilder AppString(this StringBuilder strBuilder, char c, string str0)
        {
            for (int i = 0; i < strBuilder.Length; i++)
            {
                if (strBuilder[i] == c)
                {
                    strBuilder.Insert(i + 1, str0);
                    i += str0.Length;
                }
            }

            return strBuilder;
        }

        public static int EqualizeLength(ref string str0, ref string str1)
        {
            if (str0.Length == str1.Length) return 0;

            if (str0.Length < str1.Length)
            {
                //Console.WriteLine($"Длина первой  строки: { str0.Length }");
                //Console.WriteLine($"Длина второй  строки: {str1.Length}");
                int spaceToAdd = str1.Length - str0.Length;
                StringBuilder space = new StringBuilder();
                space.Append(' ',spaceToAdd);
                str0+= space.ToString();
                //Console.WriteLine($"Новая длина первой строки: {str0.Length}");
                return -1;
            }
           else
            {
                //Console.WriteLine($"Длина первой строки: {str0.Length}");
                //Console.WriteLine($"Длина второй строки:  {str1.Length}");
                int spaceToAdd = str0.Length - str1.Length;
                StringBuilder space = new StringBuilder();
                space.Append(' ', spaceToAdd);
                str1 += space.ToString();
                //Console.WriteLine($"Новая длина второй строки: {str1.Length}");
                return 1;
            }
        }

        public static string DecToBin(this string input) 
        {
            int dec;

            if (!int.TryParse(input, out dec))
                throw new Exception($"Неверный формат числа: {input}");

            if (dec < 0)
                throw new Exception($"Число {dec} отрицательное");

                string result = Convert.ToString(dec, 2);
                return new string(result);
        } 
    }
}

