using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace Project.Pages
{
    public class UserPageModel : PageModel
    {
        // Your model properties, if any

        public void OnGet()
        {
            // Handle GET request if necessary
        }

        public IActionResult OnPost()
        {
            // Check if any checkboxes are checked
            var selectedLessons = Request.Form["lessons[]"].ToList();

            if (selectedLessons.Any())
            {
                // Redirect to the Confirm page
                return RedirectToPage("/Confirm", new { SelectedLessons = selectedLessons });
            }
            else
            {
                // No checkboxes selected, just refresh the page
                return Page();
            }
        }
    }
}