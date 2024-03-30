using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Project.Pages
{
    public class ConfirmModel : PageModel
    {
        [BindProperty]
        public List<string> Lessons { get; set; }

        public void OnGet(List<string> selectedLessons)
        {
            Lessons = selectedLessons;
        }

        public IActionResult OnPostSubmit()
        {
            // Process the form submission here
            // Redirect or perform any necessary action

            return RedirectToPage("/UserPage"); // Redirect to the UserPage after submission
        }
    }
}