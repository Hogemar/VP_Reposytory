using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace StudentsRazorPages.Models
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
        [StringLength(20)]
        [RegularExpression(@"\+7\(\d{3}\)\d{3}-\d{2}-\d{2}", ErrorMessage = "Invalid phone number format. Use +7(XXX)XXX-XX-XX")]
        public string Phone { get; set; }

      
    }
}
