using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsRazorPages.Data;
using StudentsRazorPages.Models;
using System.Threading.Tasks;

namespace StudentsRazorPages.Pages.Journals
{
    public class DetailsModel : PageModel
    {
        private readonly StudentsRazorPages.Data.StudentsRazorPagesContext _context;

        public DetailsModel(StudentsRazorPages.Data.StudentsRazorPagesContext context)
        {
            _context = context;
        }

        public StudentsRazorPages.Models.Journal Journal { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Journal = await _context.Journal
                .Include(j => j.Student)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Journal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
