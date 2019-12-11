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
    public class Product_By_BrandModel : PageModel
    {
        private readonly MyContext _context;

        public Product_By_BrandModel() 
        {
            _context = new MyContext();
        }

        public IList<Weedkend.Models.Product> Products { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Products = await _context.Product.Include(p => p.ProBrandNavigation)
                                                .Include(p => p.CategoryNavigation)
                                                .ToListAsync();
            return Page();
        }

    }
}