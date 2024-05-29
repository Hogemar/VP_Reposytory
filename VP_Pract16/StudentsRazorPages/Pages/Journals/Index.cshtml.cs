using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsRazorPages.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentsRazorPages.Pages.Journals
{
    public class IndexModel : PageModel
    {
        private readonly StudentsRazorPages.Data.StudentsRazorPagesContext _context;

        public IndexModel(StudentsRazorPages.Data.StudentsRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Journal> Journal { get; set; }

        public async Task OnGetAsync()
        {
            Journal = await _context.Journal
                .Include(j => j.Student)
                .ToListAsync();
        }
    }
}
