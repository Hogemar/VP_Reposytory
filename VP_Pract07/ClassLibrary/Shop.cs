namespace ClassLibrary
{
    public class Shop
    {
        private List<Item> _items = new();

        public void AddItem(Item newItem)
        { 
           foreach (Item item in _items)
            {
                if (item.Id == newItem.Id)
                    throw new ExistingItemCodeException(newItem);                
            }

           _items.Add(newItem);
        }
    }
}
