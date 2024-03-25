namespace ClassLibrary
{
    public class ExistingItemCodeException : ApplicationException
    {
        public Item? Item 
        {
            get;
        }
        public string? Data 
        {
            get; 
        }

        public ExistingItemCodeException(Item item) 
        {
            Data=item.ToString();
            Item=item;
        }
    }
}
