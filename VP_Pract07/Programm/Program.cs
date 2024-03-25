using ClassLibrary;

Shop shop = new Shop();
Item item1 = new Item(1,"Молоко","Белое",70.32);
Item item2 = new Item(1, "Кирпич", "Красный", 100.76);

Item item3 = new Item(2, "Карандаш", "Черный", 50.11);
Item item4 = new Item(2, "Стерка", "Синяя", 24.13);
//1 case
//try
//{
//    shop.addItem(item1);
//    shop.addItem(item2);
  
//}
//catch (ExistingItemCodeException ex)
//{
//    throw ex;
//}
 
//2 case
try
{
    shop.AddItem(item3);
    shop.AddItem(item4);
}
catch (ExistingItemCodeException ex)
{
    throw;
}

