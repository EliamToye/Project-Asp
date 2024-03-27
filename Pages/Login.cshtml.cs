using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            // This method handles GET requests to the page
        }

        public IActionResult OnPost(string username, string password)
        {
            // Hardcoded credentials for testing (replace with database logic in production)
            if (username == "admin" && password == "admin")
            {
                return RedirectToPage("/AdminCenter");
            }
            else if (username == "user" && password == "user")
            {
                return RedirectToPage("/UserPage");
            }
            else if (username == "mentor" && password == "mentor")
            {
                return RedirectToPage("/MentorPage");
            }
            else
            {
                ViewData["ErrorMessage"] = "Invalid username or password.";
                return Page();
            }
        }
    }
}