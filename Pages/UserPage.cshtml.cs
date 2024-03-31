using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Models;
using System.Linq;

namespace Project.Pages
{
    public class UserPageModel : PageModel
    {
        public List<string> SelectedLessons { get; set; }

        public void OnGet()
        {
            // Initialize the list of selected lessons
            SelectedLessons = new List<string>();
        }

        public IActionResult OnPost(List<string> lessons)
        {
            // Handle the form submission here
            // You can access the selected lessons via the 'lessons' parameter
            SelectedLessons = lessons;

            // Redirect to a confirmation page or perform any other action
            return RedirectToPage("./ConfirmPage", new { selectedLessons = SelectedLessons });
        }
    }
}