using SQLite;
namespace SupplyMobileApp
{
	[Table("Supplier")]
	public class Supplier
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(50)]
		public string Name { get; set; }

		[MaxLength(100)]
		public string Address { get; set; }

		[MaxLength(17)]
		public string Phone { get; set; }
	}
}
