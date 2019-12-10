using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend
{
    public class AdminHomePageModel : PageModel
    {
        public string ImgURL { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }

        public IActionResult OnGet()
        {

            Role = HttpContext.Session.GetString("role");

            if (Role == null)
            {
                return Redirect("/notAccess");
            }
            if (!Role.Equals("admin"))
            {

                return Redirect("/notAccess");
            }
            else
            {
                FullName = HttpContext.Session.GetString("username");
                ImgURL = HttpContext.Session.GetString("img");
                return Page();
            }
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }
    }
}