using System.Text;

namespace ClassLibrary
{

    public static class StringBuilderTasks
    {

        public static string AppString(this string S, char c, string S0)
        {
            StringBuilder insertSB = new(S);
            
            for (int i = 0; i < insertSB.Length; i++)
            {
                if (insertSB[i] == c)
                {
                    insertSB.Insert(i + 1, S0);
                    i += S0.Length;
                }
            }

            return insertSB.ToString();
        }

        public static int EqualizeLength(ref string str0, ref string str1)
        {
            if (str0.Length == str1.Length) return 0;

            if (str0.Length < str1.Length)
            {
     
                int spaceToAdd = str1.Length - str0.Length;
                StringBuilder space = new StringBuilder();
                space.Append(' ',spaceToAdd);
                str0+= space.ToString();
               
                return -1;
            }
           else
            {

                int spaceToAdd = str0.Length - str1.Length;
                StringBuilder space = new StringBuilder();
                space.Append(' ', spaceToAdd);
                str1 += space.ToString();
        
                return 1;
            }
        }

        public static string DecToBin(this string input) 
        {
            int dec = Convert.ToInt32(input);
            if (dec < 0)
                throw new Exception($"Число {dec} отрицательное");

            if (dec == 0)
                return "0";

            StringBuilder sb = new StringBuilder();
            while (dec >0)
            {
                sb.Insert(0,dec%2);
                dec /= 2;
            }

            return sb.ToString();
        } 
    }
}

