using System.Globalization;
using System.Linq;

namespace ClassLibrary
{
    public static class StringTasks
    {
        public static string RemoveAll (this string input, string substringToRemove)
        {
            return input.Replace(substringToRemove, "");
        }

        public static string NormalizeSpaces (this string input)
        {
            
            string result = string.Join(" ",input.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries));
            return result;
        }

        public static string SortString(this string input)
         {
            string[] words = input.Split(new char[] {' ', ',','.',';',':', '-', '\'', '\"'}, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            string result = string.Join(" ", words);
            return result;
        }

    }
}
