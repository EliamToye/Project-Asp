using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Project.Pages
{
    public class ConfirmModel : PageModel
    {
        public List<string> SelectedLessons { get; set; }

        public void OnGet(List<string> selectedLessons)
        {
            // Retrieve the selected lessons from the route parameter
            SelectedLessons = selectedLessons;
        }
    }
}