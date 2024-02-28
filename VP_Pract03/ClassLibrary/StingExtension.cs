namespace ClassLibrary
{
    public static class StingExtension
    {

        public static StringInfo GetInfo(this string inputString)
        {
            int length = 0;
            int digitCount = 0;
            int letterCount = 0;

            foreach (char c in inputString)
            {
                length++;
                if (char.IsDigit(c)) digitCount++;
                if (char.IsLetter(c)) letterCount++;

            }

            return new StringInfo(length, digitCount, letterCount);
        }
    }
}

