using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Models;
using System.Linq;

namespace Project.Pages
{
    public class UserPageModel : PageModel
    {
        public IActionResult OnPost()
        {
            // Logic to process form submission
            return RedirectToPage("/Confirmpage");
        }
    }
}