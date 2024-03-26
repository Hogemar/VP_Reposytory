namespace ClassLibrary
{
    [Serializable]

    public class ExistingItemCodeException : ApplicationException
    {
        public Item? Item 
        {
            get;
        }



        public ExistingItemCodeException() { }

        public ExistingItemCodeException(string message) : base(message) { }

        public ExistingItemCodeException(string message, Exception ex) : base(message) { }

        protected ExistingItemCodeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }

        public ExistingItemCodeException(Item item) 
        {
            base.Data.Add("Id", item.Id);
            base.Data.Add("Name", item.Name);
            base.Data.Add("Color", item.Color);
            base.Data.Add("Price", item.Price);

            Item=item;
        }
    }
}
