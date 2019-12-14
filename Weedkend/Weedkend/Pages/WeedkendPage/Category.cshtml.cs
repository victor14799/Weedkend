using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend.Pages.WeedkendPage
{
    public class CategoryModel : PageModel
    {
        private readonly MyContext _context;

        public CategoryModel()
        {
            _context = new MyContext();
        }
        public IList<Weedkend.Models.Product> Products { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            Products = await _context.Product.Where(p => p.CategoryNavigation.CategoryId == id)
                                            .Include(p => p.ProBrandNavigation)
                                            .Include(p => p.CategoryNavigation)
                                            .ToListAsync();
            return Page();
        }
    }
}