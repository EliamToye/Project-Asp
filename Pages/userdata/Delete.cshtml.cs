using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Project.Pages.userdata
{
    public class DeleteModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public DeleteModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Models.userdata userdata { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.userdata == null)
            {
                return NotFound();
            }

            var userdata = await _context.userdata.FirstOrDefaultAsync(m => m.ID == id);

            if (userdata == null)
            {
                return NotFound();
            }
            else 
            {
                userdata = userdata;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.userdata == null)
            {
                return NotFound();
            }
            var userdata = await _context.userdata.FindAsync(id);

            if (userdata != null)
            {
                userdata = userdata;
                _context.userdata.Remove(userdata);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
