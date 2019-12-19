using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Weedkend.Pages
{
    public class ContactModel : PageModel
    {


        public void OnGet()
        {
            double TotalPrice = Models.SessionExtensions.Get<double>(HttpContext.Session, "total");
            ViewData["Total"] = TotalPrice.ToString("#,###");
        }
    }
}
