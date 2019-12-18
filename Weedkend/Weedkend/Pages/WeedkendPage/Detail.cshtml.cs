using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend
{
    public class DetailModel : PageModel
    {
        public Product product { get; set; }

        public IList<Weedkend.Models.Brand> Brands { get; set; }
        public void OnGet(string id)
        {
            try
            {
                double TotalPrice = SessionExtensions.Get<double>(HttpContext.Session, "total");
                ViewData["Total"] = TotalPrice.ToString("#,###");
                using (var context = new MyContext())
                {
                    product = context.Set<Product>().FirstOrDefault(p => p.ProductId.ToString() == id);

                    Brands = context.Brand.ToList();
                }
            }
            catch
            {
                Redirect("Error");
            }


        }
    }
}