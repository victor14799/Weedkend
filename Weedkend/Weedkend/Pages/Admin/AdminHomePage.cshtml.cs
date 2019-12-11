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
        public void OnGet()
        {
            FullName = HttpContext.Session.GetString("username");
            Avatar = HttpContext.Session.GetString("img");
        }
    }
}