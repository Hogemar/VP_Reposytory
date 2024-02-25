namespace ClassLibrary
{
    public struct StringInfo
    {
        public int Length { get; private set; }
        public int DigitCount { get; private set; }
        public int LetterCount { get; private set; }

        public StringInfo(int length, int digitCount, int letterCount)
        {
            Length = length;
            DigitCount = digitCount;
            LetterCount = letterCount;
        }
    }


}
       
    
  
