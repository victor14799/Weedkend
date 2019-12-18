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

        public IList<Weedkend.Models.Product> Products { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            using (var context = new MyContext())
            {
                string FullName = HttpContext.Session.GetString("username");
                string Avatar = HttpContext.Session.GetString("img");
                string Role = HttpContext.Session.GetString("role");

                ViewData["FullName"] = FullName;
                ViewData["Image"] = Avatar;
                if (Role != "admin")
                {
                    return Redirect("/login");
                }
                Products = await context.Product.Include(p => p.ProBrandNavigation)
                                                .Include(p => p.CategoryNavigation)
                                                .ToListAsync();
            }
            return Page();
        }
    }
}