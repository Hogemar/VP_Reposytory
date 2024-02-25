namespace ClassLibrary
{
    public static class StingExtension
    {

        public static StringInfo GetInfo(this string inputString)
        {
            int length = CountLength (inputString);
            int digitCount = CountDigits(inputString);
            int letterCount = CountLetters(inputString);

            return new StringInfo(length, digitCount, letterCount);
        }

        private static int CountLength(this string str)
        {
            int count = 0;

            foreach (char c in str)
                count++;

            return count;
        }

        private static int CountDigits(this string str)
        {
            int count = 0;

            foreach (char c in str)
                if (char.IsDigit(c))
                    count++;

            return count;
        }

        private static int CountLetters(this string str)
        {
            int count = 0;

            foreach (char c in str)
                if (char.IsLetter(c))
                    count++;

            return count;
        }

    }
}

