using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Project.Pages.mentor
{
    public class EditModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public EditModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.mentor mentor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Mentor == null)
            {
                return NotFound();
            }

            var mentor =  await _context.Mentor.FirstOrDefaultAsync(m => m.Id == id);
            if (mentor == null)
            {
                return NotFound();
            }
            mentor = mentor;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(mentor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!mentorExists(mentor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool mentorExists(int id)
        {
          return _context.Mentor.Any(e => e.Id == id);
        }
    }
}
