using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend.Pages.WeedkendPage
{
    public class HomeModel : PageModel
    {
        private readonly MyContext _context;

        public HomeModel()
        {
            _context = new MyContext();
        }

        public IList<List<Weedkend.Models.Product>> ProductGroup { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            ProductGroup = new List<List<Weedkend.Models.Product>>();
            List<Weedkend.Models.Product> HairProducts = await _context.Product
                                                        .Where(p => p.Category == "1")
                                                        .Include(p => p.CategoryNavigation)
                                                        .Include(p => p.ProBrandNavigation)
                                                        .ToListAsync();
            List<Weedkend.Models.Product> SkinProducts = await _context.Product
                                                        .Where(p => p.Category == "2")
                                                        .Include(p => p.CategoryNavigation)
                                                        .Include(p => p.ProBrandNavigation)
                                                        .ToListAsync();
            List<Weedkend.Models.Product> PerfumeProducts = await _context.Product
                                                        .Where(p => p.Category == "4")
                                                        .Include(p => p.CategoryNavigation)
                                                        .Include(p => p.ProBrandNavigation)
                                                        .ToListAsync();
            List<Weedkend.Models.Product> NewProducts = await _context.Product
                                                        .Include(p => p.CategoryNavigation)
                                                        .Include(p => p.ProBrandNavigation)
                                                        .ToListAsync();
            NewProducts = NewProducts.Skip(NewProducts.Count - 5).Take(5).ToList();
            ProductGroup.Add(HairProducts);
            ProductGroup.Add(SkinProducts);
            ProductGroup.Add(PerfumeProducts);
            ProductGroup.Add(NewProducts);
            return Page();
        }
    }
}