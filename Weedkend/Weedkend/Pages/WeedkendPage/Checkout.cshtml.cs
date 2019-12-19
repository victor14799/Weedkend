using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend.Pages.WeedkendPage
{
    public class CheckoutModel : PageModel
    {
        public Error Err { get; set; } = new Error();
        public List<Item> cart { get; set; }
        public double Total { get; set; }
        public void OnGet()
        {
            try
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
            catch
            {
                ViewData["Error"] = "Oppss! Something went wrong!";
            }

        }
        public IActionResult OnPostCheckOut(string FullName, string phone, string email, string address)
        {
            try
            {
                cart = SessionExtensions.Get<List<Item>>(HttpContext.Session, "cart");
                if (cart != null)
                {
                    Total = cart.Sum(i => i.Product.Price * i.Quantity);
                    SessionExtensions.Set(HttpContext.Session, "total", Total);
                    double TotalPrice = SessionExtensions.Get<double>(HttpContext.Session, "total");
                    ViewData["Total"] = TotalPrice.ToString("#,###");
                }
                bool IsValid = true;
                Err = new Error();
                if (string.IsNullOrEmpty(FullName))
                {
                    Err.FullNameErr = "Xin hãy điền tên của bạn!";
                    IsValid = false;
                }
                if (string.IsNullOrEmpty(phone))
                {
                    Err.PhoneNoErr = "Xin hãy điền số điện thoại";
                    IsValid = false;
                }
                if (string.IsNullOrEmpty(address))
                {
                    Err.AddressErr = "Xin hãy điền địa chỉ của bạn";
                    IsValid = false;
                }
                Regex regx;
                Match match;
                if (!string.IsNullOrEmpty(email))
                {
                    regx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    match = regx.Match(email);
                    if (!match.Success)
                    {
                        IsValid = false;
                        Err.EmailErr = "Xin hãy điền emai hợp lệ";
                    }
                }
                else
                {
                    Err.EmailErr = "Xin hãy nhập Email";
                    IsValid = false;
                }


                if (!string.IsNullOrEmpty(phone))
                {
                    regx = new Regex(@"^[\d]{10}$");
                    match = regx.Match(phone);
                    if (!match.Success)
                    {
                        IsValid = false;
                        Err.PhoneNoErr = "Số điện thoại không chính xác!";
                    }

                }
                else { Err.PhoneNoErr = "Xin hãy điền số điện thoại"; IsValid = false; }

                if (IsValid)
                {
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
                        string dateNow = DateTime.Now.ToString("dd MMM HH:mm:ss");
                        orders.Datetime = DateTime.ParseExact(dateNow, "dd MMM HH:mm:ss", null);
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
                else
                {
                    return Page();
                }
            }
            catch
            {
                ViewData["Error"] = "Oppss! Something went wrong!";
                return Redirect("Error");
            }
        }
    }
}
public class Error
{
    public string FullNameErr { get; set; }
    public string EmailErr { get; set; }
    public string PhoneNoErr { get; set; }
    public string AddressErr { get; set; }

    public Error() { }
}