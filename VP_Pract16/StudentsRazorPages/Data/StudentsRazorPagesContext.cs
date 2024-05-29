using Microsoft.EntityFrameworkCore;
using StudentsRazorPages.Models;

namespace StudentsRazorPages.Data
{
    public class StudentsRazorPagesContext : DbContext
    {
        public StudentsRazorPagesContext(DbContextOptions<StudentsRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsRazorPages.Models.Student> Student { get; set; } = default!;
        public DbSet<StudentsRazorPages.Models.Journal> Journal { get; set; } = default!;


    }
}
