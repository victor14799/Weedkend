using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend.Pages.WeedkendPage
{
    public class CartModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total { get; set; }
        public void OnGet()
        {
            cart = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i => i.Product.Price * i.Quantity);

        }
        public IActionResult OnGetBuyNow(string id)
        {
            var productModel = new ProductModel();
            cart = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = productModel.Find(id),
                    Quantity = 1
                });
                SessionExtensions.Set(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Product = productModel.Find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionExtensions.Set(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("Cart");
        }
        public IActionResult OnGetDelete(string id)
        {
            cart = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionExtensions.Set(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            SessionExtensions.Set(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        private int Exists(List<Item> cart, string id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId.ToString() == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}