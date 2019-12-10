using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        //private MyContext _context;

        //public DeleteModel(MyContext context)
        //{
        //    _context = context;
        //}

        [BindProperty]
        public Weedkend.Models.Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
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
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync(Guid id)
        {
            using (var context = new MyContext())
            {
                if (id == null)
                {
                    return NotFound();
                }

                Product = await context.Product.FindAsync(id);

                if (Product != null)
                {
                    context.Product.Remove(Product);
                    await context.SaveChangesAsync();
                }

                return RedirectToPage("./Index");
            }
        }
    }
}
