using System;
using System.Collections.Generic; // Удалите, если больше не нужен
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsRazorPages.Models
{
    public class Journal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо указать идентификатор студента")]
        [ForeignKey("Student")] // Указываем, что это внешний ключ к таблице Student
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Необходимо указать дату")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Необходимо указать название предмета")]
        [StringLength(100, ErrorMessage = "Название предмета должно содержать не более {1} символов")]
        public string Subject { get; set; }

        public bool Presence { get; set; }

        public Student Student { get; set; }
    }
}
