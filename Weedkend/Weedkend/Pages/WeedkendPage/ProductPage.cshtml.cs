using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend
{
    public class ProductPageModel : PageModel
    {
        public IList<Product> Products { get; set; }

        public void OnGet()
        {
            double TotalPrice = SessionExtensions.Get<double>(HttpContext.Session, "total");
            ViewData["Total"] = TotalPrice.ToString("#,###");
            using (var context = new MyContext())
            {

                Products = context.Product.Include(p => p.CategoryNavigation).ToList();
            }
        }
    }
}