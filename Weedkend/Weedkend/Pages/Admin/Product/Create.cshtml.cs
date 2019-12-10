﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Weedkend.Models;

namespace Weedkend.Pages.Admin.Product
{
    public class CreateModel : PageModel
    {
        //private readonly Weedkend.Models.MyContext _context;

        //public CreateModel(Weedkend.Models.MyContext context)
        //{
        //    _context = context;
        //}
        public List<SelectListItem> ProCategory { get; set; }
        public List<SelectListItem> ProBrand { get; set; }
        public IActionResult OnGet()
        {
            using (var context = new MyContext())
            {
                ProCategory = context.Category.Select(c => new SelectListItem {
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

        [BindProperty]
        public Weedkend.Models.Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            using (var context = new MyContext())
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                Product.Status = "inStock";
                context.Product.Add(Product);
                await context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}