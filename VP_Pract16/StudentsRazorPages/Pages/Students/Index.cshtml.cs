using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsRazorPages.Data;
using StudentsRazorPages.Models;

namespace StudentsRazorPages.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentsRazorPagesContext _context;

        public IndexModel(StudentsRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public async Task OnGetAsync()
        {
            
            var student = from s in _context.Set<Student>()
                          select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                student = student.Where(s => s.Name.Contains(SearchString));
            }

            Student = await student.ToListAsync();
        }
    }
}
