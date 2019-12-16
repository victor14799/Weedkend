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
    public class ViewOrdersModel : PageModel
    {
        public IList<Orders> Orders { get; set; }

        public void OnGet()
        {
            using (var context = new MyContext())
            {
                Orders = context.Set<Orders>().Include(o => o.Customer).Include(o => o.OrdersDetail).OrderByDescending(o => o.Datetime).ToList();
            }
        }
    }
}
