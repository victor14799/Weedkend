using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend.Pages.Admin
{
    public class EditModel : PageModel
    {
        //private MyContext _context;

        //public EditModel(MyContext context)
        //{
        //    _context = context;
        //}
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public List<SelectListItem> ProCategory { get; set; }
        public List<SelectListItem> ProBrand { get; set; }

        [BindProperty]
        public Weedkend.Models.Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
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
                    if (id == null)
                    {
                        return NotFound();
                    }

                    Product = await context.Product
                        .Include(p => p.CategoryNavigation)
                        .Include(p => p.ProBrandNavigation)
                        .FirstOrDefaultAsync(m => m.ProductId == id);

                    if (Product == null)
                    {
                        return NotFound();
                    }

                    ProCategory = context.Category.Select(c => new SelectListItem
                    {
                        Value = c.CategoryId.ToString(),
                        Text = c.CategoryName
                    }).ToList();

                    ViewData["ProCategory"] = ProCategory;

                    ProBrand = context.Brand.Select(b => new SelectListItem
                    {
                        Value = b.BrandId.ToString(),
                        Text = b.BrandName
                    }).ToList();

                    ViewData["ProBrand"] = ProBrand;
                }
                return Page();
            }
            else return Redirect("/notAccess");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            using (var context = new MyContext())
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                context.Attach(Product).State = EntityState.Modified;

                try
                {
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(Product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToPage("./Index");
            }
        }

        private bool ProductExists(Guid id)
        {
            using (var context = new MyContext())
            {
                return context.Product.Any(e => e.ProductId == id);
            }
        }
    }
}
