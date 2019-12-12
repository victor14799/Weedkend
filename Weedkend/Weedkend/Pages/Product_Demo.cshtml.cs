using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend
{
    public class Product_DemoModel : PageModel
    {
        public List<Product> Products;

        public void OnGet()
        {
            ProductModel productModel = new ProductModel();
            Products = productModel.FindAll();
        }
    }
}