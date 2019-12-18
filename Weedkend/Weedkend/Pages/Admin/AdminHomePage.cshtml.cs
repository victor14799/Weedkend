using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Weedkend.Pages.Admin
{
    public class AdminHomePageModel : PageModel
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public IActionResult OnGet()
        {
            try
            {
                FullName = HttpContext.Session.GetString("username");
                Avatar = HttpContext.Session.GetString("img");
                Role = HttpContext.Session.GetString("role");

                if (string.IsNullOrEmpty(FullName))
                {
                    return Redirect("/login");
                }

                if (Role == "admin")
                {
                    return Page();
                }
                else return Redirect("/notAccess");
            }
            catch
            {
                return Redirect("/error");
            }

        }

        public IActionResult OnGetLogout()
        {
            try
            {
                HttpContext.Session.Clear();
                return Redirect("/login");
            }
            catch
            {
                return Redirect("/error");
            }

        }
    }
}