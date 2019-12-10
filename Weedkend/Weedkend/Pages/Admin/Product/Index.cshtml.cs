using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                Products = await context.Product.Include(p => p.ProBrandNavigation)
                                                .Include(p => p.CategoryNavigation)
                                                .ToListAsync();
            }
            return Page();
        }
    }
}