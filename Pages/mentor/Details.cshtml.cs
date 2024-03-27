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
    public class DetailsModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public DetailsModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

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
    }
}
