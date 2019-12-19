using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend.Pages.Admin
{
    public class DetailsModel : PageModel
    {
        private readonly MyContext _context;
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public DetailsModel()
        {
            _context = new MyContext();
        }

        public Weedkend.Models.Product Product { get; set; }
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
        public async Task<IActionResult> OnGetAsync(Guid id)
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
                    if (id == null)
                    {
                        return NotFound();
                    }

                    Product = await _context.Product
                        .Include(p => p.CategoryNavigation)
                        .Include(p => p.ProBrandNavigation).FirstOrDefaultAsync(m => m.ProductId == id);

                    if (Product == null)
                    {
                        return NotFound();
                    }
                    return Page();
                }
                else return Redirect("/notAccess");
            }
            catch
            {
                return Redirect("/error");
            }

        }
    }
}
