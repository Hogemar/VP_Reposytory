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
    public class DetailsModel : PageModel
    {
        private readonly StudentsRazorPages.Data.StudentsRazorPagesContext _context;

        public DetailsModel(StudentsRazorPages.Data.StudentsRazorPagesContext context)
        {
            _context = context;
        }

        public Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                Student = student;
            }
            return Page();
        }
    }
}
