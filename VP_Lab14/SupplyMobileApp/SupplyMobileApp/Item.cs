using SQLite;
namespace SupplyMobileApp
{
	[Table("Item")]
	public class Item
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(50)]
		public string Name { get; set; }

		[MaxLength(50)]
		public string Manufacturer { get; set; }

		public decimal Price { get; set; }
	}
}
