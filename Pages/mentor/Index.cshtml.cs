﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public IndexModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        public IList<Models.mentor> mentor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Mentor != null)
            {
                mentor = await _context.Mentor.ToListAsync();
            }
        }
    }
}
