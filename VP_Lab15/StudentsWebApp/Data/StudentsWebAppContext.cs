using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsWebApp.Models;

namespace StudentsWebApp.Data
{
    public class StudentsWebAppContext : DbContext
    {
        public StudentsWebAppContext (DbContextOptions<StudentsWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsWebApp.Models.Student> Student { get; set; } = default!;
    }
}
