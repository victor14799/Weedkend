﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weedkend.Models;

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
        public IList<Brand> Brands { get; set; }
        public string brand { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            try
            {
                Products = await _context.Product.Where(p => p.ProBrandNavigation.BrandId == id)
                                                            .Include(p => p.ProBrandNavigation)
                                                            .Include(p => p.CategoryNavigation)
                                                            .ToListAsync();
                brand = _context.Product.Where(p => p.ProBrandNavigation.BrandId == id)
                                        .FirstOrDefault()
                                        .ToString();
                Brands = _context.Brand.ToList();
                return Page();
            }
            catch
            {
                return Redirect("/error");
            }

        }

    }
}