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
    public class ViewOrderDetailModel : PageModel
    {
        private readonly Weedkend.Models.MyContext _context;

        public ViewOrderDetailModel()
        {
            _context = new MyContext();
        }

        public OrdersDetail OrdersDetail { get; set; }
        public List<Product> Products { get; set; }

        public double Total { get; set; }
        public string Description = "";
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            try
            {
                string FullName = HttpContext.Session.GetString("username");
                string Avatar = HttpContext.Session.GetString("img");
                string Role = HttpContext.Session.GetString("role");

                ViewData["FullName"] = FullName;
                ViewData["Image"] = Avatar;
                if (Role != "admin")
                {
                    return Redirect("/login");
                }
                if (id == null)
                {
                    return NotFound();
                }
                OrdersDetail = await _context.OrdersDetail
                    .Include(o => o.Order)
                    .Include(o => o.Product).FirstOrDefaultAsync(m => m.OrderId == id);

                List<OrdersDetail> ODs = await _context.OrdersDetail
                    .Include(o => o.Order)
                    .Include(o => o.Product).Where(o => o.OrderId == id).ToListAsync();

                Products = await _context.Product.Include(p => p.OrdersDetail)
                    .Where(p => p.OrdersDetail.FirstOrDefault(od => od.OrderId == id).OrderId == id)
                    .ToListAsync();
                Total = 0;

                foreach (var item in ODs)
                {
                    if (item.OrderId == id)
                    {
                        Total += item.GetTotal();
                        Description += item.GetDescription();
                    }
                }
                if (OrdersDetail == null)
                {
                    return NotFound();
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
