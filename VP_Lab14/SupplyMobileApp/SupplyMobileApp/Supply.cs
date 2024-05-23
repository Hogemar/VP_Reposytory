using SQLite;
using System;
namespace SupplyMobileApp
{
	[Table("Supply")]
	public class Supply
	{
		[Indexed(Name = "PK_Supply", Order = 1, Unique = true)]
		public int Supplier { get; set; }

		[Indexed(Name = "PK_Supply", Order = 2, Unique = true)]
		public int Item { get; set; }

		[Indexed(Name = "PK_Supply", Order = 3, Unique = true)]
		public DateTime Date { get; set; }

		public int Volume { get; set; }
	}
}
