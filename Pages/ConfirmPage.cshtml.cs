using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Project.Pages
{
    public class ConfirmModel : PageModel
    {
        [BindProperty]
        public List<string> SelectedLessons { get; set; }

        public void OnGet(List<string> selectedLessons)
        {
            // Retrieve the list of selected lessons from the query string
            SelectedLessons = selectedLessons;
        }

        public IActionResult OnPostSubmit()
        {
            // Logic to handle submission (e.g., saving data to database)
            // You can add your custom logic here

            // Redirect to a thank you page or any other page as needed
            return RedirectToPage("/Index");
        }
    }
}