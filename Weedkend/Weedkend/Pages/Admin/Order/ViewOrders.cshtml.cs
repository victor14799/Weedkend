using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend
{
    public class ViewOrdersModel : PageModel
    {
        public IList<Orders> Orders { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public IActionResult OnGet()
        {
            try
            {
                FullName = HttpContext.Session.GetString("username");
                Avatar = HttpContext.Session.GetString("img");
                Role = HttpContext.Session.GetString("role");

                ViewData["FullName"] = FullName;
                ViewData["Image"] = Avatar;

                if (Role != "admin")
                {
                    return Redirect("/login");
                }
                if (string.IsNullOrEmpty(FullName))
                {
                    Redirect("/login");
                }
                using (var context = new MyContext())
                {
                    Orders = context.Set<Orders>().Include(o => o.Customer).Include(o => o.OrdersDetail).OrderByDescending(o => o.Datetime).ToList();
                }
                return Page();
            }
            catch
            {
                return Redirect("/error");
            }

        }
        public IActionResult OnGetLogout()
        {
            try
            {
                HttpContext.Session.Clear();
                return Redirect("/login");
            }
            catch
            {
                return Redirect("/error");
            }

        }
    }
}
