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
                                                        .Where(p => p.Category == "3")
                                                        .ToListAsync();
            List<Weedkend.Models.Product> SkinProducts = await _context.Product
                                                        .Where(p => p.Category == "1")
                                                        .ToListAsync();
            List<Weedkend.Models.Product> PerfumeProducts = await _context.Product
                                                        .Where(p => p.Category == "2")
                                                        .ToListAsync();
            ProductGroup.Add(HairProducts);
            ProductGroup.Add(SkinProducts);
            ProductGroup.Add(PerfumeProducts);
            return Page();
        }
    }
}