using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;
using Microsoft.EntityFrameworkCore;

namespace Weedkend.Pages.WeedkendPage
{
    public class BrandModel : PageModel
    {
        private readonly MyContext _context;

        public BrandModel()
        {
            _context = new MyContext();
        }
        public IList<Weedkend.Models.Product> Products { get; set; }
        public string brand { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            Products = await _context.Product.Where(p => p.ProBrandNavigation.BrandId == id)
                                            .Include(p => p.ProBrandNavigation)
                                            .Include(p => p.CategoryNavigation)
                                            .ToListAsync();
            brand = _context.Product.Where(p => p.ProBrandNavigation.BrandId == id)
                                    .FirstOrDefault()
                                    .ToString();
            return Page();
        }

    }
}