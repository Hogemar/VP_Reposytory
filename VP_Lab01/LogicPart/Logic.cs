namespace LogicPart
{
    public class Logic
    {
        // строка со всеми гласными
        private static string vovels = "EeYyUuIiOoAa";
        // строка со всеми согласными
        private static string consonants = "QqWwRrTtPpSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm";


        public static float strAnalise(string? str)
        {
            if (str.Length == 0) 
            {
                throw new Exception("Ничего не введено!");
            }

            float percent = 0;
            uint letterCount = 0;
            foreach (var c in str)
            {
                if (vovels.Contains(c))
                { 
                    percent++;
                    letterCount++;
                }
                if (consonants.Contains(c))
                {
                    letterCount++;
                }

            }

            return percent*= 100F/(float)letterCount;
        }
    }
}
