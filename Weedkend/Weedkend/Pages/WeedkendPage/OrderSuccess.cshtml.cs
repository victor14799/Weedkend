using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend
{
    public class OrderSuccessModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total { get; set; }
        public string OrderID { get; set; }
        public void OnGet()
        {
            List<Item> list = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
            cart = list;
            if (cart != null)
            {
                Total = cart.Sum(i => i.Product.Price * i.Quantity);
                SessionExtensions.Set(HttpContext.Session, "total", Total);
                double TotalPrice = SessionExtensions.Get<double>(HttpContext.Session, "total");
                OrderID = SessionExtensions.Get<string>(HttpContext.Session, "OrderID");
                ViewData["Total"] = TotalPrice.ToString("#,###");
            }
        }
    }
}