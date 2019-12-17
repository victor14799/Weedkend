using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend.Pages.Admin.Product
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public IList<Weedkend.Models.Product> Products { get; set; }
        public async Task<IActionResult> OnGetAsync()
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
                using (var context = new MyContext())
                {
                    Products = await context.Product.Include(p => p.ProBrandNavigation)
                                                    .Include(p => p.CategoryNavigation)
                                                    .ToListAsync();
                }
                return Page();
            }
            else return Redirect("/notAccess");
        }
    }
}