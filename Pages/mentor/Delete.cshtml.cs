using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Project.Pages.mentor
{
    public class DeleteModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public DeleteModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Models.mentor mentor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Mentor == null)
            {
                return NotFound();
            }

            var mentor = await _context.Mentor.FirstOrDefaultAsync(m => m.Id == id);

            if (mentor == null)
            {
                return NotFound();
            }
            else 
            {
                mentor = mentor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Mentor == null)
            {
                return NotFound();
            }
            var mentor = await _context.Mentor.FindAsync(id);

            if (mentor != null)
            {
                mentor = mentor;
                _context.Mentor.Remove(mentor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
