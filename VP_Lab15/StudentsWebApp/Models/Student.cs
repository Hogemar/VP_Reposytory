using System.ComponentModel.DataAnnotations;
namespace StudentsWebApp.Models
{
	public class Student
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime Birthdate { get; set; }

		[Required]
        [RegularExpression(@"\+7\(\d{3}\)\d{3}-\d{2}-\d{2}", ErrorMessage = "Phone number must be in the format +7(xxx)xxx-xx-xx")] 
		public string Phone { get; set; }
	}
}
