using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend.Pages.WeedkendPage
{
    public class CheckoutModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total { get; set; }
        public void OnGet()
        {
            cart = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Total = cart.Sum(i => i.Product.Price * i.Quantity);
                SessionExtensions.Set(HttpContext.Session, "total", Total);
                double TotalPrice = SessionExtensions.Get<double>(HttpContext.Session, "total");
                ViewData["Total"] = TotalPrice.ToString("#,###");
            }
        }
        public IActionResult OnPostCheckOut(string FullName, string phone, string email, string address)
        {
            cart = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Total = cart.Sum(i => i.Product.Price * i.Quantity);
                SessionExtensions.Set(HttpContext.Session, "total", Total);
                double TotalPrice = SessionExtensions.Get<double>(HttpContext.Session, "total");
                ViewData["Total"] = TotalPrice.ToString("#,###");
            }
            using (var context = new MyContext())
            {
                Customer customer = new Customer();
                byte[] byteCustomer = Guid.NewGuid().ToByteArray();
                customer.CustomerId = new Guid(byteCustomer);
                customer.FullName = FullName;
                customer.ShipAddress = address;
                customer.PhoneNo = phone;
                context.Customer.Add(customer);
                //
                Orders orders = new Orders();
                byte[] byteOrder = Guid.NewGuid().ToByteArray();
                orders.OrderId = new Guid(byteOrder);
                orders.CustomerId = customer.CustomerId;
                orders.Datetime = DateTime.Now;
                SessionExtensions.Set(HttpContext.Session, "order", orders);
                context.Set<Orders>().Add(orders);
                context.SaveChanges();


                if (cart != null)
                {
                    OrdersDetail ordersDetail = new OrdersDetail();
                    ordersDetail.OrderId = orders.OrderId;
                    foreach (var item in cart)
                    {
                        ordersDetail.ProductId = item.Product.ProductId;
                        ordersDetail.UnitPrice = item.Product.Price;
                        ordersDetail.Quantity = item.Quantity;
                        context.Set<OrdersDetail>().Add(ordersDetail);
                        context.SaveChanges();
                    }
                }
                else
                {
                    ViewData["Error"] = "Oppss! Something went wrong";
                    return Redirect("/checkout");
                }
            }
            return Redirect("/orderSuccess");
        }
    }
}